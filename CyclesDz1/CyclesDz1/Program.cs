using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclesDz1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberUser = 0;
            bool isValidInput;
            do
            {
                isValidInput = int.TryParse(Console.ReadLine(), out numberUser);

            } while (isValidInput != true);
            for (int i = 1; i <= numberUser; i++)
            {
                if(numberUser % i == 0)
                {
                    Console.Write($"{i}; ");
                }
            }
            Console.ReadKey();
        }
    }
}
