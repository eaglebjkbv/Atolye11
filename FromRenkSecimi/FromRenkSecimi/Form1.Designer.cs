namespace FromRenkSecimi
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
            this.buttonKırmızı = new System.Windows.Forms.Button();
            this.buttonMavi = new System.Windows.Forms.Button();
            this.buttonSarı = new System.Windows.Forms.Button();
            this.buttonGri = new System.Windows.Forms.Button();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRastgele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKırmızı
            // 
            this.buttonKırmızı.BackColor = System.Drawing.Color.Red;
            this.buttonKırmızı.Location = new System.Drawing.Point(30, 300);
            this.buttonKırmızı.Name = "buttonKırmızı";
            this.buttonKırmızı.Size = new System.Drawing.Size(128, 42);
            this.buttonKırmızı.TabIndex = 0;
            this.buttonKırmızı.UseVisualStyleBackColor = false;
            this.buttonKırmızı.Click += new System.EventHandler(this.buttonKırmızı_Click);
            // 
            // buttonMavi
            // 
            this.buttonMavi.BackColor = System.Drawing.Color.Blue;
            this.buttonMavi.Location = new System.Drawing.Point(164, 300);
            this.buttonMavi.Name = "buttonMavi";
            this.buttonMavi.Size = new System.Drawing.Size(128, 42);
            this.buttonMavi.TabIndex = 0;
            this.buttonMavi.UseVisualStyleBackColor = false;
            // 
            // buttonSarı
            // 
            this.buttonSarı.BackColor = System.Drawing.Color.Yellow;
            this.buttonSarı.Location = new System.Drawing.Point(298, 300);
            this.buttonSarı.Name = "buttonSarı";
            this.buttonSarı.Size = new System.Drawing.Size(128, 42);
            this.buttonSarı.TabIndex = 0;
            this.buttonSarı.UseVisualStyleBackColor = false;
            // 
            // buttonGri
            // 
            this.buttonGri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonGri.Location = new System.Drawing.Point(432, 300);
            this.buttonGri.Name = "buttonGri";
            this.buttonGri.Size = new System.Drawing.Size(128, 42);
            this.buttonGri.TabIndex = 0;
            this.buttonGri.UseVisualStyleBackColor = false;
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(39, 52);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarRed.Size = new System.Drawing.Size(45, 208);
            this.trackBarRed.TabIndex = 1;
            this.trackBarRed.TickFrequency = 10;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(99, 52);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarGreen.Size = new System.Drawing.Size(45, 208);
            this.trackBarGreen.TabIndex = 1;
            this.trackBarGreen.TickFrequency = 10;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(154, 52);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarBlue.Size = new System.Drawing.Size(45, 208);
            this.trackBarBlue.TabIndex = 1;
            this.trackBarBlue.TickFrequency = 10;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.trackBarRed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trackBarGreen);
            this.groupBox1.Controls.Add(this.trackBarBlue);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(366, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 270);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Color";
            // 
            // buttonRastgele
            // 
            this.buttonRastgele.Location = new System.Drawing.Point(32, 223);
            this.buttonRastgele.Name = "buttonRastgele";
            this.buttonRastgele.Size = new System.Drawing.Size(101, 51);
            this.buttonRastgele.TabIndex = 4;
            this.buttonRastgele.Text = "Rastgele";
            this.buttonRastgele.UseVisualStyleBackColor = true;
            this.buttonRastgele.Click += new System.EventHandler(this.buttonRastgele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 354);
            this.Controls.Add(this.buttonRastgele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonGri);
            this.Controls.Add(this.buttonSarı);
            this.Controls.Add(this.buttonMavi);
            this.Controls.Add(this.buttonKırmızı);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKırmızı;
        private System.Windows.Forms.Button buttonMavi;
        private System.Windows.Forms.Button buttonSarı;
        private System.Windows.Forms.Button buttonGri;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRastgele;
    }
}

