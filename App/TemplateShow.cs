using engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace App
{
    public partial class TemplateShow : Form
    {
        public TemplateShow()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Utils.FormatInput(scintilla1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                String file = openFileDialog1.FileName;
                textBox1.Text = file;
                Template template = new Template(file);
                scintilla1.Text = template.Analyze(); 

            }
        }

  
    }
}
