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
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.scoreButton.Location = new System.Drawing.Point(91, -1);
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
            this.ScoreBoard.Location = new System.Drawing.Point(257, 29);
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
            // DolditMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1074, 586);
            this.Controls.Add(this.ScoreBoard);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.playButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "DolditMan";
            this.Text = "DolditMan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DolditMan_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.DataGridView ScoreBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCORE;
    }
}

