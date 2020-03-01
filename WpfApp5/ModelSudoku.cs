using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{

    public delegate void EventHandlerWin(object sender);
    public class ModelSudoku
    {
        public event EventHandlerWin EventWin;
        public int NbRows_Per_Block {get; set;}
        public int NbCols_Per_Block { get; set; }
         

        public ArrayList Array_Rows { get; set; } = new ArrayList();
        public ArrayList Array_Cols { get; set; } = new ArrayList();
        public ArrayList Array_Blocks { get; set; } = new ArrayList();

        /*                
                                     *********************************     
                                     *            SUDOKU:            * 
                                     *********************************
                   
                              
                                     int[,] TabJeu = new int[,] {
                                                                 {0,2,0,
                                                                  0,0,0}, { 1,0,2,
                                                                            4,0,6},
                                                                  {0,1,2,
                                                                   7,3,0}, { 0,1,4,
                                                                             0,0,5}, 
                                                                  {6,0,1,
                                                                   2,0,0}, { 0,4,0,
                                                                             0,0,0}
                                                                };
            
                                                    
            
            
                                  *************************************       
                                  *               VIEWMODEL           *
                                  *************************************

             
                                                              new Block(0, 0):
                                              
                                                             NbCols_Per_Block = 3
                                                                      |
                                                           ___________|____________
                                                          |                        |
                                      
                                  
                                           __               _______________________   _______________________           __
     new Block(0, 0):                     |                |       |       |       | |       |       |       |            |
                                          |                |   0   |   2   |   0   | |   1   |   0   |   2   |            |
     NbRows_Per_Block = 2 ________________|                |-------|-------|-------| |-------|-------|-------|            |
                                          |                |   0   |   0   |   0   | |   4   |   0   |   6   |            |
                                          |__              |_______|_______|_______| |_______|_______|_______|            |       
                                                            _______________________   _______________________             |
                                                           |       |       |       | |       |       |       |            |
                                                           |   0   |   1   |   2   | |   0   |   1   |   4   |            |
                                                           |-------|-------|-------| |-------|-------|-------|            |_________________  Number of Blocks per column
                                                           |   7   |   3   |   0   | |   0   |   0   |   5   |            |                  = NbCols_Per_Block
                                                           |_______|_______|_______| |_______|_______|_______|            |                  = 3
                                                            _______________________   _______________________             |
                                                           |       |       |       | |       |       |       |            |                  
                                                           |   6   |   0   |   1   | |   0   |   4   |   0   | `          |                      
                                                           |-------|-------|-------| |-------|-------|-------|            |                      
                                                           |   2   |   0   |   0   | |   0   |   0   |   0   |            |                      
                                                           |_______|_______|_______| |_______|_______|_______|          __|  
                                                 
                                
                                                        |______________________________________________________|                              
                                                                                    |
                                                                                    |
                                                                                    |
                                                                                    |
                                                                                    |
                                                                              Number of Block per row
                                                                              = NbRows_Per_Block
                                                                              = 2
        */

        public int Row_In_Sudoku(int indexRowBlock_In_Sudoku, int indexColBlock_In_Sudoku)
        {
            return indexColBlock_In_Sudoku + NbRows_Per_Block * indexRowBlock_In_Sudoku;
        }

        public int Column_In_Sudoku(int indexRowCell_In_Block, int indexColCell_In_Block)
        {
            return indexColCell_In_Block + NbCols_Per_Block * indexRowCell_In_Block;
        }

        public int Row_In_GridUser(int indexRowBlock_In_Sudoku, int indexRowCell_In_Block)
        {
            return indexRowCell_In_Block + NbRows_Per_Block * indexRowBlock_In_Sudoku;
        }

        public int Column_In_GridUser(int indexColBlock_In_Sudoku, int indexColCell_In_Block)
        {
            return indexColCell_In_Block + NbCols_Per_Block * indexColBlock_In_Sudoku;
        }


        public int IndexArray1D_In_Block(int indexRowCell_In_Block, int indexColCell_In_Block)
        {
            return indexColCell_In_Block + NbCols_Per_Block * indexRowCell_In_Block;
        }

        public void Initialiser(int[,] Tab)
        {

            int indexRowCell_In_Block;
            int indexColCell_In_Block;                              
                                           
            int indexRowBlock_In_Sudoku;
            int indexColBlock_In_Sudoku;

            
            int nbBlocksRow = NbCols_Per_Block;
            int nbBlocksCol = NbRows_Per_Block;

            int Id_Row;
            int Id_Col;

          

            //Creation of 9 Rows
            for (indexRowBlock_In_Sudoku = 0; indexRowBlock_In_Sudoku < nbBlocksRow; indexRowBlock_In_Sudoku++)
                 {
                     for (indexRowCell_In_Block = 0; indexRowCell_In_Block < NbRows_Per_Block; indexRowCell_In_Block++)
                     {

                         Id_Row = Row_In_GridUser(indexRowBlock_In_Sudoku, indexRowCell_In_Block);
                         RowPuzzle RowP = new RowPuzzle(Id_Row)
                         {
                             ParentGrid = this
                         };

                         for (indexColBlock_In_Sudoku = 0; indexColBlock_In_Sudoku < nbBlocksCol; indexColBlock_In_Sudoku++)
                         {
                             for (indexColCell_In_Block = 0; indexColCell_In_Block < NbCols_Per_Block; indexColCell_In_Block++)
                             {
                                
                                 RowP.Array1D.Add(Tab[Row_In_Sudoku(indexRowBlock_In_Sudoku, indexColBlock_In_Sudoku), Column_In_Sudoku(indexRowCell_In_Block, indexColCell_In_Block)]);
                             }
                         }

                         Array_Rows.Add(RowP);
                     }
                 }

            //Creation of 9 Columns
            for (indexColBlock_In_Sudoku = 0; indexColBlock_In_Sudoku < nbBlocksCol; indexColBlock_In_Sudoku++)
                 {
                     for (indexColCell_In_Block = 0; indexColCell_In_Block < NbCols_Per_Block; indexColCell_In_Block++)
                     {
                         Id_Col = Column_In_GridUser(indexColBlock_In_Sudoku, indexColCell_In_Block);

                         ColumnPuzzle ColP = new ColumnPuzzle(Id_Col);

                         for (indexRowBlock_In_Sudoku = 0; indexRowBlock_In_Sudoku < nbBlocksRow; indexRowBlock_In_Sudoku++)
                         {
                             for (indexRowCell_In_Block = 0; indexRowCell_In_Block < NbRows_Per_Block; indexRowCell_In_Block++)
                             {
                                  ColP.Array1D.Add(Tab[Row_In_Sudoku(indexRowBlock_In_Sudoku, indexColBlock_In_Sudoku), Column_In_Sudoku(indexRowCell_In_Block, indexColCell_In_Block)]);
                             }
                         }

                         Array_Cols.Add(ColP);
                     }
                 }

            //Creation of 9 Blocks
            for (indexRowBlock_In_Sudoku = 0; indexRowBlock_In_Sudoku < nbBlocksRow; indexRowBlock_In_Sudoku++)
            {
                for (indexColBlock_In_Sudoku = 0; indexColBlock_In_Sudoku < nbBlocksCol; indexColBlock_In_Sudoku++)
                {
                    BlockPuzzle BlockP = new BlockPuzzle(NbRows_Per_Block, NbCols_Per_Block, indexRowBlock_In_Sudoku, indexColBlock_In_Sudoku);

                    for (indexRowCell_In_Block = 0; indexRowCell_In_Block < NbRows_Per_Block; indexRowCell_In_Block++)
                    {
                        for (indexColCell_In_Block = 0; indexColCell_In_Block < NbCols_Per_Block; indexColCell_In_Block++)
                        {
                            BlockP.Array1D.Add(Tab[Row_In_Sudoku(indexRowBlock_In_Sudoku, indexColBlock_In_Sudoku), Column_In_Sudoku(indexRowCell_In_Block, indexColCell_In_Block)]);
                        }
                    }

                    Array_Blocks.Add(BlockP);
                }
            }
           
        }

        public bool Win()
        {
            bool win = true;

            for(int indexRowTab = 0; indexRowTab < Array_Rows.Count; indexRowTab++)
            {
                win = win && ((RowPuzzle)Array_Rows[indexRowTab]).ContainsAllDigits();
            }

            for (int indexColTab = 0; indexColTab < Array_Cols.Count; indexColTab++)
            {
                win = win && ((ColumnPuzzle)Array_Cols[indexColTab]).ContainsAllDigits();
            }

            for(int indexBlockTab = 0; indexBlockTab < Array_Blocks.Count; indexBlockTab++)
            {
                win = win && ((BlockPuzzle)Array_Blocks[indexBlockTab]).ContainsAllDigits();
            }

            return win;
        }


        public void OnWinTrigger()
        {
            EventWin?.Invoke(this);
        }

        public ModelSudoku( int nbRows_per_block, int nbCols_per_block)
        {
            NbRows_Per_Block = nbRows_per_block;
            NbCols_Per_Block = nbCols_per_block;
        }

        
    }
}
