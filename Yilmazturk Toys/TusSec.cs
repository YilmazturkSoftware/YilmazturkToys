using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Yilmazturk_Toys
{
    public partial class TusSec : Form
    {
        public TusSec()
        {
            InitializeComponent();
        }
        public YeniTusAta yeni = new YeniTusAta();
        public GorevSec gorev = new GorevSec();
        bool basilanTusuSec = false;
        public bool gorevmiSeciliyor = false;
        private void yilmazturkAdvancedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TusSec_Load(object sender, EventArgs e)
        {
            YilmazturkThemeSelector.Apply("sistemDeğişir", this);
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                listBox1.Items.Add(key);
            }
        }

        private void yilmazturkAdvancedButton3_Click(object sender, EventArgs e)
        {
            if (basilanTusuSec == false)
            {
                basilanTusuSec = true;
                yilmazturkAdvancedButton3.Text = "Seçiliyor";
            }
            else
            {
                basilanTusuSec = false;
                yilmazturkAdvancedButton3.Text = "Basılan tuşu seç";
            }
        }

        private void TusSec_KeyDown(object sender, KeyEventArgs e)
        {
            if (basilanTusuSec == true)
            {
                Keys pressedKey = e.KeyCode;


                label3.Text = pressedKey + "";
                yilmazturkAdvancedButton3.Text = "Basılan tuşu seç";
                basilanTusuSec = false;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                label3.Text = listBox1.SelectedItem.ToString();
            }
            catch
            {

            }
        }

        private void yilmazturkAdvancedButton1_Click(object sender, EventArgs e)
        {
            if(label3.Text != "-")
            {
                if (gorevmiSeciliyor == true)
                {
                    gorev.yilmazturkAdvancedButton3.Text = label3.Text;
                    gorev.listBox1.Enabled = false;
                }
                else
                {
                    yeni.yilmazturkAdvancedButton1.Text = label3.Text;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bir tuş seçin");
            }
        }
    }
}
