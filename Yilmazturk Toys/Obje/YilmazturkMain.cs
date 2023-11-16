using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class YilmazturkMain
{
    private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);


    public static void KoyuMod(Form form)
    {
        try
        {
            if (DwmSetWindowAttribute(form.Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(form.Handle, 20, new[] { 1 }, 4);
        }
        catch
        {

        }
    }
}

