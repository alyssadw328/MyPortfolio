namespace ExceptionHandlersGroupProject1
{
    partial class frmPlayerStats
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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerTeam = new System.Windows.Forms.Label();
            this.comboBoxViewBy = new System.Windows.Forms.ComboBox();
            this.lblMP = new System.Windows.Forms.Label();
            this.lblFGA = new System.Windows.Forms.Label();
            this.lblFG = new System.Windows.Forms.Label();
            this.lblFGPercent = new System.Windows.Forms.Label();
            this.lbl3P = new System.Windows.Forms.Label();
            this.lbl3PA = new System.Windows.Forms.Label();
            this.lbl3PPercent = new System.Windows.Forms.Label();
            this.lblFTA = new System.Windows.Forms.Label();
            this.labelFT = new System.Windows.Forms.Label();
            this.lblFTPercent = new System.Windows.Forms.Label();
            this.lblORB = new System.Windows.Forms.Label();
            this.lblDRB = new System.Windows.Forms.Label();
            this.lblTRB = new System.Windows.Forms.Label();
            this.lblAST = new System.Windows.Forms.Label();
            this.lblSTL = new System.Windows.Forms.Label();
            this.lblBLK = new System.Windows.Forms.Label();
            this.lblTOV = new System.Windows.Forms.Label();
            this.lblPF = new System.Windows.Forms.Label();
            this.lblPTS = new System.Windows.Forms.Label();
            this.textBox3PA = new System.Windows.Forms.TextBox();
            this.textBox3P = new System.Windows.Forms.TextBox();
            this.textBoxMP = new System.Windows.Forms.TextBox();
            this.textBoxFGA = new System.Windows.Forms.TextBox();
            this.textBoxFG = new System.Windows.Forms.TextBox();
            this.textBoxFGPercent = new System.Windows.Forms.TextBox();
            this.textBox3PPercent = new System.Windows.Forms.TextBox();
            this.textBoxFTA = new System.Windows.Forms.TextBox();
            this.textBoxFT = new System.Windows.Forms.TextBox();
            this.textBoxFTPercent = new System.Windows.Forms.TextBox();
            this.textBoxDRB = new System.Windows.Forms.TextBox();
            this.textBoxORB = new System.Windows.Forms.TextBox();
            this.textBoxTRB = new System.Windows.Forms.TextBox();
            this.textBoxAST = new System.Windows.Forms.TextBox();
            this.textBoxSTL = new System.Windows.Forms.TextBox();
            this.textBoxBLK = new System.Windows.Forms.TextBox();
            this.textBoxTOV = new System.Windows.Forms.TextBox();
            this.textBoxPF = new System.Windows.Forms.TextBox();
            this.textBoxPTS = new System.Windows.Forms.TextBox();
            this.lblGameDate = new System.Windows.Forms.Label();
            this.lblVs = new System.Windows.Forms.Label();
            this.lblOppTeam = new System.Windows.Forms.Label();
            this.lblTeamScore = new System.Windows.Forms.Label();
            this.lblOppTeamScore = new System.Windows.Forms.Label();
            this.lblWorL = new System.Windows.Forms.Label();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.comboBoxGameSelect = new System.Windows.Forms.ComboBox();
            this.lblView = new System.Windows.Forms.Label();
            this.lblGameSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(314, 59);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(270, 60);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player Name";
            // 
            // lblPlayerTeam
            // 
            this.lblPlayerTeam.AutoSize = true;
            this.lblPlayerTeam.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTeam.Location = new System.Drawing.Point(324, 130);
            this.lblPlayerTeam.Name = "lblPlayerTeam";
            this.lblPlayerTeam.Size = new System.Drawing.Size(195, 43);
            this.lblPlayerTeam.TabIndex = 2;
            this.lblPlayerTeam.Text = "Player Team";
            // 
            // comboBoxViewBy
            // 
            this.comboBoxViewBy.FormattingEnabled = true;
            this.comboBoxViewBy.Items.AddRange(new object[] {
            "Overall",
            "By Game"});
            this.comboBoxViewBy.Location = new System.Drawing.Point(662, 28);
            this.comboBoxViewBy.Name = "comboBoxViewBy";
            this.comboBoxViewBy.Size = new System.Drawing.Size(220, 28);
            this.comboBoxViewBy.TabIndex = 3;
            // 
            // lblMP
            // 
            this.lblMP.AutoSize = true;
            this.lblMP.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMP.Location = new System.Drawing.Point(68, 291);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(101, 24);
            this.lblMP.TabIndex = 10;
            this.lblMP.Text = "Minutes Played:";
            // 
            // lblFGA
            // 
            this.lblFGA.AutoSize = true;
            this.lblFGA.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFGA.Location = new System.Drawing.Point(46, 330);
            this.lblFGA.Name = "lblFGA";
            this.lblFGA.Size = new System.Drawing.Size(123, 24);
            this.lblFGA.TabIndex = 11;
            this.lblFGA.Text = "Field Goal Attempts:";
            // 
            // lblFG
            // 
            this.lblFG.AutoSize = true;
            this.lblFG.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFG.Location = new System.Drawing.Point(58, 369);
            this.lblFG.Name = "lblFG";
            this.lblFG.Size = new System.Drawing.Size(111, 24);
            this.lblFG.TabIndex = 12;
            this.lblFG.Text = "FIeld Goals Made:";
            // 
            // lblFGPercent
            // 
            this.lblFGPercent.AutoSize = true;
            this.lblFGPercent.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFGPercent.Location = new System.Drawing.Point(81, 403);
            this.lblFGPercent.Name = "lblFGPercent";
            this.lblFGPercent.Size = new System.Drawing.Size(88, 24);
            this.lblFGPercent.TabIndex = 13;
            this.lblFGPercent.Text = "Field Goal %:";
            // 
            // lbl3P
            // 
            this.lbl3P.AutoSize = true;
            this.lbl3P.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3P.Location = new System.Drawing.Point(30, 480);
            this.lbl3P.Name = "lbl3P";
            this.lbl3P.Size = new System.Drawing.Size(139, 24);
            this.lbl3P.TabIndex = 14;
            this.lbl3P.Text = "3 pt. Field Goals Made:";
            // 
            // lbl3PA
            // 
            this.lbl3PA.AutoSize = true;
            this.lbl3PA.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3PA.Location = new System.Drawing.Point(18, 441);
            this.lbl3PA.Name = "lbl3PA";
            this.lbl3PA.Size = new System.Drawing.Size(151, 24);
            this.lbl3PA.TabIndex = 15;
            this.lbl3PA.Text = "3 pt. Field Goal Attempts:";
            // 
            // lbl3PPercent
            // 
            this.lbl3PPercent.AutoSize = true;
            this.lbl3PPercent.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3PPercent.Location = new System.Drawing.Point(59, 520);
            this.lbl3PPercent.Name = "lbl3PPercent";
            this.lbl3PPercent.Size = new System.Drawing.Size(110, 24);
            this.lbl3PPercent.TabIndex = 16;
            this.lbl3PPercent.Text = "3 pt. Shooting %:";
            // 
            // lblFTA
            // 
            this.lblFTA.AutoSize = true;
            this.lblFTA.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFTA.Location = new System.Drawing.Point(323, 291);
            this.lblFTA.Name = "lblFTA";
            this.lblFTA.Size = new System.Drawing.Size(136, 24);
            this.lblFTA.TabIndex = 17;
            this.lblFTA.Text = "Free Throw Attempts:";
            // 
            // labelFT
            // 
            this.labelFT.AutoSize = true;
            this.labelFT.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFT.Location = new System.Drawing.Point(335, 328);
            this.labelFT.Name = "labelFT";
            this.labelFT.Size = new System.Drawing.Size(124, 24);
            this.labelFT.TabIndex = 18;
            this.labelFT.Text = "Free Throws Made:";
            // 
            // lblFTPercent
            // 
            this.lblFTPercent.AutoSize = true;
            this.lblFTPercent.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFTPercent.Location = new System.Drawing.Point(358, 365);
            this.lblFTPercent.Name = "lblFTPercent";
            this.lblFTPercent.Size = new System.Drawing.Size(101, 24);
            this.lblFTPercent.TabIndex = 19;
            this.lblFTPercent.Text = "Free Throw %:";
            // 
            // lblORB
            // 
            this.lblORB.AutoSize = true;
            this.lblORB.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblORB.Location = new System.Drawing.Point(332, 406);
            this.lblORB.Name = "lblORB";
            this.lblORB.Size = new System.Drawing.Size(127, 24);
            this.lblORB.TabIndex = 20;
            this.lblORB.Text = "Offensive Rebounds:";
            // 
            // lblDRB
            // 
            this.lblDRB.AutoSize = true;
            this.lblDRB.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDRB.Location = new System.Drawing.Point(328, 443);
            this.lblDRB.Name = "lblDRB";
            this.lblDRB.Size = new System.Drawing.Size(131, 24);
            this.lblDRB.TabIndex = 21;
            this.lblDRB.Text = "Defensive Rebounds:";
            // 
            // lblTRB
            // 
            this.lblTRB.AutoSize = true;
            this.lblTRB.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTRB.Location = new System.Drawing.Point(357, 481);
            this.lblTRB.Name = "lblTRB";
            this.lblTRB.Size = new System.Drawing.Size(102, 24);
            this.lblTRB.TabIndex = 22;
            this.lblTRB.Text = "Total Rebounds:";
            // 
            // lblAST
            // 
            this.lblAST.AutoSize = true;
            this.lblAST.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAST.Location = new System.Drawing.Point(667, 293);
            this.lblAST.Name = "lblAST";
            this.lblAST.Size = new System.Drawing.Size(57, 24);
            this.lblAST.TabIndex = 23;
            this.lblAST.Text = "Assists:";
            // 
            // lblSTL
            // 
            this.lblSTL.AutoSize = true;
            this.lblSTL.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTL.Location = new System.Drawing.Point(675, 331);
            this.lblSTL.Name = "lblSTL";
            this.lblSTL.Size = new System.Drawing.Size(49, 24);
            this.lblSTL.TabIndex = 24;
            this.lblSTL.Text = "Steals:";
            // 
            // lblBLK
            // 
            this.lblBLK.AutoSize = true;
            this.lblBLK.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBLK.Location = new System.Drawing.Point(671, 370);
            this.lblBLK.Name = "lblBLK";
            this.lblBLK.Size = new System.Drawing.Size(53, 24);
            this.lblBLK.TabIndex = 25;
            this.lblBLK.Text = "Blocks:";
            // 
            // lblTOV
            // 
            this.lblTOV.AutoSize = true;
            this.lblTOV.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTOV.Location = new System.Drawing.Point(649, 405);
            this.lblTOV.Name = "lblTOV";
            this.lblTOV.Size = new System.Drawing.Size(75, 24);
            this.lblTOV.TabIndex = 26;
            this.lblTOV.Text = "Turnovers:";
            // 
            // lblPF
            // 
            this.lblPF.AutoSize = true;
            this.lblPF.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPF.Location = new System.Drawing.Point(624, 442);
            this.lblPF.Name = "lblPF";
            this.lblPF.Size = new System.Drawing.Size(100, 24);
            this.lblPF.TabIndex = 27;
            this.lblPF.Text = "Personal Fouls:";
            // 
            // lblPTS
            // 
            this.lblPTS.AutoSize = true;
            this.lblPTS.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTS.Location = new System.Drawing.Point(612, 482);
            this.lblPTS.Name = "lblPTS";
            this.lblPTS.Size = new System.Drawing.Size(112, 24);
            this.lblPTS.TabIndex = 28;
            this.lblPTS.Text = "Total Pts. Scored:";
            // 
            // textBox3PA
            // 
            this.textBox3PA.Location = new System.Drawing.Point(175, 441);
            this.textBox3PA.Name = "textBox3PA";
            this.textBox3PA.Size = new System.Drawing.Size(119, 26);
            this.textBox3PA.TabIndex = 29;
            // 
            // textBox3P
            // 
            this.textBox3P.Location = new System.Drawing.Point(175, 481);
            this.textBox3P.Name = "textBox3P";
            this.textBox3P.Size = new System.Drawing.Size(119, 26);
            this.textBox3P.TabIndex = 30;
            // 
            // textBoxMP
            // 
            this.textBoxMP.Location = new System.Drawing.Point(175, 291);
            this.textBoxMP.Name = "textBoxMP";
            this.textBoxMP.Size = new System.Drawing.Size(119, 26);
            this.textBoxMP.TabIndex = 31;
            // 
            // textBoxFGA
            // 
            this.textBoxFGA.Location = new System.Drawing.Point(175, 328);
            this.textBoxFGA.Name = "textBoxFGA";
            this.textBoxFGA.Size = new System.Drawing.Size(119, 26);
            this.textBoxFGA.TabIndex = 32;
            // 
            // textBoxFG
            // 
            this.textBoxFG.Location = new System.Drawing.Point(175, 367);
            this.textBoxFG.Name = "textBoxFG";
            this.textBoxFG.Size = new System.Drawing.Size(119, 26);
            this.textBoxFG.TabIndex = 33;
            // 
            // textBoxFGPercent
            // 
            this.textBoxFGPercent.Location = new System.Drawing.Point(175, 403);
            this.textBoxFGPercent.Name = "textBoxFGPercent";
            this.textBoxFGPercent.Size = new System.Drawing.Size(119, 26);
            this.textBoxFGPercent.TabIndex = 34;
            // 
            // textBox3PPercent
            // 
            this.textBox3PPercent.Location = new System.Drawing.Point(175, 521);
            this.textBox3PPercent.Name = "textBox3PPercent";
            this.textBox3PPercent.Size = new System.Drawing.Size(119, 26);
            this.textBox3PPercent.TabIndex = 35;
            // 
            // textBoxFTA
            // 
            this.textBoxFTA.Location = new System.Drawing.Point(465, 290);
            this.textBoxFTA.Name = "textBoxFTA";
            this.textBoxFTA.Size = new System.Drawing.Size(119, 26);
            this.textBoxFTA.TabIndex = 36;
            // 
            // textBoxFT
            // 
            this.textBoxFT.Location = new System.Drawing.Point(465, 326);
            this.textBoxFT.Name = "textBoxFT";
            this.textBoxFT.Size = new System.Drawing.Size(119, 26);
            this.textBoxFT.TabIndex = 37;
            // 
            // textBoxFTPercent
            // 
            this.textBoxFTPercent.Location = new System.Drawing.Point(465, 363);
            this.textBoxFTPercent.Name = "textBoxFTPercent";
            this.textBoxFTPercent.Size = new System.Drawing.Size(119, 26);
            this.textBoxFTPercent.TabIndex = 38;
            // 
            // textBoxDRB
            // 
            this.textBoxDRB.Location = new System.Drawing.Point(465, 440);
            this.textBoxDRB.Name = "textBoxDRB";
            this.textBoxDRB.Size = new System.Drawing.Size(119, 26);
            this.textBoxDRB.TabIndex = 39;
            // 
            // textBoxORB
            // 
            this.textBoxORB.Location = new System.Drawing.Point(465, 404);
            this.textBoxORB.Name = "textBoxORB";
            this.textBoxORB.Size = new System.Drawing.Size(119, 26);
            this.textBoxORB.TabIndex = 40;
            // 
            // textBoxTRB
            // 
            this.textBoxTRB.Location = new System.Drawing.Point(465, 478);
            this.textBoxTRB.Name = "textBoxTRB";
            this.textBoxTRB.Size = new System.Drawing.Size(119, 26);
            this.textBoxTRB.TabIndex = 41;
            // 
            // textBoxAST
            // 
            this.textBoxAST.Location = new System.Drawing.Point(730, 291);
            this.textBoxAST.Name = "textBoxAST";
            this.textBoxAST.Size = new System.Drawing.Size(119, 26);
            this.textBoxAST.TabIndex = 42;
            // 
            // textBoxSTL
            // 
            this.textBoxSTL.Location = new System.Drawing.Point(730, 329);
            this.textBoxSTL.Name = "textBoxSTL";
            this.textBoxSTL.Size = new System.Drawing.Size(119, 26);
            this.textBoxSTL.TabIndex = 43;
            // 
            // textBoxBLK
            // 
            this.textBoxBLK.Location = new System.Drawing.Point(730, 368);
            this.textBoxBLK.Name = "textBoxBLK";
            this.textBoxBLK.Size = new System.Drawing.Size(119, 26);
            this.textBoxBLK.TabIndex = 44;
            // 
            // textBoxTOV
            // 
            this.textBoxTOV.Location = new System.Drawing.Point(730, 405);
            this.textBoxTOV.Name = "textBoxTOV";
            this.textBoxTOV.Size = new System.Drawing.Size(119, 26);
            this.textBoxTOV.TabIndex = 45;
            // 
            // textBoxPF
            // 
            this.textBoxPF.Location = new System.Drawing.Point(730, 442);
            this.textBoxPF.Name = "textBoxPF";
            this.textBoxPF.Size = new System.Drawing.Size(119, 26);
            this.textBoxPF.TabIndex = 46;
            // 
            // textBoxPTS
            // 
            this.textBoxPTS.Location = new System.Drawing.Point(730, 482);
            this.textBoxPTS.Name = "textBoxPTS";
            this.textBoxPTS.Size = new System.Drawing.Size(119, 26);
            this.textBoxPTS.TabIndex = 47;
            // 
            // lblGameDate
            // 
            this.lblGameDate.AutoSize = true;
            this.lblGameDate.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameDate.Location = new System.Drawing.Point(519, 206);
            this.lblGameDate.Name = "lblGameDate";
            this.lblGameDate.Size = new System.Drawing.Size(106, 34);
            this.lblGameDate.TabIndex = 48;
            this.lblGameDate.Text = "Game Date";
            // 
            // lblVs
            // 
            this.lblVs.AutoSize = true;
            this.lblVs.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVs.Location = new System.Drawing.Point(555, 138);
            this.lblVs.Name = "lblVs";
            this.lblVs.Size = new System.Drawing.Size(41, 34);
            this.lblVs.TabIndex = 49;
            this.lblVs.Text = "vs.";
            this.lblVs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOppTeam
            // 
            this.lblOppTeam.AutoSize = true;
            this.lblOppTeam.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOppTeam.Location = new System.Drawing.Point(620, 130);
            this.lblOppTeam.Name = "lblOppTeam";
            this.lblOppTeam.Size = new System.Drawing.Size(195, 43);
            this.lblOppTeam.TabIndex = 50;
            this.lblOppTeam.Text = "Player Team";
            // 
            // lblTeamScore
            // 
            this.lblTeamScore.AutoSize = true;
            this.lblTeamScore.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamScore.Location = new System.Drawing.Point(371, 173);
            this.lblTeamScore.Name = "lblTeamScore";
            this.lblTeamScore.Size = new System.Drawing.Size(116, 34);
            this.lblTeamScore.TabIndex = 51;
            this.lblTeamScore.Text = "Team Score";
            // 
            // lblOppTeamScore
            // 
            this.lblOppTeamScore.AutoSize = true;
            this.lblOppTeamScore.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOppTeamScore.Location = new System.Drawing.Point(656, 173);
            this.lblOppTeamScore.Name = "lblOppTeamScore";
            this.lblOppTeamScore.Size = new System.Drawing.Size(116, 34);
            this.lblOppTeamScore.TabIndex = 52;
            this.lblOppTeamScore.Text = "Team Score";
            // 
            // lblWorL
            // 
            this.lblWorL.AutoSize = true;
            this.lblWorL.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorL.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblWorL.Location = new System.Drawing.Point(381, 207);
            this.lblWorL.Name = "lblWorL";
            this.lblWorL.Size = new System.Drawing.Size(95, 34);
            this.lblWorL.TabIndex = 53;
            this.lblWorL.Text = "Win/Loss";
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Location = new System.Drawing.Point(47, 28);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(245, 243);
            this.pictureBoxPlayer.TabIndex = 1;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // comboBoxGameSelect
            // 
            this.comboBoxGameSelect.FormattingEnabled = true;
            this.comboBoxGameSelect.Items.AddRange(new object[] {
            "Overall",
            "By Game"});
            this.comboBoxGameSelect.Location = new System.Drawing.Point(662, 90);
            this.comboBoxGameSelect.Name = "comboBoxGameSelect";
            this.comboBoxGameSelect.Size = new System.Drawing.Size(220, 28);
            this.comboBoxGameSelect.TabIndex = 54;
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(612, 28);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(44, 24);
            this.lblView.TabIndex = 55;
            this.lblView.Text = "View:";
            // 
            // lblGameSelect
            // 
            this.lblGameSelect.AutoSize = true;
            this.lblGameSelect.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameSelect.Location = new System.Drawing.Point(658, 67);
            this.lblGameSelect.Name = "lblGameSelect";
            this.lblGameSelect.Size = new System.Drawing.Size(119, 20);
            this.lblGameSelect.TabIndex = 56;
            this.lblGameSelect.Text = "Please select a game:";
            // 
            // frmPlayerStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 587);
            this.Controls.Add(this.lblGameSelect);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.comboBoxGameSelect);
            this.Controls.Add(this.lblWorL);
            this.Controls.Add(this.lblOppTeamScore);
            this.Controls.Add(this.lblTeamScore);
            this.Controls.Add(this.lblOppTeam);
            this.Controls.Add(this.lblVs);
            this.Controls.Add(this.lblGameDate);
            this.Controls.Add(this.textBoxPTS);
            this.Controls.Add(this.textBoxPF);
            this.Controls.Add(this.textBoxTOV);
            this.Controls.Add(this.textBoxBLK);
            this.Controls.Add(this.textBoxSTL);
            this.Controls.Add(this.textBoxAST);
            this.Controls.Add(this.textBoxTRB);
            this.Controls.Add(this.textBoxORB);
            this.Controls.Add(this.textBoxDRB);
            this.Controls.Add(this.textBoxFTPercent);
            this.Controls.Add(this.textBoxFT);
            this.Controls.Add(this.textBoxFTA);
            this.Controls.Add(this.textBox3PPercent);
            this.Controls.Add(this.textBoxFGPercent);
            this.Controls.Add(this.textBoxFG);
            this.Controls.Add(this.textBoxFGA);
            this.Controls.Add(this.textBoxMP);
            this.Controls.Add(this.textBox3P);
            this.Controls.Add(this.textBox3PA);
            this.Controls.Add(this.lblPTS);
            this.Controls.Add(this.lblPF);
            this.Controls.Add(this.lblTOV);
            this.Controls.Add(this.lblBLK);
            this.Controls.Add(this.lblSTL);
            this.Controls.Add(this.lblAST);
            this.Controls.Add(this.lblTRB);
            this.Controls.Add(this.lblDRB);
            this.Controls.Add(this.lblORB);
            this.Controls.Add(this.lblFTPercent);
            this.Controls.Add(this.labelFT);
            this.Controls.Add(this.lblFTA);
            this.Controls.Add(this.lbl3PPercent);
            this.Controls.Add(this.lbl3PA);
            this.Controls.Add(this.lbl3P);
            this.Controls.Add(this.lblFGPercent);
            this.Controls.Add(this.lblFG);
            this.Controls.Add(this.lblFGA);
            this.Controls.Add(this.lblMP);
            this.Controls.Add(this.comboBoxViewBy);
            this.Controls.Add(this.lblPlayerTeam);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.lblPlayerName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPlayerStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player Stats";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.Label lblPlayerTeam;
        private System.Windows.Forms.ComboBox comboBoxViewBy;
        private System.Windows.Forms.Label lblMP;
        private System.Windows.Forms.Label lblFGA;
        private System.Windows.Forms.Label lblFG;
        private System.Windows.Forms.Label lblFGPercent;
        private System.Windows.Forms.Label lbl3P;
        private System.Windows.Forms.Label lbl3PA;
        private System.Windows.Forms.Label lbl3PPercent;
        private System.Windows.Forms.Label lblFTA;
        private System.Windows.Forms.Label labelFT;
        private System.Windows.Forms.Label lblFTPercent;
        private System.Windows.Forms.Label lblORB;
        private System.Windows.Forms.Label lblDRB;
        private System.Windows.Forms.Label lblTRB;
        private System.Windows.Forms.Label lblAST;
        private System.Windows.Forms.Label lblSTL;
        private System.Windows.Forms.Label lblBLK;
        private System.Windows.Forms.Label lblTOV;
        private System.Windows.Forms.Label lblPF;
        private System.Windows.Forms.Label lblPTS;
        private System.Windows.Forms.TextBox textBox3PA;
        private System.Windows.Forms.TextBox textBox3P;
        private System.Windows.Forms.TextBox textBoxMP;
        private System.Windows.Forms.TextBox textBoxFGA;
        private System.Windows.Forms.TextBox textBoxFG;
        private System.Windows.Forms.TextBox textBoxFGPercent;
        private System.Windows.Forms.TextBox textBox3PPercent;
        private System.Windows.Forms.TextBox textBoxFTA;
        private System.Windows.Forms.TextBox textBoxFT;
        private System.Windows.Forms.TextBox textBoxFTPercent;
        private System.Windows.Forms.TextBox textBoxDRB;
        private System.Windows.Forms.TextBox textBoxORB;
        private System.Windows.Forms.TextBox textBoxTRB;
        private System.Windows.Forms.TextBox textBoxAST;
        private System.Windows.Forms.TextBox textBoxSTL;
        private System.Windows.Forms.TextBox textBoxBLK;
        private System.Windows.Forms.TextBox textBoxTOV;
        private System.Windows.Forms.TextBox textBoxPF;
        private System.Windows.Forms.TextBox textBoxPTS;
        private System.Windows.Forms.Label lblGameDate;
        private System.Windows.Forms.Label lblVs;
        private System.Windows.Forms.Label lblOppTeam;
        private System.Windows.Forms.Label lblTeamScore;
        private System.Windows.Forms.Label lblOppTeamScore;
        private System.Windows.Forms.Label lblWorL;
        private System.Windows.Forms.ComboBox comboBoxGameSelect;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Label lblGameSelect;
    }
}