using System;
using System.Collections.Generic;

namespace Sudoku
{
    public class Cell
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public bool IsActive { get; }
        public List<int> PossibleValues { get; set; }
        public int X { get; }
        public int Y { get; }
        public int R { get; }

        public Cell(string name, int value)
        {
            Name = name;            
            Value = value;
            X = Convert.ToInt32(name[8]);
            Y = Convert.ToInt32(name[10]);
            R = Convert.ToInt32(name[12]);

            if (Value == 0)
            {
                PossibleValues = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                IsActive = true;
            }
            else
                PossibleValues = null;
        }
    }
}
