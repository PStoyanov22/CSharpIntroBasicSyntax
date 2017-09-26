using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            int energyPer100 = int.Parse(Console.ReadLine());
            int sugarPer100 = int.Parse(Console.ReadLine());

            double totalEnergy = (volume / 100) * energyPer100;
            double totalSugar = (volume / 100) * sugarPer100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");


        }
    }
}
