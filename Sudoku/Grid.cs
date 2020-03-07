using System.Collections;
using System.Collections.Generic;

namespace Sudoku
{
    public class Grid : IEnumerable
    {
        private Dictionary<string, List<int>> dataValues;

        public Grid()
        {
            dataValues = new Dictionary<string, List<int>>() 
            {
                { "TextBoxX1Y1R1", null },
                { "TextBoxX2Y1R1", null },
                { "TextBoxX3Y1R1", null },
                { "TextBoxX4Y1R2", null },
                { "TextBoxX5Y1R2", null },
                { "TextBoxX6Y1R2", null },
                { "TextBoxX7Y1R3", null },
                { "TextBoxX8Y1R3", null },
                { "TextBoxX9Y1R3", null },
                { "TextBoxX1Y2R1", null },
                { "TextBoxX2Y2R1", null },
                { "TextBoxX3Y2R1", null },
                { "TextBoxX4Y2R2", null },
                { "TextBoxX5Y2R2", null },
                { "TextBoxX6Y2R2", null },
                { "TextBoxX7Y2R3", null },
                { "TextBoxX8Y2R3", null },
                { "TextBoxX9Y2R3", null },
                { "TextBoxX1Y3R1", null },
                { "TextBoxX2Y3R1", null },
                { "TextBoxX3Y3R1", null },
                { "TextBoxX4Y3R2", null },
                { "TextBoxX5Y3R2", null },
                { "TextBoxX6Y3R2", null },
                { "TextBoxX7Y3R3", null },
                { "TextBoxX8Y3R3", null },
                { "TextBoxX9Y3R3", null },
                { "TextBoxX1Y4R4", null },
                { "TextBoxX2Y4R4", null },
                { "TextBoxX3Y4R4", null },
                { "TextBoxX4Y4R5", null },
                { "TextBoxX5Y4R5", null },
                { "TextBoxX6Y4R5", null },
                { "TextBoxX7Y4R6", null },
                { "TextBoxX8Y4R6", null },
                { "TextBoxX9Y4R6", null },
                { "TextBoxX1Y5R4", null },
                { "TextBoxX2Y5R4", null },
                { "TextBoxX3Y5R4", null },
                { "TextBoxX4Y5R5", null },
                { "TextBoxX5Y5R5", null },
                { "TextBoxX6Y5R5", null },
                { "TextBoxX7Y5R6", null },
                { "TextBoxX8Y5R6", null },
                { "TextBoxX9Y5R6", null },
                { "TextBoxX1Y6R4", null },
                { "TextBoxX2Y6R4", null },
                { "TextBoxX3Y6R4", null },
                { "TextBoxX4Y6R5", null },
                { "TextBoxX5Y6R5", null },
                { "TextBoxX6Y6R5", null },
                { "TextBoxX7Y6R6", null },
                { "TextBoxX8Y6R6", null },
                { "TextBoxX9Y6R6", null },
                { "TextBoxX1Y7R7", null },
                { "TextBoxX2Y7R7", null },
                { "TextBoxX3Y7R7", null },
                { "TextBoxX4Y7R8", null },
                { "TextBoxX5Y7R8", null },
                { "TextBoxX6Y7R8", null },
                { "TextBoxX7Y7R9", null },
                { "TextBoxX8Y7R9", null },
                { "TextBoxX9Y7R9", null },
                { "TextBoxX1Y8R7", null },
                { "TextBoxX2Y8R7", null },
                { "TextBoxX3Y8R7", null },
                { "TextBoxX4Y8R8", null },
                { "TextBoxX5Y8R8", null },
                { "TextBoxX6Y8R8", null },
                { "TextBoxX7Y8R9", null },
                { "TextBoxX8Y8R9", null },
                { "TextBoxX9Y8R9", null },
                { "TextBoxX1Y9R7", null },
                { "TextBoxX2Y9R7", null },
                { "TextBoxX3Y9R7", null },
                { "TextBoxX4Y9R8", null },
                { "TextBoxX5Y9R8", null },
                { "TextBoxX6Y9R8", null },
                { "TextBoxX7Y9R9", null },
                { "TextBoxX8Y9R9", null },
                { "TextBoxX9Y9R9", null }
            };
        }

        public List<int> this[string name]
        {
            get
            {
                return dataValues[name];
            }

            set
            {
                dataValues[name] = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)dataValues).GetEnumerator();
        }
    }
}
