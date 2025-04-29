namespace ExceptionHandlersGroupProject1
{
    partial class formDashboard
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchTeam = new System.Windows.Forms.Button();
            this.btnSearchPlayer = new System.Windows.Forms.Button();
            this.textBoxPlayer = new System.Windows.Forms.TextBox();
            this.textBoxTeam = new System.Windows.Forms.TextBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.groupBoxGames = new System.Windows.Forms.GroupBox();
            this.comboBoxGames = new System.Windows.Forms.ComboBox();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nBAStatsDBDataSet1 = new ExceptionHandlersGroupProject1.NBAStatsDBDataSet1();
            this.btnViewGame = new System.Windows.Forms.Button();
            this.lblSelectGame = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.gamesTableAdapter = new ExceptionHandlersGroupProject1.NBAStatsDBDataSet1TableAdapters.GamesTableAdapter();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxGames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBAStatsDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSearch.BackgroundImage = global::ExceptionHandlersGroupProject1.Properties.Resources.output_onlinepngtools;
            this.groupBoxSearch.Controls.Add(this.btnSearchTeam);
            this.groupBoxSearch.Controls.Add(this.btnSearchPlayer);
            this.groupBoxSearch.Controls.Add(this.textBoxPlayer);
            this.groupBoxSearch.Controls.Add(this.textBoxTeam);
            this.groupBoxSearch.Controls.Add(this.lblPlayer);
            this.groupBoxSearch.Controls.Add(this.lblTeam);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.Location = new System.Drawing.Point(29, 22);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(241, 200);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search by:";
            // 
            // btnSearchTeam
            // 
            this.btnSearchTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTeam.Location = new System.Drawing.Point(77, 79);
            this.btnSearchTeam.Name = "btnSearchTeam";
            this.btnSearchTeam.Size = new System.Drawing.Size(80, 28);
            this.btnSearchTeam.TabIndex = 5;
            this.btnSearchTeam.Text = "Search";
            this.btnSearchTeam.UseVisualStyleBackColor = true;
            this.btnSearchTeam.Click += new System.EventHandler(this.btnSearchTeam_Click);
            // 
            // btnSearchPlayer
            // 
            this.btnSearchPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPlayer.Location = new System.Drawing.Point(77, 166);
            this.btnSearchPlayer.Name = "btnSearchPlayer";
            this.btnSearchPlayer.Size = new System.Drawing.Size(80, 28);
            this.btnSearchPlayer.TabIndex = 4;
            this.btnSearchPlayer.Text = "Search";
            this.btnSearchPlayer.UseVisualStyleBackColor = true;
            // 
            // textBoxPlayer
            // 
            this.textBoxPlayer.Location = new System.Drawing.Point(19, 136);
            this.textBoxPlayer.Name = "textBoxPlayer";
            this.textBoxPlayer.Size = new System.Drawing.Size(200, 24);
            this.textBoxPlayer.TabIndex = 3;
            // 
            // textBoxTeam
            // 
            this.textBoxTeam.Location = new System.Drawing.Point(22, 51);
            this.textBoxTeam.Name = "textBoxTeam";
            this.textBoxTeam.Size = new System.Drawing.Size(200, 24);
            this.textBoxTeam.TabIndex = 2;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(16, 115);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(55, 18);
            this.lblPlayer.TabIndex = 1;
            this.lblPlayer.Text = "Player";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.Location = new System.Drawing.Point(16, 30);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(50, 18);
            this.lblTeam.TabIndex = 0;
            this.lblTeam.Text = "Team";
            // 
            // groupBoxGames
            // 
            this.groupBoxGames.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGames.BackgroundImage = global::ExceptionHandlersGroupProject1.Properties.Resources.output_onlinepngtools;
            this.groupBoxGames.Controls.Add(this.comboBoxGames);
            this.groupBoxGames.Controls.Add(this.btnViewGame);
            this.groupBoxGames.Controls.Add(this.lblSelectGame);
            this.groupBoxGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGames.Location = new System.Drawing.Point(646, 22);
            this.groupBoxGames.Name = "groupBoxGames";
            this.groupBoxGames.Size = new System.Drawing.Size(241, 120);
            this.groupBoxGames.TabIndex = 6;
            this.groupBoxGames.TabStop = false;
            this.groupBoxGames.Text = "View Game Stats";
            // 
            // comboBoxGames
            // 
            this.comboBoxGames.DataSource = this.gamesBindingSource;
            this.comboBoxGames.DisplayMember = "GameDate";
            this.comboBoxGames.FormattingEnabled = true;
            this.comboBoxGames.Location = new System.Drawing.Point(22, 51);
            this.comboBoxGames.Name = "comboBoxGames";
            this.comboBoxGames.Size = new System.Drawing.Size(202, 26);
            this.comboBoxGames.TabIndex = 6;
            this.comboBoxGames.ValueMember = "GameID";
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "Games";
            this.gamesBindingSource.DataSource = this.nBAStatsDBDataSet1;
            // 
            // nBAStatsDBDataSet1
            // 
            this.nBAStatsDBDataSet1.DataSetName = "NBAStatsDBDataSet1";
            this.nBAStatsDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnViewGame
            // 
            this.btnViewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGame.Location = new System.Drawing.Point(75, 79);
            this.btnViewGame.Name = "btnViewGame";
            this.btnViewGame.Size = new System.Drawing.Size(95, 28);
            this.btnViewGame.TabIndex = 5;
            this.btnViewGame.Text = "View Game";
            this.btnViewGame.UseVisualStyleBackColor = true;
            // 
            // lblSelectGame
            // 
            this.lblSelectGame.AutoSize = true;
            this.lblSelectGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectGame.Location = new System.Drawing.Point(6, 30);
            this.lblSelectGame.Name = "lblSelectGame";
            this.lblSelectGame.Size = new System.Drawing.Size(153, 18);
            this.lblSelectGame.TabIndex = 0;
            this.lblSelectGame.Text = "Please select a game:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(811, 568);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 39);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gamesTableAdapter
            // 
            this.gamesTableAdapter.ClearBeforeFill = true;
            // 
            // formDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExceptionHandlersGroupProject1.Properties.Resources.nbabackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 619);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBoxGames);
            this.Controls.Add(this.groupBoxSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NBA Statistics \'24/\'25 Season";
            this.Load += new System.EventHandler(this.formDashboard_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxGames.ResumeLayout(false);
            this.groupBoxGames.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBAStatsDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxPlayer;
        private System.Windows.Forms.TextBox textBoxTeam;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Button btnSearchTeam;
        private System.Windows.Forms.Button btnSearchPlayer;
        private System.Windows.Forms.GroupBox groupBoxGames;
        private System.Windows.Forms.Button btnViewGame;
        private System.Windows.Forms.Label lblSelectGame;
        private System.Windows.Forms.ComboBox comboBoxGames;
        private System.Windows.Forms.Button btnExit;
        private NBAStatsDBDataSet1 nBAStatsDBDataSet1;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private NBAStatsDBDataSet1TableAdapters.GamesTableAdapter gamesTableAdapter;
    }
}

