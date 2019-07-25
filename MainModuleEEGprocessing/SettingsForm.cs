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
        private Form1 form1;

        public event MainFrm _OptionsButonOn;

        public SettingsForm()
        {
            InitializeComponent ( );
        }

        public SettingsForm(Form1 form1)
        {
            this.form1 = form1;
        }

        public void funData()
        {
            
        }

        //public Form1 frm1 = new Form1 ( );
        private void SettingsForm_FormClosing(object sender , FormClosingEventArgs e)
        {
            //frm1.ButonsEnabled = "test";
            //if (_OptionsButonOn != null)
            //{
            //    _OptionsButonOn ( );
            //}
        }

        private void InletSearch_Click(object sender , EventArgs e)
        {
            string [ ] StreamsNames = new string [ 20 ];
            liblsl.StreamInfo [ ] allStreams = liblsl.resolve_stream ( "type" );
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

            Form1 frm1 = new Form1 ( );
            frm1.ButonsEnabled = "test";

        }

    }
}
