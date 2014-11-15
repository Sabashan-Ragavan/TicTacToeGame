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
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        ///<summary>
        ///Event Handler envoked when the startNewGameButton is clicked
        ///</summary>
        private void startNewGameButton_Click_1(object sender, EventArgs e)
        {
            using (GameMode gameMode = new GameMode())
            {
                this.Hide();
                gameMode.ShowDialog();
                this.Close(); 
            }
        }
    }
}
