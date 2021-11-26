
namespace D2R_ANTISPAM
{
    partial class frmMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSmoothGaussian = new System.Windows.Forms.NumericUpDown();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.numThresholdToZero = new System.Windows.Forms.NumericUpDown();
            this.numThresholdBinary1 = new System.Windows.Forms.NumericUpDown();
            this.numThresholdBinary2 = new System.Windows.Forms.NumericUpDown();
            this.numCanny1 = new System.Windows.Forms.NumericUpDown();
            this.numCanny2 = new System.Windows.Forms.NumericUpDown();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.numDilate = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numErode = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.chkVerboseProcessing = new System.Windows.Forms.CheckBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.linkDiabloCloneDiscordServer = new System.Windows.Forms.LinkLabel();
            this.chkKeepOnTop = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSmoothGaussian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThresholdToZero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThresholdBinary1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThresholdBinary2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCanny1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCanny2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDilate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numErode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 500;
            this.tmrRefresh.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(304, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 304);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(616, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(304, 304);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(680, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 71;
            this.label1.Text = "Canny Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 75;
            this.label3.Text = "ThresholdToZero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(352, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 78;
            this.label4.Text = "ThresholdBinary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 81;
            this.label2.Text = "SmoothGaussian";
            // 
            // numSmoothGaussian
            // 
            this.numSmoothGaussian.Location = new System.Drawing.Point(200, 336);
            this.numSmoothGaussian.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSmoothGaussian.Name = "numSmoothGaussian";
            this.numSmoothGaussian.Size = new System.Drawing.Size(96, 29);
            this.numSmoothGaussian.TabIndex = 82;
            this.numSmoothGaussian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSmoothGaussian.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numSmoothGaussian.ValueChanged += new System.EventHandler(this.numericTweak_ValueChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(928, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(304, 304);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 83;
            this.pictureBox4.TabStop = false;
            // 
            // numThresholdToZero
            // 
            this.numThresholdToZero.Location = new System.Drawing.Point(200, 376);
            this.numThresholdToZero.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numThresholdToZero.Name = "numThresholdToZero";
            this.numThresholdToZero.Size = new System.Drawing.Size(96, 29);
            this.numThresholdToZero.TabIndex = 84;
            this.numThresholdToZero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numThresholdToZero.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numThresholdToZero.ValueChanged += new System.EventHandler(this.numericTweak_ValueChanged);
            // 
            // numThresholdBinary1
            // 
            this.numThresholdBinary1.Location = new System.Drawing.Point(512, 336);
            this.numThresholdBinary1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numThresholdBinary1.Name = "numThresholdBinary1";
            this.numThresholdBinary1.Size = new System.Drawing.Size(96, 29);
            this.numThresholdBinary1.TabIndex = 85;
            this.numThresholdBinary1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numThresholdBinary1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numThresholdBinary1.ValueChanged += new System.EventHandler(this.numericTweak_ValueChanged);
            // 
            // numThresholdBinary2
            // 
            this.numThresholdBinary2.Location = new System.Drawing.Point(512, 376);
            this.numThresholdBinary2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numThresholdBinary2.Name = "numThresholdBinary2";
            this.numThresholdBinary2.Size = new System.Drawing.Size(96, 29);
            this.numThresholdBinary2.TabIndex = 86;
            this.numThresholdBinary2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numThresholdBinary2.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numThresholdBinary2.ValueChanged += new System.EventHandler(this.numericTweak_ValueChanged);
            // 
            // numCanny1
            // 
            this.numCanny1.Location = new System.Drawing.Point(824, 336);
            this.numCanny1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numCanny1.Name = "numCanny1";
            this.numCanny1.Size = new System.Drawing.Size(96, 29);
            this.numCanny1.TabIndex = 87;
            this.numCanny1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCanny1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCanny1.ValueChanged += new System.EventHandler(this.numericTweak_ValueChanged);
            // 
            // numCanny2
            // 
            this.numCanny2.Location = new System.Drawing.Point(824, 376);
            this.numCanny2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numCanny2.Name = "numCanny2";
            this.numCanny2.Size = new System.Drawing.Size(96, 29);
            this.numCanny2.TabIndex = 88;
            this.numCanny2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCanny2.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numCanny2.ValueChanged += new System.EventHandler(this.numericTweak_ValueChanged);
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.BackColor = System.Drawing.Color.Crimson;
            this.btnStopTimer.Enabled = false;
            this.btnStopTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopTimer.ForeColor = System.Drawing.Color.White;
            this.btnStopTimer.Location = new System.Drawing.Point(1032, 432);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(248, 48);
            this.btnStopTimer.TabIndex = 89;
            this.btnStopTimer.Text = "PAUSE ANTI-SPAM";
            this.btnStopTimer.UseVisualStyleBackColor = false;
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // numDilate
            // 
            this.numDilate.Location = new System.Drawing.Point(1136, 336);
            this.numDilate.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numDilate.Name = "numDilate";
            this.numDilate.Size = new System.Drawing.Size(96, 29);
            this.numDilate.TabIndex = 91;
            this.numDilate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDilate.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numDilate.ValueChanged += new System.EventHandler(this.numericTweak_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1064, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 90;
            this.label5.Text = "Dilate";
            // 
            // numErode
            // 
            this.numErode.Location = new System.Drawing.Point(1136, 376);
            this.numErode.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numErode.Name = "numErode";
            this.numErode.Size = new System.Drawing.Size(96, 29);
            this.numErode.TabIndex = 93;
            this.numErode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numErode.ValueChanged += new System.EventHandler(this.numericTweak_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1064, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 92;
            this.label6.Text = "Erode";
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.BackColor = System.Drawing.Color.Crimson;
            this.btnStartTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTimer.ForeColor = System.Drawing.Color.White;
            this.btnStartTimer.Location = new System.Drawing.Point(1296, 432);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(248, 48);
            this.btnStartTimer.TabIndex = 94;
            this.btnStartTimer.Text = "(RE)START ANTI-SPAM";
            this.btnStartTimer.UseVisualStyleBackColor = false;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // chkVerboseProcessing
            // 
            this.chkVerboseProcessing.AutoSize = true;
            this.chkVerboseProcessing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVerboseProcessing.Location = new System.Drawing.Point(40, 424);
            this.chkVerboseProcessing.Name = "chkVerboseProcessing";
            this.chkVerboseProcessing.Size = new System.Drawing.Size(420, 25);
            this.chkVerboseProcessing.TabIndex = 95;
            this.chkVerboseProcessing.Text = "Enable Verbose Processing (Require more Memory)";
            this.chkVerboseProcessing.UseVisualStyleBackColor = true;
            this.chkVerboseProcessing.CheckedChanged += new System.EventHandler(this.chkVerboseProcessing_CheckedChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(1240, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(304, 304);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 96;
            this.pictureBox5.TabStop = false;
            // 
            // linkDiabloCloneDiscordServer
            // 
            this.linkDiabloCloneDiscordServer.AutoSize = true;
            this.linkDiabloCloneDiscordServer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDiabloCloneDiscordServer.LinkColor = System.Drawing.Color.Yellow;
            this.linkDiabloCloneDiscordServer.Location = new System.Drawing.Point(512, 432);
            this.linkDiabloCloneDiscordServer.Name = "linkDiabloCloneDiscordServer";
            this.linkDiabloCloneDiscordServer.Size = new System.Drawing.Size(399, 50);
            this.linkDiabloCloneDiscordServer.TabIndex = 97;
            this.linkDiabloCloneDiscordServer.TabStop = true;
            this.linkDiabloCloneDiscordServer.Text = "CLICK HERE TO JOIN OUR DISCORD SERVER\r\nhttps://discord.gg/FQrpzV8Smv";
            this.linkDiabloCloneDiscordServer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDiabloCloneDiscordServer_LinkClicked);
            // 
            // chkKeepOnTop
            // 
            this.chkKeepOnTop.AutoSize = true;
            this.chkKeepOnTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKeepOnTop.Location = new System.Drawing.Point(40, 456);
            this.chkKeepOnTop.Name = "chkKeepOnTop";
            this.chkKeepOnTop.Size = new System.Drawing.Size(385, 25);
            this.chkKeepOnTop.TabIndex = 98;
            this.chkKeepOnTop.Text = "Keep this Window on top (useful for tweaking)";
            this.chkKeepOnTop.UseVisualStyleBackColor = true;
            this.chkKeepOnTop.CheckedChanged += new System.EventHandler(this.chkKeepOnTop_CheckedChanged_1);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1560, 494);
            this.Controls.Add(this.chkKeepOnTop);
            this.Controls.Add(this.linkDiabloCloneDiscordServer);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.chkVerboseProcessing);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.numErode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numDilate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnStopTimer);
            this.Controls.Add(this.numCanny2);
            this.Controls.Add(this.numCanny1);
            this.Controls.Add(this.numThresholdBinary2);
            this.Controls.Add(this.numThresholdBinary1);
            this.Controls.Add(this.numThresholdToZero);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.numSmoothGaussian);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "frmMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiabloClone.ORG ANTISPAM UTILITY FOR D2R - Discord Server @ https://discord.gg/FQ" +
    "rpzV8Smv";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainWindow_FormClosed);
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSmoothGaussian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThresholdToZero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThresholdBinary1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThresholdBinary2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCanny1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCanny2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDilate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numErode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSmoothGaussian;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.NumericUpDown numThresholdToZero;
        private System.Windows.Forms.NumericUpDown numThresholdBinary1;
        private System.Windows.Forms.NumericUpDown numThresholdBinary2;
        private System.Windows.Forms.NumericUpDown numCanny1;
        private System.Windows.Forms.NumericUpDown numCanny2;
        private System.Windows.Forms.Button btnStopTimer;
        private System.Windows.Forms.NumericUpDown numDilate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numErode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.CheckBox chkVerboseProcessing;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.LinkLabel linkDiabloCloneDiscordServer;
        private System.Windows.Forms.CheckBox chkKeepOnTop;
    }
}

