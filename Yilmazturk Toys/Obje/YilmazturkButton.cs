using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YilmazturkUI
{
    public class YilmazturkButton : Button
{
    private Control hostControl;
    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
        );

    private int radius;

    [Category("Yılmaztürk UI")]
    [Description("Özel yarıçap özelliği")]
    public int Radius
    {
        get { return radius; }
        set
        {
            radius = value;
           
           
              
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, radius, radius));
            
            Invalidate();
        }
    }

    public YilmazturkButton()
    {
        Size = new System.Drawing.Size(241, 51);
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        BackColor = Color.FromArgb(33, 33, 33);
        Font = new Font("Microsoft PhagsPa", 14);
        ForeColor = Color.White;

    }

  

}

}