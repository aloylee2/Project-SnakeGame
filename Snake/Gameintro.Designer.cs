namespace Snake
{
    partial class Gameintro
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
            this.instructionBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.scoreboardBTN = new System.Windows.Forms.Button();
            this.startBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(108, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(892, 145);
            this.label1.TabIndex = 4;
            this.label1.Text = " SNAKE GAME";
            // 
            // instructionBTN
            // 
            this.instructionBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.instructionBTN.Image = global::Snake.Properties.Resources.GAMEGUIDEgameintro;
            this.instructionBTN.Location = new System.Drawing.Point(237, 470);
            this.instructionBTN.Name = "instructionBTN";
            this.instructionBTN.Size = new System.Drawing.Size(442, 127);
            this.instructionBTN.TabIndex = 3;
            this.instructionBTN.UseVisualStyleBackColor = false;
            this.instructionBTN.Click += new System.EventHandler(this.instructionBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitBTN.Image = global::Snake.Properties.Resources.EXITgameintro;
            this.exitBTN.Location = new System.Drawing.Point(344, 603);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(240, 121);
            this.exitBTN.TabIndex = 2;
            this.exitBTN.UseVisualStyleBackColor = false;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // scoreboardBTN
            // 
            this.scoreboardBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreboardBTN.Image = global::Snake.Properties.Resources.SCOREBOARDgameintro;
            this.scoreboardBTN.Location = new System.Drawing.Point(237, 337);
            this.scoreboardBTN.Name = "scoreboardBTN";
            this.scoreboardBTN.Size = new System.Drawing.Size(450, 127);
            this.scoreboardBTN.TabIndex = 1;
            this.scoreboardBTN.UseVisualStyleBackColor = false;
            this.scoreboardBTN.Click += new System.EventHandler(this.scoreboardBTN_Click);
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startBTN.Image = global::Snake.Properties.Resources.STARTgameintro;
            this.startBTN.Location = new System.Drawing.Point(344, 214);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(240, 121);
            this.startBTN.TabIndex = 0;
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Snake.Properties.Resources.snakeintropic;
            this.pictureBox1.Location = new System.Drawing.Point(-24, -52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(994, 789);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Gameintro
            // 
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(919, 734);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instructionBTN);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.scoreboardBTN);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Gameintro";
            this.Text = "Welcome to Snake Game";
            this.Load += new System.EventHandler(this.Gameintro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Button scoreboardBTN;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Button instructionBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}