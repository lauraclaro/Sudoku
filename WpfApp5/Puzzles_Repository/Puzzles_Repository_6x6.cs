using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Puzzles_Repository
{
    public class Puzzles_Repository_6x6
    {
        public Puzzles_Per_Dimension Puzzles_6x6_Easy = new Puzzles_Per_Dimension(6, 6, "Easy");
        public Puzzles_Per_Dimension Puzzles_6x6_Medium = new Puzzles_Per_Dimension(6, 6, "Medium");
        public Puzzles_Per_Dimension Puzzles_6x6_Hard = new Puzzles_Per_Dimension(6, 6, "Hard");

        public void Add_Puzzles_Easy()
        {
            Puzzles_6x6_Easy.ListPuzzles.Add(
              new int[,] { {0,0,4,
                            0,0,6}, {2,5,0,
                                     0,4,1},
                            {3,0,0,
                             4,0,0}, {5,6,4,
                                      0,0,0},
                            {0,1,2,
                             0,0,3}, {4,3,0,
                                      0,1,2}
                         }
              );

            Puzzles_6x6_Easy.ListPuzzles.Add(
               new int[,] { {0,0,6,
                             1,0,0}, {0,2,1,
                                      4,0,0},
                            {3,1,0,
                             6,4,0}, {0,6,0,
                                      1,3,5},
                            {0,0,1,
                             0,0,0}, {0,0,0,
                                      6,1,0}
                         }
               );

            Puzzles_6x6_Easy.ListPuzzles.Add(
              new int[,] { {0,0,2,
                            6,3,0}, {0,0,0,
                                     0,2,0},
                            {0,0,0,
                             4,0,0}, {6,4,0,
                                      0,0,3},
                            {2,1,0,
                             0,0,6}, {0,0,6,
                                      0,1,0}
                        }
              );

            Puzzles_6x6_Easy.ListPuzzles.Add(
            new int[,] { {0,0,3,
                          5,6,0}, {0,1,0,
                                   3,2,0},
                          {0,5,4,
                           2,0,6}, {2,0,3,
                                    4,5,0},
                            {0,1,2,
                             0,4,0}, {0,4,5,
                                      1,0,0}
                      }
            );
        }
        public void Add_Puzzles_Medium()
        {
            Puzzles_6x6_Medium.ListPuzzles.Add(
              new int[,] { {4,0,2,
                            0,0,5}, {0,3,0,
                                     1,0,0},
                            {0,0,0,
                             0,0,0}, {6,0,0,
                                      0,0,0},
                            {5,0,4,
                             6,0,0}, {0,0,0,
                                      0,0,2}
                        }
             );

            Puzzles_6x6_Medium.ListPuzzles.Add(
               new int[,] { {0,0,1,
                             0,0,0}, {0,5,0,
                                      0,1,0},
                            {0,1,0,
                             0,3,4}, {0,6,3,
                                      0,0,0},
                            {0,0,0,
                             0,0,6}, {0,3,5,
                                      0,0,0}
                         }
               );

            Puzzles_6x6_Medium.ListPuzzles.Add(
              new int[,] { {3,5,4,
                            2,0,0}, {0,2,0,
                                     0,3,4},
                           {0,3,0,
                            0,2,0}, {0,6,0,
                                     0,4,0},
                           {5,4,0,
                            0,6,0}, {0,0,3,
                                     4,5,2}
                      }
            );

            Puzzles_6x6_Medium.ListPuzzles.Add(
             new int[,] { {0,0,0,
                           0,0,0}, {2,0,0,
                                    1,0,0},
                           {0,0,0,
                            0,0,0}, {3,5,1,
                                     0,0,6},
                           {3,0,0,
                            0,0,0}, {0,4,0,
                                     6,0,0}
                     }
           );
        }
        public void Add_Puzzles_Hard()
        {
            Puzzles_6x6_Hard.ListPuzzles.Add(
              new int[,] { {0,0,0,
                            5,0,0}, {0,4,0,
                                     0,0,3},
                            {0,6,0,
                             0,0,3}, {0,0,0,
                                      0,0,5},
                            {0,5,0,
                             1,0,0}, {0,1,0,
                                      0,0,2}
                         }
             );

            Puzzles_6x6_Hard.ListPuzzles.Add(
               new int[,] { {0,0,2,
                             0,3,0}, {1,0,0,
                                      0,0,0},
                            {0,0,0,
                             5,6,0}, {0,0,5,
                                      0,0,0},
                            {2,0,0,
                             0,0,0}, {0,0,1,
                                      0,3,0}  }
             );

            Puzzles_6x6_Hard.ListPuzzles.Add(
              new int[,] { {6,0,0,
                            2,0,0}, {0,0,2,
                                     5,4,6},
                            {4,0,0,
                             0,1,0}, {0,1,0,
                                      0,0,4},
                            {1,2,5,
                             3,0,0}, {0,0,3,
                                      0,0,1}  }
             );

            Puzzles_6x6_Hard.ListPuzzles.Add(
              new int[,] { {0,0,0,
                           0,0,0}, {2,0,0,
                                    1,0,0},
                           {0,0,0,
                            0,0,0}, {3,5,1,
                                     0,0,6},
                           {3,0,0,
                            0,0,0}, {0,4,0,
                                     6,0,0}
                 }
             );
        }

       



        public Puzzles_Repository_6x6()
        {
            Add_Puzzles_Easy();
            Add_Puzzles_Medium();
            Add_Puzzles_Hard();
        }


    }
}
