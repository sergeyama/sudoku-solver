using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    public struct Cell
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public bool IsActive { get; }
        public List<int> PossibleValues { get; set; }

        public Cell(string name, int value)
        {
            Name = name;            
            Value = value;

            if (Value == 0)
            {
                PossibleValues = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                IsActive = true;
            }
            else
            {
                PossibleValues = null;
                IsActive = false;
            }                
        }
    }
}
