using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class RowPuzzle
    {
         public int Index { get; set; }

         public ArrayList Array1D { get; set; } = new ArrayList();

         public ModelSudoku ParentGrid { get; set; }
         public bool ContainsAllDigits()
         {
             bool valid = true;

             for(int index = 0; index < Array1D.Count; index++)
             {
                valid = valid && Array1D.Contains(index + 1);
             }

             return valid; 
         }
         public RowPuzzle(int index)
         {
             Index = index;
         }
    }
}
