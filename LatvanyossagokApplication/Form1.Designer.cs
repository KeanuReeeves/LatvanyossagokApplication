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
            this.VarosokListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LatNevText = new System.Windows.Forms.TextBox();
            this.LeirasText = new System.Windows.Forms.TextBox();
            this.numAr = new System.Windows.Forms.NumericUpDown();
            this.LatvanyossagSubmit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTorol = new System.Windows.Forms.Button();
            this.Citysubmit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLakossag)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAr)).BeginInit();
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
            this.VarosSubmit.Location = new System.Drawing.Point(68, 72);
            this.VarosSubmit.Name = "VarosSubmit";
            this.VarosSubmit.Size = new System.Drawing.Size(75, 23);
            this.VarosSubmit.TabIndex = 5;
            this.VarosSubmit.Text = "Mentés";
            this.VarosSubmit.UseVisualStyleBackColor = true;
            this.VarosSubmit.Click += new System.EventHandler(this.VarosSubmit_Click);
            // 
            // VarosokListBox
            // 
            this.VarosokListBox.FormattingEnabled = true;
            this.VarosokListBox.Location = new System.Drawing.Point(17, 99);
            this.VarosokListBox.Name = "VarosokListBox";
            this.VarosokListBox.Size = new System.Drawing.Size(174, 69);
            this.VarosokListBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LatvanyossagSubmit);
            this.groupBox1.Controls.Add(this.numAr);
            this.groupBox1.Controls.Add(this.VarosokListBox);
            this.groupBox1.Controls.Add(this.LeirasText);
            this.groupBox1.Controls.Add(this.LatNevText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 204);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Látványosság Felvétele";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Név";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Leírás";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ár";
            // 
            // LatNevText
            // 
            this.LatNevText.Location = new System.Drawing.Point(86, 22);
            this.LatNevText.Name = "LatNevText";
            this.LatNevText.Size = new System.Drawing.Size(100, 20);
            this.LatNevText.TabIndex = 4;
            // 
            // LeirasText
            // 
            this.LeirasText.Location = new System.Drawing.Point(86, 46);
            this.LeirasText.Name = "LeirasText";
            this.LeirasText.Size = new System.Drawing.Size(100, 20);
            this.LeirasText.TabIndex = 5;
            // 
            // numAr
            // 
            this.numAr.Location = new System.Drawing.Point(86, 73);
            this.numAr.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAr.Name = "numAr";
            this.numAr.Size = new System.Drawing.Size(120, 20);
            this.numAr.TabIndex = 6;
            // 
            // LatvanyossagSubmit
            // 
            this.LatvanyossagSubmit.Location = new System.Drawing.Point(68, 174);
            this.LatvanyossagSubmit.Name = "LatvanyossagSubmit";
            this.LatvanyossagSubmit.Size = new System.Drawing.Size(75, 23);
            this.LatvanyossagSubmit.TabIndex = 7;
            this.LatvanyossagSubmit.Text = "Mentés";
            this.LatvanyossagSubmit.UseVisualStyleBackColor = true;
            this.LatvanyossagSubmit.Click += new System.EventHandler(this.LatvanyossagSubmit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(322, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 225);
            this.listBox1.TabIndex = 3;
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(423, 263);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 4;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            // 
            // LakossagNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Citysubmit);
            this.Name = "LakossagNum";
            this.Text = "Form1";
            this.Citysubmit.ResumeLayout(false);
            this.Citysubmit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLakossag)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Citysubmit;
        private System.Windows.Forms.NumericUpDown numLakossag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nevtb;
        private System.Windows.Forms.Button VarosSubmit;
        private System.Windows.Forms.ListBox VarosokListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LatvanyossagSubmit;
        private System.Windows.Forms.NumericUpDown numAr;
        private System.Windows.Forms.TextBox LeirasText;
        private System.Windows.Forms.TextBox LatNevText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnTorol;
    }
}

