using engine;
using MySql.Data.MySqlClient;
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
    public partial class MainWindow : Form
    {
        public IDbAdapter Adapter { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            this.listView1.Columns.Add("列名", 120, HorizontalAlignment.Left);
            this.listView1.Columns.Add("类型", 120, HorizontalAlignment.Left);
            this.listView1.Columns.Add("可空", 120, HorizontalAlignment.Left);
        }
        private void connectDb_Click(object sender, EventArgs e)
        {
            ConnectArgs connectArgs = new ConnectArgs();
            connectArgs.window = this;
            connectArgs.ShowDialog();
        }
        public void RefreshView()
        {
            if (Adapter != null)
            {
                List<String> tables = Adapter.GetTables();
                foreach (var table in tables)
                {
                    listBox1.Items.Add(table);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
                if (Adapter != null && listBox1.SelectedItem != null)
                {
                    List<DbColumn> cols = Adapter.GetColumns(listBox1.SelectedItem.ToString());
                    this.listView1.BeginUpdate();

                    foreach(var col in cols)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = col.ColumnName;
                        lvi.SubItems.Add(col.ColumnType);
                        lvi.SubItems.Add(col.IsNullable);
                        this.listView1.Items.Add(lvi);
                    }

                    this.listView1.EndUpdate();
                }
            //}catch(Exception ex)
            //{

            //}
            
        }
    }
}
