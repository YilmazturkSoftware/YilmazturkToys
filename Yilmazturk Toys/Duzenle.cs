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
    public partial class Duzenle : Form
    {
        public Duzenle()
        {
            InitializeComponent();
        }

        private void Duzenle_Load(object sender, EventArgs e)
        {
            YilmazturkThemeSelector.Apply("sistemDeğişir", this);
            lstBox();
        }

        private void lstBox()
        {
            try
            {
                listBox1.Items.Clear();

                DirectoryInfo d = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\YilmazturkToys\");

                FileInfo[] Files = d.GetFiles("*.*");
                string str = "";

                foreach (FileInfo file in Files)
                {
                    listBox1.Items.Add(file);
                }
            }
            catch
            {

            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                duzenleBtn.Visible = true;
                silBtn.Visible = true;
            }
            catch
            {
                duzenleBtn.Visible = false;
                silBtn.Visible = false;
            }
        }

        private void duzenleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                YeniTusAta yeniTusAta = new YeniTusAta();
                string a = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\YilmazturkToys\" + listBox1.SelectedItem.ToString());
                yeniTusAta.yilmazturkAdvancedButton1.Text = listBox1.SelectedItem.ToString();
                if (a.StartsWith("harf:"))
                {
                    yeniTusAta.yilmazturkAdvancedButton2.Text = a.Substring(5);
                    yeniTusAta.label4.Visible = true;
                }
                else if (a.StartsWith("Aç:"))
                {
                    yeniTusAta.yilmazturkAdvancedButton2.Text = a;
                    yeniTusAta.label4.Visible = false;
                }
                else if (a.StartsWith("Kapat"))
                {
                    yeniTusAta.yilmazturkAdvancedButton2.Text = a;
                    yeniTusAta.label4.Visible = false;
                }
                else if (a.StartsWith("Yeniden başlat"))
                {
                    yeniTusAta.yilmazturkAdvancedButton2.Text = a;
                    yeniTusAta.label4.Visible = false;
                }
                else
                {
                    yeniTusAta.yilmazturkAdvancedButton2.Text = "Görev Seç";
                    yeniTusAta.label4.Visible = false;
                }
                yeniTusAta.Show();
            }
            catch
            {

            }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(@"C:\Users\" + Environment.UserName + @"\YilmazturkToys\" + listBox1.SelectedItem.ToString());
                lstBox();
                duzenleBtn.Visible = false;
                silBtn.Visible = false;
            }
            catch
            {

            }
        }
    }
}
