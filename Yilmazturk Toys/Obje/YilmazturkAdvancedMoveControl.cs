using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YilmazturkUI
{
    public class YilmazturkAdvancedMoveControl : Component
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
        private Control _cntrl;
        private Control _cntrl2;
        private int _CornerRadius = 30;

        public Control TargetControl2
        {

            get { return _cntrl2; }
            set
            {
                _cntrl2 = value;

            }
        }

        public Control TargetControl
        {
           
            get { return _cntrl; }
            set
            {
            bool durum = false;
            Point İlkkonum = new Point();
                _cntrl = value;
                if (_cntrl != null)
                {
                    _cntrl.MouseUp += (senders, args) =>
                    {

                        durum = false;


                    };

                    _cntrl.MouseMove += (senders, args) =>
                    {
                        if (durum)
                        {
                            _cntrl2.Top = args.Y + _cntrl2.Top - (İlkkonum.Y);
                            _cntrl2.Left = args.X + _cntrl2.Left - (İlkkonum.X);
                        }
                    };
                    _cntrl.MouseDown += (senders, args) =>
                    {
                        durum = true;

                        İlkkonum = args.Location;

                    };
                }
          
            }
        }

   


    }
}