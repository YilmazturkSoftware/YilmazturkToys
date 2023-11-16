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
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void yilmazturkButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void yilmazturkButton2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void yilmazturkButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            YilmazturkThemeSelector.Apply("sistemDeğişir", this);
        }

        private void yilmazturkAdvancedButton2_Click(object sender, EventArgs e)
        {
            Hakkinda hakkinda = new Hakkinda();
            hakkinda.Show();
        }

        private void yilmazturkAdvancedButton3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }
    }
}
