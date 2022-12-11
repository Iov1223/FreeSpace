using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FreeSpace
{
    public partial class Form1 : Form
    {
        sbyte progessBarRed = 2;
        sbyte progessBar4 = 4;
        private DriveInfo[] allDrives = DriveInfo.GetDrives();
        public Form1()
        {
            InitializeComponent();
        }
        private void GetSize()
        {
            var size = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            var newSize = new Size(size.Width = 230, size.Height = 170);
            this.MinimumSize = this.MaximumSize = this.Size = newSize;
        }
        private void AddToComboBox()
        {
            foreach (var drive in allDrives)
            {
                 comboBoxChoiseDisk.Items.Add(drive);
            }
        }
        private float GetFreeDiskSpace(int index)
        {
            double GB = allDrives[index].AvailableFreeSpace / Math.Pow(1024, 3);
            float _cb = (float)GB;
            return _cb;
        }
        private float GetTotalDiskSpace(int index)
        {
            double GB = allDrives[index].TotalSize / Math.Pow(1024, 3);
            float _cb = (float)GB;
            return _cb;
        }
        private float GetMaximum(int index)
        {
            double GB = allDrives[index].TotalSize / Math.Pow(1024, 3);
            float _cb = (float)GB;
            return _cb;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AddToComboBox();
            GetSize();
        }
        public void ShowProgressBar()
        {
            progressBar1.Show();    
            progressBar1.Value = 0;
            int index = comboBoxChoiseDisk.SelectedIndex;
            progressBar1.ForeColor = Color.Red;
            labelDiskName.Text = "Диск " + allDrives[index].Name;
            progressBar1.Minimum = 0;
            float _value = GetTotalDiskSpace(index) - GetFreeDiskSpace(index);
            progressBar1.Maximum = (int)GetMaximum(index);
            progressBar1.Value += (int)_value;
            if (_value > 300)
            {
                ModifyProgressBarColor.SetState(progressBar1, progessBarRed);
            }

        }

        private void comboBoxChoiseDisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxChoiseDisk.SelectedIndex;
            ShowProgressBar();
            labelDiskPlace.Text = GetFreeDiskSpace(index).ToString() + " ГБ свободно из "
                + GetTotalDiskSpace(index).ToString();
            float _value = GetTotalDiskSpace(index) - GetFreeDiskSpace(index);
            MessageBox.Show(_value.ToString());
            
        }
    }
}
