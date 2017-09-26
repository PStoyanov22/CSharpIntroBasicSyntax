using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCard
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            Console.Write($"{number:d4} ");
            Console.Write($"{number1:d4} ");
            Console.Write($"{number2:d4} ");
            Console.WriteLine($"{number3:d4}");

        }
    }
}
