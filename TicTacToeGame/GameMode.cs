using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class GameMode : Form
    {
        public GameMode()
        {
            InitializeComponent();
        }
        
        ///<summary>
        ///Event Handler envoked when the GameMode screen is loaded
        ///</summary>
        private void GameMode_Load(object sender, EventArgs e)
        {
            player1StartingPiece.SelectedIndex = 0;
            player2StartingPiece.SelectedIndex = 1;
            player1GameMode.SelectedIndex = 0;
            player2GameMode.SelectedIndex = 0;
        }

        ///<summary>
        ///Event Handler envoked when cancelButton clicked
        ///</summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            using (WelcomeScreen welcomeScreen = new WelcomeScreen())
            {
                this.Hide();
                welcomeScreen.ShowDialog();
                this.Close(); 
            }
        }

        ///<summary>
        ///Event Handler envoked when the createButton clicked 
        ///</summary>
        private void createButton_Click(object sender, EventArgs e)
        {
            if (player1StartingPiece.SelectedIndex == -1 ||
                player2StartingPiece.SelectedIndex == -1 ||
                player1GameMode.SelectedIndex == -1 ||
                player2GameMode.SelectedIndex == -1)
            {
                MessageBox.Show("All dropdowns must be populated");
            }
            else
            {
                Options.setPlayer1GameMode(player1GameMode.SelectedIndex);
                Options.setPlayer2GameMode(player2GameMode.SelectedIndex);
                Options.setPlayer1StartingPiece(player1StartingPiece.SelectedIndex);
                Options.setPlayer2StartingPiece(player2StartingPiece.SelectedIndex); 

                using (GameScreen gameScreen = new GameScreen())
                {
                    this.Hide();
                    gameScreen.ShowDialog();
                    this.Close();
                }
            }
        }

        ///<summary>
        ///Event Handler envoked when the player1StartingPiece is selected
        ///</summary>
        private void player1StartingPiece_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set the player2StartingPiece to the opposite of the player1StartingPiece
            if (player1StartingPiece.SelectedIndex == 0) 
            {
                player2StartingPiece.SelectedIndex = 1; 
            }
            else
            {
                player2StartingPiece.SelectedIndex = 0;
            }
        }

        ///<summary>
        ///Event Handler envoked when the player2StartingPiece is selected
        ///</summary>
        private void player2StartingPiece_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set the player1StartingPiece to the opposite of the player2StartingPiece
            if (player2StartingPiece.SelectedIndex == 0)
            {
                player1StartingPiece.SelectedIndex = 1;
            }
            else
            {
                player1StartingPiece.SelectedIndex = 0;
            }
        }

    }
}
