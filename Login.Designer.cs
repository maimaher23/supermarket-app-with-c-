namespace MiniMarket
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.but_login = new System.Windows.Forms.Button();
            this.lb_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lb_validated = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_login
            // 
            this.but_login.BackColor = System.Drawing.Color.DarkCyan;
            resources.ApplyResources(this.but_login, "but_login");
            this.but_login.ForeColor = System.Drawing.Color.MintCream;
            this.but_login.Name = "but_login";
            this.but_login.UseVisualStyleBackColor = false;
            this.but_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_id
            // 
            resources.ApplyResources(this.lb_id, "lb_id");
            this.lb_id.ForeColor = System.Drawing.Color.Teal;
            this.lb_id.Name = "lb_id";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Name = "label2";
            // 
            // txt_password
            // 
            this.txt_password.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txt_password.BackColor = System.Drawing.Color.Teal;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_password, "txt_password");
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Name = "txt_password";
            // 
            // txt_ID
            // 
            this.txt_ID.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txt_ID.BackColor = System.Drawing.Color.Teal;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txt_ID, "txt_ID");
            this.txt_ID.ForeColor = System.Drawing.Color.White;
            this.txt_ID.Name = "txt_ID";
            // 
            // lb_validated
            // 
            this.lb_validated.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.lb_validated, "lb_validated");
            this.lb_validated.ForeColor = System.Drawing.Color.White;
            this.lb_validated.Name = "lb_validated";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MiniMarket.Properties.Resources.images;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lb
            // 
            resources.ApplyResources(this.lb, "lb");
            this.lb.ForeColor = System.Drawing.Color.Red;
            this.lb.Name = "lb";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_validated);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.but_login);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_login;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lb_validated;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb;

    }
}