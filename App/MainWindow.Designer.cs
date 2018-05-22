namespace App
{
    public partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.config = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_connDb = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_template = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ex_prefix = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.sec_do = new System.Windows.Forms.TabControl();
            this.tp_controller1 = new System.Windows.Forms.TabPage();
            this.src_c1 = new ScintillaNET.Scintilla();
            this.tp_controller2 = new System.Windows.Forms.TabPage();
            this.src_c2 = new ScintillaNET.Scintilla();
            this.tp_service1 = new System.Windows.Forms.TabPage();
            this.src_s1 = new ScintillaNET.Scintilla();
            this.tp_service2 = new System.Windows.Forms.TabPage();
            this.src_s2 = new ScintillaNET.Scintilla();
            this.tp_domain = new System.Windows.Forms.TabPage();
            this.src_do = new ScintillaNET.Scintilla();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_modelName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_bizName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.sec_do.SuspendLayout();
            this.tp_controller1.SuspendLayout();
            this.tp_controller2.SuspendLayout();
            this.tp_service1.SuspendLayout();
            this.tp_service2.SuspendLayout();
            this.tp_domain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.config});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1011, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // config
            // 
            this.config.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_connDb,
            this.menu_template});
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(44, 21);
            this.config.Text = "配置";
            // 
            // menu_connDb
            // 
            this.menu_connDb.Name = "menu_connDb";
            this.menu_connDb.Size = new System.Drawing.Size(136, 22);
            this.menu_connDb.Text = "连接数据库";
            this.menu_connDb.Click += new System.EventHandler(this.menu_connDb_Click);
            // 
            // menu_template
            // 
            this.menu_template.Name = "menu_template";
            this.menu_template.Size = new System.Drawing.Size(136, 22);
            this.menu_template.Text = "模版路径";
            this.menu_template.Click += new System.EventHandler(this.menu_template_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1011, 552);
            this.splitContainer1.SplitterDistance = 138;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 552);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.sec_do);
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Size = new System.Drawing.Size(870, 552);
            this.splitContainer2.SplitterDistance = 254;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.tb_ex_prefix);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.listView1);
            this.splitContainer3.Size = new System.Drawing.Size(254, 552);
            this.splitContainer3.SplitterDistance = 59;
            this.splitContainer3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "过滤表名前缀(,分隔)";
            // 
            // tb_ex_prefix
            // 
            this.tb_ex_prefix.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_ex_prefix.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_ex_prefix.Location = new System.Drawing.Point(0, 33);
            this.tb_ex_prefix.Name = "tb_ex_prefix";
            this.tb_ex_prefix.Size = new System.Drawing.Size(254, 26);
            this.tb_ex_prefix.TabIndex = 0;
            this.tb_ex_prefix.Text = "wms_,t_";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(254, 489);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // sec_do
            // 
            this.sec_do.Controls.Add(this.tp_controller1);
            this.sec_do.Controls.Add(this.tp_controller2);
            this.sec_do.Controls.Add(this.tp_service1);
            this.sec_do.Controls.Add(this.tp_service2);
            this.sec_do.Controls.Add(this.tp_domain);
            this.sec_do.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sec_do.Location = new System.Drawing.Point(0, 137);
            this.sec_do.Name = "sec_do";
            this.sec_do.SelectedIndex = 0;
            this.sec_do.Size = new System.Drawing.Size(613, 415);
            this.sec_do.TabIndex = 1;
            // 
            // tp_controller1
            // 
            this.tp_controller1.Controls.Add(this.src_c1);
            this.tp_controller1.Location = new System.Drawing.Point(4, 22);
            this.tp_controller1.Name = "tp_controller1";
            this.tp_controller1.Padding = new System.Windows.Forms.Padding(3);
            this.tp_controller1.Size = new System.Drawing.Size(605, 389);
            this.tp_controller1.TabIndex = 0;
            this.tp_controller1.UseVisualStyleBackColor = true;
            // 
            // src_c1
            // 
            this.src_c1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.src_c1.Location = new System.Drawing.Point(3, 3);
            this.src_c1.Name = "src_c1";
            this.src_c1.Size = new System.Drawing.Size(599, 383);
            this.src_c1.TabIndex = 0;
            this.src_c1.Text = "scintilla1";
            // 
            // tp_controller2
            // 
            this.tp_controller2.Controls.Add(this.src_c2);
            this.tp_controller2.Location = new System.Drawing.Point(4, 22);
            this.tp_controller2.Name = "tp_controller2";
            this.tp_controller2.Padding = new System.Windows.Forms.Padding(3);
            this.tp_controller2.Size = new System.Drawing.Size(605, 389);
            this.tp_controller2.TabIndex = 1;
            this.tp_controller2.UseVisualStyleBackColor = true;
            // 
            // src_c2
            // 
            this.src_c2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.src_c2.Location = new System.Drawing.Point(3, 3);
            this.src_c2.Name = "src_c2";
            this.src_c2.Size = new System.Drawing.Size(599, 383);
            this.src_c2.TabIndex = 1;
            this.src_c2.Text = "scintilla2";
            // 
            // tp_service1
            // 
            this.tp_service1.Controls.Add(this.src_s1);
            this.tp_service1.Location = new System.Drawing.Point(4, 22);
            this.tp_service1.Name = "tp_service1";
            this.tp_service1.Size = new System.Drawing.Size(605, 389);
            this.tp_service1.TabIndex = 2;
            this.tp_service1.UseVisualStyleBackColor = true;
            // 
            // src_s1
            // 
            this.src_s1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.src_s1.Location = new System.Drawing.Point(0, 0);
            this.src_s1.Name = "src_s1";
            this.src_s1.Size = new System.Drawing.Size(605, 389);
            this.src_s1.TabIndex = 1;
            this.src_s1.Text = "scintilla3";
            // 
            // tp_service2
            // 
            this.tp_service2.Controls.Add(this.src_s2);
            this.tp_service2.Location = new System.Drawing.Point(4, 22);
            this.tp_service2.Name = "tp_service2";
            this.tp_service2.Size = new System.Drawing.Size(605, 389);
            this.tp_service2.TabIndex = 4;
            this.tp_service2.UseVisualStyleBackColor = true;
            // 
            // src_s2
            // 
            this.src_s2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.src_s2.Location = new System.Drawing.Point(0, 0);
            this.src_s2.Name = "src_s2";
            this.src_s2.Size = new System.Drawing.Size(605, 389);
            this.src_s2.TabIndex = 1;
            this.src_s2.Text = "scintilla4";
            // 
            // tp_domain
            // 
            this.tp_domain.Controls.Add(this.src_do);
            this.tp_domain.Location = new System.Drawing.Point(4, 22);
            this.tp_domain.Name = "tp_domain";
            this.tp_domain.Size = new System.Drawing.Size(605, 389);
            this.tp_domain.TabIndex = 3;
            this.tp_domain.UseVisualStyleBackColor = true;
            // 
            // src_do
            // 
            this.src_do.Dock = System.Windows.Forms.DockStyle.Fill;
            this.src_do.Location = new System.Drawing.Point(0, 0);
            this.src_do.Name = "src_do";
            this.src_do.Size = new System.Drawing.Size(605, 389);
            this.src_do.TabIndex = 1;
            this.src_do.Text = "scintilla5";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_url);
            this.panel1.Controls.Add(this.tb_modelName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_bizName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 137);
            this.panel1.TabIndex = 0;
            // 
            // tb_modelName
            // 
            this.tb_modelName.Location = new System.Drawing.Point(63, 39);
            this.tb_modelName.Name = "tb_modelName";
            this.tb_modelName.Size = new System.Drawing.Size(100, 21);
            this.tb_modelName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "实体名";
            // 
            // tb_bizName
            // 
            this.tb_bizName.Location = new System.Drawing.Point(63, 11);
            this.tb_bizName.Name = "tb_bizName";
            this.tb_bizName.Size = new System.Drawing.Size(100, 21);
            this.tb_bizName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "包名";
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(63, 70);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(100, 21);
            this.tb_url.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "URL";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 577);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "太冥";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.sec_do.ResumeLayout(false);
            this.tp_controller1.ResumeLayout(false);
            this.tp_controller2.ResumeLayout(false);
            this.tp_service1.ResumeLayout(false);
            this.tp_service2.ResumeLayout(false);
            this.tp_domain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripMenuItem config;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem menu_connDb;
        private System.Windows.Forms.ToolStripMenuItem menu_template;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ex_prefix;
        private System.Windows.Forms.TabControl sec_do;
        private System.Windows.Forms.TabPage tp_controller1;
        private System.Windows.Forms.TabPage tp_controller2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_modelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_bizName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tp_service1;
        private System.Windows.Forms.TabPage tp_service2;
        private System.Windows.Forms.TabPage tp_domain;
        private ScintillaNET.Scintilla src_c1;
        private ScintillaNET.Scintilla src_c2;
        private ScintillaNET.Scintilla src_s1;
        private ScintillaNET.Scintilla src_s2;
        private ScintillaNET.Scintilla src_do;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_url;
    }
}

