using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Puzzles_Repository
{
    public class Puzzles_Repository_4x4
    {
        public Puzzles_Per_Dimension Puzzles_4x4_Easy { get; set; } = new Puzzles_Per_Dimension(4, 4, "Easy");
        public Puzzles_Per_Dimension Puzzles_4x4_Medium { get; set; } = new Puzzles_Per_Dimension(6, 6, "Medium");
        public Puzzles_Per_Dimension Puzzles_4x4_Hard { get; set; } = new Puzzles_Per_Dimension(9, 9, "Hard");

        public void Add_Puzzles_Easy()
        {
            Puzzles_4x4_Easy.ListPuzzles.Add(
                new int[,] { {1,0,
                              0,0}, {4,2,
                                     0,1},
                             {0,0,
                              2,0}, {0,4,
                                     1,0} }
              );
            Puzzles_4x4_Easy.ListPuzzles.Add(
               new int[,] { {2,0,
                             3,4}, {0,0,
                                    0,1},
                            {1,2,
                             0,3}, {3,0,
                                    0,0} }
               );

            Puzzles_4x4_Easy.ListPuzzles.Add(
              new int[,] { {0,0,
                            0,0}, {2,0,
                                   4,1},
                            {0,4,
                             3,2}, {3,2,
                                    0,4} }
              );

            Puzzles_4x4_Easy.ListPuzzles.Add(
             new int[,] { {1,4,
                           2,0}, {2,0,
                                  4,0},
                            {3,0,
                             0,0}, {0,0,
                                    3,2} }
             );
        }

        public void Add_Puzzles_Medium()
        {

            Puzzles_4x4_Medium.ListPuzzles.Add(
              new int[,] { {1,2,
                            0,4}, {3,4,
                                   0,0},
                           {0,0,
                            2,0}, {0,3,
                                   0,1} }
              );






            Puzzles_4x4_Medium.ListPuzzles.Add(
               new int[,] { {3,0,
                             0,4}, {1,0,
                                    0,2},
                            {2,0,
                             4,0}, {4,1,
                                    0,0} }
               );

            Puzzles_4x4_Medium.ListPuzzles.Add(
              new int[,] { {0,2,
                            0,3}, {0,0,
                                   4,2},
                            {0,1,
                             0,0}, {0,4,
                                    2,0}}
              );

            Puzzles_4x4_Medium.ListPuzzles.Add(
             new int[,] { {3,0,
                           0,0}, {0,1,
                                  0,0},
                          {4,3,
                           2,0}, {0,2,
                                  4,0}}
             );
        }

        public void Add_Puzzles_Hard()
        {
            Puzzles_4x4_Hard.ListPuzzles.Add(
               new int[,] { {4,0,
                             0,0}, {0,0,
                                    0,2},
                            {0,0,
                             1,0}, {0,4,
                                    0,0} }
               );
            Puzzles_4x4_Hard.ListPuzzles.Add(
               new int[,] { {0,0,
                             0,0}, {3,0,
                                    1,0},
                            {0,3,
                             4,0}, {0,0,
                                    0,0} }
               );

            Puzzles_4x4_Hard.ListPuzzles.Add(
              new int[,] { {0,4,
                            0,0}, {0,0,
                                   0,0},
                            {2,0,
                             0,0}, {0,4,
                                    0,1}}
              );

            Puzzles_4x4_Hard.ListPuzzles.Add(
             new int[,] { {1,0,
                           0,4}, {0,0,
                                  0,2},
                            {0,0,
                             0,0}, {0,0,
                                    0,4}}
             );
        }

        public Puzzles_Repository_4x4()
        {
            Add_Puzzles_Easy();
            Add_Puzzles_Medium();
            Add_Puzzles_Hard();
        }



    }
}
