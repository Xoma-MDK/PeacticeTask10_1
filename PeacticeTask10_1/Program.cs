using System;

namespace PeacticeTask10_1
{
    internal class Program
    {
        public static int[,] Rotate(int[,] m)
        {
            int[,] result = new int[m.GetLength(1), m.GetLength(0)];

            for (int i = 0; i < m.GetLength(1); i++)
                for (int j = 0; j < m.GetLength(0); j++)
                    result[i, j] = m[m.GetLength(0) - j - 1, i];

            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите элементы построчно: ");
            int[,] array = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine($"Введенный массив: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{array[i, j],5}");
                }
                Console.WriteLine();
            }
            array = Rotate(array);
            array = Rotate(array);
            Console.WriteLine($"Сформированный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j],5}");
                    if (array[i, j] < 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine($" Кол-во отрицательных элементов в строке: {count}");
            }
        }
    }
}
