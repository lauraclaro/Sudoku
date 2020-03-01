using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Sudoku.Puzzles_Repository;

namespace Sudoku
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void Window_4x4(object sender, RoutedEventArgs e)
        {
            int index;
            int jndex;
           
            Puzzles_Repository_4x4 Puzzles_4x4 = new Puzzles_Repository_4x4();

            

            Window Wind_4x4 = new Window();
            Grid Grids_4x4 = new Grid();
            Wind_4x4.Content = Grids_4x4;

            for (index = 0; index < 3; index++)
            {
                RowDefinition Row = new RowDefinition();
                Grids_4x4.RowDefinitions.Add(Row);

                StackPanel StackP = new StackPanel();
                Grids_4x4.Children.Add(StackP);

                Grid.SetRow(StackP, index);

                WrapPanel WrapP = new WrapPanel();
               
                Label Lab = new Label
                {
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalAlignment = VerticalAlignment.Stretch,
                    FontSize = 25
                };

                StackP.Children.Add(Lab);
                StackP.Children.Add(WrapP);

                switch (index)
                {
                    case 0:
                        Lab.Content = "Easy";

                        for (jndex = 0; jndex < Puzzles_4x4.Puzzles_4x4_Easy.ListPuzzles.Count; jndex++)
                        {
                            Button Btn_Easy = new Button
                            {
                                Content = "Grid " + (jndex + 1).ToString(),
                                FontSize = 30,
                                Margin = new Thickness(30),
                                Padding = new Thickness(5)
                            };

                            WrapP.Children.Add(Btn_Easy);

                            Btn_Easy.Click += Btn_4x4_Easy_Click;
                        }

                        break;

                    case 1:
                        Lab.Content = "Medium";

                        for (jndex = 0; jndex < Puzzles_4x4.Puzzles_4x4_Medium.ListPuzzles.Count; jndex++)
                        {
                            Button Btn_Medium = new Button
                            {
                                Content = "Grid " + (jndex + 1).ToString(),
                                FontSize = 30,
                                Margin = new Thickness(30),
                                Padding = new Thickness(5)
                            };

                            WrapP.Children.Add(Btn_Medium);

                            Btn_Medium.Click += Btn_4x4_Medium_Click;
                        }

                        break;

                    case 2:
                        Lab.Content = "Hard";


                        for (jndex = 0; jndex < Puzzles_4x4.Puzzles_4x4_Hard.ListPuzzles.Count; jndex++)
                        {
                            Button Btn_Hard = new Button
                            {
                                Content = "Grid " + (jndex + 1).ToString(),
                                FontSize = 30,
                                Margin = new Thickness(30),
                                Padding = new Thickness(5)
                            };

                            WrapP.Children.Add(Btn_Hard);

                            Btn_Hard.Click += Btn_4x4_Hard_Click;
                        }

                        break;
                }
            }

            Wind_4x4.Show();
        }
        private void Window_6x6(object sender, RoutedEventArgs e)
        {
            int index;
            int jndex;
            //Window 6x6
            Puzzles_Repository_6x6 Puzzles_6x6 = new Puzzles_Repository_6x6();

            // Window Wind_4x4 = new Window();

            Window Wind_6x6 = new Window();
            Grid Grids_6x6 = new Grid();
            Wind_6x6.Content = Grids_6x6;

            for (index = 0; index < 3; index++)
            {
                RowDefinition Row = new RowDefinition();
                Grids_6x6.RowDefinitions.Add(Row);

                StackPanel StackP = new StackPanel();
                Grids_6x6.Children.Add(StackP);

                Grid.SetRow(StackP, index);

                WrapPanel WrapP = new WrapPanel();
               

                Label Lab = new Label
                {
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalAlignment = VerticalAlignment.Stretch,
                    FontSize =30
                };

                StackP.Children.Add(Lab);
                StackP.Children.Add(WrapP);

                switch (index)
                {
                    case 0:
                        Lab.Content = "Easy";

                        for (jndex = 0; jndex < Puzzles_6x6.Puzzles_6x6_Easy.ListPuzzles.Count; jndex++)
                        {
                            Button Btn_Easy = new Button
                            {
                                Content = "Grid " + (jndex + 1).ToString(),
                                FontSize = 30,
                                Margin = new Thickness(30),
                                Padding = new Thickness(5)
                            };

                            WrapP.Children.Add(Btn_Easy);

                            Btn_Easy.Click += Btn_6x6_Easy_Click;
                        }

                        break;

                    case 1:
                        Lab.Content = "Medium";

                        for (jndex = 0; jndex < Puzzles_6x6.Puzzles_6x6_Medium.ListPuzzles.Count; jndex++)
                        {
                            Button Btn_Medium = new Button
                            {
                                Content = "Grid " + (jndex + 1).ToString(),
                                FontSize = 30,
                                Margin = new Thickness(30),
                                Padding = new Thickness(5)
                            };

                            WrapP.Children.Add(Btn_Medium);

                            Btn_Medium.Click += Btn_6x6_Medium_Click;
                        }

                        break;

                    case 2:
                        Lab.Content = "Hard";


                        for (jndex = 0; jndex < Puzzles_6x6.Puzzles_6x6_Hard.ListPuzzles.Count; jndex++)
                        {
                            Button Btn_Hard = new Button
                            {
                                Content = "Grid " + (jndex + 1).ToString(),
                                FontSize = 30,
                                Margin = new Thickness(30),
                                Padding = new Thickness(5)
                            };

                            WrapP.Children.Add(Btn_Hard);

                            Btn_Hard.Click += Btn_6x6_Hard_Click;
                        }

                        break;
                }
            }

            Wind_6x6.Show();
        }
        private void Window_9x9(object sender, RoutedEventArgs e)
        {
            int index;
            int jndex;
            //Window 9x9
            Puzzles_Repository_9x9 Puzzles_9x9 = new Puzzles_Repository_9x9();

            // Window Wind_9x9 = new Window();

            Window Wind_9x9 = new Window
            {
                Width = 700,
                Height = 550,
            };
            Grid Grids_9x9 = new Grid();
            Wind_9x9.Content = Grids_9x9;

            for (index = 0; index < 5; index++)
            {
                RowDefinition Row = new RowDefinition();
                Grids_9x9.RowDefinitions.Add(Row);

                StackPanel StackP = new StackPanel();
                Grids_9x9.Children.Add(StackP);

                Grid.SetRow(StackP, index);

                WrapPanel WrapP = new WrapPanel();


                Label Lab = new Label
                {
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalAlignment = VerticalAlignment.Stretch,
                    FontSize = 30
                };

                StackP.Children.Add(Lab);
                StackP.Children.Add(WrapP);

                switch (index)
                {
                    case 0:
                        Lab.Content = "Easy";

                        for (jndex = 0; jndex < Puzzles_9x9.Puzzles_9x9_Easy.ListPuzzles.Count; jndex++)
                        {
                            Button Btn_Easy = new Button
                            {
                                Content = "Grid " + (jndex + 1).ToString(),
                                FontSize = 15,
                                Margin = new Thickness(30, 5,30, 30),
                                Padding = new Thickness(5)
                            };

                            WrapP.Children.Add(Btn_Easy);

                            Btn_Easy.Click += Btn_9x9_Easy_Click;
                        }

                        break;

                    case 1:
                        Lab.Content = "Medium";

                        for (jndex = 0; jndex < Puzzles_9x9.Puzzles_9x9_Medium.ListPuzzles.Count; jndex++)
                        {
                            Button Btn_Medium = new Button
                            {
                                Content = "Grid " + (jndex + 1).ToString(),
                                FontSize = 15,
                                Margin = new Thickness(30, 5, 30, 30),
                                Padding = new Thickness(5)
                            };

                            WrapP.Children.Add(Btn_Medium);
                            Btn_Medium.Click += Btn_9x9_Medium_Click;
                        }

                        break;

                    case 2:
                        Lab.Content = "Hard";


                        for (jndex = 0; jndex < Puzzles_9x9.Puzzles_9x9_Hard.ListPuzzles.Count; jndex++)
                        {
                            Button Btn_Hard = new Button
                            {
                                Content = "Grid " + (jndex + 1).ToString(),
                                FontSize = 15,
                                Margin = new Thickness(30, 5, 30, 30),
                                Padding = new Thickness(5)
                            };

                            WrapP.Children.Add(Btn_Hard);

                            Btn_Hard.Click += Btn_9x9_Hard_Click;
                        }

                        break;

                    case 3:
                        Lab.Content = "Expert";
                        for (jndex = 0; jndex < Puzzles_9x9.Puzzles_9x9_Expert.ListPuzzles.Count; jndex++)
                        {
                            Button Btn_Expert = new Button
                            {
                                Content = "Grid " + (jndex + 1).ToString(),
                                FontSize = 15,
                                Margin = new Thickness(30, 5, 30, 30),
                                Padding = new Thickness(5)
                            };

                            WrapP.Children.Add(Btn_Expert);

                            Btn_Expert.Click += Btn_9x9_Expert_Click;
                        }

                        break;

                    case 4:
                        Lab.Content = "Diablolic";
                        for (jndex = 0; jndex < Puzzles_9x9.Puzzles_9x9_Diabolic.ListPuzzles.Count; jndex++)
                        {
                            Button Btn_Diabolic = new Button
                            {
                                Content = "Grid " + (jndex + 1).ToString(),
                                FontSize = 15,
                                Margin = new Thickness(30, 5, 30, 30),
                                Padding = new Thickness(5)
                            };
                            WrapP.Children.Add(Btn_Diabolic);

                            Btn_Diabolic.Click += Btn_9x9_Diabolic_Click;
                        }
                        break;
                }
            }

            Wind_9x9.Show();
        }


        private void Btn_4x4_Easy_Click(object sender, RoutedEventArgs e)
        {
            Puzzles_Repository_4x4 Puzzles_4x4 = new Puzzles_Repository_4x4();

            new Button();
            Button Btn = (Button)sender;

            int index;

            for (index = 0; index < Puzzles_4x4.Puzzles_4x4_Easy.ListPuzzles.Count(); index++)
            {
                if (Btn.Content.ToString() == "Grid " + (index + 1).ToString())
                {
                    Play(2, 2, Puzzles_4x4.Puzzles_4x4_Easy.ListPuzzles[index]);
                }
            }

        }
        private void Btn_4x4_Medium_Click(object sender, RoutedEventArgs e)
        {
            Puzzles_Repository_4x4 Puzzles_4x4 = new Puzzles_Repository_4x4();

            new Button();
            Button Btn = (Button)sender;

            int index;

            for (index = 0; index < Puzzles_4x4.Puzzles_4x4_Medium.ListPuzzles.Count(); index++)
            {
                if (Btn.Content.ToString() == "Grid " + (index + 1).ToString())
                {
                    Play(2, 2, Puzzles_4x4.Puzzles_4x4_Medium.ListPuzzles[index]);
                }
            }
        }
        private void Btn_4x4_Hard_Click(object sender, RoutedEventArgs e)
        {
            Puzzles_Repository_4x4 Puzzles_4x4 = new Puzzles_Repository_4x4();

            new Button();
            Button Btn = (Button)sender;

            int index;

            for (index = 0; index < Puzzles_4x4.Puzzles_4x4_Hard.ListPuzzles.Count(); index++)
            {
                if (Btn.Content.ToString() == "Grid " + (index + 1).ToString())
                {
                    Play(2, 2, Puzzles_4x4.Puzzles_4x4_Hard.ListPuzzles[index]);
                }
            }
        }



        
        private void Btn_6x6_Easy_Click(object sender, RoutedEventArgs e)
        {
            Puzzles_Repository_6x6 Puzzles_6x6 = new Puzzles_Repository_6x6();

            new Button();
            Button Btn = (Button)sender;

            int index;

            for (index = 0; index < Puzzles_6x6.Puzzles_6x6_Easy.ListPuzzles.Count(); index++)
            {
                if (Btn.Content.ToString() == "Grid " + (index + 1).ToString())
                {
                    Play(2, 3, Puzzles_6x6.Puzzles_6x6_Easy.ListPuzzles[index]);
                }
            }

        }
        private void Btn_6x6_Medium_Click(object sender, RoutedEventArgs e)
        {
            Puzzles_Repository_6x6 Puzzles_6x6 = new Puzzles_Repository_6x6();

            new Button();
            Button Btn = (Button)sender;

            int index;

            for (index = 0; index < Puzzles_6x6.Puzzles_6x6_Medium.ListPuzzles.Count(); index++)
            {
                if (Btn.Content.ToString() == "Grid " + (index + 1).ToString())
                {
                    Play(2, 3, Puzzles_6x6.Puzzles_6x6_Medium.ListPuzzles[index]);
                }
            }
        }
        private void Btn_6x6_Hard_Click(object sender, RoutedEventArgs e)
        {
            Puzzles_Repository_6x6 Puzzles_6x6 = new Puzzles_Repository_6x6();

            new Button();
            Button Btn = (Button)sender;

            int index;

            for (index = 0; index < Puzzles_6x6.Puzzles_6x6_Hard.ListPuzzles.Count(); index++)
            {
                if (Btn.Content.ToString() == "Grid " + (index + 1).ToString())
                {
                    Play(2, 3, Puzzles_6x6.Puzzles_6x6_Hard.ListPuzzles[index]);
                }
            }
        }




       
        private void Btn_9x9_Easy_Click(object sender, RoutedEventArgs e)
        {
            Puzzles_Repository_9x9 Puzzles_9x9 = new Puzzles_Repository_9x9();

            new Button();
            Button Btn = (Button)sender;

            int index;

            for (index = 0; index < Puzzles_9x9.Puzzles_9x9_Easy.ListPuzzles.Count(); index++)
            {
                if (Btn.Content.ToString() == "Grid " + (index + 1).ToString())
                {
                    Play(3, 3, Puzzles_9x9.Puzzles_9x9_Easy.ListPuzzles[index]);
                }
            }

        }
        private void Btn_9x9_Medium_Click(object sender, RoutedEventArgs e)
        {
            Puzzles_Repository_9x9 Puzzles_9x9 = new Puzzles_Repository_9x9();

            new Button();
            Button Btn = (Button)sender;

            int index;

            for (index = 0; index < Puzzles_9x9.Puzzles_9x9_Medium.ListPuzzles.Count(); index++)
            {
                if (Btn.Content.ToString() == "Grid " + (index + 1).ToString())
                {
                    Play(3, 3, Puzzles_9x9.Puzzles_9x9_Medium.ListPuzzles[index]);
                }
            }
        }
        private void Btn_9x9_Hard_Click(object sender, RoutedEventArgs e)
        {
            Puzzles_Repository_9x9 Puzzles_9x9 = new Puzzles_Repository_9x9();

            new Button();
            Button Btn = (Button)sender;

            int index;

            for (index = 0; index < Puzzles_9x9.Puzzles_9x9_Hard.ListPuzzles.Count(); index++)
            {
                if (Btn.Content.ToString() == "Grid " + (index + 1).ToString())
                {
                    Play(3, 3, Puzzles_9x9.Puzzles_9x9_Hard.ListPuzzles[index]);
                }
            }
        }
        private void Btn_9x9_Expert_Click(object sender, RoutedEventArgs e)
        {
            Puzzles_Repository_9x9 Puzzles_9x9 = new Puzzles_Repository_9x9();

            new Button();
            Button Btn = (Button)sender;

            int index;

            for (index = 0; index < Puzzles_9x9.Puzzles_9x9_Expert.ListPuzzles.Count(); index++)
            {
                if (Btn.Content.ToString() == "Grid " + (index + 1).ToString())
                {
                    Play(3, 3, Puzzles_9x9.Puzzles_9x9_Expert.ListPuzzles[index]);
                }
            }
        }
        private void Btn_9x9_Diabolic_Click(object sender, RoutedEventArgs e)
        {
            Puzzles_Repository_9x9 Puzzles_9x9 = new Puzzles_Repository_9x9();

            new Button();
            Button Btn = (Button)sender;

            int index;

            for (index = 0; index < Puzzles_9x9.Puzzles_9x9_Diabolic.ListPuzzles.Count(); index++)
            {
                if (Btn.Content.ToString() == "Grid " + (index + 1).ToString())
                {
                    Play(3, 3, Puzzles_9x9.Puzzles_9x9_Diabolic.ListPuzzles[index]);
                }
            }
        }



        

        private void Play(int nbRows_Per_Block, int nbCols_Per_Block, int[,] Puzzle)
        {
            Window WindSudoku = new Window();
            Grid GridUser = new Grid();

            ModelSudoku VmSudoku = new ModelSudoku(nbRows_Per_Block, nbCols_Per_Block);
            VmSudoku.Initialiser(Puzzle);

            for (int IndexSudoku = 0; IndexSudoku < VmSudoku.NbRows_Per_Block * VmSudoku.NbCols_Per_Block; IndexSudoku++)
            {
                RowDefinition Row = new RowDefinition();
                GridUser.RowDefinitions.Add(Row);

                ColumnDefinition Col = new ColumnDefinition();
                GridUser.ColumnDefinitions.Add(Col);
            }

            WindSudoku.Content = GridUser;


            int indexRowCell_In_Block;
            int indexColCell_In_Block;

            int indexRowBlock_In_Sudoku;
            int indexColBlock_In_Sudoku;

            int indexRowCell_In_GridUser;
            int indexColCell_In_GridUser;

            int nbBlocksRow = VmSudoku.NbCols_Per_Block;
            int nbBlocksCol = VmSudoku.NbRows_Per_Block;

            int indexRowBorder;
            int indexColBorder;

            int index_In_BlockArray1D;



            //TEXTBOX: Enter a number, and TEXTBLOCK: constant

            for (indexRowBlock_In_Sudoku = 0; indexRowBlock_In_Sudoku < nbBlocksRow; indexRowBlock_In_Sudoku++)
            {
                for (indexColBlock_In_Sudoku = 0; indexColBlock_In_Sudoku < nbBlocksCol; indexColBlock_In_Sudoku++)
                {
                    for (indexRowCell_In_Block = 0; indexRowCell_In_Block < VmSudoku.NbRows_Per_Block; indexRowCell_In_Block++)
                    {
                        for (indexColCell_In_Block = 0; indexColCell_In_Block < VmSudoku.NbCols_Per_Block; indexColCell_In_Block++)
                        {
                            if (Puzzle[VmSudoku.Row_In_Sudoku(indexRowBlock_In_Sudoku, indexColBlock_In_Sudoku), VmSudoku.Column_In_Sudoku(indexRowCell_In_Block, indexColCell_In_Block)] == 0)
                            {
                                TextBox Cell = new TextBox
                                {
                                    HorizontalAlignment = HorizontalAlignment.Stretch,
                                    VerticalAlignment = VerticalAlignment.Stretch,
                                    TextAlignment = TextAlignment.Center,
                                    FontSize = 35,
                                };

                                GridUser.Children.Add(Cell);


                                Grid.SetRow(Cell, VmSudoku.Row_In_GridUser(indexRowBlock_In_Sudoku, indexRowCell_In_Block));
                                Grid.SetColumn(Cell, VmSudoku.Column_In_GridUser(indexColBlock_In_Sudoku, indexColCell_In_Block));

                                _ = new RowPuzzle(VmSudoku.Row_In_GridUser(indexRowBlock_In_Sudoku, indexRowCell_In_Block));
                                RowPuzzle RowP = (RowPuzzle)VmSudoku.Array_Rows[VmSudoku.Row_In_GridUser(indexRowBlock_In_Sudoku, indexRowCell_In_Block)];

                                Binding BindRow = new Binding
                                {
                                    Source = RowP,
                                    Path = new PropertyPath(string.Format("Array1D[{0}]", VmSudoku.Column_In_GridUser(indexColBlock_In_Sudoku, indexColCell_In_Block)))
                                };


                                _ = new ColumnPuzzle(VmSudoku.Column_In_GridUser(indexColBlock_In_Sudoku, indexColCell_In_Block));
                                ColumnPuzzle ColP = (ColumnPuzzle)VmSudoku.Array_Cols[VmSudoku.Column_In_GridUser(indexColBlock_In_Sudoku, indexColCell_In_Block)];

                                Binding BindCol = new Binding
                                {
                                    Source = ColP,
                                    Path = new PropertyPath(string.Format("Array1D[{0}]", VmSudoku.Row_In_GridUser(indexRowBlock_In_Sudoku, indexRowCell_In_Block)))
                                };

                                index_In_BlockArray1D = indexColCell_In_Block + VmSudoku.NbCols_Per_Block * indexRowCell_In_Block;

                                Binding BindBlock = new Binding
                                {
                                    Source = (BlockPuzzle)VmSudoku.Array_Blocks[VmSudoku.Row_In_Sudoku(indexRowBlock_In_Sudoku, indexColBlock_In_Sudoku)],
                                    Path = new PropertyPath(string.Format("Array1D[{0}]", VmSudoku.IndexArray1D_In_Block(indexRowCell_In_Block, indexColCell_In_Block)))
                                };

                                MultiBinding MultiBind = new MultiBinding
                                {

                                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                                    NotifyOnSourceUpdated = true,
                                    Mode = BindingMode.OneWayToSource,

                                    Converter = new MultiConverterTab()
                                };

                                MultiBind.Bindings.Add(BindRow);
                                MultiBind.Bindings.Add(BindCol);
                                MultiBind.Bindings.Add(BindBlock);

                                Cell.SetBinding(TextBox.TextProperty, MultiBind);

                                Cell.SourceUpdated += Cell_SourceUpdated;

                                //Cell.TextChanged += Cell_TextChanged;
                            }
                            else
                            {
                                TextBlock Cell = new TextBlock
                                {
                                    Background = Brushes.LightGray,
                                    FontWeight = FontWeights.Bold,
                                    HorizontalAlignment = HorizontalAlignment.Stretch,
                                    VerticalAlignment = VerticalAlignment.Stretch,
                                    TextAlignment = TextAlignment.Center,
                                    FontSize = 35,
                                    Text = Puzzle[VmSudoku.Row_In_Sudoku(indexRowBlock_In_Sudoku, indexColBlock_In_Sudoku), VmSudoku.Column_In_Sudoku(indexRowCell_In_Block, indexColCell_In_Block)].ToString()
                                };

                                GridUser.Children.Add(Cell);

                                Grid.SetRow(Cell, VmSudoku.Row_In_GridUser(indexRowBlock_In_Sudoku, indexRowCell_In_Block));
                                Grid.SetColumn(Cell, VmSudoku.Column_In_GridUser(indexColBlock_In_Sudoku, indexColCell_In_Block));
                            }
                        }
                    }
                }
            }

           //BORDERS
            for (indexRowBlock_In_Sudoku = 0; indexRowBlock_In_Sudoku < nbBlocksRow; indexRowBlock_In_Sudoku++)
            {
                indexRowBorder = indexRowBlock_In_Sudoku * VmSudoku.NbRows_Per_Block;

              
                for (indexColBlock_In_Sudoku = 0; indexColBlock_In_Sudoku < nbBlocksCol; indexColBlock_In_Sudoku++)
                {

                    //THIN BORDERS
                    for (indexRowCell_In_Block = 0; indexRowCell_In_Block < VmSudoku.NbRows_Per_Block; indexRowCell_In_Block++)
                    {
                        for (indexColCell_In_Block = 0; indexColCell_In_Block < VmSudoku.NbCols_Per_Block; indexColCell_In_Block++)
                        {
                            Border ThinBord = new Border
                            {
                                BorderThickness = new Thickness(1),
                                BorderBrush = Brushes.Gray
                            };

                            indexRowCell_In_GridUser = indexRowCell_In_Block + VmSudoku.NbRows_Per_Block * indexRowBlock_In_Sudoku;
                            indexColCell_In_GridUser = indexColCell_In_Block + VmSudoku.NbCols_Per_Block * indexColBlock_In_Sudoku;

                            GridUser.Children.Add(ThinBord);

                            Grid.SetRow(ThinBord, indexRowCell_In_GridUser);
                            Grid.SetColumn(ThinBord, indexColCell_In_GridUser);
                        }
                    }

                    
                    //THICK BORDERS
                    Border ThickBord = new Border
                    {
                        BorderThickness = new Thickness(5),
                        BorderBrush = Brushes.Black
                    };

                    GridUser.Children.Add(ThickBord);


                    indexColBorder = indexColBlock_In_Sudoku * VmSudoku.NbCols_Per_Block;

                    Grid.SetRow(ThickBord, indexRowBorder);
                    Grid.SetColumn(ThickBord, indexColBorder);

                    Grid.SetRowSpan(ThickBord, VmSudoku.NbRows_Per_Block);
                    Grid.SetColumnSpan(ThickBord, VmSudoku.NbCols_Per_Block);

                }
            }

            VmSudoku.EventWin += VmSudoku_EventWin;

            WindSudoku.Show();

        }

        private void Cell_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            _ = new TextBox();
            TextBox TextSender = (TextBox)sender;

            new MultiBinding();
            MultiBinding MultiBindText = BindingOperations.GetMultiBinding(TextSender, TextBox.TextProperty);

            new Binding();
            Binding Bind0 = (Binding)MultiBindText.Bindings[0];

            int rowText = Grid.GetRow(TextSender);

            new RowPuzzle(rowText);
            RowPuzzle SourceBindR = (RowPuzzle)Bind0.Source;

            if (SourceBindR.ParentGrid.Win())
            {
                SourceBindR.ParentGrid.OnWinTrigger();
            }
        }

        private void VmSudoku_EventWin(object sender)
        {
            MessageBox.Show("CONGRATULATIONS !! \n You solved this Puzzle !!!");
        }

    }

}






        
    

