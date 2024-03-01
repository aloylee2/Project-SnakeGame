namespace Snake
{
    partial class records
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
            this.timelbl = new System.Windows.Forms.Label();
            this.Scorelbl = new System.Windows.Forms.Label();
            this.playertextname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submitBTN = new System.Windows.Forms.Button();
            this.playbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "YOUR RECORD:";
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.Location = new System.Drawing.Point(140, 92);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(223, 60);
            this.timelbl.TabIndex = 1;
            this.timelbl.Text = "00:00:00";
            // 
            // Scorelbl
            // 
            this.Scorelbl.AutoSize = true;
            this.Scorelbl.Font = new System.Drawing.Font("Tahoma", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorelbl.Location = new System.Drawing.Point(217, 210);
            this.Scorelbl.Name = "Scorelbl";
            this.Scorelbl.Size = new System.Drawing.Size(62, 70);
            this.Scorelbl.TabIndex = 2;
            this.Scorelbl.Text = "0";
            // 
            // playertextname
            // 
            this.playertextname.Location = new System.Drawing.Point(67, 283);
            this.playertextname.Multiline = true;
            this.playertextname.Name = "playertextname";
            this.playertextname.Size = new System.Drawing.Size(365, 56);
            this.playertextname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(173, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Text your name here";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 58);
            this.label4.TabIndex = 5;
            this.label4.Text = "SCORE";
            // 
            // submitBTN
            // 
            this.submitBTN.BackColor = System.Drawing.Color.Black;
            this.submitBTN.Image = global::Snake.Properties.Resources.SUBMIT;
            this.submitBTN.Location = new System.Drawing.Point(118, 397);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(107, 59);
            this.submitBTN.TabIndex = 6;
            this.submitBTN.UseVisualStyleBackColor = false;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // playbtn
            // 
            this.playbtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.playbtn.Image = global::Snake.Properties.Resources.play_;
            this.playbtn.Location = new System.Drawing.Point(257, 397);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(106, 59);
            this.playbtn.TabIndex = 7;
            this.playbtn.UseVisualStyleBackColor = false;
            // 
            // records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(496, 468);
            this.Controls.Add(this.playbtn);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playertextname);
            this.Controls.Add(this.Scorelbl);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.label1);
            this.Name = "records";
            this.Text = "YOUR RECORDS!";
            this.Load += new System.EventHandler(this.records_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label Scorelbl;
        private System.Windows.Forms.TextBox playertextname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Button playbtn;
    }
}