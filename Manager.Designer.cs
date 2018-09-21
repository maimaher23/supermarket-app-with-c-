namespace MiniMarket
{
    partial class Manager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_validated = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tx_id = new System.Windows.Forms.TextBox();
            this.lb_validation = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minimarketDataSet2 = new MiniMarket.MinimarketDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.but_add = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.but_update = new System.Windows.Forms.Button();
            this.tx_name = new System.Windows.Forms.TextBox();
            this.tx_salary = new System.Windows.Forms.TextBox();
            this.tx_position = new System.Windows.Forms.TextBox();
            this.tx_address = new System.Windows.Forms.TextBox();
            this.tx_password = new System.Windows.Forms.TextBox();
            this.tx_age = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtb_profit = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_check = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
//            this.employeeTableAdapter = new MiniMarket.MinimarketDataSet2TableAdapters.employeeTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimarketDataSet2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.lb_validated);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tx_id);
            this.groupBox1.Controls.Add(this.lb_validation);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.tx_name);
            this.groupBox1.Controls.Add(this.tx_salary);
            this.groupBox1.Controls.Add(this.tx_position);
            this.groupBox1.Controls.Add(this.tx_address);
            this.groupBox1.Controls.Add(this.tx_password);
            this.groupBox1.Controls.Add(this.tx_age);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(668, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 401);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // lb_validated
            // 
            this.lb_validated.AutoSize = true;
            this.lb_validated.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_validated.ForeColor = System.Drawing.Color.Red;
            this.lb_validated.Location = new System.Drawing.Point(319, 94);
            this.lb_validated.Name = "lb_validated";
            this.lb_validated.Size = new System.Drawing.Size(0, 18);
            this.lb_validated.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Honeydew;
            this.label12.Location = new System.Drawing.Point(113, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "ID:";
            // 
            // tx_id
            // 
            this.tx_id.BackColor = System.Drawing.Color.Azure;
            this.tx_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_id.ForeColor = System.Drawing.Color.Teal;
            this.tx_id.Location = new System.Drawing.Point(162, 142);
            this.tx_id.Multiline = true;
            this.tx_id.Name = "tx_id";
            this.tx_id.Size = new System.Drawing.Size(299, 22);
            this.tx_id.TabIndex = 15;
            // 
            // lb_validation
            // 
            this.lb_validation.AutoSize = true;
            this.lb_validation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_validation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_validation.Location = new System.Drawing.Point(303, 88);
            this.lb_validation.Name = "lb_validation";
            this.lb_validation.Size = new System.Drawing.Size(0, 18);
            this.lb_validation.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(271, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Aqua;
            this.panel1.Location = new System.Drawing.Point(65, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 51);
            this.panel1.TabIndex = 12;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.minimarketDataSet2;
            // 
            // minimarketDataSet2
            // 
            this.minimarketDataSet2.DataSetName = "MinimarketDataSet2";
            this.minimarketDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(332, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(20, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "The name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.but_add);
            this.groupBox3.Controls.Add(this.but_del);
            this.groupBox3.Controls.Add(this.but_update);
            this.groupBox3.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox3.Location = new System.Drawing.Point(50, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 54);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operations";
            // 
            // but_add
            // 
            this.but_add.BackColor = System.Drawing.Color.Teal;
            this.but_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_add.ForeColor = System.Drawing.Color.White;
            this.but_add.Location = new System.Drawing.Point(31, 19);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(120, 26);
            this.but_add.TabIndex = 2;
            this.but_add.Text = "Add ";
            this.but_add.UseVisualStyleBackColor = false;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // but_del
            // 
            this.but_del.BackColor = System.Drawing.Color.Teal;
            this.but_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_del.ForeColor = System.Drawing.Color.White;
            this.but_del.Location = new System.Drawing.Point(172, 19);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(120, 26);
            this.but_del.TabIndex = 3;
            this.but_del.Text = "Delete ";
            this.but_del.UseVisualStyleBackColor = false;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // but_update
            // 
            this.but_update.BackColor = System.Drawing.Color.Teal;
            this.but_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_update.ForeColor = System.Drawing.Color.White;
            this.but_update.Location = new System.Drawing.Point(314, 19);
            this.but_update.Name = "but_update";
            this.but_update.Size = new System.Drawing.Size(120, 26);
            this.but_update.TabIndex = 4;
            this.but_update.Text = "Update";
            this.but_update.UseVisualStyleBackColor = false;
            this.but_update.Click += new System.EventHandler(this.but_update_Click);
            // 
            // tx_name
            // 
            this.tx_name.BackColor = System.Drawing.Color.Azure;
            this.tx_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_name.ForeColor = System.Drawing.Color.Teal;
            this.tx_name.Location = new System.Drawing.Point(162, 116);
            this.tx_name.Multiline = true;
            this.tx_name.Name = "tx_name";
            this.tx_name.Size = new System.Drawing.Size(299, 20);
            this.tx_name.TabIndex = 11;
            // 
            // tx_salary
            // 
            this.tx_salary.BackColor = System.Drawing.Color.Azure;
            this.tx_salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_salary.ForeColor = System.Drawing.Color.Teal;
            this.tx_salary.Location = new System.Drawing.Point(162, 252);
            this.tx_salary.Multiline = true;
            this.tx_salary.Name = "tx_salary";
            this.tx_salary.Size = new System.Drawing.Size(299, 20);
            this.tx_salary.TabIndex = 10;
            // 
            // tx_position
            // 
            this.tx_position.BackColor = System.Drawing.Color.Azure;
            this.tx_position.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_position.ForeColor = System.Drawing.Color.Teal;
            this.tx_position.Location = new System.Drawing.Point(162, 225);
            this.tx_position.Multiline = true;
            this.tx_position.Name = "tx_position";
            this.tx_position.Size = new System.Drawing.Size(299, 20);
            this.tx_position.TabIndex = 9;
            // 
            // tx_address
            // 
            this.tx_address.BackColor = System.Drawing.Color.Azure;
            this.tx_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_address.ForeColor = System.Drawing.Color.Teal;
            this.tx_address.Location = new System.Drawing.Point(162, 278);
            this.tx_address.Multiline = true;
            this.tx_address.Name = "tx_address";
            this.tx_address.Size = new System.Drawing.Size(299, 20);
            this.tx_address.TabIndex = 8;
            // 
            // tx_password
            // 
            this.tx_password.BackColor = System.Drawing.Color.Azure;
            this.tx_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_password.ForeColor = System.Drawing.Color.Teal;
            this.tx_password.Location = new System.Drawing.Point(162, 196);
            this.tx_password.Multiline = true;
            this.tx_password.Name = "tx_password";
            this.tx_password.Size = new System.Drawing.Size(299, 23);
            this.tx_password.TabIndex = 7;
            // 
            // tx_age
            // 
            this.tx_age.BackColor = System.Drawing.Color.Azure;
            this.tx_age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_age.ForeColor = System.Drawing.Color.Teal;
            this.tx_age.Location = new System.Drawing.Point(162, 170);
            this.tx_age.Multiline = true;
            this.tx_age.Name = "tx_age";
            this.tx_age.Size = new System.Drawing.Size(299, 20);
            this.tx_age.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(81, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(96, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Salary:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(84, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Position:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(113, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.rtb_profit);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.but_check);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(33, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 401);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Budgets";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(144, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total Profit";
            // 
            // rtb_profit
            // 
            this.rtb_profit.BackColor = System.Drawing.Color.Azure;
            this.rtb_profit.Location = new System.Drawing.Point(265, 242);
            this.rtb_profit.Name = "rtb_profit";
            this.rtb_profit.Size = new System.Drawing.Size(228, 35);
            this.rtb_profit.TabIndex = 9;
            this.rtb_profit.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(124, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Search by:";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Azure;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly"});
            this.comboBox2.Location = new System.Drawing.Point(211, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(269, 23);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(60, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 48);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Exports";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Imports";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // but_check
            // 
            this.but_check.BackColor = System.Drawing.Color.Teal;
            this.but_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_check.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_check.ForeColor = System.Drawing.Color.MintCream;
            this.but_check.Location = new System.Drawing.Point(419, 330);
            this.but_check.Name = "but_check";
            this.but_check.Size = new System.Drawing.Size(104, 27);
            this.but_check.TabIndex = 6;
            this.but_check.Text = "More";
            this.but_check.UseVisualStyleBackColor = false;
            this.but_check.Click += new System.EventHandler(this.but_check_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label8.Location = new System.Drawing.Point(82, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::MiniMarket.Properties.Resources.images;
            this.panel2.Location = new System.Drawing.Point(172, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 99);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::MiniMarket.Properties.Resources.images;
            this.panel3.Location = new System.Drawing.Point(811, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 100);
            this.panel3.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.employeeBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "id";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1277, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.managerinterface_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimarketDataSet2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.Button but_update;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        protected internal System.Windows.Forms.TextBox tx_name;
        protected internal System.Windows.Forms.TextBox tx_salary;
        protected internal System.Windows.Forms.TextBox tx_position;
        protected internal System.Windows.Forms.TextBox tx_address;
        protected internal System.Windows.Forms.TextBox tx_password;
        protected internal System.Windows.Forms.TextBox tx_age;
        private System.Windows.Forms.Label label11;
        protected internal System.Windows.Forms.Label lb_validation;
        private System.Windows.Forms.Button but_check;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtb_profit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tx_id;
        private System.Windows.Forms.Label lb_validated;
        private System.Windows.Forms.Button button2;
        private MinimarketDataSet2 minimarketDataSet2;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private MinimarketDataSet2TableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}