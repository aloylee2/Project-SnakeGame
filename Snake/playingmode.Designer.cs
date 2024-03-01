namespace Snake
{
    partial class playingmode
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
            this.difficultyBTN = new System.Windows.Forms.Button();
            this.levelBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Tahoma", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODE";
            // 
            // difficultyBTN
            // 
            this.difficultyBTN.BackColor = System.Drawing.Color.ForestGreen;
            this.difficultyBTN.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyBTN.ForeColor = System.Drawing.Color.Black;
            this.difficultyBTN.Location = new System.Drawing.Point(82, 128);
            this.difficultyBTN.Name = "difficultyBTN";
            this.difficultyBTN.Size = new System.Drawing.Size(299, 149);
            this.difficultyBTN.TabIndex = 1;
            this.difficultyBTN.Text = "DIFFICULTY";
            this.difficultyBTN.UseVisualStyleBackColor = false;
            this.difficultyBTN.Click += new System.EventHandler(this.difficultyBTN_Click);
            // 
            // levelBTN
            // 
            this.levelBTN.BackColor = System.Drawing.Color.ForestGreen;
            this.levelBTN.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelBTN.ForeColor = System.Drawing.Color.Black;
            this.levelBTN.Location = new System.Drawing.Point(82, 286);
            this.levelBTN.Name = "levelBTN";
            this.levelBTN.Size = new System.Drawing.Size(299, 157);
            this.levelBTN.TabIndex = 2;
            this.levelBTN.Text = "LEVEL";
            this.levelBTN.UseVisualStyleBackColor = false;
            this.levelBTN.Click += new System.EventHandler(this.levelBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Snake.Properties.Resources.snake;
            this.pictureBox1.Location = new System.Drawing.Point(-657, -292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1260, 814);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // playingmode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(461, 463);
            this.Controls.Add(this.levelBTN);
            this.Controls.Add(this.difficultyBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "playingmode";
            this.Text = "Mode";
            this.Load += new System.EventHandler(this.playingmode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button difficultyBTN;
        private System.Windows.Forms.Button levelBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}