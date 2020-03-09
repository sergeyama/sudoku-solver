using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku
{
    public class Grid : IEnumerable
    {
        private List<Cell> _dataValues = new List<Cell>();

        public Grid(int[] data)
        {
            string[] names = new string[81]
            {
                "TextBoxX1Y1R1",
                "TextBoxX2Y1R1",
                "TextBoxX3Y1R1",
                "TextBoxX4Y1R2",
                "TextBoxX5Y1R2",
                "TextBoxX6Y1R2",
                "TextBoxX7Y1R3",
                "TextBoxX8Y1R3",
                "TextBoxX9Y1R3",
                "TextBoxX1Y2R1",
                "TextBoxX2Y2R1",
                "TextBoxX3Y2R1",
                "TextBoxX4Y2R2",
                "TextBoxX5Y2R2",
                "TextBoxX6Y2R2",
                "TextBoxX7Y2R3",
                "TextBoxX8Y2R3",
                "TextBoxX9Y2R3",
                "TextBoxX1Y3R1",
                "TextBoxX2Y3R1",
                "TextBoxX3Y3R1",
                "TextBoxX4Y3R2",
                "TextBoxX5Y3R2",
                "TextBoxX6Y3R2",
                "TextBoxX7Y3R3",
                "TextBoxX8Y3R3",
                "TextBoxX9Y3R3",
                "TextBoxX1Y4R4",
                "TextBoxX2Y4R4",
                "TextBoxX3Y4R4",
                "TextBoxX4Y4R5",
                "TextBoxX5Y4R5",
                "TextBoxX6Y4R5",
                "TextBoxX7Y4R6",
                "TextBoxX8Y4R6",
                "TextBoxX9Y4R6",
                "TextBoxX1Y5R4",
                "TextBoxX2Y5R4",
                "TextBoxX3Y5R4",
                "TextBoxX4Y5R5",
                "TextBoxX5Y5R5",
                "TextBoxX6Y5R5",
                "TextBoxX7Y5R6",
                "TextBoxX8Y5R6",
                "TextBoxX9Y5R6",
                "TextBoxX1Y6R4",
                "TextBoxX2Y6R4",
                "TextBoxX3Y6R4",
                "TextBoxX4Y6R5",
                "TextBoxX5Y6R5",
                "TextBoxX6Y6R5",
                "TextBoxX7Y6R6",
                "TextBoxX8Y6R6",
                "TextBoxX9Y6R6",
                "TextBoxX1Y7R7",
                "TextBoxX2Y7R7",
                "TextBoxX3Y7R7",
                "TextBoxX4Y7R8",
                "TextBoxX5Y7R8",
                "TextBoxX6Y7R8",
                "TextBoxX7Y7R9",
                "TextBoxX8Y7R9",
                "TextBoxX9Y7R9",
                "TextBoxX1Y8R7",
                "TextBoxX2Y8R7",
                "TextBoxX3Y8R7",
                "TextBoxX4Y8R8",
                "TextBoxX5Y8R8",
                "TextBoxX6Y8R8",
                "TextBoxX7Y8R9",
                "TextBoxX8Y8R9",
                "TextBoxX9Y8R9",
                "TextBoxX1Y9R7",
                "TextBoxX2Y9R7",
                "TextBoxX3Y9R7",
                "TextBoxX4Y9R8",
                "TextBoxX5Y9R8",
                "TextBoxX6Y9R8",
                "TextBoxX7Y9R9",
                "TextBoxX8Y9R9",
                "TextBoxX9Y9R9"
            };

            for (int i = 0; i < data.Length; i++)
            {
                Cell cell = new Cell(names[i], data[i]);
                _dataValues.Add(cell);
            }
        }

        public int this[string name]
        {
            get
            {
                return _dataValues.First(o => o.Name == name).Value;
            }
            
            set
            {
                _dataValues.First(o => o.Name == name).Value = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _dataValues.GetEnumerator();
        }
    }
}
