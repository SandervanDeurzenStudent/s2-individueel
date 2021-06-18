namespace Hondenrace
{
    partial class form1
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
            this.btn_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_dog5 = new System.Windows.Forms.PictureBox();
            this.pb_dog4 = new System.Windows.Forms.PictureBox();
            this.pb_dog1 = new System.Windows.Forms.PictureBox();
            this.pb_dog2 = new System.Windows.Forms.PictureBox();
            this.pb_dog3 = new System.Windows.Forms.PictureBox();
            this.Mythosis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_p1balance = new System.Windows.Forms.Label();
            this.lbl_p2balance = new System.Windows.Forms.Label();
            this.lbl_p3balance = new System.Windows.Forms.Label();
            this.lbl_player1name = new System.Windows.Forms.Label();
            this.lbl_player2name = new System.Windows.Forms.Label();
            this.lbl_player3name = new System.Windows.Forms.Label();
            this.NuD_player1 = new System.Windows.Forms.NumericUpDown();
            this.NuD_player2 = new System.Windows.Forms.NumericUpDown();
            this.NuD_player3 = new System.Windows.Forms.NumericUpDown();
            this.cb_player1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dog5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuD_player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuD_player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuD_player3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(27, 413);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(103, 63);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start!";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::Hondenrace.Properties.Resources.zand;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 293);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pb_dog5
            // 
            this.pb_dog5.Image = global::Hondenrace.Properties.Resources.daggoess;
            this.pb_dog5.Location = new System.Drawing.Point(30, 259);
            this.pb_dog5.Name = "pb_dog5";
            this.pb_dog5.Size = new System.Drawing.Size(57, 50);
            this.pb_dog5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_dog5.TabIndex = 8;
            this.pb_dog5.TabStop = false;
            // 
            // pb_dog4
            // 
            this.pb_dog4.Image = global::Hondenrace.Properties.Resources.daggoess;
            this.pb_dog4.Location = new System.Drawing.Point(30, 203);
            this.pb_dog4.Name = "pb_dog4";
            this.pb_dog4.Size = new System.Drawing.Size(57, 50);
            this.pb_dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_dog4.TabIndex = 9;
            this.pb_dog4.TabStop = false;
            // 
            // pb_dog1
            // 
            this.pb_dog1.Image = global::Hondenrace.Properties.Resources.daggoess;
            this.pb_dog1.Location = new System.Drawing.Point(30, 12);
            this.pb_dog1.Name = "pb_dog1";
            this.pb_dog1.Size = new System.Drawing.Size(57, 50);
            this.pb_dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_dog1.TabIndex = 10;
            this.pb_dog1.TabStop = false;
            this.pb_dog1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pb_dog2
            // 
            this.pb_dog2.Image = global::Hondenrace.Properties.Resources.daggoess;
            this.pb_dog2.Location = new System.Drawing.Point(30, 68);
            this.pb_dog2.Name = "pb_dog2";
            this.pb_dog2.Size = new System.Drawing.Size(57, 50);
            this.pb_dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_dog2.TabIndex = 11;
            this.pb_dog2.TabStop = false;
            // 
            // pb_dog3
            // 
            this.pb_dog3.Image = global::Hondenrace.Properties.Resources.daggoess;
            this.pb_dog3.Location = new System.Drawing.Point(30, 138);
            this.pb_dog3.Name = "pb_dog3";
            this.pb_dog3.Size = new System.Drawing.Size(57, 50);
            this.pb_dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_dog3.TabIndex = 12;
            this.pb_dog3.TabStop = false;
            // 
            // Mythosis
            // 
            this.Mythosis.AutoSize = true;
            this.Mythosis.Location = new System.Drawing.Point(868, 33);
            this.Mythosis.Name = "Mythosis";
            this.Mythosis.Size = new System.Drawing.Size(48, 13);
            this.Mythosis.TabIndex = 13;
            this.Mythosis.Text = "Mythosis";
            this.Mythosis.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(868, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "the Light";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(868, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bolt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(868, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sanic";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(868, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Zeus";
            // 
            // lbl_p1balance
            // 
            this.lbl_p1balance.AutoSize = true;
            this.lbl_p1balance.Location = new System.Drawing.Point(1110, 411);
            this.lbl_p1balance.Name = "lbl_p1balance";
            this.lbl_p1balance.Size = new System.Drawing.Size(13, 13);
            this.lbl_p1balance.TabIndex = 18;
            this.lbl_p1balance.Text = "0";
            this.lbl_p1balance.Visible = false;
            // 
            // lbl_p2balance
            // 
            this.lbl_p2balance.AutoSize = true;
            this.lbl_p2balance.Location = new System.Drawing.Point(1110, 438);
            this.lbl_p2balance.Name = "lbl_p2balance";
            this.lbl_p2balance.Size = new System.Drawing.Size(13, 13);
            this.lbl_p2balance.TabIndex = 19;
            this.lbl_p2balance.Text = "0";
            this.lbl_p2balance.Visible = false;
            // 
            // lbl_p3balance
            // 
            this.lbl_p3balance.AutoSize = true;
            this.lbl_p3balance.Location = new System.Drawing.Point(1110, 463);
            this.lbl_p3balance.Name = "lbl_p3balance";
            this.lbl_p3balance.Size = new System.Drawing.Size(13, 13);
            this.lbl_p3balance.TabIndex = 20;
            this.lbl_p3balance.Text = "0";
            this.lbl_p3balance.Visible = false;
            // 
            // lbl_player1name
            // 
            this.lbl_player1name.AutoSize = true;
            this.lbl_player1name.Location = new System.Drawing.Point(922, 411);
            this.lbl_player1name.Name = "lbl_player1name";
            this.lbl_player1name.Size = new System.Drawing.Size(29, 13);
            this.lbl_player1name.TabIndex = 21;
            this.lbl_player1name.Text = "label";
            this.lbl_player1name.Visible = false;
            this.lbl_player1name.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_player2name
            // 
            this.lbl_player2name.AutoSize = true;
            this.lbl_player2name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player2name.Location = new System.Drawing.Point(25, 373);
            this.lbl_player2name.Name = "lbl_player2name";
            this.lbl_player2name.Size = new System.Drawing.Size(66, 29);
            this.lbl_player2name.TabIndex = 22;
            this.lbl_player2name.Text = "label";
            // 
            // lbl_player3name
            // 
            this.lbl_player3name.AutoSize = true;
            this.lbl_player3name.Location = new System.Drawing.Point(922, 465);
            this.lbl_player3name.Name = "lbl_player3name";
            this.lbl_player3name.Size = new System.Drawing.Size(29, 13);
            this.lbl_player3name.TabIndex = 23;
            this.lbl_player3name.Text = "label";
            this.lbl_player3name.Visible = false;
            // 
            // NuD_player1
            // 
            this.NuD_player1.Location = new System.Drawing.Point(980, 409);
            this.NuD_player1.Name = "NuD_player1";
            this.NuD_player1.Size = new System.Drawing.Size(80, 20);
            this.NuD_player1.TabIndex = 24;
            this.NuD_player1.Visible = false;
            // 
            // NuD_player2
            // 
            this.NuD_player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuD_player2.Location = new System.Drawing.Point(404, 375);
            this.NuD_player2.Name = "NuD_player2";
            this.NuD_player2.Size = new System.Drawing.Size(99, 29);
            this.NuD_player2.TabIndex = 25;
            // 
            // NuD_player3
            // 
            this.NuD_player3.Location = new System.Drawing.Point(980, 463);
            this.NuD_player3.Name = "NuD_player3";
            this.NuD_player3.Size = new System.Drawing.Size(80, 20);
            this.NuD_player3.TabIndex = 26;
            this.NuD_player3.Visible = false;
            // 
            // cb_player1
            // 
            this.cb_player1.FormattingEnabled = true;
            this.cb_player1.Location = new System.Drawing.Point(404, 413);
            this.cb_player1.Name = "cb_player1";
            this.cb_player1.Size = new System.Drawing.Size(135, 21);
            this.cb_player1.TabIndex = 27;
            this.cb_player1.Text = "Choose a winner...";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 640);
            this.Controls.Add(this.cb_player1);
            this.Controls.Add(this.NuD_player3);
            this.Controls.Add(this.NuD_player2);
            this.Controls.Add(this.NuD_player1);
            this.Controls.Add(this.lbl_player3name);
            this.Controls.Add(this.lbl_player2name);
            this.Controls.Add(this.lbl_player1name);
            this.Controls.Add(this.lbl_p3balance);
            this.Controls.Add(this.lbl_p2balance);
            this.Controls.Add(this.lbl_p1balance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mythosis);
            this.Controls.Add(this.pb_dog3);
            this.Controls.Add(this.pb_dog2);
            this.Controls.Add(this.pb_dog1);
            this.Controls.Add(this.pb_dog4);
            this.Controls.Add(this.pb_dog5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_start);
            this.Name = "form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dog5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuD_player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuD_player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuD_player3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_dog5;
        private System.Windows.Forms.PictureBox pb_dog4;
        private System.Windows.Forms.PictureBox pb_dog1;
        private System.Windows.Forms.PictureBox pb_dog2;
        private System.Windows.Forms.PictureBox pb_dog3;
        private System.Windows.Forms.Label Mythosis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_p1balance;
        private System.Windows.Forms.Label lbl_p2balance;
        private System.Windows.Forms.Label lbl_p3balance;
        private System.Windows.Forms.Label lbl_player1name;
        private System.Windows.Forms.Label lbl_player2name;
        private System.Windows.Forms.Label lbl_player3name;
        private System.Windows.Forms.NumericUpDown NuD_player1;
        private System.Windows.Forms.NumericUpDown NuD_player2;
        private System.Windows.Forms.NumericUpDown NuD_player3;
        private System.Windows.Forms.ComboBox cb_player1;
    }
}

