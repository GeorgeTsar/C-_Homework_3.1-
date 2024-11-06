using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Homework_3._1
{
    class Matrix
    {
        private int Columns;
        private int Rows;
        private int[,] M;

        // Конструктор по умолчанию
        public Matrix() { }

        // Конструктор с параметрами
        public Matrix(int C, int R)  
        {
            this.Columns = C;
            this.Rows = R;
            M = new int[this.Columns, this.Rows];
        }

        // Ввод матрицы с клавиатуры
        public void WriteMatrix()
        {
            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    Console.WriteLine("Введите элемент матрицы {0}:{1}", i + 1, j + 1);
                    M[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        // Инициализация рандомом
        public void RandomMatrix()
        {
            Random rand = new Random();
            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    M[i, j] = rand.Next(-20, 20);
                }
            }
        }

        // Вывод матрицы на консоль
        public void PrintState()
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write($"{M[i, j]}" + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void PrintMax()
        {
            Console.WriteLine("Максимальный элемент матрицы = " + M.Cast<int>().Max());
        }

        public void PrintMin()
        {
            Console.WriteLine("Минимальный элемент матрицы = " + M.Cast<int>().Min());
        }
    }
}
