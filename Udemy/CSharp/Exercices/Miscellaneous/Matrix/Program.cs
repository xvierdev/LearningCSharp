using System;
using System.Net.WebSockets;
using System.Transactions;
namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, cols, find;
            Console.Write("Enter the number of rows: ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of cols: ");
            cols = int.Parse(Console.ReadLine());
            int[,] mtx = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    mtx[i, j] = int.Parse(data[j]);
                }
            }

            Console.Write("Enter the number to find: ");
            find = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mtx[i, j] == find)
                    {
                        Console.WriteLine($"Position: [{i},{j}]");
                        if (i > 0)
                        {
                            Console.WriteLine("Top: " + mtx[i - 1, j]);
                        }
                        if (i < cols - 1)
                        {
                            Console.WriteLine("Botton: " + mtx[i + 1, j]);
                        }
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mtx[i, j - 1]);
                        }
                        if (j < rows - 1)
                        {
                            Console.WriteLine("Right: " + mtx[i, j + 1]);
                        }
                    }
                }
            }
        }
    }
}