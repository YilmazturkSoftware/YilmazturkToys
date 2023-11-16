using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yilmazturk_Toys
{
    public partial class GorevSec : Form
    {
        public GorevSec()
        {
            InitializeComponent();
        }
        public YeniTusAta yeni = new YeniTusAta();
        private void GorevSec_Load(object sender, EventArgs e)
        {
            YilmazturkThemeSelector.Apply("sistemDeğişir", this);
        }

        private void yilmazturkAdvancedButton3_Click(object sender, EventArgs e)
        {
            TusSec tusSec = new TusSec();
            tusSec.gorevmiSeciliyor = true;
            tusSec.gorev = this;
            tusSec.Show();
        }

        private void yilmazturkAdvancedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void yilmazturkAdvancedButton1_Click(object sender, EventArgs e)
        {
            if(yilmazturkAdvancedButton3.Text != "Klavyeden bir tuşun işlevini ata")
            {
                yeni.yilmazturkAdvancedButton2.Text = yilmazturkAdvancedButton3.Text;
                yeni.label4.Visible = true;
              
                this.Hide();
            }
            else
            {
                try
                {
                    if (listBox1.SelectedItem != null)
                    {
                        if (listBox1.SelectedItem.ToString() == "Bilgisayarı kapat")
                        {
                            yeni.yilmazturkAdvancedButton2.Text = "Kapat";
                        }
                        else if (listBox1.SelectedItem.ToString() == "Bilgisayarı yeniden başlat")
                        {
                            yeni.yilmazturkAdvancedButton2.Text = "Yeniden başlat";
                        }
                        else if (listBox1.SelectedItem.ToString() == "Bir uygulamayı aç")
                        {
                            if (label5.Text == "")
                            {
                                MessageBox.Show("Uygulamayı seçin.");
                            }
                            else
                            {
                                yeni.yilmazturkAdvancedButton2.Text = "Aç:" + label5.Text;
                            }
                        }
                        yeni.label4.Visible = false;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Bir şey seçin");
                    }
                }
                catch
                {
                    MessageBox.Show("Bir şey seçin");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem.ToString() == "Bir uygulamayı aç")
                {
                   
                    panel1.Visible = true;
                }
                else
                {
                    panel1.Visible = false;
                    label5.Text = "";
                }
            }
            catch
            {
                panel1.Visible = false;
                label5.Text = "";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void yilmazturkAdvancedButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }
        }

        private void yilmazturkAdvancedButton5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                label5.Text = textBox1.Text;
                listBox1.SelectedItem = "Bir uygulamayı aç";
                panel1.Visible = false;
            }
        }
    }
}
