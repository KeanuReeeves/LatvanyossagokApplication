namespace LatvanyossagokApplication
{
    partial class LakossagNum
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
            this.Citysubmit = new System.Windows.Forms.GroupBox();
            this.nevtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numLakossag = new System.Windows.Forms.NumericUpDown();
            this.VarosSubmit = new System.Windows.Forms.Button();
            this.Citysubmit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLakossag)).BeginInit();
            this.SuspendLayout();
            // 
            // Citysubmit
            // 
            this.Citysubmit.Controls.Add(this.VarosSubmit);
            this.Citysubmit.Controls.Add(this.numLakossag);
            this.Citysubmit.Controls.Add(this.label2);
            this.Citysubmit.Controls.Add(this.label1);
            this.Citysubmit.Controls.Add(this.nevtb);
            this.Citysubmit.Location = new System.Drawing.Point(13, 13);
            this.Citysubmit.Name = "Citysubmit";
            this.Citysubmit.Size = new System.Drawing.Size(212, 104);
            this.Citysubmit.TabIndex = 0;
            this.Citysubmit.TabStop = false;
            this.Citysubmit.Text = "Város Felvétel";
            // 
            // nevtb
            // 
            this.nevtb.Location = new System.Drawing.Point(91, 19);
            this.nevtb.Name = "nevtb";
            this.nevtb.Size = new System.Drawing.Size(100, 20);
            this.nevtb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lakosság";
            // 
            // numLakossag
            // 
            this.numLakossag.Location = new System.Drawing.Point(86, 46);
            this.numLakossag.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numLakossag.Name = "numLakossag";
            this.numLakossag.Size = new System.Drawing.Size(120, 20);
            this.numLakossag.TabIndex = 4;
            // 
            // VarosSubmit
            // 
            this.VarosSubmit.Enabled = false;
            this.VarosSubmit.Location = new System.Drawing.Point(68, 72);
            this.VarosSubmit.Name = "VarosSubmit";
            this.VarosSubmit.Size = new System.Drawing.Size(75, 23);
            this.VarosSubmit.TabIndex = 5;
            this.VarosSubmit.Text = "Mentés";
            this.VarosSubmit.UseVisualStyleBackColor = true;
            this.VarosSubmit.Click += new System.EventHandler(this.VarosSubmit_Click);
            // 
            // LakossagNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Citysubmit);
            this.Name = "LakossagNum";
            this.Text = "Form1";
            this.Citysubmit.ResumeLayout(false);
            this.Citysubmit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLakossag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Citysubmit;
        private System.Windows.Forms.NumericUpDown numLakossag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nevtb;
        private System.Windows.Forms.Button VarosSubmit;
    }
}

