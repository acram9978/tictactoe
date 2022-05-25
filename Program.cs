using System;
using System.Collections.Generic;

namespace Cse210Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool win = false;
            string player = "x";
            string input = "";
            int pick = 0;
            int counter = 0;

            List<string> board = new List<string>();
            board.Add("\n");
            board.Add("1");
            board.Add("|");
            board.Add("2");
            board.Add("|");
            board.Add("3");
            board.Add("\n-+-+-\n");
            board.Add("4");
            board.Add("|");
            board.Add("5");
            board.Add("|");
            board.Add("6");
            board.Add("\n-+-+-\n");
            board.Add("7");
            board.Add("|");
            board.Add("8");
            board.Add("|");
            board.Add("9");
            board.Add("\n");


            void display_board()
                {
                    foreach (string item in board)
                        {
                            Console.Write(item);
                        }
                }

            void checkPlayer(int space) {
                if (board[space] == "x" || board[space] == "o") {
                    Console.WriteLine("\nPlease try again: ");
                    input = Console.ReadLine();
                    pick = int.Parse(input);
                    update_board(pick);
                }
                else {
                    board[space] = player;
                }
            }

            void update_board(int user) {
                switch (user) {
                    case 1:
                        checkPlayer(1);
                        break;
                    case 2:
                        //board[3] = player;
                        checkPlayer(3);
                        break;
                    case 3:
                        //board[5] = player;
                        checkPlayer(5);
                        break;
                    case 4:
                        //board[7] = player;
                        checkPlayer(7);
                        break;
                    case 5:
                        //board[9] = player;
                        checkPlayer(9);
                        break;
                    case 6:
                        //board[11] = player;
                        checkPlayer(11);
                        break;
                    case 7:
                        //board[13] = player;
                        checkPlayer(13);
                        break;
                    case 8:
                        //board[15] = player;
                        checkPlayer(15);
                        break;
                    case 9:
                        //board[17] = player;
                        checkPlayer(17);
                        break;
                }
            }

            void checkWin() {
                //Console.Write(board[1]);
                //Console.Write(board[3]);

                //horizontal wins
                if (board[1] == board[3] && board[3] == board[5]) {
                    win = true;
                }
                else if (board[7] == board[9] && board[9] == board[11]) {
                    win = true;
                }
                else if (board[13] == board[15] && board[15] == board[17]) {
                    win = true;
                }

                //vertical wins
                else if (board[1] == board[7] && board[7] == board[13]) {
                    win = true;
                }
                else if (board[3] == board[9] && board[9] == board[15]) {
                    win = true;
                }
                else if (board[5] == board[11] && board[11] == board[17]) {
                    win = true;
                }

                //diag wins
                else if (board[1] == board[9] && board[9] == board[17]) {
                    win = true;
                }
                else if (board[5] == board[9] && board[9] == board[13]) {
                    win = true;
                }

                //draw
                
            }

            void checkDraw(){
                if (counter == 5){
                    player = "draw";
                    win = true;

                }
            }
            
            Console.WriteLine("\nWelcome to the Tic Tac Toe game!--\n");

            while (win == false) {
                
                display_board();

                if (player == "x") {
                    Console.WriteLine("\nIt is x's turn, where would you like to go?: ");
                    input = Console.ReadLine();
                    pick = int.Parse(input);
                    update_board(pick);
                    
                    checkWin();
                    player = "o";
                    counter = counter + 1;
                    checkDraw();
                    //display_board();
                    //Console.WriteLine(pick);
                    //win = true;
                }
                else if (player == "o") {
                    
                    Console.WriteLine("\nIt is o's turn, where would you like to go?: ");
                    input = Console.ReadLine();
                    pick = int.Parse(input);
                    update_board(pick);
                    checkWin();
                    
                    // Console.WriteLine("\nIt is o's turn, where would you like to go?: ");
                    // input = Console.ReadLine();
                    // pick = int.Parse(input);
                    // update_board(pick);
                    // checkWin();
                    player = "x";
                }
                
            }
            
            if (player == "o") {
                player = "x";
                Console.WriteLine($"Congratulations {player}'s! You won the game!");
            }
            else if (player == "x") {
                player = "o";
                Console.WriteLine($"Congratulations {player}'s! You won the game!");
            }
            else {
                Console.WriteLine("It was a draw!");
            }

            
            //display_board();


        }
    }
}
