using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace Sudoku
{
    /// <summary>
    /// Класс ячейки поля.
    /// </summary>
    public class Cell
    {
        /// <summary>
        /// Имя ячейки. Пример: TextBoxX1Y1R1.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Значение ячейки.
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// Признак активности ячейки.
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// Отображаемый цвет ячейки на поле.
        /// </summary>
        public Brush Color { get; }
        /// <summary>
        /// Набор возможных значений ячейки.
        /// </summary>
        public List<int> PossibleValues { get; set; }
        /// <summary>
        /// Положение ячейки относительно оси X.
        /// </summary>
        public int X { get; }
        /// <summary>
        /// Положение ячейки относительно оси Y.
        /// </summary>
        public int Y { get; }
        /// <summary>
        /// Положение ячейки относительно квадрата из 9 ячеек.
        /// </summary>
        public int R { get; }

        /// <summary>
        /// Создание ячейки через заданное имя и значение.
        /// </summary>
        /// <param name="name">Имя ячейки.</param>
        /// <param name="value">Значение ячейки.</param>
        public Cell(string name, int value)
        {
            //Получение имени, значения и координат из парсинга имени ячейки.
            Name = name;            
            Value = value;
            X = int.Parse(name[8].ToString());
            Y = int.Parse(name[10].ToString());
            R = int.Parse(name[12].ToString());

            if (Value == 0)
            {
                PossibleValues = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                IsActive = true;
                Color = Brushes.Green;
            }
            else
            {
                PossibleValues = null;
                Color = Brushes.Black;
            }                
        }
    }
}
