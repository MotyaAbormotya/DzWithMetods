using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclesDz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberUser;
            int rank = 0;
            int rankcount = 1;
            bool isValidInput;
            do
            {
                isValidInput = int.TryParse(Console.ReadLine(), out numberUser);
            } while (isValidInput != true);

            for (int i = 0; i <= numberUser; i++)
            {
                if(i == rankcount)
                {
                    rankcount *= 10;
                    rank++;
                }    
            }
            Console.Write($"Разряд {numberUser} - {rank}");               
            Console.ReadKey();
        }
    }
}
