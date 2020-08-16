using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TicTacToe
{
    class Levels : Form1
    {
      
        bool[] array = null;
        String[,] xos = null;
        string winner = "";
        
        public Levels()
        {
          
        }
        public int makeComputerPlayerMove()
        {
            return 0;
        }
       
        public void setBoolArray(bool[] array)
        {
            this.array = array;
        }
        public bool[] getBoolArray()
        {
            return array;
        }
        public void setXOs(String[,] xos)
        {
            this.xos = xos;
        }
        public String[,] getXOs()
        {
            return xos;
        }
        public bool didPlayerWin()
        {
            // 0 0  0 1  0 2
            // 1 0  1 1  1 2
            // 2 0  2 1  2 2

            String[,] xos = getXOs();
            bool ind = false;
            
            if(xos[0,0] == "x" && xos[0,1] == "x" && xos[0,2] == "x")
            {
                winner = "Player One Won";
                ind = true;
            }
            else if(xos[1,0] == "x" && xos[1,1] == "x" && xos[1,2] == "x")
            {
                winner = "Player One Won";
                ind = true;
            }
            else if(xos[2,0] == "x" && xos[2,1] == "x" && xos[2,2] == "x")
            {
                winner = "Player One Won";
                ind = true;
            }
            else if(xos[0,0] == "x" && xos[1,0] == "x" && xos[2,0] == "x")
            {
                winner = "Player One Won";
                ind = true;
            }
            else if(xos[0,1] == "x" && xos[1,1] == "x" && xos[2,1] == "x")
            {
                winner = "Player One Won";
                ind = true;
            }
            else if (xos[0,2] == "x" && xos[1,2] == "x" && xos[2,2] == "x")
            {
                winner = "Player One Won";
                ind = true;
            }
            else if(xos[0,0] == "x" && xos[1,1] == "x" && xos[2,2] == "x")
            {
                winner = "Player One Won";
                ind = true;
            }
            else if(xos[0,2] == "x" && xos[1,1] == "x" && xos[2,0] == "x")
            {
                winner = "Player One Won";
                ind = true;
            }
            else if(xos[0,0] != "" && xos[0,1] != "" && xos[0,2] != "" && xos[1,0] != "" && xos[1,1] != "" && xos[1,2] != ""  
                && xos[2,0] != "" && xos[2,1] != "" && xos[2,2] != "")
            {
                winner = "Draw";
                ind = true;
            }
            //add this for a draw
            return ind;
        }
        public bool didComputerPlayerWin()
        {
            // 0 0  0 1  0 2
            // 1 0  1 1  1 2
            // 2 0  2 1  2 2

            String[,] xos = getXOs();
            bool ind = false;


            if (xos[0, 0] == "o" && xos[0, 1] == "o" && xos[0, 2] == "o")
            {
                winner = "Computer Player Won";
                ind = true;
            }
            else if (xos[1, 0] == "o" && xos[1, 1] == "o" && xos[1, 2] == "o")
            {
                winner = "Computer Player Won";
                ind = true;
            }
            else if (xos[2, 0] == "o" && xos[2, 1] == "o" && xos[2, 2] == "o")
            {
                winner = "Computer Player Won";
                ind = true;
            }
            else if (xos[0, 0] == "o" && xos[1, 0] == "o" && xos[2, 0] == "o")
            {
                winner = "Computer Player Won";
                ind = true;
            }
            else if (xos[0, 1] == "o" && xos[1, 1] == "o" && xos[2, 1] == "o")
            {
                winner = "Computer Player Won";
                ind = true;
            }
            else if (xos[0, 2] == "o" && xos[1, 2] == "o" && xos[2, 2] == "o")
            {
                winner = "Computer Player Won";
                ind = true;
            }
            else if (xos[0, 0] == "o" && xos[1, 1] == "o" && xos[2, 2] == "o")
            {
                winner = "Computer Player Won";
                ind = true;
            }
            else if (xos[0, 2] == "o" && xos[1, 1] == "o" && xos[2, 0] == "o")
            {
                winner = "Computer Player Won";
                ind = true;
            }
            else if (xos[0, 0] != "" && xos[0, 1] != "" && xos[0, 2] != "" && xos[1, 0] != "" && xos[1, 1] != "" && xos[1, 2] != ""
                && xos[2, 0] != "" && xos[2, 1] != "" && xos[2, 2] != "")
            {
                winner = "Draw";
                ind = true;
            }
            return ind;

        }
        public string getWinner()
        {
            return winner;
        }

    }
}
