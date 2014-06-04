namespace Project_TouchCube
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_pasword = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_pasword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.cmb_language = new System.Windows.Forms.ComboBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(45, 43);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(77, 13);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "gebruikernaam";
            // 
            // lbl_pasword
            // 
            this.lbl_pasword.AutoSize = true;
            this.lbl_pasword.Location = new System.Drawing.Point(57, 65);
            this.lbl_pasword.Name = "lbl_pasword";
            this.lbl_pasword.Size = new System.Drawing.Size(65, 13);
            this.lbl_pasword.TabIndex = 1;
            this.lbl_pasword.Text = "wachtwoord";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(128, 36);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(139, 20);
            this.txt_username.TabIndex = 2;
            // 
            // txt_pasword
            // 
            this.txt_pasword.Location = new System.Drawing.Point(128, 62);
            this.txt_pasword.Name = "txt_pasword";
            this.txt_pasword.PasswordChar = '*';
            this.txt_pasword.Size = new System.Drawing.Size(139, 20);
            this.txt_pasword.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_error);
            this.groupBox1.Controls.Add(this.cmb_language);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.lbl_pasword);
            this.groupBox1.Controls.Add(this.txt_pasword);
            this.groupBox1.Controls.Add(this.lbl_username);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inloggen";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(6, 16);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 5;
            // 
            // cmb_language
            // 
            this.cmb_language.DisplayMember = "nederlands";
            this.cmb_language.FormattingEnabled = true;
            this.cmb_language.Items.AddRange(new object[] {
            "Nederlands",
            "English"});
            this.cmb_language.Location = new System.Drawing.Point(39, 87);
            this.cmb_language.Name = "cmb_language";
            this.cmb_language.Size = new System.Drawing.Size(83, 21);
            this.cmb_language.TabIndex = 6;
            this.cmb_language.SelectedIndexChanged += new System.EventHandler(this.cmb_language_SelectedIndexChanged);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(187, 87);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(80, 24);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Inloggen";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 136);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_pasword;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_pasword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.ComboBox cmb_language;
        private System.Windows.Forms.Label lbl_error;



    }
}