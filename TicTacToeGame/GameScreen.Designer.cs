namespace TicTacToeGame
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.rematchButton = new System.Windows.Forms.Button();
            this.player1Win = new System.Windows.Forms.Label();
            this.player2Win = new System.Windows.Forms.Label();
            this.player1WinCount = new System.Windows.Forms.Label();
            this.player2WinCount = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.draw = new System.Windows.Forms.Label();
            this.drawsCount = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rematchButton
            // 
            this.rematchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rematchButton.BackgroundImage")));
            this.rematchButton.Location = new System.Drawing.Point(73, 364);
            this.rematchButton.Name = "rematchButton";
            this.rematchButton.Size = new System.Drawing.Size(152, 34);
            this.rematchButton.TabIndex = 0;
            this.rematchButton.UseVisualStyleBackColor = true;
            this.rematchButton.Visible = false;
            this.rematchButton.Click += new System.EventHandler(this.rematchButton_Click);
            // 
            // player1Win
            // 
            this.player1Win.BackColor = System.Drawing.Color.Transparent;
            this.player1Win.Font = new System.Drawing.Font("Lato Black", 8.25F);
            this.player1Win.Location = new System.Drawing.Point(39, 19);
            this.player1Win.Name = "player1Win";
            this.player1Win.Size = new System.Drawing.Size(53, 13);
            this.player1Win.TabIndex = 1;
            this.player1Win.Text = "P1 Wins:";
            this.player1Win.Visible = false;
            // 
            // player2Win
            // 
            this.player2Win.BackColor = System.Drawing.Color.Transparent;
            this.player2Win.Font = new System.Drawing.Font("Lato Black", 8.25F);
            this.player2Win.Location = new System.Drawing.Point(124, 19);
            this.player2Win.Name = "player2Win";
            this.player2Win.Size = new System.Drawing.Size(53, 13);
            this.player2Win.TabIndex = 3;
            this.player2Win.Text = "P2 Wins:";
            this.player2Win.Visible = false;
            // 
            // player1WinCount
            // 
            this.player1WinCount.BackColor = System.Drawing.Color.Transparent;
            this.player1WinCount.Font = new System.Drawing.Font("Lato Black", 8.25F);
            this.player1WinCount.Location = new System.Drawing.Point(95, 19);
            this.player1WinCount.Name = "player1WinCount";
            this.player1WinCount.Size = new System.Drawing.Size(20, 13);
            this.player1WinCount.TabIndex = 4;
            this.player1WinCount.Text = "0";
            this.player1WinCount.Visible = false;
            // 
            // player2WinCount
            // 
            this.player2WinCount.BackColor = System.Drawing.Color.Transparent;
            this.player2WinCount.Font = new System.Drawing.Font("Lato Black", 8.25F);
            this.player2WinCount.Location = new System.Drawing.Point(183, 19);
            this.player2WinCount.Name = "player2WinCount";
            this.player2WinCount.Size = new System.Drawing.Size(20, 13);
            this.player2WinCount.TabIndex = 5;
            this.player2WinCount.Text = "0";
            this.player2WinCount.Visible = false;
            // 
            // winnerLabel
            // 
            this.winnerLabel.BackColor = System.Drawing.Color.Transparent;
            this.winnerLabel.Font = new System.Drawing.Font("Lato Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.Location = new System.Drawing.Point(69, 46);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(176, 29);
            this.winnerLabel.TabIndex = 6;
            this.winnerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(270, 270);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // draw
            // 
            this.draw.BackColor = System.Drawing.Color.Transparent;
            this.draw.Font = new System.Drawing.Font("Lato Black", 8.25F);
            this.draw.Location = new System.Drawing.Point(209, 19);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(45, 13);
            this.draw.TabIndex = 8;
            this.draw.Text = "Draws: ";
            this.draw.Visible = false;
            // 
            // drawsCount
            // 
            this.drawsCount.BackColor = System.Drawing.Color.Transparent;
            this.drawsCount.Font = new System.Drawing.Font("Lato Black", 8.25F);
            this.drawsCount.Location = new System.Drawing.Point(260, 19);
            this.drawsCount.Name = "drawsCount";
            this.drawsCount.Size = new System.Drawing.Size(20, 13);
            this.drawsCount.TabIndex = 9;
            this.drawsCount.Text = "0";
            this.drawsCount.Visible = false;
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.Location = new System.Drawing.Point(131, 404);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(52, 34);
            this.backButton.TabIndex = 10;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.drawsCount);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.player2WinCount);
            this.Controls.Add(this.player1WinCount);
            this.Controls.Add(this.player2Win);
            this.Controls.Add(this.player1Win);
            this.Controls.Add(this.rematchButton);
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rematchButton;
        private System.Windows.Forms.Label player1Win;
        private System.Windows.Forms.Label player2Win;
        private System.Windows.Forms.Label player1WinCount;
        private System.Windows.Forms.Label player2WinCount;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label draw;
        private System.Windows.Forms.Label drawsCount;
        private System.Windows.Forms.Button backButton;
    }
}