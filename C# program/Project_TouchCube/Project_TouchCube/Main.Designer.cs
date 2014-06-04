namespace Project_TouchCube
{
    partial class Main
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
            this.cmb_patients = new System.Windows.Forms.ComboBox();
            this.btn_patient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_duimbot = new System.Windows.Forms.Label();
            this.lbl_duimtop = new System.Windows.Forms.Label();
            this.lbl_pinkbot = new System.Windows.Forms.Label();
            this.lbl_pinkmid = new System.Windows.Forms.Label();
            this.lbl_pinktop = new System.Windows.Forms.Label();
            this.lbl_ringbot = new System.Windows.Forms.Label();
            this.lbl_ringmid = new System.Windows.Forms.Label();
            this.lbl_ringtop = new System.Windows.Forms.Label();
            this.lbl_midbot = new System.Windows.Forms.Label();
            this.lbl_midmid = new System.Windows.Forms.Label();
            this.lbl_midtop = new System.Windows.Forms.Label();
            this.lbl_wijsbot = new System.Windows.Forms.Label();
            this.lbl_wijsmid = new System.Windows.Forms.Label();
            this.lbl_wijstop = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_measurement = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.cmb_port = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlstlbl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_patients
            // 
            this.cmb_patients.FormattingEnabled = true;
            this.cmb_patients.Location = new System.Drawing.Point(3, 27);
            this.cmb_patients.Name = "cmb_patients";
            this.cmb_patients.Size = new System.Drawing.Size(172, 21);
            this.cmb_patients.TabIndex = 1;
            // 
            // btn_patient
            // 
            this.btn_patient.Location = new System.Drawing.Point(90, 54);
            this.btn_patient.Name = "btn_patient";
            this.btn_patient.Size = new System.Drawing.Size(85, 23);
            this.btn_patient.TabIndex = 2;
            this.btn_patient.Text = "Bekijk patient";
            this.btn_patient.UseVisualStyleBackColor = true;
            this.btn_patient.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 261);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patienten";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Location = new System.Drawing.Point(9, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 85);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Voeg een nieuwe patient toe";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(47, 42);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Voeg Toe";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_patient);
            this.panel1.Controls.Add(this.cmb_patients);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 103);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bekijk patientgegevens";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_duimbot);
            this.groupBox2.Controls.Add(this.lbl_duimtop);
            this.groupBox2.Controls.Add(this.lbl_pinkbot);
            this.groupBox2.Controls.Add(this.lbl_pinkmid);
            this.groupBox2.Controls.Add(this.lbl_pinktop);
            this.groupBox2.Controls.Add(this.lbl_ringbot);
            this.groupBox2.Controls.Add(this.lbl_ringmid);
            this.groupBox2.Controls.Add(this.lbl_ringtop);
            this.groupBox2.Controls.Add(this.lbl_midbot);
            this.groupBox2.Controls.Add(this.lbl_midmid);
            this.groupBox2.Controls.Add(this.lbl_midtop);
            this.groupBox2.Controls.Add(this.lbl_wijsbot);
            this.groupBox2.Controls.Add(this.lbl_wijsmid);
            this.groupBox2.Controls.Add(this.lbl_wijstop);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btn_measurement);
            this.groupBox2.Location = new System.Drawing.Point(208, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 405);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metingen";
            // 
            // lbl_duimbot
            // 
            this.lbl_duimbot.AutoSize = true;
            this.lbl_duimbot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_duimbot.Location = new System.Drawing.Point(74, 219);
            this.lbl_duimbot.Name = "lbl_duimbot";
            this.lbl_duimbot.Size = new System.Drawing.Size(27, 15);
            this.lbl_duimbot.TabIndex = 15;
            this.lbl_duimbot.Text = "000";
            // 
            // lbl_duimtop
            // 
            this.lbl_duimtop.AutoSize = true;
            this.lbl_duimtop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_duimtop.Location = new System.Drawing.Point(40, 159);
            this.lbl_duimtop.Name = "lbl_duimtop";
            this.lbl_duimtop.Size = new System.Drawing.Size(27, 15);
            this.lbl_duimtop.TabIndex = 14;
            this.lbl_duimtop.Text = "000";
            // 
            // lbl_pinkbot
            // 
            this.lbl_pinkbot.AutoSize = true;
            this.lbl_pinkbot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_pinkbot.Location = new System.Drawing.Point(274, 171);
            this.lbl_pinkbot.Name = "lbl_pinkbot";
            this.lbl_pinkbot.Size = new System.Drawing.Size(27, 15);
            this.lbl_pinkbot.TabIndex = 13;
            this.lbl_pinkbot.Text = "000";
            // 
            // lbl_pinkmid
            // 
            this.lbl_pinkmid.AutoSize = true;
            this.lbl_pinkmid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_pinkmid.Location = new System.Drawing.Point(274, 138);
            this.lbl_pinkmid.Name = "lbl_pinkmid";
            this.lbl_pinkmid.Size = new System.Drawing.Size(27, 15);
            this.lbl_pinkmid.TabIndex = 12;
            this.lbl_pinkmid.Text = "000";
            // 
            // lbl_pinktop
            // 
            this.lbl_pinktop.AutoSize = true;
            this.lbl_pinktop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_pinktop.Location = new System.Drawing.Point(274, 97);
            this.lbl_pinktop.Name = "lbl_pinktop";
            this.lbl_pinktop.Size = new System.Drawing.Size(27, 15);
            this.lbl_pinktop.TabIndex = 11;
            this.lbl_pinktop.Text = "000";
            // 
            // lbl_ringbot
            // 
            this.lbl_ringbot.AutoSize = true;
            this.lbl_ringbot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ringbot.Location = new System.Drawing.Point(224, 171);
            this.lbl_ringbot.Name = "lbl_ringbot";
            this.lbl_ringbot.Size = new System.Drawing.Size(27, 15);
            this.lbl_ringbot.TabIndex = 10;
            this.lbl_ringbot.Text = "000";
            // 
            // lbl_ringmid
            // 
            this.lbl_ringmid.AutoSize = true;
            this.lbl_ringmid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ringmid.Location = new System.Drawing.Point(224, 121);
            this.lbl_ringmid.Name = "lbl_ringmid";
            this.lbl_ringmid.Size = new System.Drawing.Size(27, 15);
            this.lbl_ringmid.TabIndex = 9;
            this.lbl_ringmid.Text = "000";
            // 
            // lbl_ringtop
            // 
            this.lbl_ringtop.AutoSize = true;
            this.lbl_ringtop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ringtop.Location = new System.Drawing.Point(224, 66);
            this.lbl_ringtop.Name = "lbl_ringtop";
            this.lbl_ringtop.Size = new System.Drawing.Size(27, 15);
            this.lbl_ringtop.TabIndex = 8;
            this.lbl_ringtop.Text = "000";
            // 
            // lbl_midbot
            // 
            this.lbl_midbot.AutoSize = true;
            this.lbl_midbot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_midbot.Location = new System.Drawing.Point(178, 171);
            this.lbl_midbot.Name = "lbl_midbot";
            this.lbl_midbot.Size = new System.Drawing.Size(27, 15);
            this.lbl_midbot.TabIndex = 7;
            this.lbl_midbot.Text = "000";
            // 
            // lbl_midmid
            // 
            this.lbl_midmid.AutoSize = true;
            this.lbl_midmid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_midmid.Location = new System.Drawing.Point(178, 121);
            this.lbl_midmid.Name = "lbl_midmid";
            this.lbl_midmid.Size = new System.Drawing.Size(27, 15);
            this.lbl_midmid.TabIndex = 6;
            this.lbl_midmid.Text = "000";
            // 
            // lbl_midtop
            // 
            this.lbl_midtop.AutoSize = true;
            this.lbl_midtop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_midtop.Location = new System.Drawing.Point(178, 33);
            this.lbl_midtop.Name = "lbl_midtop";
            this.lbl_midtop.Size = new System.Drawing.Size(27, 15);
            this.lbl_midtop.TabIndex = 5;
            this.lbl_midtop.Text = "000";
            // 
            // lbl_wijsbot
            // 
            this.lbl_wijsbot.AutoSize = true;
            this.lbl_wijsbot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_wijsbot.Location = new System.Drawing.Point(135, 171);
            this.lbl_wijsbot.Name = "lbl_wijsbot";
            this.lbl_wijsbot.Size = new System.Drawing.Size(27, 15);
            this.lbl_wijsbot.TabIndex = 4;
            this.lbl_wijsbot.Text = "000";
            // 
            // lbl_wijsmid
            // 
            this.lbl_wijsmid.AutoSize = true;
            this.lbl_wijsmid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_wijsmid.Location = new System.Drawing.Point(135, 120);
            this.lbl_wijsmid.Name = "lbl_wijsmid";
            this.lbl_wijsmid.Size = new System.Drawing.Size(27, 15);
            this.lbl_wijsmid.TabIndex = 3;
            this.lbl_wijsmid.Text = "000";
            // 
            // lbl_wijstop
            // 
            this.lbl_wijstop.AutoSize = true;
            this.lbl_wijstop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_wijstop.Location = new System.Drawing.Point(135, 60);
            this.lbl_wijstop.Name = "lbl_wijstop";
            this.lbl_wijstop.Size = new System.Drawing.Size(27, 15);
            this.lbl_wijstop.TabIndex = 2;
            this.lbl_wijstop.Text = "000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_TouchCube.Properties.Resources.download__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_measurement
            // 
            this.btn_measurement.Location = new System.Drawing.Point(192, 373);
            this.btn_measurement.Name = "btn_measurement";
            this.btn_measurement.Size = new System.Drawing.Size(159, 26);
            this.btn_measurement.TabIndex = 0;
            this.btn_measurement.Text = "Voeg nieuwe meting toe";
            this.btn_measurement.UseVisualStyleBackColor = true;
            this.btn_measurement.Click += new System.EventHandler(this.btn_measurement_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_refresh);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btn_disconnect);
            this.groupBox3.Controls.Add(this.btn_connect);
            this.groupBox3.Controls.Add(this.cmb_port);
            this.groupBox3.Location = new System.Drawing.Point(12, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 128);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connectie";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(102, 58);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 16;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Poort:";
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(9, 87);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_disconnect.TabIndex = 16;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(102, 87);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // cmb_port
            // 
            this.cmb_port.FormattingEnabled = true;
            this.cmb_port.Location = new System.Drawing.Point(56, 30);
            this.cmb_port.Name = "cmb_port";
            this.cmb_port.Size = new System.Drawing.Size(121, 21);
            this.cmb_port.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstlbl_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(604, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlstlbl_status
            // 
            this.tlstlbl_status.ForeColor = System.Drawing.Color.DarkRed;
            this.tlstlbl_status.Name = "tlstlbl_status";
            this.tlstlbl_status.Size = new System.Drawing.Size(150, 17);
            this.tlstlbl_status.Text = "Niet verbonden met sensor";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 472);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Project TouchCube";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_patients;
        private System.Windows.Forms.Button btn_patient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_measurement;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_duimbot;
        private System.Windows.Forms.Label lbl_duimtop;
        private System.Windows.Forms.Label lbl_pinkbot;
        private System.Windows.Forms.Label lbl_pinkmid;
        private System.Windows.Forms.Label lbl_pinktop;
        private System.Windows.Forms.Label lbl_ringbot;
        private System.Windows.Forms.Label lbl_ringmid;
        private System.Windows.Forms.Label lbl_ringtop;
        private System.Windows.Forms.Label lbl_midbot;
        private System.Windows.Forms.Label lbl_midmid;
        private System.Windows.Forms.Label lbl_midtop;
        private System.Windows.Forms.Label lbl_wijsbot;
        private System.Windows.Forms.Label lbl_wijsmid;
        private System.Windows.Forms.Label lbl_wijstop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tlstlbl_status;
    }
}