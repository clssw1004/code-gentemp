namespace App
{
    partial class ConnectArgs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_conn = new System.Windows.Forms.Button();
            this.tb_db = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.tb_host = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_msg = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_exit);
            this.splitContainer1.Panel1.Controls.Add(this.btn_conn);
            this.splitContainer1.Panel1.Controls.Add(this.tb_db);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.tb_pass);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.tb_user);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.tb_port);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cb_type);
            this.splitContainer1.Panel1.Controls.Add(this.tb_host);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rb_msg);
            this.splitContainer1.Size = new System.Drawing.Size(713, 441);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.TabIndex = 15;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(374, 218);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(87, 37);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_conn
            // 
            this.btn_conn.Location = new System.Drawing.Point(240, 218);
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(87, 37);
            this.btn_conn.TabIndex = 6;
            this.btn_conn.Text = "连接";
            this.btn_conn.UseVisualStyleBackColor = true;
            this.btn_conn.Click += new System.EventHandler(this.btn_conn_Click);
            // 
            // tb_db
            // 
            this.tb_db.Location = new System.Drawing.Point(251, 170);
            this.tb_db.Name = "tb_db";
            this.tb_db.Size = new System.Drawing.Size(221, 25);
            this.tb_db.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "数据库";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(251, 139);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(221, 25);
            this.tb_pass.TabIndex = 4;
            this.tb_pass.Text = "123456";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "密码";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(251, 108);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(221, 25);
            this.tb_user.TabIndex = 3;
            this.tb_user.Text = "root";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "用户名";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(251, 77);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(221, 25);
            this.tb_port.TabIndex = 2;
            this.tb_port.Text = "3306";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "端口";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "数据库";
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Mysql"});
            this.cb_type.Location = new System.Drawing.Point(251, 11);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(221, 23);
            this.cb_type.TabIndex = 1000;
            this.cb_type.Text = "Mysql";
            // 
            // tb_host
            // 
            this.tb_host.Location = new System.Drawing.Point(251, 46);
            this.tb_host.Name = "tb_host";
            this.tb_host.Size = new System.Drawing.Size(221, 25);
            this.tb_host.TabIndex = 1;
            this.tb_host.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "服务器";
            // 
            // rb_msg
            // 
            this.rb_msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_msg.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rb_msg.ForeColor = System.Drawing.Color.Red;
            this.rb_msg.Location = new System.Drawing.Point(0, 0);
            this.rb_msg.Name = "rb_msg";
            this.rb_msg.ReadOnly = true;
            this.rb_msg.Size = new System.Drawing.Size(713, 165);
            this.rb_msg.TabIndex = 0;
            this.rb_msg.Text = "";
            // 
            // ConnectArgs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 441);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectArgs";
            this.Text = "连接到数据库";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_conn;
        private System.Windows.Forms.TextBox tb_db;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.TextBox tb_host;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rb_msg;
    }
}