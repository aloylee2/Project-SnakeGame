namespace Snake
{
    partial class scoreboard
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
            this.scoreboardDGV = new System.Windows.Forms.DataGridView();
            this.totallbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TOP5 = new System.Windows.Forms.Button();
            this.DSCORE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreboardDGV
            // 
            this.scoreboardDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreboardDGV.Location = new System.Drawing.Point(25, 125);
            this.scoreboardDGV.Name = "scoreboardDGV";
            this.scoreboardDGV.RowTemplate.Height = 24;
            this.scoreboardDGV.Size = new System.Drawing.Size(457, 261);
            this.scoreboardDGV.TabIndex = 0;
            this.scoreboardDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scoreboardDGV_CellContentClick);
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Location = new System.Drawing.Point(25, 403);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(16, 17);
            this.totallbl.TabIndex = 1;
            this.totallbl.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Snake.Properties.Resources.snake;
            this.pictureBox1.Location = new System.Drawing.Point(-11, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 585);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "GO BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 40F);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 81);
            this.label1.TabIndex = 4;
            this.label1.Text = "HIGH SCORE";
            // 
            // TOP5
            // 
            this.TOP5.Location = new System.Drawing.Point(214, 473);
            this.TOP5.Name = "TOP5";
            this.TOP5.Size = new System.Drawing.Size(93, 65);
            this.TOP5.TabIndex = 5;
            this.TOP5.Text = "TOP 5";
            this.TOP5.UseVisualStyleBackColor = true;
            this.TOP5.Click += new System.EventHandler(this.button2_Click);
            // 
            // DSCORE
            // 
            this.DSCORE.Location = new System.Drawing.Point(115, 473);
            this.DSCORE.Name = "DSCORE";
            this.DSCORE.Size = new System.Drawing.Size(93, 65);
            this.DSCORE.TabIndex = 6;
            this.DSCORE.Text = "DEFAULT SCORE";
            this.DSCORE.UseVisualStyleBackColor = true;
            this.DSCORE.Click += new System.EventHandler(this.button3_Click);
            // 
            // scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 550);
            this.Controls.Add(this.DSCORE);
            this.Controls.Add(this.TOP5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.scoreboardDGV);
            this.Controls.Add(this.pictureBox1);
            this.Name = "scoreboard";
            this.Text = "Universe Scoreboard";
            this.Load += new System.EventHandler(this.scoreboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreboardDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView scoreboardDGV;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TOP5;
        private System.Windows.Forms.Button DSCORE;
    }
}