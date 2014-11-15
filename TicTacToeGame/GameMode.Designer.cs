namespace TicTacToeGame
{
    partial class GameMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMode));
            this.label1 = new System.Windows.Forms.Label();
            this.player1GameMode = new System.Windows.Forms.ComboBox();
            this.player2GameMode = new System.Windows.Forms.ComboBox();
            this.player2StartingPiece = new System.Windows.Forms.ComboBox();
            this.player1StartingPiece = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lato Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(99, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1GameMode
            // 
            this.player1GameMode.FormattingEnabled = true;
            this.player1GameMode.Items.AddRange(new object[] {
            "PVP"});
            this.player1GameMode.Location = new System.Drawing.Point(93, 106);
            this.player1GameMode.Name = "player1GameMode";
            this.player1GameMode.Size = new System.Drawing.Size(58, 21);
            this.player1GameMode.TabIndex = 3;
            // 
            // player2GameMode
            // 
            this.player2GameMode.FormattingEnabled = true;
            this.player2GameMode.Items.AddRange(new object[] {
            "PVP",
            "PVE"});
            this.player2GameMode.Location = new System.Drawing.Point(256, 106);
            this.player2GameMode.Name = "player2GameMode";
            this.player2GameMode.Size = new System.Drawing.Size(57, 21);
            this.player2GameMode.TabIndex = 4;
            // 
            // player2StartingPiece
            // 
            this.player2StartingPiece.FormattingEnabled = true;
            this.player2StartingPiece.Items.AddRange(new object[] {
            "X",
            "O"});
            this.player2StartingPiece.Location = new System.Drawing.Point(256, 239);
            this.player2StartingPiece.Name = "player2StartingPiece";
            this.player2StartingPiece.Size = new System.Drawing.Size(58, 21);
            this.player2StartingPiece.TabIndex = 7;
            this.player2StartingPiece.SelectedIndexChanged += new System.EventHandler(this.player2StartingPiece_SelectedIndexChanged);
            // 
            // player1StartingPiece
            // 
            this.player1StartingPiece.FormattingEnabled = true;
            this.player1StartingPiece.Items.AddRange(new object[] {
            "X",
            "O"});
            this.player1StartingPiece.Location = new System.Drawing.Point(93, 239);
            this.player1StartingPiece.Name = "player1StartingPiece";
            this.player1StartingPiece.Size = new System.Drawing.Size(59, 21);
            this.player1StartingPiece.TabIndex = 6;
            this.player1StartingPiece.SelectedIndexChanged += new System.EventHandler(this.player1StartingPiece_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lato Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(88, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Starting Piece";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.Location = new System.Drawing.Point(53, 328);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(121, 37);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createButton.BackgroundImage")));
            this.createButton.Location = new System.Drawing.Point(179, 328);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(121, 37);
            this.createButton.TabIndex = 9;
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Player 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lato Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Player 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lato Black", 8.25F);
            this.label5.Location = new System.Drawing.Point(41, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Player 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lato Black", 8.25F);
            this.label6.Location = new System.Drawing.Point(203, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Player 2:";
            // 
            // GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(344, 442);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.player2StartingPiece);
            this.Controls.Add(this.player1StartingPiece);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.player2GameMode);
            this.Controls.Add(this.player1GameMode);
            this.Controls.Add(this.label1);
            this.Name = "GameMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GameMode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox player1GameMode;
        private System.Windows.Forms.ComboBox player2GameMode;
        private System.Windows.Forms.ComboBox player2StartingPiece;
        private System.Windows.Forms.ComboBox player1StartingPiece;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}