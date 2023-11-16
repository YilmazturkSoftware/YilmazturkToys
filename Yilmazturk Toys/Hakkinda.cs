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
    public partial class Hakkinda : Form
    {
        public Hakkinda()
        {
            InitializeComponent();
        }

        private void yilmazturkAdvancedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start("https://instagram.com/yilmazturksoftware");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://instagram.com/yilmazturksoftware");
        }

        private void Hakkinda_Load(object sender, EventArgs e)
        {
            YilmazturkThemeSelector.Apply("sistemDeğişir", this);
        }
    }
}
