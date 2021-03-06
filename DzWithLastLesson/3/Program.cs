using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                int number = int.Parse(Console.ReadLine());
                Square(number);
            }
        }
        public static int Square(int square)
        {
            square *= square;
            Console.WriteLine(square);
            Console.WriteLine();
            return square;
        }
    }
}
