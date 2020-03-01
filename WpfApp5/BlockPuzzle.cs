using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class BlockPuzzle
    {
        public int NbRows { get; set; }
        public int NbCols { get; set; }
        public int Sudoku_IndexRow { get; set; }
        public int Sudoku_IndexCol { get; set; }



        public ArrayList Array1D { get; set; } = new ArrayList();

        public bool ContainsAllDigits()
        {
            bool valid = true;

            for (int index = 0; index < Array1D.Count; index++)
            {
                valid = valid && Array1D.Contains(index + 1);
            }

            return valid;
        }

        public BlockPuzzle(int nbRows, int nbCols, int indR, int indC)
        {
            NbRows = nbRows;
            NbCols = nbCols;
            Sudoku_IndexRow = indR;
            Sudoku_IndexCol = indC;
        }

    }
}
