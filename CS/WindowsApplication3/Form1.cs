using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;

namespace WindowsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Skin s = DevExpress.Skins.CommonSkins.GetSkin(wizardControl1.LookAndFeel);
            wizardControl1.Image = s[DevExpress.Skins.CommonSkins.SkinGroupPanelCaptionLeft].Image.GetImages().Images[0];
        }
    }
}