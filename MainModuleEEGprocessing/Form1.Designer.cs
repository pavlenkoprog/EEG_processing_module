namespace MainModuleEEGprocessing
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && ( components != null ))
            {
                components.Dispose ( );
            }
            base.Dispose ( disposing );
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StarButton = new System.Windows.Forms.ToolStripButton();
            this.OptionsButton = new System.Windows.Forms.ToolStripButton();
            this.ConnectionButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.SplineButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.StartButton = new System.Windows.Forms.ToolStripButton();
            this.PauseButton = new System.Windows.Forms.ToolStripButton();
            this.OffButton = new System.Windows.Forms.ToolStripButton();
            this.InversionButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.RawSignalButton = new System.Windows.Forms.ToolStripButton();
            this.toolChartFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LogButton = new System.Windows.Forms.ToolStripButton();
            this.LogNumericOutButton = new System.Windows.Forms.ToolStripButton();
            this.InfoSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ChartsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.SpectChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RawSignalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InfoGroupBox1 = new System.Windows.Forms.GroupBox();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.InfoGroupBox2 = new System.Windows.Forms.GroupBox();
            this.DopInfoPanel = new System.Windows.Forms.Panel();
            this.CompareSumLabel = new System.Windows.Forms.Label();
            this.MainSumLabel = new System.Windows.Forms.Label();
            this.ConnectedSensorText = new System.Windows.Forms.Label();
            this.ConnectedLSLText = new System.Windows.Forms.Label();
            this.ControlSignalText = new System.Windows.Forms.Label();
            this.SumRatioLabel = new System.Windows.Forms.Label();
            this.IterationTimeText = new System.Windows.Forms.Label();
            this.IterationTimeСheckBox = new System.Windows.Forms.CheckBox();
            this.SendSignalСhart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DopChartSplitContainer = new System.Windows.Forms.SplitContainer();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoSplitContainer)).BeginInit();
            this.InfoSplitContainer.Panel1.SuspendLayout();
            this.InfoSplitContainer.Panel2.SuspendLayout();
            this.InfoSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartsSplitContainer)).BeginInit();
            this.ChartsSplitContainer.Panel1.SuspendLayout();
            this.ChartsSplitContainer.Panel2.SuspendLayout();
            this.ChartsSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpectChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RawSignalChart)).BeginInit();
            this.InfoGroupBox1.SuspendLayout();
            this.InfoGroupBox2.SuspendLayout();
            this.DopInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SendSignalСhart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DopChartSplitContainer)).BeginInit();
            this.DopChartSplitContainer.Panel1.SuspendLayout();
            this.DopChartSplitContainer.Panel2.SuspendLayout();
            this.DopChartSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StarButton,
            this.OptionsButton,
            this.ConnectionButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(963, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // StarButton
            // 
            this.StarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StarButton.Enabled = false;
            this.StarButton.Image = ((System.Drawing.Image)(resources.GetObject("StarButton.Image")));
            this.StarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StarButton.Name = "StarButton";
            this.StarButton.Size = new System.Drawing.Size(49, 22);
            this.StarButton.Text = "Запуск";
            // 
            // OptionsButton
            // 
            this.OptionsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OptionsButton.Image = ((System.Drawing.Image)(resources.GetObject("OptionsButton.Image")));
            this.OptionsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(71, 22);
            this.OptionsButton.Text = "Настройки";
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // ConnectionButton
            // 
            this.ConnectionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ConnectionButton.Image = ((System.Drawing.Image)(resources.GetObject("ConnectionButton.Image")));
            this.ConnectionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Size = new System.Drawing.Size(89, 22);
            this.ConnectionButton.Text = "Подключения";
            this.ConnectionButton.Click += new System.EventHandler(this.ConnectionButton_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.SplineButton,
            this.toolStripSeparator2,
            this.StartButton,
            this.PauseButton,
            this.OffButton,
            this.InversionButton,
            this.toolStripSeparator4,
            this.RawSignalButton,
            this.toolChartFilter,
            this.toolStripSeparator3,
            this.LogButton,
            this.LogNumericOutButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(963, 27);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Enabled = false;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "Столбчатый график";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Enabled = false;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton5.Text = "Точечный график";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Checked = true;
            this.toolStripButton6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Enabled = false;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton6.Text = "Линейный график";
            // 
            // SplineButton
            // 
            this.SplineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SplineButton.Image = ((System.Drawing.Image)(resources.GetObject("SplineButton.Image")));
            this.SplineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SplineButton.Name = "SplineButton";
            this.SplineButton.Size = new System.Drawing.Size(24, 24);
            this.SplineButton.Text = "Сплайн";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // StartButton
            // 
            this.StartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StartButton.Image = ((System.Drawing.Image)(resources.GetObject("StartButton.Image")));
            this.StartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(24, 24);
            this.StartButton.Text = "Запуск";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PauseButton.Enabled = false;
            this.PauseButton.Image = ((System.Drawing.Image)(resources.GetObject("PauseButton.Image")));
            this.PauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(24, 24);
            this.PauseButton.Text = "Пауза";
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // OffButton
            // 
            this.OffButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OffButton.Enabled = false;
            this.OffButton.Image = ((System.Drawing.Image)(resources.GetObject("OffButton.Image")));
            this.OffButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OffButton.Name = "OffButton";
            this.OffButton.Size = new System.Drawing.Size(24, 24);
            this.OffButton.Text = "Остановка для повторного запуска";
            this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // InversionButton
            // 
            this.InversionButton.Checked = true;
            this.InversionButton.CheckOnClick = true;
            this.InversionButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InversionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InversionButton.Image = ((System.Drawing.Image)(resources.GetObject("InversionButton.Image")));
            this.InversionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InversionButton.Name = "InversionButton";
            this.InversionButton.Size = new System.Drawing.Size(24, 24);
            this.InversionButton.Text = "Инверсия управляющего сигнала";
            this.InversionButton.Click += new System.EventHandler(this.InversionButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // RawSignalButton
            // 
            this.RawSignalButton.Checked = true;
            this.RawSignalButton.CheckOnClick = true;
            this.RawSignalButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RawSignalButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RawSignalButton.Image = ((System.Drawing.Image)(resources.GetObject("RawSignalButton.Image")));
            this.RawSignalButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RawSignalButton.Name = "RawSignalButton";
            this.RawSignalButton.Size = new System.Drawing.Size(24, 24);
            this.RawSignalButton.Text = "Скрыть график сигнала энцефалографа";
            this.RawSignalButton.Click += new System.EventHandler(this.RawSignalButton_Click);
            // 
            // toolChartFilter
            // 
            this.toolChartFilter.Checked = true;
            this.toolChartFilter.CheckOnClick = true;
            this.toolChartFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolChartFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolChartFilter.Image = ((System.Drawing.Image)(resources.GetObject("toolChartFilter.Image")));
            this.toolChartFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolChartFilter.Name = "toolChartFilter";
            this.toolChartFilter.Size = new System.Drawing.Size(24, 24);
            this.toolChartFilter.Text = "Фильтрация данных";
            this.toolChartFilter.Click += new System.EventHandler(this.toolChartFilter_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // LogButton
            // 
            this.LogButton.Checked = true;
            this.LogButton.CheckOnClick = true;
            this.LogButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LogButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LogButton.Image = ((System.Drawing.Image)(resources.GetObject("LogButton.Image")));
            this.LogButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(24, 24);
            this.LogButton.Text = "Скрыть вывод текстовых данных";
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // LogNumericOutButton
            // 
            this.LogNumericOutButton.Checked = true;
            this.LogNumericOutButton.CheckOnClick = true;
            this.LogNumericOutButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LogNumericOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LogNumericOutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogNumericOutButton.Image")));
            this.LogNumericOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogNumericOutButton.Name = "LogNumericOutButton";
            this.LogNumericOutButton.Size = new System.Drawing.Size(24, 24);
            this.LogNumericOutButton.Text = "Вывод полученных значений в окно логов";
            this.LogNumericOutButton.Click += new System.EventHandler(this.LogNumericOutButton_Click);
            // 
            // InfoSplitContainer
            // 
            this.InfoSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.InfoSplitContainer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfoSplitContainer.Location = new System.Drawing.Point(0, 52);
            this.InfoSplitContainer.Name = "InfoSplitContainer";
            // 
            // InfoSplitContainer.Panel1
            // 
            this.InfoSplitContainer.Panel1.Controls.Add(this.ChartsSplitContainer);
            this.InfoSplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // InfoSplitContainer.Panel2
            // 
            this.InfoSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.InfoSplitContainer.Panel2.Controls.Add(this.InfoGroupBox1);
            this.InfoSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InfoSplitContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InfoSplitContainer.Size = new System.Drawing.Size(963, 397);
            this.InfoSplitContainer.SplitterDistance = 728;
            this.InfoSplitContainer.TabIndex = 6;
            // 
            // ChartsSplitContainer
            // 
            this.ChartsSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartsSplitContainer.Location = new System.Drawing.Point(3, 2);
            this.ChartsSplitContainer.Name = "ChartsSplitContainer";
            // 
            // ChartsSplitContainer.Panel1
            // 
            this.ChartsSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.ChartsSplitContainer.Panel1.Controls.Add(this.SpectChart);
            // 
            // ChartsSplitContainer.Panel2
            // 
            this.ChartsSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.ChartsSplitContainer.Panel2.Controls.Add(this.DopChartSplitContainer);
            this.ChartsSplitContainer.Size = new System.Drawing.Size(720, 390);
            this.ChartsSplitContainer.SplitterDistance = 240;
            this.ChartsSplitContainer.TabIndex = 0;
            // 
            // SpectChart
            // 
            this.SpectChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.AxisX.Interval = 10D;
            chartArea7.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea7.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea7.AxisX.Maximum = 40D;
            chartArea7.AxisX.Minimum = 0D;
            chartArea7.AxisX.Title = "Частота";
            chartArea7.AxisY.Maximum = 20D;
            chartArea7.AxisY.Minimum = 0D;
            chartArea7.AxisY.Title = "Амплитуда";
            chartArea7.Name = "ChartArea1";
            this.SpectChart.ChartAreas.Add(chartArea7);
            legend7.Alignment = System.Drawing.StringAlignment.Center;
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend7.Name = "Legend1";
            this.SpectChart.Legends.Add(legend7);
            this.SpectChart.Location = new System.Drawing.Point(-15, 1);
            this.SpectChart.Margin = new System.Windows.Forms.Padding(2);
            this.SpectChart.Name = "SpectChart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.LegendText = "Значения спектра ЭЭГ";
            series7.Name = "Series1";
            this.SpectChart.Series.Add(series7);
            this.SpectChart.Size = new System.Drawing.Size(253, 381);
            this.SpectChart.TabIndex = 1;
            this.SpectChart.Text = "Значения спектра ЭЭГ";
            // 
            // RawSignalChart
            // 
            this.RawSignalChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea8.AxisX.Minimum = 0D;
            chartArea8.Name = "ChartArea1";
            this.RawSignalChart.ChartAreas.Add(chartArea8);
            legend8.Alignment = System.Drawing.StringAlignment.Center;
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend8.Name = "Legend1";
            this.RawSignalChart.Legends.Add(legend8);
            this.RawSignalChart.Location = new System.Drawing.Point(2, 2);
            this.RawSignalChart.Margin = new System.Windows.Forms.Padding(2);
            this.RawSignalChart.Name = "RawSignalChart";
            this.RawSignalChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.LegendText = "ЭЭГ полученное по LSL";
            series8.Name = "Series1";
            this.RawSignalChart.Series.Add(series8);
            this.RawSignalChart.Size = new System.Drawing.Size(231, 381);
            this.RawSignalChart.TabIndex = 0;
            this.RawSignalChart.Text = "Полученные значения ЭЭГ";
            // 
            // InfoGroupBox1
            // 
            this.InfoGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoGroupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.InfoGroupBox1.Controls.Add(this.LogBox);
            this.InfoGroupBox1.Controls.Add(this.InfoGroupBox2);
            this.InfoGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.InfoGroupBox1.Name = "InfoGroupBox1";
            this.InfoGroupBox1.Size = new System.Drawing.Size(220, 388);
            this.InfoGroupBox1.TabIndex = 0;
            this.InfoGroupBox1.TabStop = false;
            this.InfoGroupBox1.Text = "Вывод текстовых данных";
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.BackColor = System.Drawing.SystemColors.Window;
            this.LogBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LogBox.Location = new System.Drawing.Point(6, 19);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(208, 183);
            this.LogBox.TabIndex = 1;
            this.LogBox.Text = "Вывод логов\r\n\r\nЗдесь будут отображаться основные события и ошибки произошедшие пр" +
    "и выполнении программы\r\n";
            // 
            // InfoGroupBox2
            // 
            this.InfoGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoGroupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.InfoGroupBox2.Controls.Add(this.DopInfoPanel);
            this.InfoGroupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfoGroupBox2.Location = new System.Drawing.Point(2, 208);
            this.InfoGroupBox2.Name = "InfoGroupBox2";
            this.InfoGroupBox2.Size = new System.Drawing.Size(218, 180);
            this.InfoGroupBox2.TabIndex = 0;
            this.InfoGroupBox2.TabStop = false;
            this.InfoGroupBox2.Text = "Доп. инфо.";
            // 
            // DopInfoPanel
            // 
            this.DopInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DopInfoPanel.AutoScroll = true;
            this.DopInfoPanel.Controls.Add(this.CompareSumLabel);
            this.DopInfoPanel.Controls.Add(this.MainSumLabel);
            this.DopInfoPanel.Controls.Add(this.ConnectedSensorText);
            this.DopInfoPanel.Controls.Add(this.ConnectedLSLText);
            this.DopInfoPanel.Controls.Add(this.ControlSignalText);
            this.DopInfoPanel.Controls.Add(this.SumRatioLabel);
            this.DopInfoPanel.Controls.Add(this.IterationTimeText);
            this.DopInfoPanel.Location = new System.Drawing.Point(4, 19);
            this.DopInfoPanel.Name = "DopInfoPanel";
            this.DopInfoPanel.Size = new System.Drawing.Size(208, 155);
            this.DopInfoPanel.TabIndex = 1;
            // 
            // CompareSumLabel
            // 
            this.CompareSumLabel.AutoSize = true;
            this.CompareSumLabel.Location = new System.Drawing.Point(3, 74);
            this.CompareSumLabel.Name = "CompareSumLabel";
            this.CompareSumLabel.Size = new System.Drawing.Size(103, 13);
            this.CompareSumLabel.TabIndex = 8;
            this.CompareSumLabel.Text = "Сигнал сравнения:";
            // 
            // MainSumLabel
            // 
            this.MainSumLabel.AutoSize = true;
            this.MainSumLabel.Location = new System.Drawing.Point(3, 54);
            this.MainSumLabel.Name = "MainSumLabel";
            this.MainSumLabel.Size = new System.Drawing.Size(98, 13);
            this.MainSumLabel.TabIndex = 7;
            this.MainSumLabel.Text = "Основной сигнал:";
            // 
            // ConnectedSensorText
            // 
            this.ConnectedSensorText.AutoSize = true;
            this.ConnectedSensorText.Location = new System.Drawing.Point(3, 34);
            this.ConnectedSensorText.Name = "ConnectedSensorText";
            this.ConnectedSensorText.Size = new System.Drawing.Size(112, 13);
            this.ConnectedSensorText.TabIndex = 6;
            this.ConnectedSensorText.Text = "Подключеное канал:";
            // 
            // ConnectedLSLText
            // 
            this.ConnectedLSLText.Location = new System.Drawing.Point(3, 3);
            this.ConnectedLSLText.Name = "ConnectedLSLText";
            this.ConnectedLSLText.Size = new System.Drawing.Size(204, 30);
            this.ConnectedLSLText.TabIndex = 5;
            this.ConnectedLSLText.Text = "Подключеный поток:";
            // 
            // ControlSignalText
            // 
            this.ControlSignalText.AutoSize = true;
            this.ControlSignalText.Location = new System.Drawing.Point(3, 116);
            this.ControlSignalText.Name = "ControlSignalText";
            this.ControlSignalText.Size = new System.Drawing.Size(121, 13);
            this.ControlSignalText.TabIndex = 4;
            this.ControlSignalText.Text = "Управляющий сигнал:";
            // 
            // SumRatioLabel
            // 
            this.SumRatioLabel.AutoSize = true;
            this.SumRatioLabel.Location = new System.Drawing.Point(3, 94);
            this.SumRatioLabel.Name = "SumRatioLabel";
            this.SumRatioLabel.Size = new System.Drawing.Size(128, 13);
            this.SumRatioLabel.TabIndex = 3;
            this.SumRatioLabel.Text = "Соотношение сигналов:";
            // 
            // IterationTimeText
            // 
            this.IterationTimeText.AutoSize = true;
            this.IterationTimeText.Location = new System.Drawing.Point(3, 136);
            this.IterationTimeText.Name = "IterationTimeText";
            this.IterationTimeText.Size = new System.Drawing.Size(110, 13);
            this.IterationTimeText.TabIndex = 2;
            this.IterationTimeText.Text = "Время на итерацию:";
            // 
            // IterationTimeСheckBox
            // 
            this.IterationTimeСheckBox.AutoSize = true;
            this.IterationTimeСheckBox.Checked = true;
            this.IterationTimeСheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IterationTimeСheckBox.Location = new System.Drawing.Point(341, 29);
            this.IterationTimeСheckBox.Name = "IterationTimeСheckBox";
            this.IterationTimeСheckBox.Size = new System.Drawing.Size(126, 17);
            this.IterationTimeСheckBox.TabIndex = 0;
            this.IterationTimeСheckBox.Text = "Время на итерацию";
            this.IterationTimeСheckBox.UseVisualStyleBackColor = true;
            this.IterationTimeСheckBox.CheckedChanged += new System.EventHandler(this.IterationTimeСheckBox_CheckedChanged);
            // 
            // SendSignalСhart
            // 
            this.SendSignalСhart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea9.AxisX.Minimum = 0D;
            chartArea9.Name = "ChartArea1";
            this.SendSignalСhart.ChartAreas.Add(chartArea9);
            legend9.Alignment = System.Drawing.StringAlignment.Center;
            legend9.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend9.Name = "Legend1";
            this.SendSignalСhart.Legends.Add(legend9);
            this.SendSignalСhart.Location = new System.Drawing.Point(2, 2);
            this.SendSignalСhart.Margin = new System.Windows.Forms.Padding(2);
            this.SendSignalСhart.Name = "SendSignalСhart";
            this.SendSignalСhart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.LegendText = "Отправляемый аправляющий сигнал";
            series9.Name = "Series1";
            this.SendSignalСhart.Series.Add(series9);
            this.SendSignalСhart.Size = new System.Drawing.Size(227, 381);
            this.SendSignalСhart.TabIndex = 1;
            this.SendSignalСhart.Text = "Полученные значения ЭЭГ";
            // 
            // DopChartSplitContainer
            // 
            this.DopChartSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DopChartSplitContainer.BackColor = System.Drawing.SystemColors.Control;
            this.DopChartSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.DopChartSplitContainer.Name = "DopChartSplitContainer";
            // 
            // DopChartSplitContainer.Panel1
            // 
            this.DopChartSplitContainer.Panel1.Controls.Add(this.RawSignalChart);
            // 
            // DopChartSplitContainer.Panel2
            // 
            this.DopChartSplitContainer.Panel2.Controls.Add(this.SendSignalСhart);
            this.DopChartSplitContainer.Size = new System.Drawing.Size(470, 385);
            this.DopChartSplitContainer.SplitterDistance = 235;
            this.DopChartSplitContainer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 449);
            this.Controls.Add(this.InfoSplitContainer);
            this.Controls.Add(this.IterationTimeСheckBox);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Основной модуль для обработки ЭЭГ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.InfoSplitContainer.Panel1.ResumeLayout(false);
            this.InfoSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoSplitContainer)).EndInit();
            this.InfoSplitContainer.ResumeLayout(false);
            this.ChartsSplitContainer.Panel1.ResumeLayout(false);
            this.ChartsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartsSplitContainer)).EndInit();
            this.ChartsSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpectChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RawSignalChart)).EndInit();
            this.InfoGroupBox1.ResumeLayout(false);
            this.InfoGroupBox1.PerformLayout();
            this.InfoGroupBox2.ResumeLayout(false);
            this.DopInfoPanel.ResumeLayout(false);
            this.DopInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SendSignalСhart)).EndInit();
            this.DopChartSplitContainer.Panel1.ResumeLayout(false);
            this.DopChartSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DopChartSplitContainer)).EndInit();
            this.DopChartSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton StarButton;
        public System.Windows.Forms.ToolStripButton OptionsButton;
        public System.Windows.Forms.ToolStripButton ConnectionButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton StartButton;
        private System.Windows.Forms.SplitContainer InfoSplitContainer;
        private System.Windows.Forms.GroupBox InfoGroupBox1;
        private System.Windows.Forms.SplitContainer ChartsSplitContainer;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.GroupBox InfoGroupBox2;
        private System.Windows.Forms.ToolStripButton PauseButton;
        private System.Windows.Forms.ToolStripButton OffButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton SplineButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton RawSignalButton;
        private System.Windows.Forms.ToolStripButton LogButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataVisualization.Charting.Chart RawSignalChart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolChartFilter;
        private System.Windows.Forms.ToolStripButton LogNumericOutButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart SpectChart;
        private System.Windows.Forms.CheckBox IterationTimeСheckBox;
        private System.Windows.Forms.Panel DopInfoPanel;
        private System.Windows.Forms.Label IterationTimeText;
        private System.Windows.Forms.Label ConnectedSensorText;
        private System.Windows.Forms.Label ConnectedLSLText;
        private System.Windows.Forms.Label ControlSignalText;
        private System.Windows.Forms.Label SumRatioLabel;
        private System.Windows.Forms.Label CompareSumLabel;
        private System.Windows.Forms.Label MainSumLabel;
        private System.Windows.Forms.ToolStripButton InversionButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart SendSignalСhart;
        private System.Windows.Forms.SplitContainer DopChartSplitContainer;
    }
}

