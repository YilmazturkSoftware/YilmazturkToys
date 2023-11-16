using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace YilmazturkUI
{
    public class YilmazturkShadow : Control
    {
        private Control _cntrl;
        private bool dragging;
        private Point initialLocation;

        public Control TargetControl
        {
            get { return _cntrl; }
            set
            {
              

                _cntrl = value;

            }
        }

        private void TargetControl_MouseDown(object sender, MouseEventArgs args)
        {
            dragging = true;
            initialLocation = args.Location;
        }

        private void TargetControl_MouseMove(object sender, MouseEventArgs args)
        {
            if (dragging)
            {
                _cntrl.Left += args.X - initialLocation.X;
                _cntrl.Top += args.Y - initialLocation.Y;
            }
        }

        private void TargetControl_MouseUp(object sender, MouseEventArgs args)
        {
            dragging = false;
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private void ApplyDwmEffects()
        {
            if (CheckAeroEnabled())
            {
                var v = 2;
                DwmSetWindowAttribute(_cntrl.Handle, 2, ref v, 4);
                MARGINS margins = new MARGINS()
                {
                    bottomHeight = 1,
                    leftWidth = 0,
                    rightWidth = 0,
                    topHeight = 0
                };
                DwmExtendFrameIntoClientArea(_cntrl.Handle, ref margins);
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return enabled == 1;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    ApplyDwmEffects();
                    break;
                default:
                    break;
            }

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
                m.Result = (IntPtr)HTCAPTION;

            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                bool aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;

                if (!aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private int _CornerRadius = 30;

        // TODO: You may need to implement additional logic for rendering or other features based on your requirements.
    }
}
