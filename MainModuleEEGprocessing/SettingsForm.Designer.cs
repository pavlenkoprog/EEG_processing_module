namespace MainModuleEEGprocessing
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && ( components != null ))
            {
                components.Dispose ( );
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.InletSearch = new System.Windows.Forms.Button();
            this.InletComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SettingTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonToDefault = new System.Windows.Forms.Button();
            this.SaveButton1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ComparisonRangeLabel = new System.Windows.Forms.Label();
            this.ComparisonRangeSlider = new MainModuleEEGprocessing.SelectionRangeSlider();
            this.label10 = new System.Windows.Forms.Label();
            this.MainRangeSlider = new MainModuleEEGprocessing.SelectionRangeSlider();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MainRangeLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OutletTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnectedLSLText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.KalmanRadio1 = new System.Windows.Forms.RadioButton();
            this.KalmanRadio = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.AverageDeviationLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.AverageDeviationTrack = new System.Windows.Forms.TrackBar();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ReactionSpeedLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ReactionSpeedTrack = new System.Windows.Forms.TrackBar();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.MainAreaRadio = new System.Windows.Forms.RadioButton();
            this.FullRhythmRadio = new System.Windows.Forms.RadioButton();
            this.SettingTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AverageDeviationTrack)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReactionSpeedTrack)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // InletSearch
            // 
            this.InletSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InletSearch.Location = new System.Drawing.Point(405, 31);
            this.InletSearch.Margin = new System.Windows.Forms.Padding(2);
            this.InletSearch.Name = "InletSearch";
            this.InletSearch.Size = new System.Drawing.Size(75, 23);
            this.InletSearch.TabIndex = 0;
            this.InletSearch.Text = "обновить";
            this.InletSearch.UseVisualStyleBackColor = true;
            this.InletSearch.Click += new System.EventHandler(this.InletSearch_Click);
            // 
            // InletComboBox
            // 
            this.InletComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InletComboBox.FormattingEnabled = true;
            this.InletComboBox.Location = new System.Drawing.Point(9, 32);
            this.InletComboBox.Name = "InletComboBox";
            this.InletComboBox.Size = new System.Drawing.Size(391, 21);
            this.InletComboBox.TabIndex = 1;
            this.InletComboBox.SelectionChangeCommitted += new System.EventHandler(this.InletComboBox_SelectionChangeCommitted);
            // 
            // SaveButton2
            // 
            this.SaveButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton2.Location = new System.Drawing.Point(416, 462);
            this.SaveButton2.Name = "SaveButton2";
            this.SaveButton2.Size = new System.Drawing.Size(75, 23);
            this.SaveButton2.TabIndex = 2;
            this.SaveButton2.Text = "Сохранить";
            this.SaveButton2.UseVisualStyleBackColor = true;
            this.SaveButton2.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(391, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // SettingTabControl
            // 
            this.SettingTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingTabControl.Controls.Add(this.tabPage1);
            this.SettingTabControl.Controls.Add(this.tabPage2);
            this.SettingTabControl.Controls.Add(this.tabPage3);
            this.SettingTabControl.Location = new System.Drawing.Point(0, 0);
            this.SettingTabControl.Name = "SettingTabControl";
            this.SettingTabControl.SelectedIndex = 0;
            this.SettingTabControl.Size = new System.Drawing.Size(508, 520);
            this.SettingTabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox12);
            this.tabPage1.Controls.Add(this.buttonToDefault);
            this.tabPage1.Controls.Add(this.SaveButton1);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(500, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Обработка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonToDefault
            // 
            this.buttonToDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToDefault.Location = new System.Drawing.Point(323, 462);
            this.buttonToDefault.Name = "buttonToDefault";
            this.buttonToDefault.Size = new System.Drawing.Size(87, 23);
            this.buttonToDefault.TabIndex = 11;
            this.buttonToDefault.Text = "Станд. настр.";
            this.buttonToDefault.UseVisualStyleBackColor = true;
            // 
            // SaveButton1
            // 
            this.SaveButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton1.Location = new System.Drawing.Point(416, 462);
            this.SaveButton1.Name = "SaveButton1";
            this.SaveButton1.Size = new System.Drawing.Size(75, 23);
            this.SaveButton1.TabIndex = 10;
            this.SaveButton1.Text = "Сохранить";
            this.SaveButton1.UseVisualStyleBackColor = true;
            this.SaveButton1.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.comboBox3);
            this.groupBox6.Controls.Add(this.comboBox2);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Location = new System.Drawing.Point(6, 267);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(485, 147);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Эпоха анализа";
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteCustomSource.AddRange(new string[] {
            "256",
            "512",
            "1024",
            "2048"});
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(276, 16);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.SelectedValueChanged += new System.EventHandler(this.comboBox3_SelectedValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "128",
            "256",
            "512",
            "1024",
            "2048"});
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(276, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(7, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(472, 67);
            this.label15.TabIndex = 8;
            this.label15.Text = resources.GetString("label15.Text");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(263, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Количество данных в пересечении эпохи анализа:";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(7, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(200, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Количество данных в эпохе анализа:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.ComparisonRangeLabel);
            this.groupBox4.Controls.Add(this.ComparisonRangeSlider);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.MainRangeSlider);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.MainRangeLabel);
            this.groupBox4.Location = new System.Drawing.Point(6, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 183);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Выбор частотных облостей";
            // 
            // ComparisonRangeLabel
            // 
            this.ComparisonRangeLabel.AutoSize = true;
            this.ComparisonRangeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ComparisonRangeLabel.Location = new System.Drawing.Point(167, 83);
            this.ComparisonRangeLabel.Name = "ComparisonRangeLabel";
            this.ComparisonRangeLabel.Size = new System.Drawing.Size(33, 13);
            this.ComparisonRangeLabel.TabIndex = 15;
            this.ComparisonRangeLabel.Text = "от до";
            // 
            // ComparisonRangeSlider
            // 
            this.ComparisonRangeSlider.BackColor = System.Drawing.SystemColors.Control;
            this.ComparisonRangeSlider.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ComparisonRangeSlider.Location = new System.Drawing.Point(6, 99);
            this.ComparisonRangeSlider.Max = 50;
            this.ComparisonRangeSlider.Min = 0;
            this.ComparisonRangeSlider.Name = "ComparisonRangeSlider";
            this.ComparisonRangeSlider.SelectedMax = 50;
            this.ComparisonRangeSlider.SelectedMin = 0;
            this.ComparisonRangeSlider.Size = new System.Drawing.Size(473, 37);
            this.ComparisonRangeSlider.TabIndex = 14;
            this.ComparisonRangeSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ComparisonRangeGet);
            this.ComparisonRangeSlider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ComparisonRangeGet);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Основной диапазон частот:";
            // 
            // MainRangeSlider
            // 
            this.MainRangeSlider.BackColor = System.Drawing.SystemColors.Control;
            this.MainRangeSlider.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainRangeSlider.Location = new System.Drawing.Point(6, 32);
            this.MainRangeSlider.Max = 50;
            this.MainRangeSlider.Min = 0;
            this.MainRangeSlider.Name = "MainRangeSlider";
            this.MainRangeSlider.SelectedMax = 50;
            this.MainRangeSlider.SelectedMin = 0;
            this.MainRangeSlider.Size = new System.Drawing.Size(473, 37);
            this.MainRangeSlider.TabIndex = 12;
            this.MainRangeSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainRangeGet);
            this.MainRangeSlider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainRangeGet);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Диапазон частот сравнения:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(7, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(473, 30);
            this.label9.TabIndex = 8;
            this.label9.Text = "Управляющий сигнал вычисляется путем деления мощности сигнала в основном диапазон" +
    "е частот на мощность сигнала диапозона частот сравнения.";
            // 
            // MainRangeLabel
            // 
            this.MainRangeLabel.AutoSize = true;
            this.MainRangeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.MainRangeLabel.Location = new System.Drawing.Point(160, 16);
            this.MainRangeLabel.Name = "MainRangeLabel";
            this.MainRangeLabel.Size = new System.Drawing.Size(33, 13);
            this.MainRangeLabel.TabIndex = 1;
            this.MainRangeLabel.Text = "от до";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox11);
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.SaveButton2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(500, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Подключения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.radioButton3);
            this.groupBox11.Controls.Add(this.radioButton4);
            this.groupBox11.Location = new System.Drawing.Point(258, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(233, 69);
            this.groupBox11.TabIndex = 9;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Протокол отправки данных";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(10, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(96, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "протокол TCP";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(10, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(94, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "протокол LSL";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.radioButton2);
            this.groupBox10.Controls.Add(this.radioButton1);
            this.groupBox10.Location = new System.Drawing.Point(6, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(235, 69);
            this.groupBox10.TabIndex = 8;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Протокол приема данных";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(10, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(96, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "протокол TCP";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "протокол LSL";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.OutletTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(6, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 110);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ЭЭГ канал";
            // 
            // OutletTextBox
            // 
            this.OutletTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutletTextBox.Location = new System.Drawing.Point(9, 33);
            this.OutletTextBox.Name = "OutletTextBox";
            this.OutletTextBox.Size = new System.Drawing.Size(391, 20);
            this.OutletTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(472, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "При выводе обработаных данных используется тот-же протокол LSL. Для удобства можн" +
    "о изменить название канала вывода, который должен быть указан в БОС модулях.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Канал для вывода данных:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(405, 31);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "обновить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Наименование канала для вывода данных:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(6, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 126);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ЭЭГ канал";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(472, 45);
            this.label5.TabIndex = 8;
            this.label5.Text = "Данные от каждого отведения энцефалографа передаются в отдельных канале LSL подкл" +
    "ючения.  По умолчанию подключается первый доступный канал. При необходимости его" +
    " можно выбрать из списка.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Подключенный канал:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(405, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "обновить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Доступные в данный момент каналы:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ConnectedLSLText);
            this.groupBox1.Controls.Add(this.InletComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.InletSearch);
            this.groupBox1.Location = new System.Drawing.Point(6, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LSL подключение";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(7, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 49);
            this.label2.TabIndex = 7;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // ConnectedLSLText
            // 
            this.ConnectedLSLText.AutoSize = true;
            this.ConnectedLSLText.Location = new System.Drawing.Point(6, 56);
            this.ConnectedLSLText.Name = "ConnectedLSLText";
            this.ConnectedLSLText.Size = new System.Drawing.Size(159, 13);
            this.ConnectedLSLText.TabIndex = 6;
            this.ConnectedLSLText.Text = "Установленное подключение:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Доступные в данный момент подключения:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(500, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Фильтрация";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(416, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.KalmanRadio1);
            this.groupBox7.Controls.Add(this.KalmanRadio);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(485, 41);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Выбор фильтра";
            // 
            // KalmanRadio1
            // 
            this.KalmanRadio1.AutoSize = true;
            this.KalmanRadio1.Location = new System.Drawing.Point(144, 16);
            this.KalmanRadio1.Name = "KalmanRadio1";
            this.KalmanRadio1.Size = new System.Drawing.Size(113, 17);
            this.KalmanRadio1.TabIndex = 7;
            this.KalmanRadio1.TabStop = true;
            this.KalmanRadio1.Text = "Фильтр Калмана";
            this.KalmanRadio1.UseVisualStyleBackColor = true;
            // 
            // KalmanRadio
            // 
            this.KalmanRadio.AutoSize = true;
            this.KalmanRadio.Location = new System.Drawing.Point(9, 16);
            this.KalmanRadio.Name = "KalmanRadio";
            this.KalmanRadio.Size = new System.Drawing.Size(113, 17);
            this.KalmanRadio.TabIndex = 6;
            this.KalmanRadio.TabStop = true;
            this.KalmanRadio.Text = "Фильтр Калмана";
            this.KalmanRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.groupBox9);
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Location = new System.Drawing.Point(6, 53);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(485, 132);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Фильтр Калмана";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.AverageDeviationLabel);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.AverageDeviationTrack);
            this.groupBox9.Location = new System.Drawing.Point(170, 10);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(155, 116);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            // 
            // AverageDeviationLabel
            // 
            this.AverageDeviationLabel.Location = new System.Drawing.Point(8, 95);
            this.AverageDeviationLabel.Name = "AverageDeviationLabel";
            this.AverageDeviationLabel.Size = new System.Drawing.Size(135, 18);
            this.AverageDeviationLabel.TabIndex = 13;
            this.AverageDeviationLabel.Text = "= 0.0005";
            this.AverageDeviationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Среднее отклонение (0.3):";
            // 
            // AverageDeviationTrack
            // 
            this.AverageDeviationTrack.Location = new System.Drawing.Point(9, 47);
            this.AverageDeviationTrack.Name = "AverageDeviationTrack";
            this.AverageDeviationTrack.Size = new System.Drawing.Size(135, 45);
            this.AverageDeviationTrack.TabIndex = 9;
            this.AverageDeviationTrack.ValueChanged += new System.EventHandler(this.AverageDeviationTrack_ValueChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.ReactionSpeedLabel);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.ReactionSpeedTrack);
            this.groupBox8.Location = new System.Drawing.Point(9, 10);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(155, 116);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            // 
            // ReactionSpeedLabel
            // 
            this.ReactionSpeedLabel.Location = new System.Drawing.Point(9, 95);
            this.ReactionSpeedLabel.Name = "ReactionSpeedLabel";
            this.ReactionSpeedLabel.Size = new System.Drawing.Size(135, 18);
            this.ReactionSpeedLabel.TabIndex = 11;
            this.ReactionSpeedLabel.Text = "= 0.0005";
            this.ReactionSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 31);
            this.label11.TabIndex = 10;
            this.label11.Text = "Скорость реакции на изменение (0.0005):";
            // 
            // ReactionSpeedTrack
            // 
            this.ReactionSpeedTrack.Location = new System.Drawing.Point(9, 47);
            this.ReactionSpeedTrack.Name = "ReactionSpeedTrack";
            this.ReactionSpeedTrack.Size = new System.Drawing.Size(135, 45);
            this.ReactionSpeedTrack.TabIndex = 9;
            this.ReactionSpeedTrack.ValueChanged += new System.EventHandler(this.ReactionSpeedTrack_ValueChanged);
            // 
            // groupBox12
            // 
            this.groupBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox12.Controls.Add(this.MainAreaRadio);
            this.groupBox12.Controls.Add(this.FullRhythmRadio);
            this.groupBox12.Location = new System.Drawing.Point(6, 6);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(485, 68);
            this.groupBox12.TabIndex = 11;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Тип обработки ЭЭГ";
            // 
            // MainAreaRadio
            // 
            this.MainAreaRadio.AutoSize = true;
            this.MainAreaRadio.Checked = true;
            this.MainAreaRadio.Location = new System.Drawing.Point(13, 42);
            this.MainAreaRadio.Name = "MainAreaRadio";
            this.MainAreaRadio.Size = new System.Drawing.Size(354, 17);
            this.MainAreaRadio.TabIndex = 3;
            this.MainAreaRadio.TabStop = true;
            this.MainAreaRadio.Text = "Получение данных по мощности выделеных частотных облостей";
            this.MainAreaRadio.UseVisualStyleBackColor = true;
            this.MainAreaRadio.CheckedChanged += new System.EventHandler(this.MainAreaRadio_CheckedChanged);
            // 
            // FullRhythmRadio
            // 
            this.FullRhythmRadio.AutoSize = true;
            this.FullRhythmRadio.Location = new System.Drawing.Point(13, 19);
            this.FullRhythmRadio.Name = "FullRhythmRadio";
            this.FullRhythmRadio.Size = new System.Drawing.Size(255, 17);
            this.FullRhythmRadio.TabIndex = 2;
            this.FullRhythmRadio.Text = "Получение данных по мощности всех ритмов";
            this.FullRhythmRadio.UseVisualStyleBackColor = true;
            this.FullRhythmRadio.CheckedChanged += new System.EventHandler(this.FullRhythmRadio_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 519);
            this.Controls.Add(this.SettingTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Параметры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.SettingTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AverageDeviationTrack)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReactionSpeedTrack)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InletSearch;
        private System.Windows.Forms.ComboBox InletComboBox;
        private System.Windows.Forms.Button SaveButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl SettingTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ConnectedLSLText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox OutletTextBox;
        private System.Windows.Forms.Button SaveButton1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label MainRangeLabel;
        private SelectionRangeSlider MainRangeSlider;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ComparisonRangeLabel;
        private SelectionRangeSlider ComparisonRangeSlider;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton KalmanRadio;
        private System.Windows.Forms.RadioButton KalmanRadio1;
        private System.Windows.Forms.TrackBar ReactionSpeedTrack;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label AverageDeviationLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar AverageDeviationTrack;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label ReactionSpeedLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonToDefault;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.RadioButton MainAreaRadio;
        private System.Windows.Forms.RadioButton FullRhythmRadio;
    }
}