using System;
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

namespace Sudoku
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[,] testExample;
        private Grid grid = new Grid();

        public MainWindow()
        {
            InitializeComponent();

            #region Инициализация тестого набора

            testExample = new int[9, 9] {
                { 0, 0, 0, 0, 4, 7, 0, 0, 8 },
                { 0, 8, 0, 0, 0, 5, 0, 0, 0 },
                { 0, 0, 2, 8, 0, 0, 1, 9, 0 },
                { 0, 4, 0, 0, 8, 0, 0, 0, 0 },
                { 0, 0, 7, 4, 0, 0, 0, 0, 0 },
                { 1, 0, 0, 0, 2, 0, 0, 7, 0 },
                { 9, 0, 0, 0, 0, 0, 6, 0, 0 },
                { 2, 0, 1, 0, 0, 0, 0, 3, 0 },
                { 0, 0, 0, 0, 7, 0, 2, 0, 0 }
            };
            int r = 3;

            for (int i = 0; i < 9; i++)
            {
                if (i < 3) r = 3;
                if (i > 2 && i < 6) r = 12;
                if (i > 5) r = 21;

                for (int j = 0; j < 9; j++)
                {
                    if (testExample[i, j] != 0)
                    {
                        MainGrid.Children.OfType<TextBox>().FirstOrDefault(o => o.Name == $"TextBoxX{j + 1}Y{i + 1}R{r / 3}").Text = testExample[i, j].ToString();
                    }
                    else
                    {
                        grid[$"TextBoxX{j + 1}Y{i + 1}R{r / 3}"] = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    }
                        
                    r++;
                }
            }

            #endregion
        }

        private void TextBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
