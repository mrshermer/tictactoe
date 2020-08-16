using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Graphics s1 = null, s2 = null, s3 = null, s4 = null, s5 = null, s6 = null,
        s7 = null, s8=null, s9 = null;
        bool[] ifPanelClicked = { false, false, false, false, false, false, false, false, false };
        string[,] xos = {{"", "", "" },
                          { "", "", "" },
                          { "", "", "" }};
        int playerWinNumber = 1, computerWinNumber = 1;
        public Form1()
        {
            
            InitializeComponent();
        
        }
        
   

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
        
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics tictactoeboard = groupBox1.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Red);
            Pen pen = new Pen(brush);

            

            tictactoeboard.DrawLine(pen, 300, 50, 300, 350);
            tictactoeboard.DrawLine(pen, 150, 50, 150, 350);
            tictactoeboard.DrawLine(pen, 30, 250, 400, 250);
            tictactoeboard.DrawLine(pen, 30, 140, 400, 140);

              
        }
        private void drawO(int g)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(brush);
            if (g == 1)
            {
                s1 = Square1.CreateGraphics();
                s1.DrawEllipse(pen,30,25,70,70);
            }
            else if(g == 2)
            {
                s2 = Square2.CreateGraphics();
                s2.DrawEllipse(pen,20,25,70,70);
            }
            else if(g == 3)
            {
                s3 = Square3.CreateGraphics();
                s3.DrawEllipse(pen,10,25,70,70);
            }
            else if(g == 4)
            {
                s4 = Square4.CreateGraphics();
                s4.DrawEllipse(pen, 30, 10, 70, 70);
            }
            else if(g == 5)
            {
                s5 = Square5.CreateGraphics();
                s5.DrawEllipse(pen, 20, 10, 70, 70);
            }
            else if(g == 6)
            {
                s6 = Square6.CreateGraphics();
                s6.DrawEllipse(pen, 10, 10, 70, 70);
            }
            else if(g == 7)
            {
                s7 = Square7.CreateGraphics();
                s7.DrawEllipse(pen, 30, 10, 70, 70);
            }
            else if(g == 8)
            {
                s8 = Square8.CreateGraphics();
                s8.DrawEllipse(pen, 20, 10, 70, 70);
            }
            else if(g == 9)
            {
                s9 = Square9.CreateGraphics();
                s9.DrawEllipse(pen, 10, 10, 70, 70);
            }
        }
        private void computerPlayerMove()
        {
            if (listBox1.SelectedItem.Equals("Level1"))
            {
                Levels lv1 = new Level1(ifPanelClicked, xos);
                Level1 l1 = (Level1)lv1;
                ifPanelClicked = lv1.getBoolArray();
                xos = lv1.getXOs();
                if (!lv1.didPlayerWin())
                {
                    int g = l1.makeComputerPlayerMove();
                    drawO(g);
                    if (lv1.didComputerPlayerWin()&&lv1.getWinner().Equals("Computer Player Won"))
                    {

                        computerWin.Text = computerWinNumber.ToString();
                        computerWinNumber++;
                        disableControls();
                    }
                }
                else
                {
                    if (lv1.getWinner().Equals("Player One Won"))
                    {
                        playerWin.Text = playerWinNumber.ToString();
                        playerWinNumber++;
                        disableControls();
                    }
                    else if (lv1.getWinner().Equals("Draw"))
                    {
                        disableControls();
                    }

                    
                }
            }
            else if (listBox1.SelectedItem.Equals("Level2"))
            {
                Levels lv2 = new Level2(ifPanelClicked, xos);
                Level2 l2 = (Level2)lv2;
                ifPanelClicked = lv2.getBoolArray();
                xos = lv2.getXOs();
                if (!lv2.didPlayerWin())
                {
                    int g = l2.makeComputerPlayerMove();
                    drawO(g);
                    if (lv2.didComputerPlayerWin() && lv2.getWinner().Equals("Computer Player Won"))
                    {
                        computerWin.Text = computerWinNumber.ToString();
                        computerWinNumber++;
                        disableControls();
                    }
                }
                else
                {
                    if (lv2.getWinner().Equals("Player One Won"))
                    {
                        playerWin.Text = playerWinNumber.ToString();
                        playerWinNumber++;
                        disableControls();
                    }
                    else if (lv2.getWinner().Equals("Draw"))
                    {
                        disableControls();
                    }
                }
            }
        }
        public void disableControls()
        {
            for(int a = 0; a < ifPanelClicked.Length; a++)
            {
                ifPanelClicked[a] = true;
            }


            playAgainButton.Enabled = true;
            
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            Square1.Invalidate();
            Square2.Invalidate();
            Square3.Invalidate();
            Square4.Invalidate();
            Square5.Invalidate();
            Square6.Invalidate();
            Square7.Invalidate();
            Square8.Invalidate();
            Square9.Invalidate();
           
            playAgainButton.Enabled = false;
            listBox1.Enabled = true;
            for(int a = 0; a < ifPanelClicked.Length; a++)
            {
                ifPanelClicked[a] = false;
            }

            for(int a = 0; a < 3; a++)
            {
                for(int b = 0; b < 3; b++)
                {
                    xos[a,b] = "";
                }  
            }
        }

    

        private void Square1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ifPanelClicked[0] && listBox1.SelectedIndex > -1)
            {
                listBox1.Enabled = false;
                s1 = Square1.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.Black);

                Pen pen = new Pen(brush);

                s1.DrawLine(pen, 50, 40, 90, 100);
                s1.DrawLine(pen, 90, 40, 50, 100);

                ifPanelClicked[0] = true;
                xos[0, 0] = "x";
                computerPlayerMove();
            }
        }

        public void Square2_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ifPanelClicked[1] && listBox1.SelectedIndex > -1)
            {
                listBox1.Enabled = false;
                s2 = Square2.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.Black);

                Pen pen = new Pen(brush);


                s2.DrawLine(pen, 30, 40, 70, 100);
                s2.DrawLine(pen, 70, 40, 30, 100);

                ifPanelClicked[1] = true;
                xos[0, 1] = "x";
                computerPlayerMove();
            }
        }

        private void Square3_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ifPanelClicked[2] && listBox1.SelectedIndex > -1)
            {
                listBox1.Enabled = false;
                s3 = Square3.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.Black);

                Pen pen = new Pen(brush);


                s3.DrawLine(pen, 10, 40, 50, 100);
                s3.DrawLine(pen, 50, 40, 10, 100);

                ifPanelClicked[2] = true;
                xos[0, 2] = "x";
                computerPlayerMove();
            }

        }

        private void Square4_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ifPanelClicked[3] && listBox1.SelectedIndex > -1)
            {
                listBox1.Enabled = false;
                s4 = Square4.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.Black);

                Pen pen = new Pen(brush);


                s4.DrawLine(pen, 50, 30, 90, 100);
                s4.DrawLine(pen, 80, 30, 40, 100);

                ifPanelClicked[3] = true;
                xos[1, 0] = "x";
                computerPlayerMove();
            }
        }

        private void Square5_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ifPanelClicked[4] && listBox1.SelectedIndex > -1)
            {
                listBox1.Enabled = false;

                s5 = Square5.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.Black);

                Pen pen = new Pen(brush);

                s5.DrawLine(pen, 30, 30, 70, 100);
                s5.DrawLine(pen, 60, 30, 20, 100);

                ifPanelClicked[4] = true;
                xos[1, 1] = "x";
                computerPlayerMove();
            }
        } 

        private void Square6_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ifPanelClicked[5] && listBox1.SelectedIndex > -1)
            {
                listBox1.Enabled = false;

                s6 = Square6.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.Black);

                Pen pen = new Pen(brush);

                s6.DrawLine(pen, 10, 30, 50, 100);
                s6.DrawLine(pen, 40, 30, 0, 100);

                ifPanelClicked[5] = true;
                xos[1, 2] = "x";
                computerPlayerMove();
            }
        }

        private void Square7_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ifPanelClicked[6] && listBox1.SelectedIndex > -1)
            {
                listBox1.Enabled = false;
                s7 = Square7.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.Black);

                Pen pen = new Pen(brush);

                s7.DrawLine(pen, 50, 30, 90, 90);
                s7.DrawLine(pen, 90, 30, 50, 90);

                ifPanelClicked[6] = true;
                xos[2, 0] = "x";
                computerPlayerMove();
            }
        }

        private void Square8_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ifPanelClicked[7] && listBox1.SelectedIndex > -1)
            {
                listBox1.Enabled = false;
                s8 = Square8.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.Black);

                Pen pen = new Pen(brush);

                s8.DrawLine(pen, 30, 30, 70, 90);
                s8.DrawLine(pen, 70, 30, 30, 90);

                ifPanelClicked[7] = true;
                xos[2, 1] = "x";
                computerPlayerMove();
            }
        }

        private void Square9_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ifPanelClicked[8] && listBox1.SelectedIndex > -1)
            {
                listBox1.Enabled = false;
                s9 = Square9.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.Black);

                Pen pen = new Pen(brush);

                s9.DrawLine(pen, 10, 30, 50, 90);
                s9.DrawLine(pen, 50, 30, 10, 90);

                ifPanelClicked[8] = true;
                xos[2, 2] = "x";
                computerPlayerMove();
            }
        }
    }
}
