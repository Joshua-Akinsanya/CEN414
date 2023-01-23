namespace MyCalculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.bad = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.bmul = new System.Windows.Forms.Button();
            this.ndot = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.nequal = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.bc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(297, 102);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(40, 42);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(343, 102);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(40, 42);
            this.n2.TabIndex = 1;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(389, 102);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(40, 42);
            this.n3.TabIndex = 1;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // bad
            // 
            this.bad.Location = new System.Drawing.Point(435, 102);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(40, 42);
            this.bad.TabIndex = 1;
            this.bad.Text = "+";
            this.bad.UseVisualStyleBackColor = true;
            this.bad.Click += new System.EventHandler(this.bad_Click);
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(297, 150);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(40, 42);
            this.n4.TabIndex = 1;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(343, 150);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(40, 42);
            this.n5.TabIndex = 1;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n6
            // 
            this.n6.Location = new System.Drawing.Point(389, 150);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(40, 42);
            this.n6.TabIndex = 1;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // bsub
            // 
            this.bsub.Location = new System.Drawing.Point(435, 150);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(40, 42);
            this.bsub.TabIndex = 1;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = true;
            this.bsub.Click += new System.EventHandler(this.bsub_Click);
            // 
            // n7
            // 
            this.n7.Location = new System.Drawing.Point(297, 198);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(40, 42);
            this.n7.TabIndex = 1;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n8
            // 
            this.n8.Location = new System.Drawing.Point(343, 198);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(40, 42);
            this.n8.TabIndex = 1;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n9
            // 
            this.n9.Location = new System.Drawing.Point(389, 198);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(40, 42);
            this.n9.TabIndex = 1;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // bmul
            // 
            this.bmul.Location = new System.Drawing.Point(435, 198);
            this.bmul.Name = "bmul";
            this.bmul.Size = new System.Drawing.Size(40, 42);
            this.bmul.TabIndex = 1;
            this.bmul.Text = "*";
            this.bmul.UseVisualStyleBackColor = true;
            this.bmul.Click += new System.EventHandler(this.bmul_Click);
            // 
            // ndot
            // 
            this.ndot.Location = new System.Drawing.Point(297, 246);
            this.ndot.Name = "ndot";
            this.ndot.Size = new System.Drawing.Size(40, 42);
            this.ndot.TabIndex = 1;
            this.ndot.Text = ".";
            this.ndot.UseVisualStyleBackColor = true;
            this.ndot.Click += new System.EventHandler(this.ndot_Click);
            // 
            // n0
            // 
            this.n0.Location = new System.Drawing.Point(343, 246);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(40, 42);
            this.n0.TabIndex = 1;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // nequal
            // 
            this.nequal.Location = new System.Drawing.Point(389, 246);
            this.nequal.Name = "nequal";
            this.nequal.Size = new System.Drawing.Size(40, 42);
            this.nequal.TabIndex = 1;
            this.nequal.Text = "=";
            this.nequal.UseVisualStyleBackColor = true;
            this.nequal.Click += new System.EventHandler(this.nequal_Click);
            // 
            // bdiv
            // 
            this.bdiv.Location = new System.Drawing.Point(435, 246);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(40, 42);
            this.bdiv.TabIndex = 1;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = true;
            this.bdiv.Click += new System.EventHandler(this.bdiv_Click);
            // 
            // bc
            // 
            this.bc.Location = new System.Drawing.Point(366, 294);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(40, 42);
            this.bc.TabIndex = 1;
            this.bc.Text = "C";
            this.bc.UseVisualStyleBackColor = true;
            this.bc.Click += new System.EventHandler(this.bdiv_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bc);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.bmul);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.bad);
            this.Controls.Add(this.nequal);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.ndot);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.textBox1);
            this.Name = "Calculator";
            this.Text = "+";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button n1;
        private Button n2;
        private Button n3;
        private Button bad;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button bsub;
        private Button n7;
        private Button n8;
        private Button n9;
        private Button bmul;
        private Button ndot;
        private Button n0;
        private Button nequal;
        private Button bdiv;
        private Button bc;
    }
}