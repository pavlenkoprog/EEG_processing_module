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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StarButton = new System.Windows.Forms.ToolStripButton();
            this.ConnectionButton = new System.Windows.Forms.ToolStripButton();
            this.OptionsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.SplineButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RawSignalButton = new System.Windows.Forms.ToolStripButton();
            this.LogButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.StartButton = new System.Windows.Forms.ToolStripButton();
            this.PauseButton = new System.Windows.Forms.ToolStripButton();
            this.OffButton = new System.Windows.Forms.ToolStripButton();
            this.InfoSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ChartsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.RawSignalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InfoGroupBox1 = new System.Windows.Forms.GroupBox();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.InfoGroupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoSplitContainer)).BeginInit();
            this.InfoSplitContainer.Panel1.SuspendLayout();
            this.InfoSplitContainer.Panel2.SuspendLayout();
            this.InfoSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartsSplitContainer)).BeginInit();
            this.ChartsSplitContainer.Panel2.SuspendLayout();
            this.ChartsSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RawSignalChart)).BeginInit();
            this.InfoGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StarButton,
            this.ConnectionButton,
            this.OptionsButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(883, 25);
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
            // ConnectionButton
            // 
            this.ConnectionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ConnectionButton.Image = ((System.Drawing.Image)(resources.GetObject("ConnectionButton.Image")));
            this.ConnectionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Size = new System.Drawing.Size(89, 22);
            this.ConnectionButton.Text = "Подключения";
            // 
            // OptionsButton
            // 
            this.OptionsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OptionsButton.Image = ((System.Drawing.Image)(resources.GetObject("OptionsButton.Image")));
            this.OptionsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(73, 22);
            this.OptionsButton.Text = "Насиройки";
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
            this.toolStripSeparator4,
            this.RawSignalButton,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.LogButton,
            this.toolStripButton3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(883, 27);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
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
            this.InfoSplitContainer.Size = new System.Drawing.Size(883, 398);
            this.InfoSplitContainer.SplitterDistance = 649;
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
            // 
            // ChartsSplitContainer.Panel2
            // 
            this.ChartsSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.ChartsSplitContainer.Panel2.Controls.Add(this.RawSignalChart);
            this.ChartsSplitContainer.Size = new System.Drawing.Size(642, 390);
            this.ChartsSplitContainer.SplitterDistance = 300;
            this.ChartsSplitContainer.TabIndex = 0;
            // 
            // RawSignalChart
            // 
            this.RawSignalChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.Maximum = 2500D;
            chartArea2.Name = "ChartArea1";
            this.RawSignalChart.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.RawSignalChart.Legends.Add(legend2);
            this.RawSignalChart.Location = new System.Drawing.Point(2, 3);
            this.RawSignalChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RawSignalChart.Name = "RawSignalChart";
            this.RawSignalChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "ЭЭГ полученное по LSL";
            series2.Name = "Series1";
            this.RawSignalChart.Series.Add(series2);
            this.RawSignalChart.Size = new System.Drawing.Size(313, 381);
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
            this.InfoGroupBox1.Location = new System.Drawing.Point(1, 3);
            this.InfoGroupBox1.Name = "InfoGroupBox1";
            this.InfoGroupBox1.Size = new System.Drawing.Size(222, 389);
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
            this.LogBox.Size = new System.Drawing.Size(210, 192);
            this.LogBox.TabIndex = 1;
            this.LogBox.Text = "Вывод логов\r\n\r\nЗдесь будут отображаться основные события и ошибки произошедшие пр" +
    "и выполнении программы\r\n";
            // 
            // InfoGroupBox2
            // 
            this.InfoGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoGroupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.InfoGroupBox2.Location = new System.Drawing.Point(2, 218);
            this.InfoGroupBox2.Name = "InfoGroupBox2";
            this.InfoGroupBox2.Size = new System.Drawing.Size(220, 172);
            this.InfoGroupBox2.TabIndex = 0;
            this.InfoGroupBox2.TabStop = false;
            this.InfoGroupBox2.Text = "Доп. инфо.";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Checked = true;
            this.toolStripButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Вывод данных после фильтрации";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Checked = true;
            this.toolStripButton3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.InfoSplitContainer);
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
            this.ChartsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartsSplitContainer)).EndInit();
            this.ChartsSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RawSignalChart)).EndInit();
            this.InfoGroupBox1.ResumeLayout(false);
            this.InfoGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton StarButton;
        private System.Windows.Forms.ToolStripButton OptionsButton;
        private System.Windows.Forms.ToolStripButton ConnectionButton;
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}

