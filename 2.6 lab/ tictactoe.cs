using System;

class MainClass {
  public static void Main () {
    Console.WriteLine ("welcome to Tic-Tac-Toe please enter an a, b, or c for the column and a 0, 1, 2 for your row to input your x");
  int Row, column, i;
  char Column;

  char [,] TicTacToe = new char [3,3] ;
  TicTacToe [0,0] = 'o';
  TicTacToe [0,1] = 'o';
  TicTacToe [0,2] = 'o';
  TicTacToe [2,1] = 'o';
  TicTacToe [2,2] = 'o';
  TicTacToe [2,0] = 'o';
  TicTacToe [1,0] = 'o';
  TicTacToe [1,1] = 'o';
  TicTacToe [1,2] = 'o';
column = 0;
  for (i=0; i<7; i=i+1)
{
  Column = char.Parse(Console.ReadLine());
  if (Column == 'a')
  {
    column = 0;
  }
  if (Column == 'b')
  {

    column = 1;
  }
  if (Column == 'c')
  {
    column = 2;
  }


  Row = int.Parse(Console.ReadLine());
  TicTacToe [Row,column] = 'x';

 Console.WriteLine ("");
}



  }
 }
