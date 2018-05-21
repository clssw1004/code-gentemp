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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace App
{
    public partial class MainWindow : Form
    {
        private List<DbColumn> tableCols;
        private String selectTable;
        private Dictionary<String, String> args = new Dictionary<string, string>();
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
            try
            {
                if (Adapter != null && listBox1.SelectedItem != null)
                {
                    selectTable = listBox1.SelectedItem.ToString();
                    tableCols = Adapter.GetColumns(selectTable);
                    this.listView1.BeginUpdate();

                    foreach (var col in tableCols)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = col.ColumnName;
                        lvi.SubItems.Add(col.ColumnType);
                        lvi.SubItems.Add(col.IsNullable);
                        this.listView1.Items.Add(lvi);
                    }

                    this.listView1.EndUpdate();
                    generateArgs();
                    renderTemplate();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void menu_connDb_Click(object sender, EventArgs e)
        {
            ConnectArgs connectArgs = new ConnectArgs();
            connectArgs.window = this;
            connectArgs.ShowDialog();
        }

        private void menu_template_Click(object sender, EventArgs e)
        {
            SetPath sp = new SetPath();
            sp.ShowDialog();
        }

        private void generateArgs()
        {
            if (String.IsNullOrEmpty(selectTable))
            {
                return;
            }
            if (!String.IsNullOrEmpty(tb_ex_prefix.Text))
            {
                String[] prefix = tb_ex_prefix.Text.Split(',');
                String modelName = selectTable;
                //去表名前缀
                foreach (var p in prefix)
                {
                    modelName = modelName.Replace(p, "");
                }
                //驼峰命名生曾实体类名
                MatchCollection mc = Regex.Matches(modelName, "_[0-9a-zA-Z_]{1,1}");
                if (mc != null)
                {
                    foreach (Match m in mc)
                    {
                        modelName = modelName.Replace(m.Value, m.Value.ToUpper().Replace("_", ""));
                    }
                }
                String modelNameVariable = modelName;
                modelName = modelName.Substring(0, 1).ToUpper() + modelName.Substring(1);
                String bizName = modelName.ToLower();
                this.tb_bizName.Text = bizName;
                this.tb_modelName.Text = modelName;
                addArgs("modelName", modelName);
                addArgs("modelNameVariable", modelNameVariable);
                addArgs("bizName", bizName);

            }
        }
        private void renderTemplate()
        {
            String pathPrefix = @"D:\env\2018\templates\";

            String controll1Path = pathPrefix + @"controller\TDicController.java";
            Template t1 = new Template(controll1Path, Encoding.UTF8);
            tp_controller1.Text = args["modelName"] + "Controller";
            src_c1.Text = t1.Analyze(args);
            
            String controll2Path = pathPrefix + @"controller\TDicQueryController.java";
            Template t2 = new Template(controll2Path, Encoding.UTF8);
            tp_controller2.Text = args["modelName"] + "QueryController";
            src_c2.Text = t2.Analyze(args);

            String service1Path = pathPrefix + @"service\TDicService.java";
            Template t3 = new Template(service1Path, Encoding.UTF8);
            tp_service1.Text = args["modelName"] + "Service";
            src_s1.Text = t2.Analyze(args);

            String service2Path = pathPrefix + @"query\TDicQuery.java";
            Template t4 = new Template(service2Path, Encoding.UTF8);
            tp_service2.Text = args["modelName"] + "Query";
            src_s2.Text = t2.Analyze(args);

        }
        private void addArgs(String key, String val)
        {
            if (args.ContainsKey(key))
            {
                args[key] = val;
            }
            else
            {
                args.Add(key, val);
            }
        }
    }
}
