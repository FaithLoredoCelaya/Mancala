namespace Mancala
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.scoreP1 = new System.Windows.Forms.TextBox();
            this.scoreP2 = new System.Windows.Forms.TextBox();
            this.p2Pocket6 = new System.Windows.Forms.Button();
            this.p2Pocket5 = new System.Windows.Forms.Button();
            this.p2Pocket4 = new System.Windows.Forms.Button();
            this.p2Pocket3 = new System.Windows.Forms.Button();
            this.p2Pocket2 = new System.Windows.Forms.Button();
            this.p2Pocket1 = new System.Windows.Forms.Button();
            this.p1Pocket6 = new System.Windows.Forms.Button();
            this.p1Pocket5 = new System.Windows.Forms.Button();
            this.p1Pocket4 = new System.Windows.Forms.Button();
            this.p1Pocket3 = new System.Windows.Forms.Button();
            this.p1Pocket2 = new System.Windows.Forms.Button();
            this.p1Pocket1 = new System.Windows.Forms.Button();
            this.Intro = new System.Windows.Forms.Label();
            this.Turn = new System.Windows.Forms.Label();
            this.StartNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.scoreP1);
            this.panel1.Controls.Add(this.scoreP2);
            this.panel1.Controls.Add(this.p2Pocket6);
            this.panel1.Controls.Add(this.p2Pocket5);
            this.panel1.Controls.Add(this.p2Pocket4);
            this.panel1.Controls.Add(this.p2Pocket3);
            this.panel1.Controls.Add(this.p2Pocket2);
            this.panel1.Controls.Add(this.p2Pocket1);
            this.panel1.Controls.Add(this.p1Pocket6);
            this.panel1.Controls.Add(this.p1Pocket5);
            this.panel1.Controls.Add(this.p1Pocket4);
            this.panel1.Controls.Add(this.p1Pocket3);
            this.panel1.Controls.Add(this.p1Pocket2);
            this.panel1.Controls.Add(this.p1Pocket1);
            this.panel1.Location = new System.Drawing.Point(173, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 152);
            this.panel1.TabIndex = 0;
            // 
            // scoreP1
            // 
            this.scoreP1.BackColor = System.Drawing.SystemColors.Info;
            this.scoreP1.Location = new System.Drawing.Point(350, 18);
            this.scoreP1.Multiline = true;
            this.scoreP1.Name = "scoreP1";
            this.scoreP1.Size = new System.Drawing.Size(49, 117);
            this.scoreP1.TabIndex = 13;
            // 
            // scoreP2
            // 
            this.scoreP2.BackColor = System.Drawing.SystemColors.Info;
            this.scoreP2.Location = new System.Drawing.Point(19, 18);
            this.scoreP2.Multiline = true;
            this.scoreP2.Name = "scoreP2";
            this.scoreP2.Size = new System.Drawing.Size(49, 117);
            this.scoreP2.TabIndex = 12;
            // 
            // p2Pocket6
            // 
            this.p2Pocket6.Location = new System.Drawing.Point(74, 18);
            this.p2Pocket6.Name = "p2Pocket6";
            this.p2Pocket6.Size = new System.Drawing.Size(40, 37);
            this.p2Pocket6.TabIndex = 11;
            this.p2Pocket6.UseVisualStyleBackColor = true;
            this.p2Pocket6.Click += new System.EventHandler(this.p2Pocket6_Click);
            // 
            // p2Pocket5
            // 
            this.p2Pocket5.Location = new System.Drawing.Point(120, 18);
            this.p2Pocket5.Name = "p2Pocket5";
            this.p2Pocket5.Size = new System.Drawing.Size(40, 37);
            this.p2Pocket5.TabIndex = 10;
            this.p2Pocket5.UseVisualStyleBackColor = true;
            this.p2Pocket5.Click += new System.EventHandler(this.p2Pocket5_Click);
            // 
            // p2Pocket4
            // 
            this.p2Pocket4.Location = new System.Drawing.Point(166, 18);
            this.p2Pocket4.Name = "p2Pocket4";
            this.p2Pocket4.Size = new System.Drawing.Size(40, 37);
            this.p2Pocket4.TabIndex = 9;
            this.p2Pocket4.UseVisualStyleBackColor = true;
            this.p2Pocket4.Click += new System.EventHandler(this.p2Pocket4_Click);
            // 
            // p2Pocket3
            // 
            this.p2Pocket3.Location = new System.Drawing.Point(212, 18);
            this.p2Pocket3.Name = "p2Pocket3";
            this.p2Pocket3.Size = new System.Drawing.Size(40, 37);
            this.p2Pocket3.TabIndex = 8;
            this.p2Pocket3.UseVisualStyleBackColor = true;
            this.p2Pocket3.Click += new System.EventHandler(this.p2Pocket3_Click);
            // 
            // p2Pocket2
            // 
            this.p2Pocket2.Location = new System.Drawing.Point(258, 18);
            this.p2Pocket2.Name = "p2Pocket2";
            this.p2Pocket2.Size = new System.Drawing.Size(40, 37);
            this.p2Pocket2.TabIndex = 7;
            this.p2Pocket2.UseVisualStyleBackColor = true;
            this.p2Pocket2.Click += new System.EventHandler(this.p2Pocket2_Click);
            // 
            // p2Pocket1
            // 
            this.p2Pocket1.Location = new System.Drawing.Point(304, 18);
            this.p2Pocket1.Name = "p2Pocket1";
            this.p2Pocket1.Size = new System.Drawing.Size(40, 37);
            this.p2Pocket1.TabIndex = 6;
            this.p2Pocket1.UseVisualStyleBackColor = true;
            this.p2Pocket1.Click += new System.EventHandler(this.p2Pocket1_Click);
            // 
            // p1Pocket6
            // 
            this.p1Pocket6.Location = new System.Drawing.Point(304, 98);
            this.p1Pocket6.Name = "p1Pocket6";
            this.p1Pocket6.Size = new System.Drawing.Size(40, 37);
            this.p1Pocket6.TabIndex = 5;
            this.p1Pocket6.UseVisualStyleBackColor = true;
            this.p1Pocket6.Click += new System.EventHandler(this.p1Pocket6_Click);
            // 
            // p1Pocket5
            // 
            this.p1Pocket5.Location = new System.Drawing.Point(258, 98);
            this.p1Pocket5.Name = "p1Pocket5";
            this.p1Pocket5.Size = new System.Drawing.Size(40, 37);
            this.p1Pocket5.TabIndex = 4;
            this.p1Pocket5.UseVisualStyleBackColor = true;
            this.p1Pocket5.Click += new System.EventHandler(this.p1Pocket5_Click);
            // 
            // p1Pocket4
            // 
            this.p1Pocket4.Location = new System.Drawing.Point(212, 98);
            this.p1Pocket4.Name = "p1Pocket4";
            this.p1Pocket4.Size = new System.Drawing.Size(40, 37);
            this.p1Pocket4.TabIndex = 3;
            this.p1Pocket4.UseVisualStyleBackColor = true;
            this.p1Pocket4.Click += new System.EventHandler(this.p1Pocket4_Click);
            // 
            // p1Pocket3
            // 
            this.p1Pocket3.Location = new System.Drawing.Point(166, 98);
            this.p1Pocket3.Name = "p1Pocket3";
            this.p1Pocket3.Size = new System.Drawing.Size(40, 37);
            this.p1Pocket3.TabIndex = 2;
            this.p1Pocket3.UseVisualStyleBackColor = true;
            this.p1Pocket3.Click += new System.EventHandler(this.p1Pocket3_Click);
            // 
            // p1Pocket2
            // 
            this.p1Pocket2.Location = new System.Drawing.Point(120, 98);
            this.p1Pocket2.Name = "p1Pocket2";
            this.p1Pocket2.Size = new System.Drawing.Size(40, 37);
            this.p1Pocket2.TabIndex = 1;
            this.p1Pocket2.UseVisualStyleBackColor = true;
            this.p1Pocket2.Click += new System.EventHandler(this.p1Pocket2_Click);
            // 
            // p1Pocket1
            // 
            this.p1Pocket1.Location = new System.Drawing.Point(74, 98);
            this.p1Pocket1.Name = "p1Pocket1";
            this.p1Pocket1.Size = new System.Drawing.Size(40, 37);
            this.p1Pocket1.TabIndex = 0;
            this.p1Pocket1.UseVisualStyleBackColor = true;
            this.p1Pocket1.Click += new System.EventHandler(this.p1Pocket1_Click);
            // 
            // Intro
            // 
            this.Intro.AutoSize = true;
            this.Intro.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intro.Location = new System.Drawing.Point(12, 71);
            this.Intro.Name = "Intro";
            this.Intro.Size = new System.Drawing.Size(739, 90);
            this.Intro.TabIndex = 1;
            this.Intro.Text = "Faith\'s Crazy Mancala";
            this.Intro.Click += new System.EventHandler(this.label1_Click);
            // 
            // Turn
            // 
            this.Turn.AutoSize = true;
            this.Turn.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turn.Location = new System.Drawing.Point(286, 476);
            this.Turn.Name = "Turn";
            this.Turn.Size = new System.Drawing.Size(192, 38);
            this.Turn.TabIndex = 2;
            this.Turn.Text = "Player Turn: ";
            // 
            // StartNew
            // 
            this.StartNew.Location = new System.Drawing.Point(339, 533);
            this.StartNew.Name = "StartNew";
            this.StartNew.Size = new System.Drawing.Size(75, 23);
            this.StartNew.TabIndex = 3;
            this.StartNew.Text = "New Game";
            this.StartNew.UseVisualStyleBackColor = true;
            this.StartNew.Click += new System.EventHandler(this.StartNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 591);
            this.Controls.Add(this.StartNew);
            this.Controls.Add(this.Turn);
            this.Controls.Add(this.Intro);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox scoreP1;
        private System.Windows.Forms.TextBox scoreP2;
        private System.Windows.Forms.Button p2Pocket6;
        private System.Windows.Forms.Button p2Pocket5;
        private System.Windows.Forms.Button p2Pocket4;
        private System.Windows.Forms.Button p2Pocket3;
        private System.Windows.Forms.Button p2Pocket2;
        private System.Windows.Forms.Button p2Pocket1;
        private System.Windows.Forms.Button p1Pocket6;
        private System.Windows.Forms.Button p1Pocket5;
        private System.Windows.Forms.Button p1Pocket4;
        private System.Windows.Forms.Button p1Pocket3;
        private System.Windows.Forms.Button p1Pocket2;
        private System.Windows.Forms.Button p1Pocket1;
        private System.Windows.Forms.Label Intro;
        private System.Windows.Forms.Label Turn;
        private System.Windows.Forms.Button StartNew;
    }
}

