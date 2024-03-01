namespace Snake
{
    partial class hardmode
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
            this.controlPanel = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.finishBTN = new System.Windows.Forms.Button();
            this.uprightBTN = new System.Windows.Forms.Button();
            this.upleftBTN = new System.Windows.Forms.Button();
            this.downleftBTN = new System.Windows.Forms.Button();
            this.downrightBTN = new System.Windows.Forms.Button();
            this.levelLBL = new System.Windows.Forms.Label();
            this.scoreLBL = new System.Windows.Forms.Label();
            this.pauseBTN = new System.Windows.Forms.Button();
            this.startBTN = new System.Windows.Forms.Button();
            this.modeLBL = new System.Windows.Forms.Label();
            this.timerLBL = new System.Windows.Forms.Label();
            this.upBTN = new System.Windows.Forms.Button();
            this.leftBTN = new System.Windows.Forms.Button();
            this.downBTN = new System.Windows.Forms.Button();
            this.rightBTN = new System.Windows.Forms.Button();
            this.boardPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.DarkGreen;
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.button8);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.button7);
            this.controlPanel.Controls.Add(this.button6);
            this.controlPanel.Controls.Add(this.finishBTN);
            this.controlPanel.Controls.Add(this.uprightBTN);
            this.controlPanel.Controls.Add(this.upleftBTN);
            this.controlPanel.Controls.Add(this.downleftBTN);
            this.controlPanel.Controls.Add(this.downrightBTN);
            this.controlPanel.Controls.Add(this.levelLBL);
            this.controlPanel.Controls.Add(this.scoreLBL);
            this.controlPanel.Controls.Add(this.pauseBTN);
            this.controlPanel.Controls.Add(this.startBTN);
            this.controlPanel.Controls.Add(this.modeLBL);
            this.controlPanel.Controls.Add(this.timerLBL);
            this.controlPanel.Controls.Add(this.upBTN);
            this.controlPanel.Controls.Add(this.leftBTN);
            this.controlPanel.Controls.Add(this.downBTN);
            this.controlPanel.Controls.Add(this.rightBTN);
            this.controlPanel.Location = new System.Drawing.Point(0, 226);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(820, 224);
            this.controlPanel.TabIndex = 18;
            // 
            // button8
            // 
            this.button8.Image = global::Snake.Properties.Resources.time;
            this.button8.Location = new System.Drawing.Point(13, 124);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 58);
            this.button8.TabIndex = 35;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Image = global::Snake.Properties.Resources.score;
            this.button7.Location = new System.Drawing.Point(13, 72);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 54);
            this.button7.TabIndex = 34;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = global::Snake.Properties.Resources.level;
            this.button6.Location = new System.Drawing.Point(13, 15);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 60);
            this.button6.TabIndex = 33;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // finishBTN
            // 
            this.finishBTN.Image = global::Snake.Properties.Resources.Artboard_1_copy_2;
            this.finishBTN.Location = new System.Drawing.Point(454, 135);
            this.finishBTN.Margin = new System.Windows.Forms.Padding(4);
            this.finishBTN.Name = "finishBTN";
            this.finishBTN.Size = new System.Drawing.Size(122, 54);
            this.finishBTN.TabIndex = 32;
            this.finishBTN.UseVisualStyleBackColor = true;
            this.finishBTN.Click += new System.EventHandler(this.finishBTN_Click);
            // 
            // uprightBTN
            // 
            this.uprightBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uprightBTN.Image = global::Snake.Properties.Resources.topright;
            this.uprightBTN.Location = new System.Drawing.Point(710, 39);
            this.uprightBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uprightBTN.Name = "uprightBTN";
            this.uprightBTN.Size = new System.Drawing.Size(35, 32);
            this.uprightBTN.TabIndex = 31;
            this.uprightBTN.UseVisualStyleBackColor = true;
            this.uprightBTN.Click += new System.EventHandler(this.uprightBTN_Click);
            // 
            // upleftBTN
            // 
            this.upleftBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upleftBTN.Image = global::Snake.Properties.Resources.topleft;
            this.upleftBTN.Location = new System.Drawing.Point(583, 40);
            this.upleftBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upleftBTN.Name = "upleftBTN";
            this.upleftBTN.Size = new System.Drawing.Size(35, 32);
            this.upleftBTN.TabIndex = 30;
            this.upleftBTN.UseVisualStyleBackColor = true;
            this.upleftBTN.Click += new System.EventHandler(this.upleftBTN_Click);
            // 
            // downleftBTN
            // 
            this.downleftBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downleftBTN.Image = global::Snake.Properties.Resources.downleft;
            this.downleftBTN.Location = new System.Drawing.Point(583, 127);
            this.downleftBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downleftBTN.Name = "downleftBTN";
            this.downleftBTN.Size = new System.Drawing.Size(35, 32);
            this.downleftBTN.TabIndex = 29;
            this.downleftBTN.UseVisualStyleBackColor = true;
            this.downleftBTN.Click += new System.EventHandler(this.downleftBTN_Click);
            // 
            // downrightBTN
            // 
            this.downrightBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downrightBTN.Image = global::Snake.Properties.Resources.downright;
            this.downrightBTN.Location = new System.Drawing.Point(710, 127);
            this.downrightBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downrightBTN.Name = "downrightBTN";
            this.downrightBTN.Size = new System.Drawing.Size(35, 32);
            this.downrightBTN.TabIndex = 28;
            this.downrightBTN.UseVisualStyleBackColor = true;
            this.downrightBTN.Click += new System.EventHandler(this.downrightBTN_Click);
            // 
            // levelLBL
            // 
            this.levelLBL.AutoSize = true;
            this.levelLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.levelLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLBL.Location = new System.Drawing.Point(141, 19);
            this.levelLBL.Name = "levelLBL";
            this.levelLBL.Size = new System.Drawing.Size(38, 40);
            this.levelLBL.TabIndex = 26;
            this.levelLBL.Text = "1";
            // 
            // scoreLBL
            // 
            this.scoreLBL.AutoSize = true;
            this.scoreLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoreLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.scoreLBL.Location = new System.Drawing.Point(141, 76);
            this.scoreLBL.Name = "scoreLBL";
            this.scoreLBL.Size = new System.Drawing.Size(39, 41);
            this.scoreLBL.TabIndex = 24;
            this.scoreLBL.Text = "0";
            // 
            // pauseBTN
            // 
            this.pauseBTN.Image = global::Snake.Properties.Resources.pause;
            this.pauseBTN.Location = new System.Drawing.Point(454, 77);
            this.pauseBTN.Margin = new System.Windows.Forms.Padding(4);
            this.pauseBTN.Name = "pauseBTN";
            this.pauseBTN.Size = new System.Drawing.Size(122, 50);
            this.pauseBTN.TabIndex = 23;
            this.pauseBTN.UseVisualStyleBackColor = true;
            this.pauseBTN.Click += new System.EventHandler(this.pauseBTN_Click);
            // 
            // startBTN
            // 
            this.startBTN.Image = global::Snake.Properties.Resources.start;
            this.startBTN.Location = new System.Drawing.Point(454, 19);
            this.startBTN.Margin = new System.Windows.Forms.Padding(4);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(122, 53);
            this.startBTN.TabIndex = 22;
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // modeLBL
            // 
            this.modeLBL.AutoSize = true;
            this.modeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLBL.Location = new System.Drawing.Point(626, 15);
            this.modeLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modeLBL.Name = "modeLBL";
            this.modeLBL.Size = new System.Drawing.Size(75, 17);
            this.modeLBL.TabIndex = 6;
            this.modeLBL.Text = "modeLBL";
            // 
            // timerLBL
            // 
            this.timerLBL.AutoSize = true;
            this.timerLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timerLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.timerLBL.Location = new System.Drawing.Point(141, 135);
            this.timerLBL.Name = "timerLBL";
            this.timerLBL.Size = new System.Drawing.Size(159, 41);
            this.timerLBL.TabIndex = 20;
            this.timerLBL.Text = "00:00:00";
            // 
            // upBTN
            // 
            this.upBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upBTN.Image = global::Snake.Properties.Resources.top;
            this.upBTN.Location = new System.Drawing.Point(644, 40);
            this.upBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upBTN.Name = "upBTN";
            this.upBTN.Size = new System.Drawing.Size(35, 31);
            this.upBTN.TabIndex = 4;
            this.upBTN.UseVisualStyleBackColor = true;
            this.upBTN.Click += new System.EventHandler(this.upBTN_Click);
            // 
            // leftBTN
            // 
            this.leftBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftBTN.Image = global::Snake.Properties.Resources.left;
            this.leftBTN.Location = new System.Drawing.Point(583, 82);
            this.leftBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftBTN.Name = "leftBTN";
            this.leftBTN.Size = new System.Drawing.Size(35, 32);
            this.leftBTN.TabIndex = 1;
            this.leftBTN.UseVisualStyleBackColor = true;
            this.leftBTN.Click += new System.EventHandler(this.leftBTN_Click);
            // 
            // downBTN
            // 
            this.downBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downBTN.Image = global::Snake.Properties.Resources.down;
            this.downBTN.Location = new System.Drawing.Point(644, 127);
            this.downBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downBTN.Name = "downBTN";
            this.downBTN.Size = new System.Drawing.Size(35, 32);
            this.downBTN.TabIndex = 3;
            this.downBTN.UseVisualStyleBackColor = true;
            this.downBTN.Click += new System.EventHandler(this.downBTN_Click);
            // 
            // rightBTN
            // 
            this.rightBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBTN.Image = global::Snake.Properties.Resources.right;
            this.rightBTN.Location = new System.Drawing.Point(710, 82);
            this.rightBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightBTN.Name = "rightBTN";
            this.rightBTN.Size = new System.Drawing.Size(35, 32);
            this.rightBTN.TabIndex = 5;
            this.rightBTN.UseVisualStyleBackColor = true;
            this.rightBTN.Click += new System.EventHandler(this.rightBTN_Click);
            // 
            // boardPanel
            // 
            this.boardPanel.BackColor = System.Drawing.Color.SaddleBrown;
            this.boardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boardPanel.Location = new System.Drawing.Point(13, 10);
            this.boardPanel.Margin = new System.Windows.Forms.Padding(4);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(688, 210);
            this.boardPanel.TabIndex = 19;
            this.boardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.boardPanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(301, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "HARD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(203, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "MODE:";
            // 
            // hardmode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(771, 432);
            this.Controls.Add(this.boardPanel);
            this.Controls.Add(this.controlPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "hardmode";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button leftBTN;
        private System.Windows.Forms.Button downBTN;
        private System.Windows.Forms.Button upBTN;
        private System.Windows.Forms.Button rightBTN;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.Label modeLBL;
        private System.Windows.Forms.Label timerLBL;
        private System.Windows.Forms.Button pauseBTN;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Label scoreLBL;
        private System.Windows.Forms.Label levelLBL;
        private System.Windows.Forms.Button uprightBTN;
        private System.Windows.Forms.Button upleftBTN;
        private System.Windows.Forms.Button downleftBTN;
        private System.Windows.Forms.Button downrightBTN;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button finishBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

