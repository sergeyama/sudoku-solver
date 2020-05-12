using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sudoku
{
    /// <summary>
    /// Класс решения головоломки.
    /// </summary>
    public class Solver
    {
        /// <summary>
        /// Игровое поле.
        /// </summary>
        private Grid _grid;

        /// <summary>
        /// Создание решения для конкретного поля.
        /// </summary>
        /// <param name="grid">Игровое поле.</param>
        public Solver(Grid grid)
        {
            _grid = grid;
        }

        /// <summary>
        /// Основной метод для решения головоломки.
        /// </summary>
        public void SolveIt()
        {
            SetPossibleValues();

            foreach (Cell item in _grid)
            {
                if (item.IsActive)
                {
                    var groupCells = _grid.GetGroupCells(item.X, item.Y, item.R);
                    groupCells = groupCells.Where(o => o.R == item.R && o.PossibleValues != null).ToList();
                    int hasMatch;

                    foreach (int number in item.PossibleValues)
                    {
                        hasMatch = 0;

                        foreach (Cell cell in groupCells)
                        {
                            if (cell.PossibleValues.Contains(number))
                                hasMatch++;
                        }

                        if (hasMatch == 0)
                        {
                            item.Value = number;
                            item.PossibleValues = null;
                            item.IsActive = false;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Убирает дубликаты значений связанных ячеек в списке возможных значений всех ячеек.
        /// </summary>
        private void SetPossibleValues()
        {
            foreach (Cell item in _grid)
            {
                if (item.IsActive)
                {
                    var groupCells = _grid.GetGroupCells(item.X, item.Y, item.R);

                    foreach (Cell cell in groupCells)
                    {
                        item.PossibleValues.Remove(cell.Value);
                    }
                }
            }
        }
    }
}
