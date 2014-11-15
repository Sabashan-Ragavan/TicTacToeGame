using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    ///<summary>
    ///Class holds information slected from the GameMode screen 
    ///</summary>
    class Options
    {
        private static string player1GameMode;
        private static string player2GameMode;
        private static string player1StartingPiece;
        private static string player2StartingPiece;

        public static string getPlayer1GameMode()
        {
            return player1GameMode; 
        }

        public static string getPlayer2GameMode()
        {
            return player2GameMode;
        }

        public static string getPlayer1StartingPiece()
        {
            return player1StartingPiece;
        }

        public static string getPlayer2StartingPiece()
        {
            return player2StartingPiece;
        }

        public static void setPlayer1GameMode(int value)
        {
            if (value == 0)
                player1GameMode = "PVP";
            else if (value == 1)
                player1GameMode = "PVE";
        }

        public static void setPlayer2GameMode(int value)
        {
            if (value == 0)
                player2GameMode = "PVP";
            else if (value == 1)
                player2GameMode = "PVE";
        }

        public static void setPlayer1StartingPiece(int value)
        {
            if (value == 0)
                player1StartingPiece = "X";
            else if (value == 1)
                player1StartingPiece = "O";
        }

        public static void setPlayer2StartingPiece(int value)
        {
            if (value == 0)
                player2StartingPiece = "X";
            else if (value == 1)
                player2StartingPiece = "O";
        }
    }
}
