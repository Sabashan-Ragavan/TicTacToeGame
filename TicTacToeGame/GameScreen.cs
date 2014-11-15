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
    public partial class GameScreen : Form
    {
        int player1Wins = 0;
        int player2Wins = 0;
        int drawCount = 0;
        int tilesUsedCount = 0;
        bool isPlayer1turn; 
        Button[,] gameButton = new Button[3,3];

        public GameScreen()
        {
            InitializeComponent();
        }

        ///<summary>
        ///Event Handler envoked when the GameScreen loads 
        ///</summary>
        private void GameScreen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gameButton.GetLength(0); i++)
            {
                for (int j = 0; j < gameButton.GetLength(1); j++)
                {
                    //Set up each gameButton
                    gameButton[i, j] = new Button();
                    gameButton[i, j].Width = 80;
                    gameButton[i, j].Height = 80;
                    gameButton[i, j].Click += new EventHandler(gameButton_Click);

                    flowLayoutPanel1.Controls.Add(gameButton[i, j]);
                }
            }

            winnerLabel.Text = "P1's Turn";
            isPlayer1turn = true; 
        }

        ///<summary>
        ///Event Handler envoked when a GameButton is clicked
        ///</summary>
        void gameButton_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            if (isPlayer1turn)
            {
                bt.Text = Options.getPlayer1StartingPiece();
                isPlayer1turn = false;
                winnerLabel.Text = "P2's Turn";
            }
            else
            {
                bt.Text = Options.getPlayer2StartingPiece();
                isPlayer1turn = true;
                winnerLabel.Text = "P1's Turn";
            }

            bt.Enabled = false;
            tilesUsedCount++;
            bool checkForWinFlag = checkForWin();

            if (!isPlayer1turn && !checkForWinFlag && Options.getPlayer2GameMode() == "PVE") //AI's turn
            {
                if (!aiTurn(true)) //First try if the AI can win the game
                    if (!aiTurn(false)) //If not then block the opponent from winning (in at least one way)
                        aiNeutral(); //If nothing to block then play neutral move

                isPlayer1turn = true;
                winnerLabel.Text = "P1's Turn";
                tilesUsedCount++;
                checkForWinFlag = checkForWin();
            }

            if (tilesUsedCount >= 9 && !checkForWinFlag) //Case where a draw game has occured
            {
                winnerLabel.Text = "Draw Game";
                drawCount++;
                drawsCount.Text = drawCount.ToString();
                showScoreBar(); 
            }
        }

        ///<summary>
        ///Event Handler envoked when rematchButton clicked
        ///</summary>
        private void rematchButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        ///<summary>
        ///Event Handler envoked when backButton clicked
        ///</summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            using (GameMode gameMode = new GameMode())
            {
                this.Hide();
                gameMode.ShowDialog();
                this.Close();
            }
        }

        ///<summary>
        ///Function resets the GameScreen back to start 
        ///</summary>
        void reset()
        {
            for (int i = 0; i < gameButton.GetLength(0); i++)
            {
                for (int j = 0; j < gameButton.GetLength(1); j++)
                {
                    gameButton[i, j].Enabled = true;
                    gameButton[i, j].Text = "";
                    tilesUsedCount = 0;
                }
            }

            winnerLabel.Text = "P1's Turn";
            isPlayer1turn = true;
            hideScoreBar(); 
        }

        ///<summary>
        ///Function disables all the GameButtons
        ///</summary>
        void disableAll()
        {
            for (int i = 0; i < gameButton.GetLength(0); i++)
            {
                for (int j = 0; j < gameButton.GetLength(1); j++)
                {
                    gameButton[i, j].Enabled = false;
                }
            }
        }

        ///<summary>
        ///Function checks for any posssible way which they can either win the game or not allow 
        ///the opponent to win the game based on if a true of false is passed in respectively. 
        ///</summary>
        bool aiTurn(bool winTheGame)
        {
            string player1StartingPiece, player2StartingPiece;
            if (winTheGame)
            {
                player1StartingPiece = Options.getPlayer2StartingPiece();
                player2StartingPiece = Options.getPlayer2StartingPiece();
            }
            else
            {
                player1StartingPiece = Options.getPlayer1StartingPiece();
                player2StartingPiece = Options.getPlayer2StartingPiece();
            }

            if (gameButton[0, 0].Text == player1StartingPiece && gameButton[0, 1].Text == player1StartingPiece && gameButton[0, 2].Text == "")
            {
                gameButton[0, 2].Text = player2StartingPiece;
                gameButton[0, 2].Enabled = false;           
            }
            else if(gameButton[0, 1].Text == player1StartingPiece && gameButton[0, 2].Text  == player1StartingPiece && gameButton[0, 0].Text == "")
            {
                gameButton[0, 0].Text = player2StartingPiece;
                gameButton[0, 0].Enabled = false;           
            }
            else if(gameButton[1, 0].Text == player1StartingPiece && gameButton[1, 1].Text == player1StartingPiece && gameButton[1, 2].Text == "")
            {
                gameButton[1, 2].Text =   player2StartingPiece;
                gameButton[1, 2].Enabled = false;           
            }
            else if(gameButton[1, 1].Text == player1StartingPiece  && gameButton[1, 2].Text == player1StartingPiece && gameButton[1, 0].Text == "" )
            {
                gameButton[1, 0].Text = player2StartingPiece;
                gameButton[1, 0].Enabled = false;           

            }
            else if(gameButton[2, 0].Text == player1StartingPiece  && gameButton[2, 1].Text == player1StartingPiece && gameButton[2, 2].Text == "" )
            {
                gameButton[2, 2].Text = player2StartingPiece;
                gameButton[2, 2].Enabled = false;           

            }
            else if(gameButton[2, 1].Text == player1StartingPiece  && gameButton[2, 2].Text == player1StartingPiece && gameButton[2, 0].Text == "" )
            {
                gameButton[2, 0].Text = player2StartingPiece;
                gameButton[2, 0].Enabled = false;           

            }
            else if(gameButton[0, 0].Text == player1StartingPiece  && gameButton[1, 1].Text == player1StartingPiece && gameButton[2, 2].Text == "" )
            {
                gameButton[2, 2].Text = player2StartingPiece;
                gameButton[2, 2].Enabled = false;           

            }
            else if(gameButton[1, 1].Text == player1StartingPiece  && gameButton[2, 2].Text == player1StartingPiece && gameButton[0, 0].Text == "" )
            {
                gameButton[0, 0].Text = player2StartingPiece;
                gameButton[0, 0].Enabled = false;           

            }
            else if(gameButton[0, 2].Text == player1StartingPiece  && gameButton[1, 1].Text == player1StartingPiece && gameButton[2, 0].Text == "" )
            {
                gameButton[2, 0].Text = player2StartingPiece;
                gameButton[2, 0].Enabled = false;           

            }
            else if(gameButton[2, 0].Text == player1StartingPiece  && gameButton[1, 1].Text == player1StartingPiece && gameButton[0, 2].Text == "" )
            {
                gameButton[0, 2].Text = player2StartingPiece;
                gameButton[0, 2].Enabled = false;           

            }
            else if(gameButton[0, 0].Text == player1StartingPiece  && gameButton[0, 2].Text == player1StartingPiece && gameButton[0, 1].Text == "" )
            {
                gameButton[0, 1].Text = player2StartingPiece;
                gameButton[0, 1].Enabled = false;           

            }
            else if(gameButton[1, 0].Text == player1StartingPiece  && gameButton[1, 2].Text == player1StartingPiece && gameButton[1, 1].Text == "" )
            {
                gameButton[1, 1].Text = player2StartingPiece;
                gameButton[1, 1].Enabled = false;           

            }
            else if(gameButton[2, 0].Text == player1StartingPiece  && gameButton[2, 2].Text == player1StartingPiece && gameButton[2, 1].Text == "" )
            {
                gameButton[2, 1].Text = player2StartingPiece;
                gameButton[2, 1].Enabled = false;           

            }
            else if(gameButton[0, 0].Text == player1StartingPiece  && gameButton[2, 0].Text == player1StartingPiece && gameButton[1, 0].Text == "" )
            {
                gameButton[1, 0].Text = player2StartingPiece;
                gameButton[1, 0].Enabled = false;           

            }
            else if(gameButton[0, 1].Text == player1StartingPiece  && gameButton[2, 1].Text == player1StartingPiece && gameButton[1, 1].Text == "" )
            {
                gameButton[1, 1].Text = player2StartingPiece;
                gameButton[1, 1].Enabled = false;           

            }
            else if(gameButton[0, 2].Text == player1StartingPiece  && gameButton[2, 2].Text == player1StartingPiece && gameButton[1, 2].Text == "" )
            {
                gameButton[1, 2].Text = player2StartingPiece;
                gameButton[1, 2].Enabled = false;           

            }
            else if(gameButton[0, 0].Text == player1StartingPiece  && gameButton[1, 1].Text == player1StartingPiece && gameButton[2, 2].Text == "" )
            {
                gameButton[2, 2].Text = player2StartingPiece;
                gameButton[2, 2].Enabled = false;           

            }
            else if(gameButton[1, 0].Text == player1StartingPiece  && gameButton[2, 0].Text == player1StartingPiece && gameButton[0, 0].Text == "" )
            {
                gameButton[0, 0].Text = player2StartingPiece;
                gameButton[0, 0].Enabled = false;           

            }
            else if(gameButton[1, 1].Text == player1StartingPiece  && gameButton[2, 1].Text == player1StartingPiece && gameButton[0, 1].Text == "" )
            {
                gameButton[0, 1].Text = player2StartingPiece;
                gameButton[0, 1].Enabled = false;           

            }
            else if(gameButton[1, 2].Text == player1StartingPiece  && gameButton[2, 2].Text == player1StartingPiece && gameButton[0, 2].Text == "" )
            {
                gameButton[0, 2].Text = player2StartingPiece;
                gameButton[0, 2].Enabled = false;           

            }
            else if(gameButton[0, 0].Text == player1StartingPiece  && gameButton[1, 0].Text == player1StartingPiece && gameButton[2, 0].Text == "" )
            {
                gameButton[2, 0].Text = player2StartingPiece;
                gameButton[2, 0].Enabled = false;           

            }
            else if(gameButton[0, 1].Text == player1StartingPiece  && gameButton[1, 1].Text == player1StartingPiece && gameButton[2, 1].Text == "" )
            {
                gameButton[2, 1].Text = player2StartingPiece;
                gameButton[2, 1].Enabled = false;           

            }
            else if(gameButton[0, 2].Text == player1StartingPiece  && gameButton[1, 2].Text == player1StartingPiece && gameButton[2, 2].Text == "" )
            {
                gameButton[2, 2].Text = player2StartingPiece;
                gameButton[2, 2].Enabled = false;           

            }
            else if(gameButton[0, 0].Text == player1StartingPiece  && gameButton[2, 2].Text == player1StartingPiece && gameButton[1, 1].Text == "" )
            {
                gameButton[1, 1].Text = player2StartingPiece;
                gameButton[1, 1].Enabled = false;           

            }
            else if (gameButton[0, 2].Text == player1StartingPiece && gameButton[2, 0].Text == player1StartingPiece && gameButton[1, 1].Text == "")
            {
                gameButton[0, 2].Text = player2StartingPiece;
                gameButton[0, 2].Enabled = false;
            }
            else
            {
                return false; 
            }
            return true; 
        }

        ///<summary>
        ///Function will play a neutral move if it cannot win the game or does not need to 
        ///stop their opponent form winning. Attempts to place piece first in the middle, 
        ///then the corner,then the opposite corner, then the empty corner and lastly
        ///the empty side if the position is already full. 
        ///</summary>
        void aiNeutral()
        { 
            if(gameButton[1, 1].Text == "")
            {
                gameButton[1, 1].Text = Options.getPlayer2StartingPiece();
                gameButton[1, 1].Enabled = false;           
            }
            else if(gameButton[0, 0].Text == "")
            {
                gameButton[0, 0].Text = Options.getPlayer2StartingPiece();
                gameButton[0, 0].Enabled = false;           
            }
            else if(gameButton[2, 2].Text == "")
            {
                gameButton[2, 2].Text = Options.getPlayer2StartingPiece();
                gameButton[2, 2].Enabled = false;           
            }
            else if(gameButton[1, 2].Text == "")
            {
                gameButton[1, 2].Text = Options.getPlayer2StartingPiece();
                gameButton[1, 2].Enabled = false;           
            }
            else if(gameButton[0, 1].Text == "")
            {
                gameButton[0, 1].Text = Options.getPlayer2StartingPiece();
                gameButton[0, 1].Enabled = false;           
            }
            else if(gameButton[2, 1].Text == "")
            {
                gameButton[2, 1].Text = Options.getPlayer2StartingPiece();
                gameButton[2, 1].Enabled = false;           
            }
            else if(gameButton[0, 2].Text == "")
            {
                gameButton[0, 2].Text = Options.getPlayer2StartingPiece();
                gameButton[0, 2].Enabled = false;           
            }
            else if(gameButton[2, 0].Text == "")
            {
                gameButton[2, 0].Text = Options.getPlayer2StartingPiece();
                gameButton[2, 0].Enabled = false;           
            }
            else if(gameButton[1, 0].Text == "")
            {
                gameButton[1, 0].Text = Options.getPlayer2StartingPiece();
                gameButton[1, 0].Enabled = false;           
            }
        }

        ///<summary>
        ///Function checks if someone has won the game 
        ///</summary>
        bool checkForWin() 
        {
            for (int i = 0; i < gameButton.GetLength(0); i++)
            {
                //Make the check if someone has won horizontally (i.e a row)
                if (gameButton[i, 0].Text == gameButton[i, 1].Text && gameButton[i, 1].Text == gameButton[i, 2].Text && gameButton[i, 0].Text != "") 
                {
                    if (gameButton[i, 0].Text == Options.getPlayer1StartingPiece())
                    {
                        player1Wins++;
                        player1WinCount.Text = player1Wins.ToString();
                        winnerLabel.Text = "P1 is the Winner";
                    }
                    else
                    {
                        player2Wins++;
                        player2WinCount.Text = player2Wins.ToString();
                        winnerLabel.Text = "P2 is the Winner";

                    }
                    showScoreBar(); 
                    return true; 
                }

                //Make the check if someone has won vertically (i.e a column)
                if (gameButton[0, i].Text == gameButton[1, i].Text && gameButton[1, i].Text == gameButton[2, i].Text && gameButton[0, i].Text != "") 
                {
                    if (gameButton[0, i].Text == Options.getPlayer1StartingPiece())
                    {
                        player1Wins++;
                        player1WinCount.Text = player1Wins.ToString();
                        winnerLabel.Text = "P1 is the Winner";
                    }
                    else
                    {
                        player2Wins++;
                        player2WinCount.Text = player2Wins.ToString();
                        winnerLabel.Text = "P2 is the Winner";
                    }
                    showScoreBar(); 
                    return true; 
                }
            }

            //Check if someone won diagonally (top left to bottom right)
            if (gameButton[0, 0].Text == gameButton[1, 1].Text && gameButton[1, 1].Text == gameButton[2, 2].Text && gameButton[0, 0].Text != "") 
            {

                if (gameButton[0, 0].Text == Options.getPlayer1StartingPiece())
                {
                    player1Wins++;
                    player1WinCount.Text = player1Wins.ToString(); 
                    winnerLabel.Text = "P1 is the Winner";

                }
                else
                {
                    player2Wins++;
                    player2WinCount.Text = player2Wins.ToString();
                    winnerLabel.Text = "P2 is the Winner";

                }
                showScoreBar(); 
                return true; 

            }

            //Check if someone won diagonally (bottom left to top right) 
            if (gameButton[2, 0].Text == gameButton[1, 1].Text && gameButton[1, 1].Text == gameButton[0, 2].Text && gameButton[2, 0].Text != "") //Diagonal Check (bottom left to top right) 
            {
                if (gameButton[2, 0].Text == Options.getPlayer1StartingPiece())
                {
                    player1Wins++;
                    player1WinCount.Text = player1Wins.ToString();
                    winnerLabel.Text = "P1 is the Winner"; 

                }
                else
                {
                    player2Wins++;
                    player2WinCount.Text = player2Wins.ToString();
                    winnerLabel.Text = "P2 is the Winner";

                }
                showScoreBar(); 
                return true;             
            }
            return false; 
        }

        ///<summary>
        ///Function shows the score bar
        ///</summary>
        void showScoreBar()
        {
            disableAll();
            rematchButton.Visible = true;
            backButton.Visible = true;
            player1Win.Visible = true;
            player2Win.Visible = true;
            draw.Visible = true;
            player1WinCount.Visible = true;
            player2WinCount.Visible = true;
            drawsCount.Visible = true; 
        }

        ///<summary>
        ///Function hides the score bar
        ///</summary>
        void hideScoreBar()
        {
            rematchButton.Visible = false;
            backButton.Visible = false;
            player1Win.Visible = false;
            player2Win.Visible = false;
            draw.Visible = false;
            player1WinCount.Visible = false;
            player2WinCount.Visible = false;
            drawsCount.Visible = false; 
        }

    }
}
