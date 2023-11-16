using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Yilmazturk_Toys
{
    public partial class KeyEngine : Form
    {
     
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);


        [DllImport("user32.dll", SetLastError = true)]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

      
        const int WM_KEYDOWN = 0x0100;

  
        const int VK_F1 = 0x70;
        public List<string> keyNames;

        public bool asd = true;
        public KeyEngine()
        {
            InitializeComponent();
        }

        private void KeyEngine_Load(object sender, EventArgs e)
        {

            keyNames = GetKeyNamesFromFolder(@"C:\Users\" + Environment.UserName + @"\YilmazturkToys\");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (asd == true)
            {
                CheckForHotKey();
            }
        }
        public List<string> GetKeyNamesFromFolder(string folderPath)
        { 
            var items = Directory.GetFileSystemEntries(folderPath);
            return items.Select(item => Path.GetFileName(item)).ToList();
        }

        private void CheckForHotKey()
        {

            foreach (var keyName in keyNames)
            {
                Keys key = (Keys)Enum.Parse(typeof(Keys), keyName);
                if (IsKeyDown(key))
                {
                    this.BringToFront();
                    string file = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\YilmazturkToys\" + keyName);
                    if (file.StartsWith("Aç:"))
                    {
                        Process.Start(file.Substring(3));
                    }
                    else if (file.StartsWith("harf:"))
                    {
                        SendKeys.Send(file.Substring(5));
                    }
                    else if(file == "Kapat")
                    {
                        var psi = new ProcessStartInfo("shutdown", "/s /t 0");
                        psi.CreateNoWindow = true;
                        psi.UseShellExecute = false;
                        Process.Start(psi);
                    }
                    else if (file == "Yeniden başlat")
                    {
                        var psi = new ProcessStartInfo("shutdown", "/r /t 0");
                        psi.CreateNoWindow = true;
                        psi.UseShellExecute = false;
                        Process.Start(psi);
                    }
                }
            }
        }

        private bool IsKeyDown(Keys key)
        {
           
            return (GetAsyncKeyState(key) & 0x8000) != 0;
        }

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        private void KeyEngine_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            timer1.Stop();
        }
    }
}
