namespace Snake
{
    partial class srecords
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
            this.label3 = new System.Windows.Forms.Label();
            this.scorelbl = new System.Windows.Forms.Label();
            this.playertextname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "YOUR RECORD :";
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.Location = new System.Drawing.Point(189, 83);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(180, 48);
            this.timelbl.TabIndex = 1;
            this.timelbl.Text = "00:00:00";
            this.timelbl.Click += new System.EventHandler(this.timelbl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "SCORE";
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelbl.Location = new System.Drawing.Point(252, 193);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(42, 48);
            this.scorelbl.TabIndex = 3;
            this.scorelbl.Text = "0";
            // 
            // playertextname
            // 
            this.playertextname.Location = new System.Drawing.Point(109, 244);
            this.playertextname.Multiline = true;
            this.playertextname.Name = "playertextname";
            this.playertextname.Size = new System.Drawing.Size(321, 47);
            this.playertextname.TabIndex = 4;
            this.playertextname.TextChanged += new System.EventHandler(this.playertextname_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(206, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "ENTER YOUR NAME";
            // 
            // button1
            // 
            this.button1.Image = global::Snake.Properties.Resources.SUBMIT;
            this.button1.Location = new System.Drawing.Point(209, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 50);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // srecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(560, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.playertextname);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.label1);
            this.Name = "srecords";
            this.Text = "YOUR RECORDS!";
            this.Load += new System.EventHandler(this.srecords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.TextBox playertextname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}