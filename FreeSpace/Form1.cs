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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FreeSpace
{
    public partial class Form1 : Form
    {
        FsProgressBar fsProgress = new FsProgressBar();
        public override System.Drawing.Color ForeColor { get; set; }
        private DriveInfo[] allDrives;
        public Form1()
        {
            InitializeComponent();
        }
        private void GetSize()
        {
            var size = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            var newSize = new Size(size.Width = 300, size.Height = 150);
            this.MinimumSize = this.MaximumSize = this.Size = newSize;
        }
        private float GetFreeDiskSpace()
        {
            allDrives = DriveInfo.GetDrives();
            double GB = allDrives[0].AvailableFreeSpace / Math.Pow(1024, 3);
            float _cb = (float)GB;
            return _cb;
        }
        private float GetTotalDiskSpace()
        {
            allDrives = DriveInfo.GetDrives();
            double GB = allDrives[0].TotalSize / Math.Pow(1024, 3);
            float _cb = (float)GB;
            return _cb;
        }
        private float GetMaximum()
        {
            allDrives = DriveInfo.GetDrives();
            double GB = allDrives[0].TotalSize / Math.Pow(1024, 3);
            float _cb = (float)GB;
            return _cb;
        }
        private string GetName()
        {
            allDrives = DriveInfo.GetDrives();
            
            return allDrives[0].Name;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetSize();
            ShowProgressBar();
            label1.Text = GetFreeDiskSpace().ToString() + " ГБ свободно из " + GetTotalDiskSpace().ToString();
        }
        public void ShowProgressBar()
        {
            fsProgress.ForeColor = Color.Red;
            label2.Text = "Диск " + GetName();
            progressBar1.Minimum = 0;
            float _value = GetTotalDiskSpace() - GetFreeDiskSpace();
            progressBar1.Maximum = (int)GetMaximum();
            progressBar1.Value += (int)_value;
        }
       
    }
}
