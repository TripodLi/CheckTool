namespace ccgcscx
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonclose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelline = new System.Windows.Forms.Label();
            this.dataGridViewst = new System.Windows.Forms.DataGridView();
            this.Station_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.station_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GROUP_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.节点信息 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewnode = new System.Windows.Forms.DataGridView();
            this.节点名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.节点ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.运行存储过程 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labeltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDP = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewpa = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelline1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelgroup = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelstation = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelnode = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxpr = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnode)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonclose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 78);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Window_Move);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "参数查询工具";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ccgcscx.Properties.Resources.min1;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(639, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonclose
            // 
            this.buttonclose.BackColor = System.Drawing.Color.Transparent;
            this.buttonclose.BackgroundImage = global::ccgcscx.Properties.Resources.close1;
            this.buttonclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonclose.Location = new System.Drawing.Point(675, 12);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(30, 30);
            this.buttonclose.TabIndex = 1;
            this.buttonclose.UseVisualStyleBackColor = false;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "产线ID：";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(339, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "查  询";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelline
            // 
            this.labelline.AutoSize = true;
            this.labelline.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelline.ForeColor = System.Drawing.Color.OliveDrab;
            this.labelline.Location = new System.Drawing.Point(450, 138);
            this.labelline.Name = "labelline";
            this.labelline.Size = new System.Drawing.Size(109, 21);
            this.labelline.TabIndex = 4;
            this.labelline.Text = "labelline";
            this.labelline.Visible = false;
            // 
            // dataGridViewst
            // 
            this.dataGridViewst.AllowUserToAddRows = false;
            this.dataGridViewst.AllowUserToDeleteRows = false;
            this.dataGridViewst.AllowUserToResizeRows = false;
            this.dataGridViewst.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewst.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Station_Id,
            this.station_name,
            this.GROUP_ID,
            this.SEQ,
            this.Column1,
            this.节点信息});
            this.dataGridViewst.Location = new System.Drawing.Point(19, 171);
            this.dataGridViewst.MultiSelect = false;
            this.dataGridViewst.Name = "dataGridViewst";
            this.dataGridViewst.ReadOnly = true;
            this.dataGridViewst.RowHeadersVisible = false;
            this.dataGridViewst.RowTemplate.Height = 23;
            this.dataGridViewst.Size = new System.Drawing.Size(675, 253);
            this.dataGridViewst.TabIndex = 5;
            this.dataGridViewst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewst_CellContentClick);
            // 
            // Station_Id
            // 
            this.Station_Id.DataPropertyName = "station_name";
            this.Station_Id.HeaderText = "工位名称";
            this.Station_Id.Name = "Station_Id";
            this.Station_Id.ReadOnly = true;
            this.Station_Id.Width = 270;
            // 
            // station_name
            // 
            this.station_name.DataPropertyName = "station_id";
            this.station_name.HeaderText = "工位ID";
            this.station_name.Name = "station_name";
            this.station_name.ReadOnly = true;
            this.station_name.Width = 70;
            // 
            // GROUP_ID
            // 
            this.GROUP_ID.DataPropertyName = "group_id";
            this.GROUP_ID.HeaderText = "群组ID";
            this.GROUP_ID.Name = "GROUP_ID";
            this.GROUP_ID.ReadOnly = true;
            this.GROUP_ID.Width = 70;
            // 
            // SEQ
            // 
            this.SEQ.DataPropertyName = "station_seq";
            this.SEQ.HeaderText = "工位顺序号";
            this.SEQ.Name = "SEQ";
            this.SEQ.ReadOnly = true;
            this.SEQ.Width = 90;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "line_id";
            this.Column1.HeaderText = "产线ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // 节点信息
            // 
            this.节点信息.HeaderText = "节点信息";
            this.节点信息.Name = "节点信息";
            this.节点信息.ReadOnly = true;
            this.节点信息.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.节点信息.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.节点信息.Text = "节点信息";
            this.节点信息.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewnode
            // 
            this.dataGridViewnode.AllowUserToAddRows = false;
            this.dataGridViewnode.AllowUserToDeleteRows = false;
            this.dataGridViewnode.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewnode.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewnode.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewnode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewnode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.节点名称,
            this.节点ID,
            this.运行存储过程});
            this.dataGridViewnode.Location = new System.Drawing.Point(19, 446);
            this.dataGridViewnode.MultiSelect = false;
            this.dataGridViewnode.Name = "dataGridViewnode";
            this.dataGridViewnode.ReadOnly = true;
            this.dataGridViewnode.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewnode.RowHeadersVisible = false;
            this.dataGridViewnode.RowTemplate.Height = 23;
            this.dataGridViewnode.Size = new System.Drawing.Size(675, 185);
            this.dataGridViewnode.TabIndex = 6;
            this.dataGridViewnode.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewnode_CellContentClick);
            // 
            // 节点名称
            // 
            this.节点名称.DataPropertyName = "node_name";
            this.节点名称.HeaderText = "节点名称";
            this.节点名称.Name = "节点名称";
            this.节点名称.ReadOnly = true;
            this.节点名称.Width = 400;
            // 
            // 节点ID
            // 
            this.节点ID.DataPropertyName = "node_id";
            this.节点ID.HeaderText = "节点ID";
            this.节点ID.Name = "节点ID";
            this.节点ID.ReadOnly = true;
            this.节点ID.Width = 150;
            // 
            // 运行存储过程
            // 
            this.运行存储过程.HeaderText = "运行存储过程";
            this.运行存储过程.Name = "运行存储过程";
            this.运行存储过程.ReadOnly = true;
            this.运行存储过程.Text = "此节点运行";
            this.运行存储过程.ToolTipText = "此节点运行";
            this.运行存储过程.UseColumnTextForButtonValue = true;
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltime.ForeColor = System.Drawing.Color.SteelBlue;
            this.labeltime.Location = new System.Drawing.Point(566, 660);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(103, 29);
            this.labeltime.TabIndex = 7;
            this.labeltime.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 20);
            this.comboBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(17, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "数据库别名：";
            // 
            // textBoxDN
            // 
            this.textBoxDN.Enabled = false;
            this.textBoxDN.Location = new System.Drawing.Point(116, 94);
            this.textBoxDN.Name = "textBoxDN";
            this.textBoxDN.Size = new System.Drawing.Size(116, 21);
            this.textBoxDN.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(238, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "登录名：";
            // 
            // textBoxDD
            // 
            this.textBoxDD.Enabled = false;
            this.textBoxDD.Location = new System.Drawing.Point(309, 94);
            this.textBoxDD.Name = "textBoxDD";
            this.textBoxDD.Size = new System.Drawing.Size(97, 21);
            this.textBoxDD.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(412, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "密码：";
            // 
            // textBoxDP
            // 
            this.textBoxDP.Enabled = false;
            this.textBoxDP.Location = new System.Drawing.Point(462, 94);
            this.textBoxDP.Name = "textBoxDP";
            this.textBoxDP.Size = new System.Drawing.Size(97, 21);
            this.textBoxDP.TabIndex = 14;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(583, 92);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "修  改";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.dataGridViewpa);
            this.panel2.Controls.Add(this.labelline1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.labelgroup);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.labelstation);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.labelnode);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboBoxpr);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(19, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 460);
            this.panel2.TabIndex = 16;
            this.panel2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(564, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "确  定";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewpa
            // 
            this.dataGridViewpa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewpa.Location = new System.Drawing.Point(21, 123);
            this.dataGridViewpa.Name = "dataGridViewpa";
            this.dataGridViewpa.RowHeadersVisible = false;
            this.dataGridViewpa.RowTemplate.Height = 23;
            this.dataGridViewpa.Size = new System.Drawing.Size(629, 305);
            this.dataGridViewpa.TabIndex = 28;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ARGUMENT_NAME";
            this.Column2.HeaderText = "参数名";
            this.Column2.Name = "Column2";
            this.Column2.Width = 214;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DATA_TYPE";
            this.Column3.HeaderText = "参数类型";
            this.Column3.Name = "Column3";
            this.Column3.Width = 214;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PAVALUE";
            this.Column4.HeaderText = "参数值";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // labelline1
            // 
            this.labelline1.AutoSize = true;
            this.labelline1.Location = new System.Drawing.Point(527, 85);
            this.labelline1.Name = "labelline1";
            this.labelline1.Size = new System.Drawing.Size(47, 12);
            this.labelline1.TabIndex = 27;
            this.labelline1.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(455, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "当前产线：";
            // 
            // labelgroup
            // 
            this.labelgroup.AutoSize = true;
            this.labelgroup.Location = new System.Drawing.Point(310, 86);
            this.labelgroup.Name = "labelgroup";
            this.labelgroup.Size = new System.Drawing.Size(47, 12);
            this.labelgroup.TabIndex = 25;
            this.labelgroup.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "当前群组：";
            // 
            // labelstation
            // 
            this.labelstation.AutoSize = true;
            this.labelstation.Location = new System.Drawing.Point(95, 86);
            this.labelstation.Name = "labelstation";
            this.labelstation.Size = new System.Drawing.Size(47, 12);
            this.labelstation.TabIndex = 23;
            this.labelstation.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "当前工位：";
            // 
            // labelnode
            // 
            this.labelnode.AutoSize = true;
            this.labelnode.Location = new System.Drawing.Point(108, 57);
            this.labelnode.Name = "labelnode";
            this.labelnode.Size = new System.Drawing.Size(41, 12);
            this.labelnode.TabIndex = 21;
            this.labelnode.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "当前节点：";
            // 
            // comboBoxpr
            // 
            this.comboBoxpr.FormattingEnabled = true;
            this.comboBoxpr.Location = new System.Drawing.Point(131, 19);
            this.comboBoxpr.Name = "comboBoxpr";
            this.comboBoxpr.Size = new System.Drawing.Size(313, 20);
            this.comboBoxpr.TabIndex = 19;
            this.comboBoxpr.SelectedIndexChanged += new System.EventHandler(this.comboBoxpr_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "选择存储过程：";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(597, 434);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "返  回";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 715);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBoxDP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.dataGridViewnode);
            this.Controls.Add(this.dataGridViewst);
            this.Controls.Add(this.labelline);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnode)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelline;
        private System.Windows.Forms.DataGridView dataGridViewst;
        private System.Windows.Forms.DataGridView dataGridViewnode;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Station_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn station_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn GROUP_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn 节点信息;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDP;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 节点名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 节点ID;
        private System.Windows.Forms.DataGridViewButtonColumn 运行存储过程;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxpr;
        private System.Windows.Forms.DataGridView dataGridViewpa;
        private System.Windows.Forms.Label labelline1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelgroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelstation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelnode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

