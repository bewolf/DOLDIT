namespace DolditMan
{
    partial class DolditMan
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
            this.playButton = new System.Windows.Forms.Button();
            this.scoreButton = new System.Windows.Forms.Button();
            this.ScoreBoard = new System.Windows.Forms.DataGridView();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCORE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.yourScoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.characterSelection = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playButton.Location = new System.Drawing.Point(2, -1);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(92, 24);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // scoreButton
            // 
            this.scoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreButton.Location = new System.Drawing.Point(453, -2);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(96, 24);
            this.scoreButton.TabIndex = 2;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // ScoreBoard
            // 
            this.ScoreBoard.BackgroundColor = System.Drawing.Color.White;
            this.ScoreBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoreBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAME,
            this.SCORE});
            this.ScoreBoard.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ScoreBoard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ScoreBoard.Location = new System.Drawing.Point(221, 29);
            this.ScoreBoard.Name = "ScoreBoard";
            this.ScoreBoard.Size = new System.Drawing.Size(544, 520);
            this.ScoreBoard.TabIndex = 3;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NAME.Width = 250;
            // 
            // SCORE
            // 
            this.SCORE.HeaderText = "SCORE";
            this.SCORE.Name = "SCORE";
            this.SCORE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SCORE.Width = 250;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLabel.Location = new System.Drawing.Point(100, 4);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(43, 13);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "Name:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(149, 1);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 6;
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Showcard Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(319, 130);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(393, 79);
            this.gameOverLabel.TabIndex = 7;
            this.gameOverLabel.Text = "GAME OVER";
            this.gameOverLabel.Visible = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(193, 248);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(344, 60);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "YOUR SCORE:";
            this.scoreLabel.Visible = false;
            // 
            // yourScoreLabel
            // 
            this.yourScoreLabel.AutoSize = true;
            this.yourScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.yourScoreLabel.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourScoreLabel.Location = new System.Drawing.Point(601, 248);
            this.yourScoreLabel.Name = "yourScoreLabel";
            this.yourScoreLabel.Size = new System.Drawing.Size(0, 60);
            this.yourScoreLabel.TabIndex = 9;
            this.yourScoreLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(254, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Character:";
            // 
            // characterSelection
            // 
            this.characterSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.characterSelection.FormattingEnabled = true;
            this.characterSelection.Items.AddRange(new object[] {
            "Cartman",
            "Kenny",
            "Kylle",
            "Chef",
            "Stan",
            "Wendy"});
            this.characterSelection.Location = new System.Drawing.Point(326, 2);
            this.characterSelection.Name = "characterSelection";
            this.characterSelection.Size = new System.Drawing.Size(121, 21);
            this.characterSelection.TabIndex = 11;
            this.characterSelection.SelectedIndexChanged += new System.EventHandler(this.characterSelection_SelectedIndexChanged);
            // 
            // DolditMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 586);
            this.Controls.Add(this.characterSelection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yourScoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.ScoreBoard);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.playButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "DolditMan";
            this.Text = "DolditMan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DolditMan_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DolditMan_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DolditMan_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.DataGridView ScoreBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCORE;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label yourScoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox characterSelection;
    }
}

