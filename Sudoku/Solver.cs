using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sudoku
{
    public class Solver
    {
        private Grid _grid;

        public Solver(Grid grid)
        {
            _grid = grid;
        }

        public void SolveIt()
        {
            SetPossibleValues();

            foreach (Cell item in _grid)
            {
                if (item.IsActive)
                {
                    var groupCells = _grid.GetGroupCells(item.X, item.Y, item.R);
                    groupCells = groupCells.Where(o => o.R == item.R && o.PossibleValues != null).ToList();
                    int hasMatch = 0;

                    foreach (int number in item.PossibleValues)
                    {
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
