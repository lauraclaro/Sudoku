using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Puzzles_Per_Dimension
    {
        public int NbRows_Per_Block { get; set; }
        public int NbCols_Per_Block { get; set; }
        public string Level { get; set; }
        public List<int[,]> ListPuzzles { get; set; } = new List<int[,]>();

        public Puzzles_Per_Dimension(int nbRows, int nbCols, string level)
        {
            NbRows_Per_Block = nbRows;
            NbCols_Per_Block = nbCols;
            Level = level;
        }

    }
}
