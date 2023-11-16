using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

using Button = System.Windows.Forms.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using ComboBox = System.Windows.Forms.ComboBox;
using Control = System.Windows.Forms.Control;
using Label = System.Windows.Forms.Label;
using ListBox = System.Windows.Forms.ListBox;
using MessageBox = System.Windows.Forms.MessageBox;
using Panel = System.Windows.Forms.Panel;

public static class YilmazturkThemeSelector
{
    #region Bu script Emre Yılmaztürk tarafından Yılmaztürk Software için yapılmıştır
    //Instagram hesabımızı takip etmeyi unutmayın.
    //İletişim için yilmazturksoftware@gmail.com
    //Instagram: https://instagram.com/yilmazturksoftware
    
    #endregion

    #region Değişkenler
    private const double BrightnessThreshold = 128.0;
    private static Control controls;
    #endregion
    #region Tetikleyici Kod
    public static async void Apply(string theme,Control control)
    {
        if(theme == "açık")
        {
            ApplyLightTheme(control);
        }
        else if(theme == "koyu")
        {
            ApplyDarkTheme(control);
        }
        else if(theme == "sistem")
        {
            if(GetWindowsTheme() == "Default")
            {
                ApplyLightTheme(control);
            }
            else
            {
                ApplyDarkTheme(control);
            }
        }
        else if (theme == "sistemDeğişir")
        {

            controls = control;
            await tema(control);


        }
        else
        {
            ApplyAnotherTheme(control);
        }
    }
    #endregion

    // Başlatıcı kod, tetikleyici koddur.

    #region Ana Kodlar 

    static async Task tema(Control contr)
    {
        if (GetWindowsTheme() == "Default")
        {
            ApplyLightTheme(contr);
           
        }
        else
        {
            ApplyDarkTheme(contr);
        }
        

        await Task.Delay(1000); tema(contr);

    }

    public static void ApplyAnotherTheme(Control control, bool pictureBoxDark = false)
    {
        var controlNames = ListControlItems(control, 0);
        foreach (var controlName in controlNames)
        {
            var currentControl = GetControlByName(control, controlName);
            if (currentControl != null)
            {
                ChangeThemeObjects(currentControl, pictureBoxDark);
            }
            if (control is Form form)
            {

                if (IsColorDarker(form.BackColor))
                {
                    form.BackColor = Color.WhiteSmoke;
                }
            }
        }
    }

    public static void ApplyDarkTheme(Control control, bool pictureBoxDark = false)
    {
        var controlNames = ListControlItems(control, 0);
        foreach (var controlName in controlNames)
        {
            var currentControl = GetControlByName(control, controlName);
            if (currentControl != null)
            {
                ChangeThemeObjectsDarkMode(currentControl);
            }
            if (control is Form form)
            {

                
                    form.BackColor = Color.FromArgb(24,24,24);
                
            }
        }
    }
    public static void ApplyLightTheme(Control control, bool pictureBoxDark = false)
    {
        var controlNames = ListControlItems(control, 0);
        foreach (var controlName in controlNames)
        {
            var currentControl = GetControlByName(control, controlName);
            if (currentControl != null)
            {
               ChangeThemeObjectsLightMode(currentControl);
            }
            if (control is Form form)
            {

               
                    form.BackColor = Color.WhiteSmoke;
                
            }
        }
    }


    private static void ChangeImageColor(Color newColor, PictureBox pictureBox)
    {
        Bitmap originalImage = new Bitmap(pictureBox.Image);

        float[][] colorMatrixElements = {
            new float[] { newColor.R / 255f, 0, 0, 0, 0 },  
            new float[] { 0, newColor.G / 255f, 0, 0, 0 }, 
            new float[] { 0, 0, newColor.B / 255f, 0, 0 }, 
            new float[] { 0, 0, 0, 1, 0 },                 
            new float[] { 0, 0, 0, 0, 1 }                   
        };

        ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

     
        ImageAttributes imageAttributes = new ImageAttributes();
        imageAttributes.SetColorMatrix(colorMatrix);


        Bitmap newImage = new Bitmap(originalImage.Width, originalImage.Height);

        using (Graphics g = Graphics.FromImage(newImage))
        {
            g.DrawImage(originalImage,
                        new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                        0, 0, originalImage.Width, originalImage.Height,
                        GraphicsUnit.Pixel, imageAttributes);
        }


        pictureBox.Image = newImage;
    }
    private static void ChangeThemeObjectsLightMode(Control control)
    {

        if (control is Label label)
        {
            label.ForeColor = Color.Black;
        }
        else if (control is Panel panel)
        {
            panel.BackColor =  Color.Transparent;
        }
        else if (control is ListBox listBox)
        {
            listBox.BackColor = Color.WhiteSmoke;
            listBox.ForeColor =  Color.Black;
        }
        else if (control is Button button)
        {
            button.BackColor = Color.Transparent;
            button.ForeColor = Color.Black;
        }
        else if (control is ComboBox comboBox)
        {
            comboBox.BackColor =  Color.Black;
            comboBox.ForeColor =  Color.White;
        }
        else if (control is CheckBox checkBox)
        {
            checkBox.BackColor =  Color.Black;
            checkBox.ForeColor =  Color.White;
        }
        else if (control is ContextMenuStrip contextMenu)
        {
            contextMenu.BackColor = Color.Black;
            contextMenu.ForeColor = Color.White;
        }
        else if (control is PictureBox pictureBox)
        {     
            ChangeImageColor(Color.Black, pictureBox);
        }
    }
    private static void ChangeThemeObjectsDarkMode(Control control)
    {
        if (control is Label label)
        {
            label.ForeColor = Color.White;
        }
        else if (control is Panel panel)
        {
            panel.BackColor = Color.Transparent;
        }
        else if (control is ListBox listBox)
        {
            listBox.BackColor = Color.FromArgb(24,24,24);
            listBox.ForeColor = Color.White;
        }
        else if (control is ComboBox comboBox)
        {
            comboBox.BackColor = Color.White;
            comboBox.ForeColor = Color.Black;
        }
        else if (control is Button button)
        {
            button.BackColor = Color.Transparent;
            button.ForeColor = Color.White;
        }
        else if (control is CheckBox checkBox)
        {
            checkBox.BackColor = Color.White;
            checkBox.ForeColor = Color.Black;
        }
        else if (control is ContextMenuStrip contextMenu)
        {
            contextMenu.BackColor = Color.White;
            contextMenu.ForeColor = Color.Black;
        }
    }
    private static void ChangeThemeObjects(Control control, bool dark)
    {

        if (control is Label label)
        {
            label.ForeColor = IsColorDarker(label.ForeColor) ? Color.White : Color.Black;
        }
        else if (control is Panel panel)
        {
            panel.BackColor = IsColorDarker(panel.BackColor) ? Color.White : Color.Black;
        }
        else if (control is ListBox listBox)
        {
            listBox.BackColor = IsColorDarker(listBox.BackColor) ? Color.White : Color.Black;
            listBox.ForeColor = IsColorDarker(listBox.ForeColor) ? Color.Black : Color.White;
        }
        else if (control is ComboBox comboBox)
        {
            comboBox.BackColor = IsColorDarker(comboBox.BackColor) ? Color.White : Color.Black;
            comboBox.ForeColor = IsColorDarker(comboBox.ForeColor) ? Color.Black : Color.White;
        }
        else if (control is CheckBox checkBox)
        {
            checkBox.BackColor = IsColorDarker(checkBox.BackColor) ? Color.White : Color.Black;
            checkBox.ForeColor = IsColorDarker(checkBox.ForeColor) ? Color.Black : Color.White;
        }
        else if (control is ContextMenuStrip contextMenu)
        {
            contextMenu.BackColor = IsColorDarker(contextMenu.BackColor) ? Color.White : Color.Black;
            contextMenu.ForeColor = IsColorDarker(contextMenu.ForeColor) ? Color.Black : Color.White;
        }
        else if (control is PictureBox pictureBox)
        {
            ChangeImageColor(Color.Black, pictureBox); 
        }
    }
    #endregion
    #region Ek Kodlar
    private static string GetWindowsTheme()
    {
        string RegistryKeyPath = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
        string RegistryValueName = "AppsUseLightTheme";

        if (SystemParameters.HighContrast)
            return "High Contrast";

        using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryKeyPath))
        {
            object registryValueObject = key?.GetValue(RegistryValueName);
            if (registryValueObject == null)
                return "Default";

            int registryValue = (int)registryValueObject;
            return registryValue > 0 ? "Default" : "Dark Theme";
        }
    }

    private static Control GetControlByName(Control control, string controlName)
    {
        return control.Controls.Find(controlName, true)?.FirstOrDefault();
    }

    private static List<string> ListControlItems(Control control, int indentLevel = 0)
    {
        var itemsList = new List<string>();

        System.Windows.Forms.ComboBox combo = new System.Windows.Forms.ComboBox();
        combo.Items.Add(control.Name);

        foreach (object item in combo.Items)
        {
            itemsList.Add(item.ToString());
        }

        foreach (Control subControl in control.Controls)
        {
            itemsList.AddRange(ListControlItems(subControl, indentLevel + 1));
        }

        return itemsList;
    }

    public static bool IsColorDarker(Color color)
    {
        double brightness = 0.299 * color.R + 0.587 * color.G + 0.114 * color.B;
        return brightness < BrightnessThreshold;
    }
    #endregion
}
