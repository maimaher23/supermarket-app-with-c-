namespace MiniMarket
{
    partial class Casheir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Casheir));
            this.but_save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.but_finish = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_product = new System.Windows.Forms.ComboBox();
            this.producBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minimarketDataSet = new MiniMarket.MinimarketDataSet();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.tx_quantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Category1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.producTableAdapter = new MiniMarket.MinimarketDataSetTableAdapters.ProducTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimarketDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // but_save
            // 
            this.but_save.BackColor = System.Drawing.Color.White;
            this.but_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.but_save.Location = new System.Drawing.Point(155, 121);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(206, 30);
            this.but_save.TabIndex = 6;
            this.but_save.Text = "Save";
            this.but_save.UseVisualStyleBackColor = false;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(641, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(311, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bill ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(256, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(286, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.but_finish);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(122, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 370);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 34;
            // 
            // but_finish
            // 
            this.but_finish.BackColor = System.Drawing.Color.White;
            this.but_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_finish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.but_finish.Location = new System.Drawing.Point(641, 211);
            this.but_finish.Name = "but_finish";
            this.but_finish.Size = new System.Drawing.Size(112, 30);
            this.but_finish.TabIndex = 33;
            this.but_finish.Text = "Finish";
            this.but_finish.UseVisualStyleBackColor = false;
            this.but_finish.Click += new System.EventHandler(this.but_finish_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_product);
            this.groupBox2.Controls.Add(this.cb_category);
            this.groupBox2.Controls.Add(this.tx_quantity);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Category1);
            this.groupBox2.Controls.Add(this.but_save);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(71, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 161);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Item in bill";
            // 
            // cb_product
            // 
            this.cb_product.DataSource = this.producBindingSource;
            this.cb_product.DisplayMember = "ProductName";
            this.cb_product.FormattingEnabled = true;
            this.cb_product.Location = new System.Drawing.Point(185, 51);
            this.cb_product.Name = "cb_product";
            this.cb_product.Size = new System.Drawing.Size(257, 24);
            this.cb_product.TabIndex = 34;
            // 
            // producBindingSource
            // 
            this.producBindingSource.DataMember = "Produc";
            this.producBindingSource.DataSource = this.minimarketDataSet;
            // 
            // minimarketDataSet
            // 
            this.minimarketDataSet.DataSetName = "MinimarketDataSet";
            this.minimarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_category
            // 
            this.cb_category.DataSource = this.producBindingSource;
            this.cb_category.DisplayMember = "ProductCateg";
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(185, 22);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(257, 24);
            this.cb_category.TabIndex = 33;
            // 
            // tx_quantity
            // 
            this.tx_quantity.Location = new System.Drawing.Point(185, 80);
            this.tx_quantity.Name = "tx_quantity";
            this.tx_quantity.Size = new System.Drawing.Size(257, 22);
            this.tx_quantity.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(115, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(76, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Product name";
            // 
            // Category1
            // 
            this.Category1.AutoSize = true;
            this.Category1.ForeColor = System.Drawing.Color.Transparent;
            this.Category1.Location = new System.Drawing.Point(108, 25);
            this.Category1.Name = "Category1";
            this.Category1.Size = new System.Drawing.Size(71, 16);
            this.Category1.TabIndex = 26;
            this.Category1.Text = "Category";
            // 
            // listBox1
            // 
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(221, 303);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(311, 36);
            this.listBox1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(366, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MiniMarket.Properties.Resources.images;
            this.panel1.Location = new System.Drawing.Point(343, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 108);
            this.panel1.TabIndex = 18;
            // 
            // producTableAdapter
            // 
            this.producTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Casheir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1080, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Casheir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casheir";
            this.Load += new System.EventHandler(this.Casheir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimarketDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        //  private MinimarketDataSet minimarketDataSet;
      //  private MinimarketDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_product;
        private System.Windows.Forms.TextBox tx_quantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Category1;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Button but_finish;
        private MinimarketDataSet minimarketDataSet;
        private System.Windows.Forms.BindingSource producBindingSource;
        private MinimarketDataSetTableAdapters.ProducTableAdapter producTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        //  private MinimarketDataSet1 minimarketDataSet1;
      //  private MinimarketDataSet1TableAdapters.productTableAdapter productTableAdapter1;
    }
}