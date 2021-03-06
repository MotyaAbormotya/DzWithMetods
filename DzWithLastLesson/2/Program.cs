using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {


            
            while (true)
            {
               
                string message = Console.ReadLine();
                WriteError(message);
               
              
               
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                message = Console.ReadLine();
                WriteTrubl(message);


                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                message = Console.ReadLine();
                WriteRandom(message);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static string WriteError(string message)
        {
            ConsoleColor error = ConsoleColor.Red;
            Console.ForegroundColor = error;
            Console.Write(message);
            return (message);
        }
        public static string WriteTrubl(string message)
        {
            ConsoleColor trubl = ConsoleColor.Yellow;
            Console.ForegroundColor = trubl;
            Console.Write(message);
            return (message);
        }
        public static string WriteRandom(string message)
        {
            ConsoleColor randomColor;
            Random random = new Random();
            int numberColor = random.Next(1, 3 + 1);
            switch(numberColor)
            {
                case 1:
                    randomColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = randomColor;
                    Console.Write(message);
                    break;
                case 2:
                    randomColor = ConsoleColor.Blue;
                    Console.ForegroundColor = randomColor;
                    Console.Write(message);
                    break;
                case 3:
                    randomColor = ConsoleColor.Green;
                    Console.ForegroundColor = randomColor;
                    Console.Write(message);
                    break;
            }
            return (message);
        }
    }
}
