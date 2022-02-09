namespace PlayGame
{
    partial class Arcade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arcade));
            this.PlayGame = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Label();
            this.Count3 = new System.Windows.Forms.Label();
            this.Count2 = new System.Windows.Forms.Label();
            this.GoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayGame
            // 
            this.PlayGame.BackColor = System.Drawing.Color.Black;
            this.PlayGame.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayGame.ForeColor = System.Drawing.Color.White;
            this.PlayGame.Location = new System.Drawing.Point(315, 317);
            this.PlayGame.Name = "PlayGame";
            this.PlayGame.Size = new System.Drawing.Size(138, 48);
            this.PlayGame.TabIndex = 0;
            this.PlayGame.Text = "PLAY GAME";
            this.PlayGame.UseVisualStyleBackColor = false;
            this.PlayGame.Click += new System.EventHandler(this.PlayGame_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.Transparent;
            this.Start.Location = new System.Drawing.Point(310, 211);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(143, 26);
            this.Start.TabIndex = 1;
            this.Start.Text = "Game Starts In";
            // 
            // Count3
            // 
            this.Count3.AutoSize = true;
            this.Count3.BackColor = System.Drawing.Color.Transparent;
            this.Count3.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count3.ForeColor = System.Drawing.Color.Transparent;
            this.Count3.Location = new System.Drawing.Point(366, 237);
            this.Count3.Name = "Count3";
            this.Count3.Size = new System.Drawing.Size(35, 25);
            this.Count3.TabIndex = 2;
            this.Count3.Text = "3...";
            // 
            // Count2
            // 
            this.Count2.AutoSize = true;
            this.Count2.BackColor = System.Drawing.Color.Transparent;
            this.Count2.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count2.ForeColor = System.Drawing.Color.Transparent;
            this.Count2.Location = new System.Drawing.Point(367, 262);
            this.Count2.Name = "Count2";
            this.Count2.Size = new System.Drawing.Size(0, 25);
            this.Count2.TabIndex = 3;
            // 
            // GoLabel
            // 
            this.GoLabel.AutoSize = true;
            this.GoLabel.BackColor = System.Drawing.Color.Transparent;
            this.GoLabel.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoLabel.ForeColor = System.Drawing.Color.Transparent;
            this.GoLabel.Location = new System.Drawing.Point(337, 92);
            this.GoLabel.Name = "GoLabel";
            this.GoLabel.Size = new System.Drawing.Size(80, 45);
            this.GoLabel.TabIndex = 5;
            this.GoLabel.Text = "GO!!";
            this.GoLabel.Click += new System.EventHandler(this.beginLabel_Click);
            // 
            // Arcade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoLabel);
            this.Controls.Add(this.Count2);
            this.Controls.Add(this.Count3);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.PlayGame);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Arcade";
            this.Text = "Arcade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayGame;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Label Count3;
        private System.Windows.Forms.Label Count2;
        private System.Windows.Forms.Label GoLabel;
    }
}

