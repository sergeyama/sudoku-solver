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
        /// Признак найденной уникальной цифры.
        /// </summary>
        private bool _findNumber = true;

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
            //Убираем дубли начальных значений из возможных среди пустых ячеек.
            SetPossibleValues();

            //Выставляем очевидные значения.
            FindUniqueValueAlgorithm();

            while (_findNumber)
            {
                _findNumber = false;

                FindTwoCellsWithTwoPairAlgorithm();

                FindUniqueValueAlgorithm();
            }
        }

        private void FindTwoCellsWithTwoPairAlgorithm()
        {
            for (int i = 0; i < 9; i++)
            {
                var rectungleCells = _grid.GetRectungleGroupCells(i + 1).Where(o => o.IsActive).ToList();

                foreach (var cell in rectungleCells)
                {
                    List<Cell> twoCells = rectungleCells.Where(o => o.PossibleValues.SequenceEqual(cell.PossibleValues) && o.PossibleValues.Count == 2).ToList();

                    if (twoCells.Count == 2)
                    {
                        foreach (var cellForRemove in rectungleCells)
                        {
                            if (!cellForRemove.PossibleValues.SequenceEqual(twoCells[0].PossibleValues))
                            {
                                cellForRemove.PossibleValues.Remove(twoCells[0].PossibleValues[0]);
                                cellForRemove.PossibleValues.Remove(twoCells[0].PossibleValues[1]);

                                //TODO: добавить чистку дубликатов из строк и стобцов для подобных ячеек
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Поиск уникального значения в ячейке среди смежных ячеек и установка значений с деактивацией.
        /// </summary>
        private void FindUniqueValueAlgorithm()
        {          
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

                        if (hasMatch == 0 || (item.IsActive && item.PossibleValues.Count == 1))
                        {
                            item.Value = number;
                            item.PossibleValues = null;
                            item.IsActive = false;
                            _findNumber = true;
                            SetPossibleValues();
                        }
                    }
                }
            }            
        }

        /// <summary>
        /// Убирает дубликаты значений связанных ячеек (не активных) в списке возможных значений всех ячеек.
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
