using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yilmazturk_Toys
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
            ShowInTaskbar = false;
        }
        KeyEngine keyEngine = new KeyEngine();
        private void Form1_Load(object sender, EventArgs e)
        {
          
            notifyIcon1.ShowBalloonTip(1, "Yılmaztürk Toys", "Yılmaztürk Toys başlatıldı.", ToolTipIcon.Info);
            YilmazturkThemeSelector.Apply("sistemDeğişir", this);
            
            keyEngine.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://instagram.com/yilmazturksoftware");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start("https://instagram.com/yilmazturksoftware");
        }

        private void yilmazturkAdvancedButton1_Click(object sender, EventArgs e)
        {
            YeniTusAta yeni = new YeniTusAta();
            yeni.Show();
        }

        private void yilmazturkAdvancedButton3_Click(object sender, EventArgs e)
        {
            Hakkinda hakkinda = new Hakkinda();
            hakkinda.Show();
        }

        private void yilmazturkAdvancedButton2_Click(object sender, EventArgs e)
        {
            Duzenle duzenle = new Duzenle();
            duzenle.Show();
        }

        private void yilmazturkAdvancedButton4_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
        }

        private void Anasayfa_Activated(object sender, EventArgs e)
        {
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal; keyEngine.asd = false; ShowInTaskbar = true;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized; keyEngine.asd = true; keyEngine.keyNames = keyEngine.GetKeyNamesFromFolder(@"C:\Users\" + Environment.UserName + @"\YilmazturkToys\"); ShowInTaskbar = false;
            }
        }

        private void Anasayfa_KeyDown(object sender, KeyEventArgs e)
        {
       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }
    }
}
