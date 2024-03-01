namespace Snake
{
    partial class InsideDifficulty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsideDifficulty));
            this.easyBTN = new System.Windows.Forms.Button();
            this.hardBTN = new System.Windows.Forms.Button();
            this.extremeBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // easyBTN
            // 
            this.easyBTN.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyBTN.Image = ((System.Drawing.Image)(resources.GetObject("easyBTN.Image")));
            this.easyBTN.Location = new System.Drawing.Point(100, 62);
            this.easyBTN.Name = "easyBTN";
            this.easyBTN.Size = new System.Drawing.Size(245, 116);
            this.easyBTN.TabIndex = 0;
            this.easyBTN.Text = "EASY";
            this.easyBTN.UseVisualStyleBackColor = true;
            this.easyBTN.Click += new System.EventHandler(this.easyBTN_Click);
            // 
            // hardBTN
            // 
            this.hardBTN.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardBTN.Image = ((System.Drawing.Image)(resources.GetObject("hardBTN.Image")));
            this.hardBTN.Location = new System.Drawing.Point(100, 191);
            this.hardBTN.Name = "hardBTN";
            this.hardBTN.Size = new System.Drawing.Size(245, 116);
            this.hardBTN.TabIndex = 1;
            this.hardBTN.Text = "HARD";
            this.hardBTN.UseVisualStyleBackColor = true;
            this.hardBTN.Click += new System.EventHandler(this.hardBTN_Click);
            // 
            // extremeBTN
            // 
            this.extremeBTN.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extremeBTN.Image = ((System.Drawing.Image)(resources.GetObject("extremeBTN.Image")));
            this.extremeBTN.Location = new System.Drawing.Point(100, 320);
            this.extremeBTN.Name = "extremeBTN";
            this.extremeBTN.Size = new System.Drawing.Size(245, 116);
            this.extremeBTN.TabIndex = 2;
            this.extremeBTN.Text = "EXTREME";
            this.extremeBTN.UseVisualStyleBackColor = true;
            this.extremeBTN.Click += new System.EventHandler(this.extremeBTN_Click);
            // 
            // InsideDifficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(442, 478);
            this.Controls.Add(this.extremeBTN);
            this.Controls.Add(this.hardBTN);
            this.Controls.Add(this.easyBTN);
            this.Name = "InsideDifficulty";
            this.Text = "Difficulty Mode";
            this.Load += new System.EventHandler(this.InsideDifficulty_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button easyBTN;
        private System.Windows.Forms.Button hardBTN;
        private System.Windows.Forms.Button extremeBTN;
    }
}