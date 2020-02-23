namespace C_sharp__Says
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
            this.Green = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.PatternLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(20, 41);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(205, 115);
            this.Green.TabIndex = 0;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(258, 41);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(205, 115);
            this.Red.TabIndex = 1;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Blue
            // 
            this.Blue.Location = new System.Drawing.Point(258, 191);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(205, 115);
            this.Blue.TabIndex = 3;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Yellow
            // 
            this.Yellow.Location = new System.Drawing.Point(20, 191);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(205, 115);
            this.Yellow.TabIndex = 2;
            this.Yellow.Text = "Yellow";
            this.Yellow.UseVisualStyleBackColor = true;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(22, 358);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(61, 17);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "Score: 0";
            // 
            // PatternLabel
            // 
            this.PatternLabel.AutoSize = true;
            this.PatternLabel.Location = new System.Drawing.Point(255, 358);
            this.PatternLabel.Name = "PatternLabel";
            this.PatternLabel.Size = new System.Drawing.Size(118, 17);
            this.PatternLabel.TabIndex = 5;
            this.PatternLabel.Text = "Pattern Length: 0";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(480, 402);
            this.Controls.Add(this.PatternLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Green);
            this.Name = "Form1";
            this.Text = "C# Says";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label PatternLabel;
    }
}

