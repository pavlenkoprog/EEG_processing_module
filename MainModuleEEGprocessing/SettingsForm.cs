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
        //При загрузке формы настроек
        public SettingsForm(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent ( );

            //Загрузка переменных из основной формы

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
            _form1.LogOutlet ( "Настройки сохранены");
        }
        #endregion

        #region Настройки обработки
        //Изменение основного промежутка сравнения
        private void MainRangeGet( object sender , MouseEventArgs e )
        {
            MainRangeLabel.Text = "от " + MainRangeSlider.SelectedMin.ToString( ) + "Гц до " + MainRangeSlider.SelectedMax.ToString( ) + "Гц.";
        }

        //Изменение второстепенного промежутка сравнения
        private void ComparisonRangeGet( object sender , MouseEventArgs e )
        {
            ComparisonRangeLabel.Text = "от " + ComparisonRangeSlider.SelectedMin.ToString( ) + "Гц до " + ComparisonRangeSlider.SelectedMax.ToString( ) + "Гц.";
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
    }
}
