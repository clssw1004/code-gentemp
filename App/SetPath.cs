using engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace App
{
    public partial class SetPath : Form
    {
        private List<String> paths = new List<string>();
        public SetPath()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TemplateConfig.AddPath(folderBrowserDialog1.SelectedPath);
                RefreshList();
            }
        }

        private void SetPath_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            listBox1.Items.Clear();
            List<String> paths = TemplateConfig.GetPaths();
            foreach (var p in paths)
            {
                listBox1.Items.Add(p);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            TemplateConfig.RemovePath(listBox1.SelectedIndex);
            RefreshList();
        }
    }
}
