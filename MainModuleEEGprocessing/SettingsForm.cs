using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LSL;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.Numerics;

namespace MainModuleEEGprocessing
{
    public delegate void MainFrm();

    public partial class SettingsForm : Form
    {
        private Form1 _form1;

        #region Функции формы
        //Переменные
        //Обработка данных
        int _AnalysisEra;
        int _IntersectionEra;
        int _MainAreaStart;
        int _MainAreaEnd;
        int _ComparisonAreaStart;
        int _ComparisonAreaEnd;
        bool _FullRhythmAnalysis;
        //Фильтрация
        double _varVolt;
        double _varProcess;

        //При загрузке формы настроек
        public SettingsForm(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent ( );

            //Загрузка переменных из основной формы
            //Обработка данных
            _AnalysisEra = _form1.AnalysisEra;
            _IntersectionEra = _form1.IntersectionEra;

            _MainAreaStart = _form1.MainAreaStart;
            _MainAreaEnd = _form1.MainAreaEnd;
            _ComparisonAreaStart = _form1.ComparisonAreaStart;
            _ComparisonAreaEnd = _form1.ComparisonAreaEnd;
            _FullRhythmAnalysis = _form1.FullRhythmAnalysis;

            _varVolt = _form1.varVolt;
            _varProcess = _form1.varProcess;

            SetVarForm( );
        }

        //Установка переменных в форме 
        private void SetVarForm()
        {
            //Обработка данных
            MainRangeSlider.SelectedMin = _MainAreaStart;
            MainRangeSlider.SelectedMax = _MainAreaEnd;
            ComparisonRangeSlider.SelectedMin = _ComparisonAreaStart;
            ComparisonRangeSlider.SelectedMax = _ComparisonAreaEnd;
            MainRangeLabel.Text = "от " + MainRangeSlider.SelectedMin.ToString( ) + "Гц до " + MainRangeSlider.SelectedMax.ToString( ) + "Гц.";
            ComparisonRangeLabel.Text = "от " + ComparisonRangeSlider.SelectedMin.ToString( ) + "Гц до " + ComparisonRangeSlider.SelectedMax.ToString( ) + "Гц.";
            //Фильтрация
            ReactionSpeedTrack.Value = Convert.ToInt32( _varProcess * 10000);
            AverageDeviationTrack.Value = Convert.ToInt32( _varVolt * 10 );
            ReactionSpeedLabel.Text = "= " + ReactionSpeedTrack.Value / 10000;
            AverageDeviationLabel.Text = "= " + AverageDeviationTrack.Value / 10;
        }

        //При закрытии формы настроек
        private void SettingsForm_FormClosing(object sender , FormClosingEventArgs e)
        {
            _form1.ConnectionButton.Enabled = true;
            _form1.OptionsButton.Enabled = true;
        }

        //Поиск доступных каналов LSL
        private void InletSearch_Click(object sender , EventArgs e)
        {
            string [ ] StreamsNames = new string [ 20 ];
            liblsl.StreamInfo [ ] allStreams = liblsl.resolve_stream ( "type" , 1 , 3 );
            if (allStreams.Length >= 1)
            {
                int n = 0;
                foreach (var stream in allStreams)
                {
                    StreamsNames[n]=stream.name ( );
                    n++;
                }
                InletComboBox.DataSource = StreamsNames;
                InletComboBox.SelectedIndex = 0;
            }
        }

        //Сохранение настроек
        private void SaveButton_Click(object sender , EventArgs e)
        {
            
            if( _MainAreaStart != _form1.MainAreaStart || _MainAreaEnd != _form1.MainAreaEnd )
            { _form1.MainAreaStart = _MainAreaStart; _form1.MainAreaEnd = _MainAreaEnd; _form1.LogOutlet( "Осн.част.изм." ); }

            if( _ComparisonAreaStart != _form1.ComparisonAreaStart || _ComparisonAreaEnd != _form1.ComparisonAreaEnd )
            { _form1.ComparisonAreaStart = _ComparisonAreaStart; _form1.ComparisonAreaEnd = _ComparisonAreaStart; _form1.LogOutlet( "Сравн.част.изм." ); }

            if( _FullRhythmAnalysis != _form1.FullRhythmAnalysis )
            { _form1.FullRhythmAnalysis = _FullRhythmAnalysis; _form1.LogOutlet( "Тип обработки ЭЭГ изменен. Чтобы измменения вступили в силу требуется перезапустить программу" ); }

            _form1.LogOutlet ( "Настройки сохранены");
        }
        #endregion

        #region Настройки обработки
        //Изменение основного промежутка сравнения
        private void MainRangeGet( object sender , MouseEventArgs e )
        {
            _MainAreaStart = MainRangeSlider.SelectedMin;
            _MainAreaEnd = MainRangeSlider.SelectedMax;
            MainRangeLabel.Text = "от " + _MainAreaStart.ToString( ) + "Гц до " + _MainAreaEnd.ToString( ) + "Гц.";
        }

        //Изменение второстепенного промежутка сравнения
        private void ComparisonRangeGet( object sender , MouseEventArgs e )
        {
            _ComparisonAreaStart = ComparisonRangeSlider.SelectedMin;
            _ComparisonAreaEnd = ComparisonRangeSlider.SelectedMax;
            ComparisonRangeLabel.Text = "от " + _ComparisonAreaStart.ToString( ) + "Гц до " + _ComparisonAreaEnd.ToString( ) + "Гц.";
        }

        //Изменение настроект типа обработки
        private void FullRhythmRadio_CheckedChanged( object sender , EventArgs e )
        {
            groupBox4.Enabled = false;
            _FullRhythmAnalysis = true;
        }

        //Изменение настроект типа обработки
        private void MainAreaRadio_CheckedChanged( object sender , EventArgs e )
        {
            groupBox4.Enabled = true;
            _FullRhythmAnalysis = false;
        }
        #endregion

        #region Настройки Подключения
        //Изменение канала подключения
        private void InletComboBox_SelectionChangeCommitted( object sender , EventArgs e )
        {
            string name = InletComboBox.SelectedItem.ToString( );
            _form1.ConnectionByName( name );
        }
        #endregion

        #region Настройки Фильтрации

        #endregion

        private void AverageDeviationTrack_ValueChanged( object sender , EventArgs e )
        {
            AverageDeviationLabel.Text = "= " + AverageDeviationTrack.Value / 10;
        }

        private void ReactionSpeedTrack_ValueChanged( object sender , EventArgs e )
        {
            ReactionSpeedLabel.Text = "= " + ReactionSpeedTrack.Value / 10000;
        }

        private void comboBox3_SelectedValueChanged( object sender , EventArgs e )
        {

        }

        private void comboBox2_SelectedIndexChanged( object sender , EventArgs e )
        {

        }
    }
}
