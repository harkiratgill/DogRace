namespace Dog_Race
{
    partial class MainGame
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
            this.labelBettor1 = new System.Windows.Forms.Label();
            this.labelbettor2 = new System.Windows.Forms.Label();
            this.labelbettor3 = new System.Windows.Forms.Label();
            this.betrd1 = new System.Windows.Forms.RadioButton();
            this.Betrd2 = new System.Windows.Forms.RadioButton();
            this.betrd3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMinBet = new System.Windows.Forms.Label();
            this.Bettor_name = new System.Windows.Forms.Label();
            this.bet_btn = new System.Windows.Forms.Button();
            this.Bettorselect = new System.Windows.Forms.NumericUpDown();
            this.label_bucks = new System.Windows.Forms.Label();
            this.moneyselect = new System.Windows.Forms.NumericUpDown();
            this.Race_btn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.racerpb1 = new System.Windows.Forms.PictureBox();
            this.racerpb4 = new System.Windows.Forms.PictureBox();
            this.racerpb3 = new System.Windows.Forms.PictureBox();
            this.racerpb2 = new System.Windows.Forms.PictureBox();
            this.tp_pb5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bettorselect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyselect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racerpb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racerpb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racerpb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racerpb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp_pb5)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBettor1
            // 
            this.labelBettor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBettor1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBettor1.ForeColor = System.Drawing.Color.Lime;
            this.labelBettor1.Location = new System.Drawing.Point(12, 550);
            this.labelBettor1.Name = "labelBettor1";
            this.labelBettor1.Size = new System.Drawing.Size(297, 23);
            this.labelBettor1.TabIndex = 2;
            this.labelBettor1.Text = "First Better Here";
            // 
            // labelbettor2
            // 
            this.labelbettor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelbettor2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbettor2.ForeColor = System.Drawing.Color.Lime;
            this.labelbettor2.Location = new System.Drawing.Point(315, 550);
            this.labelbettor2.Name = "labelbettor2";
            this.labelbettor2.Size = new System.Drawing.Size(311, 23);
            this.labelbettor2.TabIndex = 2;
            this.labelbettor2.Text = "Second Bettor Here";
            this.labelbettor2.Click += new System.EventHandler(this.labelGuy2_Click);
            // 
            // labelbettor3
            // 
            this.labelbettor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelbettor3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbettor3.ForeColor = System.Drawing.Color.Lime;
            this.labelbettor3.Location = new System.Drawing.Point(632, 550);
            this.labelbettor3.Name = "labelbettor3";
            this.labelbettor3.Size = new System.Drawing.Size(339, 23);
            this.labelbettor3.TabIndex = 2;
            this.labelbettor3.Text = "Third Bettor Here";
            // 
            // betrd1
            // 
            this.betrd1.AutoSize = true;
            this.betrd1.BackColor = System.Drawing.Color.Transparent;
            this.betrd1.Checked = true;
            this.betrd1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betrd1.ForeColor = System.Drawing.Color.Lime;
            this.betrd1.Location = new System.Drawing.Point(30, 445);
            this.betrd1.Name = "betrd1";
            this.betrd1.Size = new System.Drawing.Size(71, 21);
            this.betrd1.TabIndex = 3;
            this.betrd1.TabStop = true;
            this.betrd1.Text = "Better1";
            this.betrd1.UseVisualStyleBackColor = false;
            this.betrd1.CheckedChanged += new System.EventHandler(this.bet_rb1_CheckedChanged);
            // 
            // Betrd2
            // 
            this.Betrd2.AutoSize = true;
            this.Betrd2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Betrd2.ForeColor = System.Drawing.Color.Lime;
            this.Betrd2.Location = new System.Drawing.Point(145, 445);
            this.Betrd2.Name = "Betrd2";
            this.Betrd2.Size = new System.Drawing.Size(67, 21);
            this.Betrd2.TabIndex = 3;
            this.Betrd2.Text = "Better2";
            this.Betrd2.UseVisualStyleBackColor = true;
            this.Betrd2.CheckedChanged += new System.EventHandler(this.bet_rb2_CheckedChanged);
            // 
            // betrd3
            // 
            this.betrd3.AutoSize = true;
            this.betrd3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betrd3.ForeColor = System.Drawing.Color.Lime;
            this.betrd3.Location = new System.Drawing.Point(274, 445);
            this.betrd3.Name = "betrd3";
            this.betrd3.Size = new System.Drawing.Size(71, 21);
            this.betrd3.TabIndex = 3;
            this.betrd3.Text = "Better 3";
            this.betrd3.UseVisualStyleBackColor = true;
            this.betrd3.CheckedChanged += new System.EventHandler(this.bet_rb3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bets";
            // 
            // labelMinBet
            // 
            this.labelMinBet.AutoSize = true;
            this.labelMinBet.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinBet.ForeColor = System.Drawing.Color.Lime;
            this.labelMinBet.Location = new System.Drawing.Point(23, 409);
            this.labelMinBet.Name = "labelMinBet";
            this.labelMinBet.Size = new System.Drawing.Size(94, 25);
            this.labelMinBet.TabIndex = 5;
            this.labelMinBet.Text = "BET HERE";
            // 
            // Bettor_name
            // 
            this.Bettor_name.AutoSize = true;
            this.Bettor_name.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bettor_name.ForeColor = System.Drawing.Color.Lime;
            this.Bettor_name.Location = new System.Drawing.Point(420, 414);
            this.Bettor_name.Name = "Bettor_name";
            this.Bettor_name.Size = new System.Drawing.Size(71, 17);
            this.Bettor_name.TabIndex = 6;
            this.Bettor_name.Text = "labelName";
            this.Bettor_name.Click += new System.EventHandler(this.labelName_Click);
            // 
            // bet_btn
            // 
            this.bet_btn.BackColor = System.Drawing.Color.DarkViolet;
            this.bet_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bet_btn.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bet_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.bet_btn.Location = new System.Drawing.Point(690, 442);
            this.bet_btn.Name = "bet_btn";
            this.bet_btn.Size = new System.Drawing.Size(92, 43);
            this.bet_btn.TabIndex = 7;
            this.bet_btn.Text = "Bets";
            this.bet_btn.UseVisualStyleBackColor = false;
            this.bet_btn.Click += new System.EventHandler(this.Bet_btn_Click);
            // 
            // Bettorselect
            // 
            this.Bettorselect.BackColor = System.Drawing.SystemColors.InfoText;
            this.Bettorselect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bettorselect.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bettorselect.ForeColor = System.Drawing.Color.Lime;
            this.Bettorselect.Location = new System.Drawing.Point(423, 442);
            this.Bettorselect.Name = "Bettorselect";
            this.Bettorselect.Size = new System.Drawing.Size(68, 21);
            this.Bettorselect.TabIndex = 8;
            this.Bettorselect.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Bettorselect.ValueChanged += new System.EventHandler(this.bettorselect_ValueChanged);
            // 
            // label_bucks
            // 
            this.label_bucks.AutoSize = true;
            this.label_bucks.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bucks.ForeColor = System.Drawing.Color.Lime;
            this.label_bucks.Location = new System.Drawing.Point(540, 414);
            this.label_bucks.Name = "label_bucks";
            this.label_bucks.Size = new System.Drawing.Size(137, 17);
            this.label_bucks.TabIndex = 9;
            this.label_bucks.Text = "bucks on dog number";
            this.label_bucks.Click += new System.EventHandler(this.label2_Click);
            // 
            // moneyselect
            // 
            this.moneyselect.BackColor = System.Drawing.SystemColors.WindowText;
            this.moneyselect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moneyselect.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyselect.ForeColor = System.Drawing.Color.Lime;
            this.moneyselect.Location = new System.Drawing.Point(559, 442);
            this.moneyselect.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.moneyselect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.moneyselect.Name = "moneyselect";
            this.moneyselect.Size = new System.Drawing.Size(72, 21);
            this.moneyselect.TabIndex = 10;
            this.moneyselect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Race_btn
            // 
            this.Race_btn.BackColor = System.Drawing.Color.DarkViolet;
            this.Race_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Race_btn.Font = new System.Drawing.Font("Nirmala UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Race_btn.ForeColor = System.Drawing.Color.Snow;
            this.Race_btn.Location = new System.Drawing.Point(823, 445);
            this.Race_btn.Name = "Race_btn";
            this.Race_btn.Size = new System.Drawing.Size(133, 59);
            this.Race_btn.TabIndex = 11;
            this.Race_btn.Text = "RACE";
            this.Race_btn.UseVisualStyleBackColor = false;
            this.Race_btn.Click += new System.EventHandler(this.racebtn_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // racerpb1
            // 
            this.racerpb1.BackColor = System.Drawing.Color.Transparent;
            this.racerpb1.Image = global::Race_dog.Properties.Resources.malamut;
            this.racerpb1.Location = new System.Drawing.Point(-10, -3);
            this.racerpb1.Name = "racerpb1";
            this.racerpb1.Size = new System.Drawing.Size(113, 90);
            this.racerpb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.racerpb1.TabIndex = 0;
            this.racerpb1.TabStop = false;
            this.racerpb1.Click += new System.EventHandler(this.racerpb1_Click);
            // 
            // racerpb4
            // 
            this.racerpb4.BackColor = System.Drawing.Color.Transparent;
            this.racerpb4.Image = global::Race_dog.Properties.Resources.dog4;
            this.racerpb4.Location = new System.Drawing.Point(-39, 295);
            this.racerpb4.Name = "racerpb4";
            this.racerpb4.Size = new System.Drawing.Size(164, 136);
            this.racerpb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.racerpb4.TabIndex = 0;
            this.racerpb4.TabStop = false;
            // 
            // racerpb3
            // 
            this.racerpb3.BackColor = System.Drawing.Color.Transparent;
            this.racerpb3.Image = global::Race_dog.Properties.Resources._2773177_60x60;
            this.racerpb3.Location = new System.Drawing.Point(-24, 171);
            this.racerpb3.Name = "racerpb3";
            this.racerpb3.Size = new System.Drawing.Size(149, 132);
            this.racerpb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.racerpb3.TabIndex = 0;
            this.racerpb3.TabStop = false;
            // 
            // racerpb2
            // 
            this.racerpb2.BackColor = System.Drawing.Color.Transparent;
            this.racerpb2.Image = global::Race_dog.Properties.Resources.wolf_running_animated_gif;
            this.racerpb2.Location = new System.Drawing.Point(-10, 105);
            this.racerpb2.Name = "racerpb2";
            this.racerpb2.Size = new System.Drawing.Size(127, 86);
            this.racerpb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.racerpb2.TabIndex = 0;
            this.racerpb2.TabStop = false;
            this.racerpb2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tp_pb5
            // 
            this.tp_pb5.BackColor = System.Drawing.SystemColors.Control;
            this.tp_pb5.Image = global::Race_dog.Properties.Resources.background;
            this.tp_pb5.Location = new System.Drawing.Point(-2, -3);
            this.tp_pb5.Name = "tp_pb5";
            this.tp_pb5.Size = new System.Drawing.Size(987, 414);
            this.tp_pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tp_pb5.TabIndex = 1;
            this.tp_pb5.TabStop = false;
            this.tp_pb5.Click += new System.EventHandler(this.tp_pb5_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(983, 598);
            this.Controls.Add(this.racerpb1);
            this.Controls.Add(this.Race_btn);
            this.Controls.Add(this.moneyselect);
            this.Controls.Add(this.label_bucks);
            this.Controls.Add(this.Bettorselect);
            this.Controls.Add(this.bet_btn);
            this.Controls.Add(this.Bettor_name);
            this.Controls.Add(this.labelMinBet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.betrd3);
            this.Controls.Add(this.Betrd2);
            this.Controls.Add(this.betrd1);
            this.Controls.Add(this.labelbettor3);
            this.Controls.Add(this.labelbettor2);
            this.Controls.Add(this.labelBettor1);
            this.Controls.Add(this.racerpb4);
            this.Controls.Add(this.racerpb3);
            this.Controls.Add(this.racerpb2);
            this.Controls.Add(this.tp_pb5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainGame";
            this.Text = "Dog Race";
            this.Load += new System.EventHandler(this.dograce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bettorselect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyselect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racerpb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racerpb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racerpb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racerpb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp_pb5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox racerpb1;
        private System.Windows.Forms.PictureBox tp_pb5;
        private System.Windows.Forms.PictureBox racerpb2;
        private System.Windows.Forms.PictureBox racerpb3;
        private System.Windows.Forms.PictureBox racerpb4;
        private System.Windows.Forms.Label labelBettor1;
        private System.Windows.Forms.Label labelbettor2;
        private System.Windows.Forms.Label labelbettor3;
        private System.Windows.Forms.RadioButton betrd1;
        private System.Windows.Forms.RadioButton Betrd2;
        private System.Windows.Forms.RadioButton betrd3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMinBet;
        private System.Windows.Forms.Label Bettor_name;
        private System.Windows.Forms.Button bet_btn;
        private System.Windows.Forms.NumericUpDown Bettorselect;
        private System.Windows.Forms.Label label_bucks;
        private System.Windows.Forms.NumericUpDown moneyselect;
        private System.Windows.Forms.Button Race_btn;
        private System.Windows.Forms.Timer timer;
    }
}

