namespace ExceptionHandlersGroupProject1
{
    partial class frmGameInfo
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
            this.lblGameTeams = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.pictureBoxTeam2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTeam1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeam1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameTeams
            // 
            this.lblGameTeams.AutoSize = true;
            this.lblGameTeams.BackColor = System.Drawing.Color.Transparent;
            this.lblGameTeams.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTeams.Location = new System.Drawing.Point(302, 84);
            this.lblGameTeams.Name = "lblGameTeams";
            this.lblGameTeams.Size = new System.Drawing.Size(274, 60);
            this.lblGameTeams.TabIndex = 2;
            this.lblGameTeams.Text = "Team v Team";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.BackColor = System.Drawing.Color.Transparent;
            this.lblScore1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.Location = new System.Drawing.Point(287, 185);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(100, 36);
            this.lblScore1.TabIndex = 6;
            this.lblScore1.Text = "Score 1";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.BackColor = System.Drawing.Color.Transparent;
            this.lblScore2.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.Location = new System.Drawing.Point(491, 185);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(104, 36);
            this.lblScore2.TabIndex = 7;
            this.lblScore2.Text = "Score 2";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFinal.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(419, 195);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(42, 24);
            this.lblFinal.TabIndex = 8;
            this.lblFinal.Text = "FINAL";
            // 
            // pictureBoxTeam2
            // 
            this.pictureBoxTeam2.Location = new System.Drawing.Point(597, 37);
            this.pictureBoxTeam2.Name = "pictureBoxTeam2";
            this.pictureBoxTeam2.Size = new System.Drawing.Size(241, 228);
            this.pictureBoxTeam2.TabIndex = 4;
            this.pictureBoxTeam2.TabStop = false;
            // 
            // pictureBoxTeam1
            // 
            this.pictureBoxTeam1.Location = new System.Drawing.Point(40, 37);
            this.pictureBoxTeam1.Name = "pictureBoxTeam1";
            this.pictureBoxTeam1.Size = new System.Drawing.Size(241, 228);
            this.pictureBoxTeam1.TabIndex = 3;
            this.pictureBoxTeam1.TabStop = false;
            // 
            // frmGameInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExceptionHandlersGroupProject1.Properties.Resources.bball1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 577);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.pictureBoxTeam2);
            this.Controls.Add(this.pictureBoxTeam1);
            this.Controls.Add(this.lblGameTeams);
            this.DoubleBuffered = true;
            this.Name = "frmGameInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Stats";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeam1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameTeams;
        private System.Windows.Forms.PictureBox pictureBoxTeam1;
        private System.Windows.Forms.PictureBox pictureBoxTeam2;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblFinal;
    }
}