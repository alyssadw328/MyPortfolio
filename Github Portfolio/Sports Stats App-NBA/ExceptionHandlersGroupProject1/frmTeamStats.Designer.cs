namespace ExceptionHandlersGroupProject1
{
    partial class frmTeamStats
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
            this.lblTeamName = new System.Windows.Forms.Label();
            this.pictureBoxTeamLogo = new System.Windows.Forms.PictureBox();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLoss = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxRanking = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeamLogo)).BeginInit();
            this.groupBoxRanking.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.BackColor = System.Drawing.Color.Transparent;
            this.lblTeamName.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(318, 36);
            this.lblTeamName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(251, 60);
            this.lblTeamName.TabIndex = 1;
            this.lblTeamName.Text = "Team Name";
            // 
            // pictureBoxTeamLogo
            // 
            this.pictureBoxTeamLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxTeamLogo.Location = new System.Drawing.Point(34, 26);
            this.pictureBoxTeamLogo.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxTeamLogo.Name = "pictureBoxTeamLogo";
            this.pictureBoxTeamLogo.Size = new System.Drawing.Size(254, 232);
            this.pictureBoxTeamLogo.TabIndex = 2;
            this.pictureBoxTeamLogo.TabStop = false;
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(311, 122);
            this.lblWin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(51, 31);
            this.lblWin.TabIndex = 9;
            this.lblWin.Text = "Wins";
            // 
            // lblLoss
            // 
            this.lblLoss.AutoSize = true;
            this.lblLoss.BackColor = System.Drawing.Color.Transparent;
            this.lblLoss.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoss.Location = new System.Drawing.Point(311, 160);
            this.lblLoss.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(66, 31);
            this.lblLoss.TabIndex = 10;
            this.lblLoss.Text = "Losses";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(980, 203);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(420, 263);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBoxRanking
            // 
            this.groupBoxRanking.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxRanking.Controls.Add(this.label1);
            this.groupBoxRanking.Controls.Add(this.comboBox1);
            this.groupBoxRanking.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRanking.Location = new System.Drawing.Point(621, 101);
            this.groupBoxRanking.Name = "groupBoxRanking";
            this.groupBoxRanking.Size = new System.Drawing.Size(251, 157);
            this.groupBoxRanking.TabIndex = 12;
            this.groupBoxRanking.TabStop = false;
            this.groupBoxRanking.Text = "Ranking";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "RANK";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "by Division",
            "by Conference"});
            this.comboBox1.Location = new System.Drawing.Point(16, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 32);
            this.comboBox1.TabIndex = 0;
            // 
            // frmTeamStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExceptionHandlersGroupProject1.Properties.Resources.bballbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(903, 574);
            this.Controls.Add(this.groupBoxRanking);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLoss);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.pictureBoxTeamLogo);
            this.Controls.Add(this.lblTeamName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTeamStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Stats";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeamLogo)).EndInit();
            this.groupBoxRanking.ResumeLayout(false);
            this.groupBoxRanking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.PictureBox pictureBoxTeamLogo;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLoss;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxRanking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}