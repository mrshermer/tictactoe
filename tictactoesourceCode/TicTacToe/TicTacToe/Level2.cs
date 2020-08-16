using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this is implemented using the mini max algorithm
//the source this algorithm can be found here:
//https://www.geeksforgeeks.org/minimax-algorithm-in-game-theory-set-3-tic-tac-toe-ai-finding-optimal-move



namespace TicTacToe
{
    class Level2 : Levels
    {
        class Move
        {
            public int row, col;
        }
        string player = "x", opponent = "o";



        public Level2(bool[] array, String[,] xos)
        {
            base.setBoolArray(array);
            base.setXOs(xos);
        }
        public int makeComputerPlayerMove()
        {
            bool[] array = base.getBoolArray();
            String[,] xos = base.getXOs();
            Move bestMove = findBestMove(xos);
            int tempNum = 0;

            Console.Write("The Optimal Move is :\n");
            Console.Write("ROW: {0} COL: {1}\n\n",
                    bestMove.row, bestMove.col);
            xos[bestMove.row, bestMove.col] = "o";
            base.setXOs(xos);
            if(bestMove.row == 0 && bestMove.col == 0)
            {
                tempNum = 1;
                array[0] = true;
            }
            else if (bestMove.row == 0 && bestMove.col == 1)
            {
                tempNum = 2;
                array[1] = true;
            }
            else if (bestMove.row == 0 && bestMove.col == 2)
            {
                tempNum = 3;
                array[2] = true;
            }
            else if (bestMove.row == 1 && bestMove.col == 0)
            {
                tempNum = 4;
                array[3] = true;
            }
            else if (bestMove.row == 1 && bestMove.col == 1)
            {
                tempNum = 5;
                array[4] = true;
            }
            else if (bestMove.row == 1 && bestMove.col == 2)
            {
                tempNum = 6;
                array[5] = true;
            }
            else if (bestMove.row == 2 && bestMove.col == 0)
            {
                tempNum = 7;
                array[6] = true;
            }
            else if (bestMove.row == 2 && bestMove.col == 1)
            {
                tempNum = 8;
                array[7] = true;
            }
            else if (bestMove.row == 2 && bestMove.col == 2)
            {
                tempNum = 9;
                array[8] = true;
            }
            base.setBoolArray(array);
            return tempNum;
        }
        Boolean isMovesLeft(string[,] board)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (board[i, j] == "")
                        return true;
            return false;
        }
        int evaluate(string[,] b)
        {
            // Checking for Rows for X or O victory. 
            for (int row = 0; row < 3; row++)
            {
                if (b[row, 0] == b[row, 1] &&
                    b[row, 1] == b[row, 2])
                {
                    if (b[row, 0] == player)
                        return +10;
                    else if (b[row, 0] == opponent)
                        return -10;
                }
            }

            // Checking for Columns for X or O victory. 
            for (int col = 0; col < 3; col++)
            {
                if (b[0, col] == b[1, col] &&
                    b[1, col] == b[2, col])
                {
                    if (b[0, col] == player)
                        return +10;

                    else if (b[0, col] == opponent)
                        return -10;
                }
            }

            // Checking for Diagonals for X or O victory. 
            if (b[0, 0] == b[1, 1] && b[1, 1] == b[2, 2])
            {
                if (b[0, 0] == player)
                    return +10;
                else if (b[0, 0] == opponent)
                    return -10;
            }

            if (b[0, 2] == b[1, 1] && b[1, 1] == b[2, 0])
            {
                if (b[0, 2] == player)
                    return +10;
                else if (b[0, 2] == opponent)
                    return -10;
            }

            // Else if none of them have won then return 0 
            return 0;
        }
        int minimax(string[,] board,
                   int depth, Boolean isMax)
        {
            int score = evaluate(board);

            // If Maximizer has won the game  
            // return his/her evaluated score 
            if (score == 10)
                return score;

            // If Minimizer has won the game  
            // return his/her evaluated score 
            if (score == -10)
                return score;

            // If there are no more moves and  
            // no winner then it is a tie 
            if (isMovesLeft(board) == false)
                return 0;

            // If this maximizer's move 
            if (isMax)
            {
                int best = -1000;

                // Traverse all cells 
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        // Check if cell is empty 
                        if (board[i, j] == "")
                        {
                            // Make the move 
                            board[i, j] = opponent;

                            // Call minimax recursively and choose 
                            // the maximum value 
                            best = Math.Max(best, minimax(board,
                                            depth + 1, !isMax));

                            // Undo the move 
                            board[i, j] = "";
                        }
                    }
                }
                return best;
            }

            // If this minimizer's move 
            else
            {
                int best = 1000;

                // Traverse all cells 
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        // Check if cell is empty 
                        if (board[i, j] == "")
                        {
                            // Make the move 
                            board[i, j] = opponent;

                            // Call minimax recursively and choose 
                            // the minimum value 
                            best = Math.Min(best, minimax(board,
                                            depth + 1, !isMax));

                            // Undo the move 
                            board[i, j] = "";
                        }
                    }
                }
                return best;
            }
        }
        Move findBestMove(string[,] board)
        {
            int bestVal = -1000;
            Move bestMove = new Move();
            bestMove.row = -1;
            bestMove.col = -1;

            // Traverse all cells, evaluate minimax function  
            // for all empty cells. And return the cell  
            // with optimal value. 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // Check if cell is empty 
                    if (board[i, j] == "")
                    {
                        // Make the move 
                        board[i, j] = player;

                        // compute evaluation function for this 
                        // move. 
                        int moveVal = minimax(board, 0, false);

                        // Undo the move 
                        board[i, j] = "";

                        // If the value of the current move is 
                        // more than the best value, then update 
                        // best/ 
                        if (moveVal > bestVal)
                        {
                            bestMove.row = i;
                            bestMove.col = j;
                            bestVal = moveVal;
                        }
                    }
                }
            }
            Console.Write("The value of the best Move " +
                                    "is : {0}\n\n", bestVal);

            return bestMove;

        }
    }
}