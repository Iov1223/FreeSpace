namespace FreeSpace
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDiskPlace = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelDiskName = new System.Windows.Forms.Label();
            this.comboBoxChoiseDisk = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelDiskPlace
            // 
            this.labelDiskPlace.AutoSize = true;
            this.labelDiskPlace.Location = new System.Drawing.Point(13, 125);
            this.labelDiskPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiskPlace.Name = "labelDiskPlace";
            this.labelDiskPlace.Size = new System.Drawing.Size(0, 16);
            this.labelDiskPlace.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 93);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(241, 28);
            this.progressBar1.TabIndex = 1;
            // 
            // labelDiskName
            // 
            this.labelDiskName.AutoSize = true;
            this.labelDiskName.Location = new System.Drawing.Point(13, 73);
            this.labelDiskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiskName.Name = "labelDiskName";
            this.labelDiskName.Size = new System.Drawing.Size(0, 16);
            this.labelDiskName.TabIndex = 2;
            // 
            // comboBoxChoiseDisk
            // 
            this.comboBoxChoiseDisk.FormattingEnabled = true;
            this.comboBoxChoiseDisk.Location = new System.Drawing.Point(13, 24);
            this.comboBoxChoiseDisk.Name = "comboBoxChoiseDisk";
            this.comboBoxChoiseDisk.Size = new System.Drawing.Size(121, 24);
            this.comboBoxChoiseDisk.TabIndex = 3;
            this.comboBoxChoiseDisk.Text = "Выбор диска";
            this.comboBoxChoiseDisk.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoiseDisk_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.comboBoxChoiseDisk);
            this.Controls.Add(this.labelDiskName);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelDiskPlace);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDiskPlace;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelDiskName;
        private System.Windows.Forms.ComboBox comboBoxChoiseDisk;
    }
}

