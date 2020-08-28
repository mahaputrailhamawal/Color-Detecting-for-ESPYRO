namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.rdiobtnKirmizi = new System.Windows.Forms.RadioButton();
            this.rdiobtnMavi = new System.Windows.Forms.RadioButton();
            this.rdiobtnTekCisimTakibi = new System.Windows.Forms.RadioButton();
            this.rdiobtnCokCisimTakibi = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdiobtnGeoSekil = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbtnElleBelirleme = new System.Windows.Forms.RadioButton();
            this.rdiobtnYesil = new System.Windows.Forms.RadioButton();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.chkboxMesafeOlcer = new System.Windows.Forms.CheckBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1016, 624);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1056, 273);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(380, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mulai";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(1056, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(378, 240);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(1056, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 114);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Command";
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(23, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 26);
            this.button3.TabIndex = 4;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rdiobtnKirmizi
            // 
            this.rdiobtnKirmizi.AutoSize = true;
            this.rdiobtnKirmizi.Location = new System.Drawing.Point(8, 19);
            this.rdiobtnKirmizi.Name = "rdiobtnKirmizi";
            this.rdiobtnKirmizi.Size = new System.Drawing.Size(45, 17);
            this.rdiobtnKirmizi.TabIndex = 6;
            this.rdiobtnKirmizi.TabStop = true;
            this.rdiobtnKirmizi.Text = "Red";
            this.rdiobtnKirmizi.UseVisualStyleBackColor = true;
            // 
            // rdiobtnMavi
            // 
            this.rdiobtnMavi.AutoSize = true;
            this.rdiobtnMavi.Location = new System.Drawing.Point(8, 65);
            this.rdiobtnMavi.Name = "rdiobtnMavi";
            this.rdiobtnMavi.Size = new System.Drawing.Size(46, 17);
            this.rdiobtnMavi.TabIndex = 7;
            this.rdiobtnMavi.TabStop = true;
            this.rdiobtnMavi.Text = "Blue";
            this.rdiobtnMavi.UseVisualStyleBackColor = true;
            // 
            // rdiobtnTekCisimTakibi
            // 
            this.rdiobtnTekCisimTakibi.AutoSize = true;
            this.rdiobtnTekCisimTakibi.Location = new System.Drawing.Point(14, 24);
            this.rdiobtnTekCisimTakibi.Name = "rdiobtnTekCisimTakibi";
            this.rdiobtnTekCisimTakibi.Size = new System.Drawing.Size(64, 17);
            this.rdiobtnTekCisimTakibi.TabIndex = 8;
            this.rdiobtnTekCisimTakibi.TabStop = true;
            this.rdiobtnTekCisimTakibi.Text = "Tunggal";
            this.rdiobtnTekCisimTakibi.UseVisualStyleBackColor = true;
            // 
            // rdiobtnCokCisimTakibi
            // 
            this.rdiobtnCokCisimTakibi.AutoSize = true;
            this.rdiobtnCokCisimTakibi.Location = new System.Drawing.Point(14, 47);
            this.rdiobtnCokCisimTakibi.Name = "rdiobtnCokCisimTakibi";
            this.rdiobtnCokCisimTakibi.Size = new System.Drawing.Size(61, 17);
            this.rdiobtnCokCisimTakibi.TabIndex = 9;
            this.rdiobtnCokCisimTakibi.TabStop = true;
            this.rdiobtnCokCisimTakibi.Text = "Banyak";
            this.rdiobtnCokCisimTakibi.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdiobtnGeoSekil);
            this.groupBox2.Controls.Add(this.rdiobtnTekCisimTakibi);
            this.groupBox2.Controls.Add(this.rdiobtnCokCisimTakibi);
            this.groupBox2.Location = new System.Drawing.Point(1284, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 114);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Track Mode";
            // 
            // rdiobtnGeoSekil
            // 
            this.rdiobtnGeoSekil.AutoSize = true;
            this.rdiobtnGeoSekil.Location = new System.Drawing.Point(14, 70);
            this.rdiobtnGeoSekil.Name = "rdiobtnGeoSekil";
            this.rdiobtnGeoSekil.Size = new System.Drawing.Size(59, 17);
            this.rdiobtnGeoSekil.TabIndex = 13;
            this.rdiobtnGeoSekil.TabStop = true;
            this.rdiobtnGeoSekil.Text = "Bentuk";
            this.rdiobtnGeoSekil.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbtnElleBelirleme);
            this.groupBox3.Controls.Add(this.rdiobtnYesil);
            this.groupBox3.Controls.Add(this.rdiobtnKirmizi);
            this.groupBox3.Controls.Add(this.rdiobtnMavi);
            this.groupBox3.Location = new System.Drawing.Point(1223, 480);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(93, 114);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Render GSC";
            // 
            // rdbtnElleBelirleme
            // 
            this.rdbtnElleBelirleme.AutoSize = true;
            this.rdbtnElleBelirleme.Location = new System.Drawing.Point(8, 88);
            this.rdbtnElleBelirleme.Name = "rdbtnElleBelirleme";
            this.rdbtnElleBelirleme.Size = new System.Drawing.Size(55, 17);
            this.rdbtnElleBelirleme.TabIndex = 24;
            this.rdbtnElleBelirleme.TabStop = true;
            this.rdbtnElleBelirleme.Text = "Mixing";
            this.rdbtnElleBelirleme.UseVisualStyleBackColor = true;
            // 
            // rdiobtnYesil
            // 
            this.rdiobtnYesil.AutoSize = true;
            this.rdiobtnYesil.Location = new System.Drawing.Point(8, 42);
            this.rdiobtnYesil.Name = "rdiobtnYesil";
            this.rdiobtnYesil.Size = new System.Drawing.Size(54, 17);
            this.rdiobtnYesil.TabIndex = 8;
            this.rdiobtnYesil.TabStop = true;
            this.rdiobtnYesil.Text = "Green";
            this.rdiobtnYesil.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(17, 38);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 115);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // chkboxMesafeOlcer
            // 
            this.chkboxMesafeOlcer.AutoSize = true;
            this.chkboxMesafeOlcer.Location = new System.Drawing.Point(17, 20);
            this.chkboxMesafeOlcer.Name = "chkboxMesafeOlcer";
            this.chkboxMesafeOlcer.Size = new System.Drawing.Size(89, 17);
            this.chkboxMesafeOlcer.TabIndex = 16;
            this.chkboxMesafeOlcer.Text = "Mesafe Ölçer";
            this.chkboxMesafeOlcer.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(136, 38);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(100, 115);
            this.richTextBox3.TabIndex = 17;
            this.richTextBox3.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button3;
            this.ClientSize = new System.Drawing.Size(1446, 651);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdiobtnKirmizi;
        private System.Windows.Forms.RadioButton rdiobtnMavi;
        private System.Windows.Forms.RadioButton rdiobtnTekCisimTakibi;
        private System.Windows.Forms.RadioButton rdiobtnCokCisimTakibi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdiobtnGeoSekil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdiobtnYesil;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.CheckBox chkboxMesafeOlcer;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RadioButton rdbtnElleBelirleme;
        private System.Windows.Forms.Button button3;
        //private System.Windows.Forms.CheckBox cek_koor;
        //private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

