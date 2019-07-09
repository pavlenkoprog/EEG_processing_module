using LSL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //this.Invoke (( MethodInvoker ) delegate {
            LogBox.Invoke (( MethodInvoker ) delegate {
                LogBox.AppendText ( "\r\n" + text );
            } );
        }

        #endregion

        #region Логический код

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

        private void LSLreceive()
        {
            StartLSL ( );

            float [ ] sample = new float [ inlet.info ( ).channel_count ( ) ];

            while(true)
            { 
            inlet.pull_sample ( sample );
                LogOutlet ( sample[0].ToString());

                //Переменная для вывода графика
                lastLSLin = sample [ 0 ];

                //foreach (float f in sample)
                //    LogOutlet ( f.ToString() );
            }
        }

        static double lastLSLin = 0;
        //Поток для вывода графика входящих данных
        public void LSLoutlet()
        {
            int i1 = 0;
            double prev = 0;
            while (true)
            {
                //mutexObj.WaitOne();
                //Выводит данные из lsl в график Вх. данных
                if (lastLSLin != prev)
                {
                    //prev = lastLSLin;
                    i1++;
                    RawSignalChart.Invoke ( ( MethodInvoker ) delegate {
                        RawSignalChart.Series [ 0 ].Points.AddY ( lastLSLin );
                        if (i1 >= 2500)
                        { RawSignalChart.Series [ 0 ].Points.Clear ( );i1 = 0; }
                    } );

                }
                //mutexObj.ReleaseMutex();
            }
        }

            #endregion


    }
}
