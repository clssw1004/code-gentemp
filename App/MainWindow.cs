using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            InitScintilla();
        }
        public void InitScintilla()
        {
            
        }
        private void App_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"D:\env\scb_workspace\scb-2nd-parsing\src\main\java\com\quangao\scb\parsing\MessageParser.java");
            String src = sr.ReadToEnd();
            scintilla.Text = src;

        }
    }
}
