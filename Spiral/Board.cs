using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral
{
    public class Board
    {
        public int[][] Cells;
        public string boardString;
        private int rows;
        private int cols;

        public override string ToString()
        {
            return boardString;
        }

        static void Main(string[] args)
        {
            var board = new Board(6, 2);
            Console.WriteLine(board);
        }

        public Board(int rows, int cols)
        {
            boardString = "";
            this.rows = rows;
            this.cols = cols;
            Cells = new int[rows][];
            Cells[0] = new int[cols];
            var Col = Cells[0];
            Col = new int[Cells.Length];

            for (int i = 0; i < rows; i++)
            {
                Col[i] = i;
                for (int j = 0; j < cols; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        boardString += (" ");
                        Console.Write(" ");
                    }
                    else
                    {
                        boardString += ("#");
                        Console.Write("#");
                    }
                }
                boardString += ("\n");
                Console.Write("\n");
            }
        }
    }
}
