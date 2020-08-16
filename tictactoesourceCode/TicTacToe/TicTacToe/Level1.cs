using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class Level1:  Levels
    {
     
    
        public Level1(bool[] array, String[,] xos)
    
        {
           
            base.setBoolArray(array);
            base.setXOs(xos);

        }
        public int makeComputerPlayerMove()
        {
            Random rand = new Random();
           
            bool[] array = base.getBoolArray();
            String[,] xos = base.getXOs();
            
            bool ind = false;
            int tempNum = 0;

            int number = rand.Next(9) + 1;

            while (!ind)
            {
                if (number == 1 && array[0] == false)
                {
                    ind = true;
                    array[0] = true;
                    xos[0,0] = "o";
                    tempNum = number;
                }
                else if (number == 2 && array[1] == false)
                {
                    ind = true;
                    array[1] = true;
                    xos[0,1] = "o";
                    tempNum = number;
                }
                else if (number == 3 && array[2] == false)
                {
                    ind = true;
                    array[2] = true;
                    xos[0,2] = "o";
                    tempNum = number;
                }
                else if (number == 4 && array[3] == false)
                {
                    ind = true;
                    array[3] = true;
                    xos[1,0] = "o";
                    tempNum = number;
                }
                else if (number == 5 && array[4] == false)
                {
                    ind = true;
                    array[4] = true;
                    xos[1,1] = "o";
                    tempNum = number;
                }
                else if (number == 6 && array[5] == false)
                {
                    ind = true;
                    array[5] = true;
                    xos[1,2] = "o";
                    tempNum = number;
                }
                else if (number == 7 && array[6] == false)
                {
                    ind = true;
                    array[6] = true;
                    xos[2,0] = "o";
                    tempNum = number;
                }
                else if (number == 8 && array[7] == false)
                {
                    ind = true;
                    array[7] = true;
                    xos[2,1] = "o";
                    tempNum = number;
                }
                else if (number == 9 && array[8] == false)
                {
                    ind = true;
                    array[8] = true;
                    xos[2,2] = "o";
                    tempNum = number;
                }
                number = rand.Next(9) + 1;
                
            }//end of while statement
            base.setBoolArray(array);
            base.setXOs(xos);
            return tempNum;
        }
       
    }//end of class
   
   
}
