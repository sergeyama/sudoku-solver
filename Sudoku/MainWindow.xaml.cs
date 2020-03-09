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
        private int[] testExample;
        private Grid grid;

        public MainWindow()
        {
            InitializeComponent();

            #region Инициализация тестого набора

            testExample = new int[81] {
                0, 0, 0, 0, 4, 7, 0, 0, 8,
                0, 8, 0, 0, 0, 5, 0, 0, 0,
                0, 0, 2, 8, 0, 0, 1, 9, 0,
                0, 4, 0, 0, 8, 0, 0, 0, 0,
                0, 0, 7, 4, 0, 0, 0, 0, 0,
                1, 0, 0, 0, 2, 0, 0, 7, 0,
                9, 0, 0, 0, 0, 0, 6, 0, 0,
                2, 0, 1, 0, 0, 0, 0, 3, 0,
                0, 0, 0, 0, 7, 0, 2, 0, 0
            };

            grid = new Grid(testExample);

            foreach (Cell item in grid)
            {
                if(item.Value != 0)
                    MainGrid.Children.OfType<TextBox>().FirstOrDefault(o => o.Name == item.Name).Text = item.Value.ToString();
            }

            #endregion
        }

        private void TextBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
