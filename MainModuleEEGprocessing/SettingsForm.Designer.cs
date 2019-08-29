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
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InletSearch
            // 
            this.InletSearch.Location = new System.Drawing.Point(390, 55);
            this.InletSearch.Margin = new System.Windows.Forms.Padding(2);
            this.InletSearch.Name = "InletSearch";
            this.InletSearch.Size = new System.Drawing.Size(66, 19);
            this.InletSearch.TabIndex = 0;
            this.InletSearch.Text = "обновить";
            this.InletSearch.UseVisualStyleBackColor = true;
            this.InletSearch.Click += new System.EventHandler(this.InletSearch_Click);
            // 
            // InletComboBox
            // 
            this.InletComboBox.FormattingEnabled = true;
            this.InletComboBox.Location = new System.Drawing.Point(76, 55);
            this.InletComboBox.Name = "InletComboBox";
            this.InletComboBox.Size = new System.Drawing.Size(292, 21);
            this.InletComboBox.TabIndex = 1;
            this.InletComboBox.SelectionChangeCommitted += new System.EventHandler(this.InletComboBox_SelectionChangeCommitted);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(403, 296);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.InletComboBox);
            this.Controls.Add(this.InletSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Параметры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InletSearch;
        private System.Windows.Forms.ComboBox InletComboBox;
        private System.Windows.Forms.Button SaveButton;
    }
}