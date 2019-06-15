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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StarButton = new System.Windows.Forms.ToolStripButton();
            this.OptionsButton = new System.Windows.Forms.ToolStripButton();
            this.ConnectionButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.InfoSplitContainer = new System.Windows.Forms.SplitContainer();
            this.InfoGroupBox1 = new System.Windows.Forms.GroupBox();
            this.ChartsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.InfoGroupBox2 = new System.Windows.Forms.GroupBox();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoSplitContainer)).BeginInit();
            this.InfoSplitContainer.Panel1.SuspendLayout();
            this.InfoSplitContainer.Panel2.SuspendLayout();
            this.InfoSplitContainer.SuspendLayout();
            this.InfoGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartsSplitContainer)).BeginInit();
            this.ChartsSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StarButton,
            this.ConnectionButton,
            this.OptionsButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
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
            this.OptionsButton.Size = new System.Drawing.Size(73, 22);
            this.OptionsButton.Text = "Насиройки";
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
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // InfoSplitContainer
            // 
            this.InfoSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoSplitContainer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfoSplitContainer.IsSplitterFixed = true;
            this.InfoSplitContainer.Location = new System.Drawing.Point(0, 50);
            this.InfoSplitContainer.Name = "InfoSplitContainer";
            // 
            // InfoSplitContainer.Panel1
            // 
            this.InfoSplitContainer.Panel1.Controls.Add(this.ChartsSplitContainer);
            this.InfoSplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // InfoSplitContainer.Panel2
            // 
            this.InfoSplitContainer.Panel2.Controls.Add(this.InfoGroupBox1);
            this.InfoSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InfoSplitContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InfoSplitContainer.Size = new System.Drawing.Size(800, 400);
            this.InfoSplitContainer.SplitterDistance = 594;
            this.InfoSplitContainer.TabIndex = 6;
            // 
            // InfoGroupBox1
            // 
            this.InfoGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoGroupBox1.Controls.Add(this.LogBox);
            this.InfoGroupBox1.Controls.Add(this.InfoGroupBox2);
            this.InfoGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.InfoGroupBox1.Name = "InfoGroupBox1";
            this.InfoGroupBox1.Size = new System.Drawing.Size(194, 392);
            this.InfoGroupBox1.TabIndex = 0;
            this.InfoGroupBox1.TabStop = false;
            this.InfoGroupBox1.Text = "Вывод текстовых данных";
            // 
            // ChartsSplitContainer
            // 
            this.ChartsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartsSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ChartsSplitContainer.Name = "ChartsSplitContainer";
            this.ChartsSplitContainer.Size = new System.Drawing.Size(592, 398);
            this.ChartsSplitContainer.SplitterDistance = 281;
            this.ChartsSplitContainer.TabIndex = 0;
            // 
            // InfoGroupBox2
            // 
            this.InfoGroupBox2.Location = new System.Drawing.Point(0, 220);
            this.InfoGroupBox2.Name = "InfoGroupBox2";
            this.InfoGroupBox2.Size = new System.Drawing.Size(194, 172);
            this.InfoGroupBox2.TabIndex = 0;
            this.InfoGroupBox2.TabStop = false;
            this.InfoGroupBox2.Text = "Доп. инфо.";
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LogBox.Location = new System.Drawing.Point(6, 19);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(182, 195);
            this.LogBox.TabIndex = 1;
            this.LogBox.Text = "Вывод логов\r\n\r\nЗдесь будут отображаться основные события и ошибки произошедшие пр" +
    "и выполнении программы\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InfoSplitContainer);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
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
            this.InfoGroupBox1.ResumeLayout(false);
            this.InfoGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartsSplitContainer)).EndInit();
            this.ChartsSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton StarButton;
        private System.Windows.Forms.ToolStripButton OptionsButton;
        private System.Windows.Forms.ToolStripButton ConnectionButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SplitContainer InfoSplitContainer;
        private System.Windows.Forms.GroupBox InfoGroupBox1;
        private System.Windows.Forms.SplitContainer ChartsSplitContainer;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.GroupBox InfoGroupBox2;
    }
}

