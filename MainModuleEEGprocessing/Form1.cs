﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using LSL;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.Numerics;

namespace MainModuleEEGprocessing
{
    public partial class Form1 : Form
    {
        Thread LSLreceiveThread;
        Thread LSLoutletThread;
        liblsl.StreamInlet inlet;

        
        public Form1()
        {
            InitializeComponent ( );

            LSLreceiveThread = new Thread ( LSLreceive );
            LSLoutletThread = new Thread ( LSLoutlet );
        }

        #region Код управления интерфейсом 

        //Основные элементы управления
        //При загрузке основной формы
        private void Form1_Load(object sender , EventArgs e)
        {
            InfoSplitContainer.SplitterDistance = 650;
        }

        //При нажатии кнопки подключения
        private void ConnectionButton_Click(object sender , EventArgs e)
        {

        }

        //При нажатии кнопки настройки
        private void OptionsButton_Click(object sender , EventArgs e)
        {

        }

        //При нажатии кнопки старт
        private void StartButton_Click(object sender , EventArgs e)
        {
            StartButton.Enabled = false;
            PauseButton.Enabled = true;
            OffButton.Enabled = true;

            LSLreceiveThread.Start ( );
            LSLoutletThread.Start ( );
        }

        //При нажатии кнопки пауза
        private void PauseButton_Click(object sender , EventArgs e)
        {
            StartButton.Enabled = true;
            PauseButton.Enabled = false;
            OffButton.Enabled = true;
        }

        //При нажатии кнопки Выкл
        private void OffButton_Click(object sender , EventArgs e)
        {
            StartButton.Enabled = true;
            PauseButton.Enabled = true;
            OffButton.Enabled = false;

            LSLreceiveThread.Abort ( );
            LSLoutletThread.Abort ( );
        }

        //Элементы управления отвечающие за вкл/откл окон
        //Окно вывода текстовой информации
        private void LogButton_Click(object sender , EventArgs e)
        {
            switch (InfoSplitContainer.Panel2Collapsed)
            {
            case true:
                InfoSplitContainer.Panel2Collapsed = false;
                break;
            case false:
                InfoSplitContainer.Panel2Collapsed = true;
                break;
            }
        }

        //Окно графика сырого сигнала
        private void RawSignalButton_Click(object sender , EventArgs e)
        {
            switch (ChartsSplitContainer.Panel2Collapsed)
            {
            case true:
            ChartsSplitContainer.Panel2Collapsed = false;
            break;
            case false:
            ChartsSplitContainer.Panel2Collapsed = true;
            break;
            }
        }

        public void LogOutlet(string text)
        {
            LogBox.Invoke ( ( MethodInvoker ) delegate
            {
                LogBox.AppendText ( "\r\n" + text );
            } );
        }

        public bool LSLChartFilter = true;
        private void toolChartFilter_Click(object sender , EventArgs e)
        {
            if (LSLChartFilter) LSLChartFilter = false;
            else LSLChartFilter = true;
        }

        public bool LSLLogOutlet = true;
        private void LogNumericOutButton_Click(object sender , EventArgs e)
        {
            if (LSLLogOutlet) LSLLogOutlet = false;
            else LSLLogOutlet = true;
        }

        #region Переключение чек бокса доп. инф.
        bool IterationTimeB = true;
        bool ControlSignalB = true;
        private void IterationTimeСheckBox_CheckedChanged(object sender , EventArgs e)
        {
            if(IterationTimeСheckBox.Checked)
                IterationTimeB = false;
            else
            {
                IterationTimeB = true;
                IterationTimeСheckBox.Text = "Время на итерацию";
            }
        }

        #endregion

        #region Вывод графика LSL

        static double lastLSLin = 0;
        //Поток для вывода графика входящих данных
        public void LSLoutlet()
        {
            int i1 = 0;
            int i2 = 0;
            double [ ] RawSignalMass  = new double [ 2500 ];
            double prev = 0;
            while (true)
            {
                //mutexObj.WaitOne();
                //Выводит данные из lsl в график Вх. данных
                if (lastLSLin != prev)
                {
                    prev = lastLSLin;
                    RawSignalMass[i1] = lastLSLin;
                    i2++;i1++;

                    if(i1%5==0)
                    RawSignalChart.Invoke ( ( MethodInvoker ) delegate
                    {
                        RawSignalChart.Series [ 0 ].Points.DataBindY ( RawSignalMass );
                    } );

                    if (i1 >= 2500)
                    {
                        i1 = 0;
                        RawSignalChart.Invoke ( ( MethodInvoker ) delegate
                        {
                            RawSignalChart.Series [ 0 ].Points.Clear ( );
                            Array.Clear ( RawSignalMass , 0 , RawSignalMass.Length );
                        } );
                    }

                }
                //mutexObj.ReleaseMutex();
            }
        }

        #endregion

        #region Вывод графика Спектра
        public void SpectOutlet(double lastSpect)
        {
            int i1 = 0;
            double prev = 0;
            while (true)
            {
                //mutexObj.WaitOne();
                //Выводит данные из lsl в график Вх. данных
                if (lastSpect != prev)
                {
                    //prev = lastLSLin;
                    i1++;
                    SpectChart.Invoke ( ( MethodInvoker ) delegate {
                        SpectChart.Series [ 0 ].Points.AddY ( lastLSLin );
                        if (i1 >= 2500)
                        { SpectChart.Series [ 0 ].Points.Clear ( ); i1 = 0; }
                    } );

                }
                //mutexObj.ReleaseMutex();
            }
        }
        #endregion

        #endregion

        #region Логический код

        #region Поиск и подключение LSL
        //Подготовка к запуску LSL
        [DllImport ( "liblsl32.dll" )]
        public static extern int SetForegroundWindow(IntPtr point);
        
        public void StartLSL()
        {
            LogOutlet ( "Поиск потоков..." );
            //Поиск и вывод потоков по типу
            liblsl.StreamInfo [ ] allStreams = liblsl.resolve_stream ( "type",1,3 );
            if (allStreams.Length>=1)
            {
                LogOutlet ( "Найдены потоки:" );
                foreach (var stream in allStreams)
                {
                    LogOutlet ( stream.name ( ) );
                }
            }
            else
                LogOutlet ( "Ошибка! Потоки не найдены" );

            //Настройка параметров LSL
            //Ждет подключения
            liblsl.StreamInfo [ ] results = liblsl.resolve_stream ( "type" , "EEG" );
            inlet = new liblsl.StreamInlet ( results [ 0 ] );

            //Вывод информации о подкл. потоке
            LogOutlet ( "Подключен LSL поток с им. " + inlet.info ( ).name ( ) );
            LogOutlet ( "Доступно каналов: " + inlet.info ( ).channel_count ( ) );
        }
        #endregion

        #region Фильтрация

        //Метод фильтроации Калмана

        // переменные для калмана
        //double varVolt = 0.25;  // среднее отклонение (ищем в excel)
        //double varProcess = 0.05; // скорость реакции на изменение (подбирается вручную)
        double varVolt = 0.3;
        double varProcess = 0.0005;

        double Pc = 0;
        double G = 0;
        double P = 1;
        double Xp = 0;
        double Zp = 0;
        double Xe = 0;
        // переменные для калмана

        double filter(double val)
        {  //функция фильтрации
            Pc = P + varProcess;
            G = Pc / ( Pc + varVolt );
            P = ( 1 - G ) * Pc;
            Xp = Xe;
            Zp = Xp;
            Xe = G * ( val - Zp ) + Xp; // "фильтрованное" значение
            return ( Xe );
        }

        #endregion

        Complex [ ] EEGcomplex = new Complex [ 2048 ];
        Complex [ ] EEGcomplex2 = new Complex [ 2048 ];
        
        int N = 256;
        int n = 128;
        int Xmax = 50;
        double T = 0;
        double t = 0;
        
        #region Первый раз заполняет масив данными

        public void FirstFillMasiv(float[] sample)
        {
            //double T = 0;
            //double t = 0;
            Stopwatch stopWatch_1 = new Stopwatch ( );
            stopWatch_1.Start ( );
            for (int i = 0 ; i < N ; i++)
            {
                inlet.pull_sample ( sample );
                EEGcomplex [ i ] = filter ( sample [ 0 ] );

                //Переменная для вывода графика LSL
                if (LSLChartFilter) { lastLSLin = filter ( sample [ 0 ] ); }
                else lastLSLin = sample [ 0 ];
            }
            T = stopWatch_1.ElapsedMilliseconds;
            stopWatch_1.Reset ( );
            spectrumoutN = ( int ) ( Xmax * T / 1000 );
        }

        #endregion

        #region Повторно заполняет масив данными

        public void FillMasiv(float [ ] sample)
        {
            //double T = 0;
            //double t = 0;

            Stopwatch stopWatch_1 = new Stopwatch ( );

            for (int i = N - n - 1 ; i > 0 ; i--)
                EEGcomplex [ i + n ] = EEGcomplex [ i ];

            stopWatch_1.Start ( );
            for (int i = 0 ; i < N ; i++)
            {
                inlet.pull_sample ( sample );
                EEGcomplex [ i ] = filter ( sample [ 0 ] );

                //Переменная для вывода графика LSL
                if (LSLChartFilter) { lastLSLin = filter ( sample [ 0 ] ); }
                else lastLSLin = sample [ 0 ];
            }

            //T -= t;//?
            t = stopWatch_1.ElapsedMilliseconds;
            stopWatch_1.Reset ( );
            T += t;//?
            T = 500;

            spectrumoutN = ( int ) ( Xmax * T / 1000 );
        }

        #endregion

        double [ ] frequencyOut;
        double [ ] amplitudeOut;
        Stopwatch stopWatch_2 = new Stopwatch ( );

        #region Прием данных
        private void LSLreceive()
        {
            StartLSL ( );

            float [ ] sample = new float [ inlet.info ( ).channel_count ( ) ];

            while (true)
            {
                

                inlet.pull_sample ( sample );

                if (LSLLogOutlet) LogOutlet ( sample [ 0 ].ToString ( ) );

                if (EEGcomplex [ 1 ].Real == 0)
                    FirstFillMasiv ( sample );
                else
                    FillMasiv ( sample );
                DataProcessing ( );

                if (IterationTimeB)
                {
                    //Label IterationTimeText = new Label ( );

                    //IterationTimeText.Location = new Point ( 10 , DopInfoPanel.Controls.Count * 20 );
                    //DopInfoPanel.Invoke ( ( MethodInvoker ) delegate {
                    //    DopInfoPanel.Controls.Add ( IterationTimeText );
                    //    IterationTimeText.Text = "Время на итерацию: " + stopWatch_2.ElapsedMilliseconds + " мс";
                    //} );

                    if (IterationTimeText.InvokeRequired)
                        IterationTimeText.Invoke ( new Action ( () => IterationTimeText.Text = "Время на итерацию: " + stopWatch_2.ElapsedMilliseconds + " мс" ) );
                    else IterationTimeСheckBox.Text = "Время на итерацию: " + stopWatch_2.ElapsedMilliseconds + " мс";
                    Application.DoEvents( );
                }

                stopWatch_2.Restart();
            }
        }
        #endregion

        int spectrumoutN = 0;
        double MuSum = 0;
        double CompareSum = 0;
        double SpectCon = 0;

        #region Быстрое преобразование Фурье (БПФ)

        /// <summary>
        /// Вычисление поворачивающего модуля e^(-i*2*PI*k/N)
        /// </summary>
        /// <param name="k"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        private static Complex w(int k , int N)
        {
            if (k % N == 0) return 1;
            double arg = -2 * Math.PI * k / N;
            return new Complex ( Math.Cos ( arg ) , Math.Sin ( arg ) );
        }


        /// <summary>
        /// Возвращает спектр сигнала
        /// </summary>
        /// <param name="x">Массив значений сигнала. Количество значений должно быть степенью 2</param>
        /// <returns>Массив со значениями спектра сигнала</returns>
        public static Complex [ ] fft(Complex [ ] x , int Ni)
        {
            //Ni = Ni / 2;
            Complex [ ] X;
            //int Ni = x.Length;
            if (Ni == 2)
            {
                X = new Complex [ 2 ];
                X [ 0 ] = x [ 0 ] + x [ 1 ];
                X [ 1 ] = x [ 0 ] - x [ 1 ];
            }
            else
            {
                Complex [ ] x_even = new Complex [ Ni / 2 ];
                Complex [ ] x_odd = new Complex [ Ni / 2 ];
                for (int i = 0 ; i < Ni / 2 ; i++)
                {
                    x_even [ i ] = x [ 2 * i ];
                    x_odd [ i ] = x [ 2 * i + 1 ];
                }
                Complex [ ] X_even = fft ( x_even , Ni / 2 );
                Complex [ ] X_odd = fft ( x_odd , Ni / 2 );
                X = new Complex [ Ni ];
                for (int i = 0 ; i < Ni / 2 ; i++)
                {
                    X [ i ] = X_even [ i ] + w ( i , Ni ) * X_odd [ i ];
                    X [ i + Ni / 2 ] = X_even [ i ] - w ( i , Ni ) * X_odd [ i ];
                }
            }
            return X;
        }


        /// <summary>
        /// Центровка массива значений полученных в fft (спектральная составляющая при нулевой частоте будет в центре массива)
        /// </summary>
        /// <param name="X">Массив значений полученный в fft</param>
        /// <returns></returns>
        public static Complex [ ] nfft(Complex [ ] X)
        {
            int N = X.Length;
            Complex [ ] X_n = new Complex [ N ];
            for (int i = 0 ; i < N / 2 ; i++)
            {
                X_n [ i ] = X [ N / 2 + i ];
                X_n [ N / 2 + i ] = X [ i ];
            }
            return X_n;
        }

        public const double SinglePi = Math.PI;
        public const double DoublePi = 2 * Math.PI;


        #endregion

        #region Обработка данных
        public void DataProcessing()
        {
            EEGcomplex2 = fft ( EEGcomplex , N );
            frequencyOut = new double [ spectrumoutN ];
            amplitudeOut = new double [ spectrumoutN ];

            if (spectrumoutN > EEGcomplex2.Length)
                spectrumoutN = EEGcomplex2.Length;

            for (int i = 0 ; i < spectrumoutN ; i++)
            {
                frequencyOut [ i ] = ( double ) i / T * 1000;
                amplitudeOut [ i ] = 2.0 * Math.Sqrt ( Math.Pow ( EEGcomplex2 [ i ].Real , 2 ) +
                    Math.Pow ( EEGcomplex2 [ i ].Imaginary , 2 ) ) / ( double ) N;
                //убрать *10 !!!!!


                if (( frequencyOut [ i ] >= 0 ) && ( frequencyOut [ i ] <= 48 ))
                {
                    if (( frequencyOut [ i ] >= 8 ) && ( frequencyOut [ i ] <= 14 ))
                        MuSum += amplitudeOut [ i ];
                    if (( frequencyOut [ i ] >= 0 ) && ( frequencyOut [ i ] <= 50 ))
                        CompareSum += amplitudeOut [ i ];
                }
            }

            SpectChart.Invoke ( ( MethodInvoker ) delegate {
                SpectChart.Series [ 0 ].Points.Clear ( );
                SpectChart.Series [ 0 ].Points.DataBindXY ( frequencyOut , amplitudeOut );
            } );
        }


        #endregion

        #endregion

    }
}
