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
            scintilla.Lexer = ScintillaNET.Lexer.Cpp;
            scintilla.Margins[0].Width = 25;
            scintilla.Margins[2].Type = MarginType.Symbol;
            scintilla.Margins[2].Mask = Marker.MaskFolders;
            scintilla.Margins[2].Sensitive = true;
            scintilla.Margins[2].Width = 20;
            // Set the lexer
            scintilla.Lexer = Lexer.Cpp;

            // Instruct the lexer to calculate folding
            scintilla.SetProperty("fold", "1");
            scintilla.SetProperty("fold.compact", "1");


            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                scintilla.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                scintilla.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            // Configure folding markers with respective symbols
            scintilla.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            scintilla.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            scintilla.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            scintilla.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintilla.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            scintilla.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintilla.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            scintilla.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);
            scintilla.Styles[Style.Default].Font = "Source Code Pro";
            scintilla.Styles[Style.Default].Size = 10;
            scintilla.Styles[Style.Default].ForeColor = Color.Gray; // Green
        }
        private void App_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"D:\env\scb_workspace\scb-2nd-parsing\src\main\java\com\quangao\scb\parsing\MessageParser.java");
            String src = sr.ReadToEnd();
            scintilla.Text = src;

        }
    }
}
