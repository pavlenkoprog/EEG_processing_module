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
using MathNet.Filtering;

using LSL;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.Numerics;
using MathNet.Filtering.FIR;

namespace MainModuleEEGprocessing
{
    public partial class Form1 : Form
    {
        //AutoResetEvent ThreadReset = new AutoResetEvent ( false );
        Thread LSLreceiveThread;
        Thread LSLoutletThread;
        Thread DataProcessingThread;
        liblsl.StreamInlet inlet;
        liblsl.StreamOutlet outlet;
        liblsl.StreamOutlet Fulloutlet;
        liblsl.StreamInfo info;
        liblsl.StreamInfo Fullinfo;

        public Form1()
        {
            InitializeComponent();
            StartProcess();

            LSLreceiveThread = new Thread(LSLreceive);
            LSLoutletThread = new Thread(LSLoutlet);//Вывод графика
            DataProcessingThread = new Thread(ProcessingCall);

            //if(FullRhythmAnalysis)
            //    info = new liblsl.StreamInfo( "FullBioSemi" , "float" , 7 , 500 , liblsl.channel_format_t.cf_float32 , "sddsfsdf" );
            //else
            //    info = new liblsl.StreamInfo( "BioSemi" , "float" , 1 , 500 , liblsl.channel_format_t.cf_float32 , "sddsfsdf" );

            info = new liblsl.StreamInfo("BioSemi", "float", 1, 500, liblsl.channel_format_t.cf_float32, "sddsfsdf");
            Fullinfo = new liblsl.StreamInfo("FullBioSemi", "float", 8, 500, liblsl.channel_format_t.cf_float32, "sddsfsdf");
            outlet = new liblsl.StreamOutlet(info);
            Fulloutlet = new liblsl.StreamOutlet(Fullinfo);

            FullRhythmAnalysis = Properties.Settings.Default.FullRhythmAnalysis;
            SimpleAreaPower = Properties.Settings.Default.SimpleAreaPower;
            AbductionNumber = Properties.Settings.Default.AbductionNumber;
        }

        void StartProcess()
        {
            Process[] Processes = Process.GetProcessesByName("MainModuleEEGprocessing");
            if (Processes.Count() >= 2)
            {
                if (Processes[0].StartTime < Processes[1].StartTime)
                {
                    Processes[0].Kill();
                    Processes[0].WaitForExit();
                    Processes[0].Dispose();
                }
                else
                {
                    Processes[1].Kill();
                    Processes[1].WaitForExit();
                    Processes[1].Dispose();
                }
            }
        }

        #region Код управления интерфейсом 

        //Основные элементы управления
        //При загрузке основной формы
        private void Form1_Load(object sender, EventArgs e)
        {
            InfoSplitContainer.SplitterDistance = 650;
        }

        public int TubIndex;
        //При нажатии кнопки настройки
        private void OptionsButton_Click(object sender, EventArgs e)
        {
            TubIndex = 0;
            SettingsForm _SettingsForm = new SettingsForm(this);
            _SettingsForm.Show();
            OptionsButton.Enabled = false;
            ConnectionButton.Enabled = false;
        }

        //При нажатии кнопки подключения
        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            TubIndex = 1;
            SettingsForm _SettingsForm = new SettingsForm(this);
            _SettingsForm.Show();
            OptionsButton.Enabled = false;
            ConnectionButton.Enabled = false;
        }

        //Включение кнопок настройки
        public delegate void OptionsButonOn();
        //{
        //    OptionsButton.Enabled = true;
        //    ConnectionButton.Enabled = true;
        //}

        //Инверсия упр. сигнала
        public bool inversionSign = true;
        private void InversionButton_Click(object sender, EventArgs e)
        {
            if (inversionSign) inversionSign = false;
            else inversionSign = true;
        }

        //При нажатии кнопки старт
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!LSLreceiveThread.IsAlive)
            {
                StartButton.Enabled = false;
                PauseButton.Enabled = true;
                OffButton.Enabled = true;
                LSLreceiveThread = new Thread(LSLreceive);
                LSLreceiveThread.Start();

                DataProcessingThread = new Thread(ProcessingCall);
                DataProcessingThread.Start();
            }
            if (!LSLoutletThread.IsAlive)
            {
                LSLoutletThread = new Thread(LSLoutlet);
                LSLoutletThread.Start();
            }
        }

        //При нажатии кнопки пауза
        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (LSLreceiveThread.IsAlive)
            {
                StartButton.Enabled = true;
                PauseButton.Enabled = false;
                OffButton.Enabled = true;

                LSLreceiveThread.Abort();
                LSLreceiveThread.Join();
            }
            if (LSLoutletThread.IsAlive)
            {
                LSLoutletThread.Abort();
                LSLoutletThread.Join();
            }
        }

        //При нажатии кнопки Выкл
        private void OffButton_Click(object sender, EventArgs e)
        {
            if (LSLreceiveThread.IsAlive)
            {
                StartButton.Enabled = true;
                PauseButton.Enabled = false;
                OffButton.Enabled = false;

                LSLreceiveThread.Abort();
                LSLreceiveThread.Join();
            }
            if (LSLoutletThread.IsAlive)
            {
                LSLoutletThread.Abort();
                LSLoutletThread.Join();
            }
        }

        //Элементы управления отвечающие за вкл/откл окон
        //Окно вывода текстовой информации
        private void LogButton_Click(object sender, EventArgs e)
        {
            switch (InfoSplitContainer.Panel2Collapsed)
            {
                case true:
                    InfoSplitContainer.Panel2Collapsed = false;
                    InfoSplitContainer.Invoke((MethodInvoker)delegate
                    {});
                    break;
                case false:
                    InfoSplitContainer.Panel2Collapsed = true;
                    break;
            }
        }

        //Окно графика сырого сигнала
        private void RawSignalButton_Click(object sender, EventArgs e)
        {
            switch (ChartsSplitContainer.Panel2Collapsed)
            {
                case true:
                    ChartsSplitContainer.Panel2Collapsed = false;
                    if (!LSLoutletThread.IsAlive)
                    {
                        LSLoutletThread = new Thread(LSLoutlet);
                        LSLoutletThread.Start();
                    }
                    break;
                case false:
                    ChartsSplitContainer.Panel2Collapsed = true;
                    if (LSLoutletThread.IsAlive)
                    {
                        LSLoutletThread.Abort();
                        LSLoutletThread.Join();
                    }
                    break;
            }
        }

        //Вывод логов
        public void LogOutlet(string text)
        {
            LogBox.Invoke((MethodInvoker)delegate
       {
           LogBox.AppendText("\r\n" + text);
       });
        }

        //Вывод доп информации
        public void InfOutlet(double[] _DopInfoList)
        {
            DopInfoPanel.Invoke((MethodInvoker)delegate
        {
            ConnectedLSLText.Text = "Подкл. поток: " + inlet.info().name();
            ConnectedSensorText.Text = "Подкл. датчик:" + AbductionLabels[AbductionNumber];
            MainSumLabel.Text = "Мощность осн. част.: " + Math.Truncate(_DopInfoList[0]).ToString();
            CompareSumLabel.Text = "Мощность част. сравн.: " + Math.Truncate(_DopInfoList[1]).ToString();
            SumRatioLabel.Text = "Соотношение сигналов: " + Math.Truncate(_DopInfoList[2]).ToString() + "%";
            ControlSignalText.Text = "Управляющий сигнал: " + Math.Truncate(_DopInfoList[3]).ToString();
        });
            DopInfoPanel.Refresh();
        }

        //Вывод доп информации
        public void InfOutletFull(float[] _DopInfoList)
        {
            //double[ ] DopInfoList = { alpha , beta , gamma , delta , mu , theta , kappa  };
            DopInfoPanel.Invoke((MethodInvoker)delegate
        {
            ConnectedLSLText.Text = "Подкл. поток: " + inlet.info().name();
            ConnectedSensorText.Text = "Подкл. датчик:" + AbductionLabels[AbductionNumber];
            MainSumLabel.Text = "Мощность осн. частот: " +
            "selected " + Math.Truncate(_DopInfoList[0]).ToString() + "%  \r\n" +
            "alpha " + Math.Truncate(_DopInfoList[1]).ToString() + "%  \r\n" +
            "beta " + Math.Truncate(_DopInfoList[2]).ToString() + "% " +
            "gamma " + Math.Truncate(_DopInfoList[3]).ToString() + "% " +
            "delta " + Math.Truncate(_DopInfoList[4]).ToString() + "% ";

            CompareSumLabel.Text = "";

            SumRatioLabel.Text = "Мощность доп. частот: " +
            "mu " + Math.Truncate(_DopInfoList[5]).ToString() + "%  \r\n" +
            "theta " + Math.Truncate(_DopInfoList[6]).ToString() + "% " +
            "kappa " + Math.Truncate(_DopInfoList[7]).ToString() + "% ";

            ControlSignalText.Text = "";

        });
        }

        public bool LSLChartFilter = true;
        private void toolChartFilter_Click(object sender, EventArgs e)
        {
            if (LSLChartFilter) LSLChartFilter = false;
            else LSLChartFilter = true;
        }

        public bool LSLLogOutlet = true;
        private void LogNumericOutButton_Click(object sender, EventArgs e)
        {
            if (LSLLogOutlet) LSLLogOutlet = false;
            else LSLLogOutlet = true;
        }

        #region Переключение чек бокса доп. инф.
        bool IterationTimeB = true;
        bool ControlSignalB = true;
        private void IterationTimeСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IterationTimeСheckBox.Checked)
                IterationTimeB = false;
            else
            {
                IterationTimeB = true;
                IterationTimeСheckBox.Text = "Время на итерацию";
            }
        }

        #endregion

        #region Вывод графика LSL
        int counter1 = 0;
        double[] RawSignalMass = new double[2500];
        public void NewLSLoutlet()
        {
            
            while (true)
            {
                RawSignalMass[counter1] = lastLSLin;
                RawSignalChart.Invoke((MethodInvoker)delegate
                {
                   RawSignalChart.Series[0].Points.DataBindY(RawSignalMass);
                });

                if (counter1 >= 2400)
                {
                    counter1 = 0;
                    RawSignalChart.Invoke((MethodInvoker)delegate
                    {
                       RawSignalChart.Series[0].Points.Clear();
                       Array.Clear(RawSignalMass, 0, RawSignalMass.Length);
                    });
                }
                this.Refresh();
                counter1++;
                Thread.Sleep(10);
            }
        }

        static double lastLSLin = 0;
        //Поток для вывода графика входящих данных
        public void LSLoutlet()
        {
            //NewLSLoutlet ( );
            int counter1 = 0;
            double[] RawSignalMass = new double[2500];
            double prev = 0;
            while (true)
            {
                //Выводит данные из lsl в график Вх. данных
                if (lastLSLin != prev)
                {
                    if (LSLChartFilter)
                    {
                        RawSignalChart.Invoke((MethodInvoker)delegate
                        {
                            RawSignalChart.Series[0].Points.DataBindY(filtredDataStore);
                        });
                    }                        
                    else
                    {
                        RawSignalChart.Invoke((MethodInvoker)delegate
                        {
                            RawSignalChart.Series[0].Points.DataBindY(DataStore.ToArray());
                        });
                    }

                    /*
                    prev = lastLSLin;
                    RawSignalMass[counter1] = lastLSLin;//данные LSL
                    counter1++;
                    if (counter1 % 5 == 0)
                        RawSignalChart.Invoke((MethodInvoker)delegate
                   {
                       //RawSignalChart.Series[0].Points.DataBindY(RawSignalMass);//!!!
                       //RawSignalChart.Series[0].Points.DataBindY(EEGdouble);//!!!
                       RawSignalChart.Series[0].Points.DataBindY(filtredDataStore);//!!!
                   });
                    if (counter1 >= 2500)
                    {
                        counter1 = 0;
                        RawSignalChart.Invoke((MethodInvoker)delegate
                        {
                           RawSignalChart.Series[0].Points.Clear();
                           Array.Clear(RawSignalMass, 0, RawSignalMass.Length);
                        });
                    }
                    */

                }
            }
        }

        #endregion

        #region Вывод графика Спектра
        public void SpectOutlet(double lastSpect)
        {
            int CHARTCOUNTER = 0;
            int CHARTMAX = 2500;
            double prev = 0;
            while (true)
            {
                //mutexObj.WaitOne();
                //Выводит данные из lsl в график Вх. данных
                if (lastSpect != prev)
                {
                    prev = lastLSLin;
                    CHARTCOUNTER++;
                    Invoke((MethodInvoker)delegate
                    {
                        SendSignalСhart.Series[0].Points.DataBindY(SendSignalSeries);
                    });

                    SpectChart.Invoke((MethodInvoker)delegate {
                        SpectChart.Series[0].Points.AddY(lastLSLin);                        
                        if (CHARTCOUNTER >= CHARTMAX)
                        { SpectChart.Series[0].Points.Clear(); CHARTCOUNTER = 0; }
                    });

                }
                //mutexObj.ReleaseMutex();
            }
        }
        #endregion

        #endregion

        #region Логический код

        #region Main метод и прием данных
        Complex[] EEGcomplex = new Complex[2048];
        Complex[] EEGcomplex2 = new Complex[2048];
        Double[] EEGdouble = new Double[2048];

        //Булевые значения
        public bool FullRhythmAnalysis = false;
        public bool SimpleAreaPower = false;

        //Переменные для настроек
        //public int AnalysisEra = 1024;//Эпоха анализа
        public int AnalysisEra = 256;//Эпоха анализа
        public int IntersectionEra = 128;//Пересечение эпохи
        //Области ритмов
        public int MainAreaStart = 8;
        public int MainAreaEnd = 14;
        public int ComparisonAreaStart = 3;
        public int ComparisonAreaEnd = 50;        

        int Xmax = 80;
        double T = 0;
        double t = 0;

        double [ ] frequencyOut;
        double [ ] amplitudeOut;
        Stopwatch stopWatch_2 = new Stopwatch ( );
        float [ ] sample;

        private void LSLreceive()
        {
            StartLSL ( );
            while (true)
            {
                FillMasiv(sample);
                //inlet.pull_sample ( sample );

                //if (LSLLogOutlet) LogOutlet ( sample [ 0 ].ToString ( ) );

                //LogOutlet ( inlet.info().name() );

                /*
                //Методы заполнения массивов
                if (EEGcomplex [ 1 ].Real == 0)
                    FirstFillMasiv ( sample );
                else
                    FillMasiv ( sample );

                //Основные операции обработки
                //DataProcessing ( );

                
                if (IterationTimeB)
                {
                    if (IterationTimeText.InvokeRequired)
                        IterationTimeText.Invoke ( new Action ( () => IterationTimeText.Text = "Время на итерацию: " + stopWatch_2.ElapsedMilliseconds + " мс" ) );
                    else IterationTimeСheckBox.Text = "Время на итерацию: " + stopWatch_2.ElapsedMilliseconds + " мс";
                    Application.DoEvents( );
                }

                stopWatch_2.Restart();
                */
            }
        }
        #endregion

        #region Поиск и подключение LSL
        //Подготовка к запуску LSL
        [DllImport ( "liblsl32.dll" )]
        public static extern int SetForegroundWindow(IntPtr point);
        public string [ ] deadStreams = new string [ 20];
        public int deadStreamsCounter = 0;
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
            {
                LogOutlet ( "Ошибка! Потоки не найдены" );

                StartButton.Enabled = true;
                PauseButton.Enabled = false;
                OffButton.Enabled = false;

                LSLreceiveThread.Abort ( );
                LSLoutletThread.Abort ( );
            }

            //Настройка параметров LSL
            //Ждет подключения
            liblsl.StreamInfo [ ] results = liblsl.resolve_stream ( "type" , "EEG" );

            //Проверка потоков LSL
            bool _normres=false;
            foreach (var result in results)
            {
                if(!deadStreams.Contains(result.name ( )))
                {
                    inlet = new liblsl.StreamInlet ( result );
                    _normres = true;
                    break;
                }
            }

            if(!_normres)
            {
                LogOutlet ( "Ошибка! все LSL потоки не рабочие ! " );
                StartButton.Enabled = true;
                PauseButton.Enabled = false;
                OffButton.Enabled = false;

                LSLreceiveThread.Abort ( );
                LSLoutletThread.Abort ( );
            }

            //Определение подключенных датчиков
            XMLReader( );

            //Вывод информации о подкл. потоке
            LogOutlet ( "Подключен LSL поток с им. " + inlet.info ( ).name ( ) );
            LogOutlet ( "Доступно каналов (датчиков): " + inlet.info ( ).channel_count ( ) );
            LogOutlet ( "Подкл. датчик: " + AbductionLabels[AbductionNumber] );
            if(inlet.info ( ).channel_count ( )==0)
            {
                deadStreams [ deadStreamsCounter ] = inlet.info ( ).name ( );
                deadStreamsCounter++;
            }
            sample = new float [ inlet.info ( ).channel_count ( ) ];
        }
        #endregion

        #region Получение данных по отведениям
        public int AbductionNumber = 0;
        public string[ ] AbductionLabels = new string[ 40 ];
        public void XMLReader()
        {
            string xmlstring = inlet.info( ).as_xml( ); // загрузить XML
            string separators = "<";
            string[ ] words = xmlstring.Split( Convert.ToChar( separators ) );
            int n = 0;
            foreach( string label in words )
            {
                if( label.Contains( "label" ) && !label.Contains( "/" ) )
                {
                    AbductionLabels[ n ] = ( label.Replace( "label>" , "" ) );
                    n++;
                }
            }
        }
        #endregion

        #region Подключение к LSL по имени потока
        public void ConnectionByName(string StreamName)
        {
            liblsl.StreamInfo [ ] allStreams = liblsl.resolve_stream ( "type" , 1 , 0.5 );
            bool _normres = false;
            foreach (var result in allStreams)
            {
                if (result.name ( ).Equals ( StreamName ))
                {
                    inlet = new liblsl.StreamInlet ( result );
                    _normres = true;
                    LogOutlet ( "Подключено к потоку: " + result.name ( ) );
                    break;
                }
            }
            if(!_normres)
                LogOutlet("Ошибка! Поток не обнаружен");
        }
        #endregion

        #region Фильтрация

        //Метод фильтроации Калмана

        // переменные для калмана
        //double varVolt = 0.25;  // среднее отклонение (ищем в excel)
        //double varProcess = 0.05; // скорость реакции на изменение (подбирается вручную)
        public double varVolt = 0.3;
        public double varProcess = 0.0005;

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

        #region Проверка канала на наличие данных
        int EmptyDataCounter = 0;
        public void DataAvailabilityCheck()
        {
            if (inlet.samples_available ( ) == 0)
                EmptyDataCounter++;
            else
                EmptyDataCounter = 0;
            if(EmptyDataCounter>=10)
            {
                LogOutlet ( "Ошибка! сбой потока" );
                deadStreams [ deadStreamsCounter ] = inlet.info ( ).name ( );
                deadStreamsCounter++;
                EmptyDataCounter = 0;
                StartLSL ( );
            }

            if( AbductionLabels[ AbductionNumber ] == null )
                AbductionNumber = 0;
        }
        #endregion

        #region Первый раз заполняет масив данными
        public void FirstFillMasiv(float[] sample)
        {
            Stopwatch stopWatch_1 = new Stopwatch ( );
            stopWatch_1.Start ( );
            for (int i = 0 ; i < AnalysisEra ; i++)
            {
                inlet.pull_sample ( sample,0.5 );
                DataAvailabilityCheck ( );

                //EEGcomplex[i] = sample[AbductionNumber];

                //Переменная для вывода графика LSL
                if (LSLChartFilter) { lastLSLin = filter ( sample [ AbductionNumber ] ); }
                else lastLSLin = sample [ AbductionNumber ];

                DataStore.Add(sample[AbductionNumber]);
            }

            T = stopWatch_1.ElapsedMilliseconds;
            stopWatch_1.Reset ( );
            spectrumoutN = ( int ) ( Xmax * T / 1000 );            
        }
        #endregion

        #region Повторно заполняет масив данными
        int testSN = 0;
        Stopwatch stopWatch_1 = new Stopwatch();
        public void FillMasiv(float [ ] sample)
        {
            /*
            // Убирает старые данные из эпохи анализа
            for (int i = AnalysisEra - IntersectionEra - 1 ; i > 0 ; i--)
                EEGcomplex [ i + IntersectionEra ] = EEGcomplex [ i ];            
            //для проверки
            for (int i = AnalysisEra - IntersectionEra - 1; i > 0; i--)
                EEGdouble[i + IntersectionEra] = EEGdouble[i];            
            */
            /*
            Stopwatch stopWatch_1 = new Stopwatch ( );
            stopWatch_1.Start ( );
            
            for (int i = 0 ; i < AnalysisEra ; i++)
            {
                inlet.pull_sample ( sample , 0.5 );
                DataAvailabilityCheck ( );
                
                /*
                double[] doubleSample = Array.ConvertAll(sample, x => (double)x);
                EEGcomplex[i] = doubleSample[AbductionNumber];
                //для проверки
                EEGdouble[i] = doubleSample[AbductionNumber];
                *//*

                //Переменная для вывода графика LSL
                if (LSLChartFilter) { lastLSLin = filter ( sample [ AbductionNumber ] ); }
                else lastLSLin = sample [ AbductionNumber ];

                DataStore.Add(sample[AbductionNumber]);
                DataStore.RemoveAt(0);
            }*/

            inlet.pull_sample(sample, 0.5);
            DataAvailabilityCheck();
            DataStore.Add(sample[AbductionNumber]);            
            if(DataStore.Count>= AnalysisEra)
                DataStore.RemoveRange(0, DataStore.Count - AnalysisEra);                
                //DataStore.RemoveAt(0);

            if (LSLChartFilter) { lastLSLin = filter(sample[AbductionNumber]); }
            else lastLSLin = sample[AbductionNumber];

            testSN++;
            if (testSN>= AnalysisEra)
            {
                T = stopWatch_1.ElapsedMilliseconds;
                stopWatch_1.Reset();
                spectrumoutN = (int)(Xmax * T / 1000);
                testSN = 0;
                stopWatch_1.Start();
            }
            
        }

        #endregion

        #region Быстрое преобразование Фурье (БПФ)
        int spectrumoutN = 0;
        double SpectCon = 0;
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

        //Метод вызывает набор основных скриптов в отдельном потоке
        public void ProcessingCall()
        {
            Thread.Sleep(2000);
            while (true)
            {
                Thread.Sleep(100);
                DataProcessing();

                if (IterationTimeB)
                {
                    if (IterationTimeText.InvokeRequired)
                        IterationTimeText.Invoke(new Action(() => IterationTimeText.Text = "Время на итерацию: " + stopWatch_2.ElapsedMilliseconds + " мс"));
                    else IterationTimeСheckBox.Text = "Время на итерацию: " + stopWatch_2.ElapsedMilliseconds + " мс";
                    Application.DoEvents();
                }

                stopWatch_2.Restart();
            }
        }

        List<double> DataStore = new List<double>();
        List<double> tempDataStore = new List<double>();
        Double[] filtredDataStore = new double [2048];
        Complex[] testEEGcomplex = new Complex[2048];
        //double[] SendSignalSeries = new double[100];
        List<double> SendSignalSeries = new List<double>();

        int tempDataStoreCount;        

        public void DataProcessing()
        {
            if (LSLChartFilter)
            {
                //Рабочий фильтр            
                var lowpass = OnlineFirFilter.CreateBandpass(ImpulseResponse.Finite, 500, 3, 40);
                try
                {
                    filtredDataStore = lowpass.ProcessSamples(DataStore.ToArray());
                }
                catch { }
                for (int i = 0; i < filtredDataStore.Length - 1; i++)
                    testEEGcomplex[i] = filtredDataStore[i];
            }
            else
            {
                for (int i = 0; i < DataStore.Count - 1; i++)
                    testEEGcomplex[i] = DataStore[i];                
            }


            //EEGcomplex2 = fft(EEGcomplex , AnalysisEra );
            EEGcomplex2 = fft(testEEGcomplex, AnalysisEra);
            if (spectrumoutN > EEGcomplex2.Length)
                spectrumoutN = EEGcomplex2.Length;
            //spectrumoutN = 250;

            frequencyOut = new double[spectrumoutN];
            amplitudeOut = new double[spectrumoutN];

            double MainSum = 0;
            int test1 = 0;
            double CompareSum = 0;
            double SelectedCompareSum = 0;

            double alpha = 0;
            double beta = 0;
            double gamma = 0;
            double delta = 0;

            double mu = 0;
            double theta = 0;
            double kappa = 0;
            
            for (int i = 0; i < frequencyOut.Length; i++)
            {
                frequencyOut[i] = (double)i / T * 1000;
                amplitudeOut[i] = 2.0 * Math.Sqrt(Math.Pow(EEGcomplex2[i].Real, 2) +
                    Math.Pow(EEGcomplex2[i].Imaginary, 2)) / (double)AnalysisEra;
                //убрать *10 !!!!!

                if ((frequencyOut[i] >= 0) && (frequencyOut[i] <= 48))
                {
                    if (FullRhythmAnalysis)
                    {
                        InfoGroupBox2.ForeColor = Color.DarkOrange;

                        if ((frequencyOut[i] >= 8) && (frequencyOut[i] <= 13))
                            alpha += amplitudeOut[i];
                        if ((frequencyOut[i] >= 14) && (frequencyOut[i] <= 40))
                            beta += amplitudeOut[i];
                        if ((frequencyOut[i] >= 30) && (frequencyOut[i] <= 50))
                            gamma += amplitudeOut[i];
                        if ((frequencyOut[i] >= 1) && (frequencyOut[i] <= 4))
                            delta += amplitudeOut[i];
                        if ((frequencyOut[i] >= 8) && (frequencyOut[i] <= 13))
                            mu += amplitudeOut[i];
                        if ((frequencyOut[i] >= 4) && (frequencyOut[i] <= 8))
                            theta += amplitudeOut[i];
                        if ((frequencyOut[i] >= 8) && (frequencyOut[i] <= 13))
                            kappa += amplitudeOut[i];
                        CompareSum += amplitudeOut[i];

                        //добавил 05,11,2021
                        if ((frequencyOut[i] >= MainAreaStart) && (frequencyOut[i] <= MainAreaEnd))
                            MainSum += amplitudeOut[i];
                        if ((frequencyOut[i] >= ComparisonAreaStart) && (frequencyOut[i] <= ComparisonAreaEnd))
                            SelectedCompareSum += amplitudeOut[i];
                    }
                    else if (SimpleAreaPower)
                    {
                        InfoGroupBox2.ForeColor = Color.LightSeaGreen;

                        if ((frequencyOut[i] >= MainAreaStart) && (frequencyOut[i] <= MainAreaEnd))
                        {
                            MainSum += amplitudeOut[i];
                            test1++;
                        }
                    }
                    else
                    {
                        InfoGroupBox2.ForeColor = Color.DarkBlue;

                        if ((frequencyOut[i] >= MainAreaStart) && (frequencyOut[i] <= MainAreaEnd))
                            MainSum += amplitudeOut[i];
                        if ((frequencyOut[i] >= ComparisonAreaStart) && (frequencyOut[i] <= ComparisonAreaEnd))
                            CompareSum += amplitudeOut[i];

                    }

                }
            }

            double SumRatio;
            if (FullRhythmAnalysis)
            {
                alpha = alpha / CompareSum * 100;
                beta = beta / CompareSum * 100;
                gamma = gamma / CompareSum * 100;
                delta = delta / CompareSum * 100;
                mu = mu / CompareSum * 100;
                theta = theta / CompareSum * 100;
                kappa = kappa / CompareSum * 100;
                SumRatio = MainSum / SelectedCompareSum * 100;
                float[] DopInfoList = { (float)SumRatio, (float)alpha, (float)beta, (float)gamma, (float)delta, (float)mu, (float)theta, (float)kappa };

                InfOutletFull(DopInfoList);
                SendSignalLSLFull(DopInfoList);
            }
            else if (SimpleAreaPower)
            {
                SumRatio = MainSum;
                SendSignalLSL(SumRatio);
                double[] DopInfoList = { EEGcomplex[1].Real, 0, 0, MainSum };
                InfOutlet(DopInfoList);    
            }
            else
            {
                if (inversionSign)
                    SumRatio = 100 - MainSum / CompareSum * 100;
                //SumRatio = 50 - MainSum / CompareSum * 100;                   
                else
                    SumRatio = MainSum / CompareSum * 100;

                if (SumRatio < 0)
                    SumRatio = 0;

                double[] DopInfoList = { MainSum, CompareSum, SumRatio, SumRatio };
                InfOutlet(DopInfoList);
                SendSignalLSL(SumRatio);
            }


            SpectChart.Invoke((MethodInvoker)delegate {
                SpectChart.Series[0].Points.Clear();
                SpectChart.Series[0].Points.DataBindXY(frequencyOut, amplitudeOut);
            });

            SendSignalSeries.Add(SumRatio);
            if (SendSignalSeries.Count >= 100)
                SendSignalSeries.RemoveAt(0);

            SendSignalСhart.Invoke((MethodInvoker)delegate
            {
                SendSignalСhart.Series[0].Points.Clear();
                SendSignalСhart.Series[0].Points.DataBindY(SendSignalSeries);
            });
            SendSignalСhart.Refresh();
        }


        #endregion

        #region Отправка сигнала
        float[ ] data = new float[ 1 ];
        public void SendSignalLSL(double _SumRatio )
        {
            data[ 0 ] = ( float ) _SumRatio;
            outlet.push_sample( data );
        }

        //float[ ] dataFull = new float[ 1 ];
        public void SendSignalLSLFull( float [] data )
        {
            //data[ 0 ] = ( float ) _SumRatio;
            Fulloutlet.push_sample( data );
        }

        #endregion

        #endregion
    }
}
