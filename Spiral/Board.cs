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
        private int boardSize = 5;
        public int[][] Cells = new int[5][];
        private int x;
        private int y;

        static void Main(string[] args)
        {
        }
        public Board(int x, int y)
        {
            Cells[0] = new int[5];
            for (int i = 0; i < Cells.Length; i++)
            {
                var Col = Cells[0];
                Col = new int[Cells.Length];
                Col[i] = i;

                Console.WriteLine();
            }
            this.x = x;
            this.y = y;
        }
    }
}
