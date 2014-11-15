namespace TicTacToeGame
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.startNewGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startNewGameButton
            // 
            this.startNewGameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startNewGameButton.BackgroundImage")));
            this.startNewGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startNewGameButton.Location = new System.Drawing.Point(36, 50);
            this.startNewGameButton.Name = "startNewGameButton";
            this.startNewGameButton.Size = new System.Drawing.Size(234, 43);
            this.startNewGameButton.TabIndex = 0;
            this.startNewGameButton.UseCompatibleTextRendering = true;
            this.startNewGameButton.UseVisualStyleBackColor = true;
            this.startNewGameButton.Click += new System.EventHandler(this.startNewGameButton_Click_1);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.startNewGameButton);
            this.Name = "WelcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startNewGameButton;

    }
}