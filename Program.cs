using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vavedete chisla za matrix 2x2");
            int[,] Matrix = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Matrix [i,j] =int.Parse(Console.ReadLine());
                }
            }
            

        }
    }
}
