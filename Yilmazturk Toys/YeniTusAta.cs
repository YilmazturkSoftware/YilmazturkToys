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

namespace Yilmazturk_Toys
{
    public partial class YeniTusAta : Form
    {
        public YeniTusAta()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void yilmazturkAdvancedButton1_Click(object sender, EventArgs e)
        {
            if (yilmazturkAdvancedButton1.Text == "Tuş ata")
            {
                TusSec tusSec = new TusSec();
                tusSec.yeni = this;
                tusSec.Show();
            }
            else
            {
                TusSec tusSec = new TusSec();
                tusSec.yeni = this;
                tusSec.listBox1.SelectedItem = yilmazturkAdvancedButton1.Text;
                tusSec.label3.Text = yilmazturkAdvancedButton1.Text;
                tusSec.Show();
            }
        }

        private void yilmazturkAdvancedButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void yilmazturkAdvancedButton2_Click(object sender, EventArgs e)
        {
            GorevSec gorev = new GorevSec();
            gorev.yeni = this;
            gorev.Show();
        }

        private void yilmazturkAdvancedButton4_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\Users\" + Environment.UserName + @"\YilmazturkToys\");
            if (File.Exists(@"C:\Users\" + Environment.UserName + @"\YilmazturkToys\" + yilmazturkAdvancedButton1.Text))
            {
                File.Delete(@"C:\Users\" + Environment.UserName + @"\YilmazturkToys\" + yilmazturkAdvancedButton1.Text);
            }
            if (label4.Visible == true)
            {
                File.AppendAllText(@"C:\Users\" + Environment.UserName + @"\YilmazturkToys\" + yilmazturkAdvancedButton1.Text, "harf:" + yilmazturkAdvancedButton2.Text);
            }
            else if(yilmazturkAdvancedButton2.Text.StartsWith("Aç:"))
            {
                File.AppendAllText(@"C:\Users\" + Environment.UserName + @"\YilmazturkToys\" + yilmazturkAdvancedButton1.Text, yilmazturkAdvancedButton2.Text);
            }
            else if (yilmazturkAdvancedButton2.Text.StartsWith("Kapat"))
            {
                File.AppendAllText(@"C:\Users\" + Environment.UserName + @"\YilmazturkToys\" + yilmazturkAdvancedButton1.Text, "Kapat");
            }
            else if (yilmazturkAdvancedButton2.Text.StartsWith("Yeniden başlat"))
            {
                File.AppendAllText(@"C:\Users\" + Environment.UserName + @"\YilmazturkToys\" + yilmazturkAdvancedButton1.Text, "Yeniden başlat");
            }
            this.Hide();
        }

        private void YeniTusAta_Load(object sender, EventArgs e)
        {
            YilmazturkThemeSelector.Apply("sistemDeğişir", this);
        }
    }
}
