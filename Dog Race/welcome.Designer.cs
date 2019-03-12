namespace Dog_Race
{
    partial class welcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To DOG RACE";
            // 
            // button_go
            // 
            this.button_go.BackColor = System.Drawing.Color.Red;
            this.button_go.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_go.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_go.Location = new System.Drawing.Point(502, 280);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(136, 62);
            this.button_go.TabIndex = 5;
            this.button_go.Text = "GO";
            this.button_go.UseVisualStyleBackColor = false;
            this.button_go.Click += new System.EventHandler(this.button1_Click);
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Race_dog.Properties.Resources.Welcome;
            this.ClientSize = new System.Drawing.Size(701, 369);
            this.Controls.Add(this.button_go);
            this.Controls.Add(this.label1);
            this.Name = "welcome";
            this.Text = "welcome";
            this.Load += new System.EventHandler(this.welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_go;
    }
}