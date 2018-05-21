using engine;
using engine.db;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class ConnectArgs : Form
    {
        public MainWindow window { private get; set; }
        public ConnectArgs()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_conn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_host.Text))
            {
                rb_msg.Text = "服务器IP不能为空!";
                rb_msg.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tb_host.Text))
            {
                rb_msg.Text = "服务器IP不能为空!";
                rb_msg.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tb_port.Text))
            {
                rb_msg.Text = "端口不能为空!";
                tb_port.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tb_user.Text))
            {
                rb_msg.Text = "用户名不能为空!";
                tb_user.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tb_pass.Text))
            {
                rb_msg.Text = "密码不能为空!";
                tb_pass.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tb_db.Text))
            {
                rb_msg.Text = "数据库不能为空!";
                tb_db.Focus();
                return;
            }
            try
            {
                MysqlAdapter adapter = new MysqlAdapter();
                adapter.SetServer(tb_host.Text)
                    .SetPort(tb_port.Text)
                    .SetUsername(tb_user.Text)
                    .SetPassword(tb_pass.Text)
                    .SetDataBase(tb_db.Text);
                MySqlConnection conn = adapter.GetConnection();
                conn.Open();
                conn.Close();
                window.Adapter = adapter;
                window.RefreshView();
                this.Close();
            }
            catch (Exception ex)
            {
                rb_msg.Text = String.Format("错误：{0}", ex.Message);
            }
        }
    }
}
