using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            char pipe = '|';
            int healthPipeNumber = currentHealth;
            int energyPipeNumber = currentEnergy;

            char dot = '.';
            int healthDotNumber = maxHealth - currentHealth;
            int energyDotNumber = maxEnergy - currentEnergy;


            string formatHealth = "{0}{1}{2}{0}";
            string formatEnergy = "{0}{1}{2}{0}";

            string healthFormat = string.Format(formatHealth, pipe, new string(pipe, healthPipeNumber),
                                                                    new string(dot, healthDotNumber), pipe);

            string energyFormat = string.Format(formatHealth, pipe, new string(pipe, energyPipeNumber),
                                                                    new string(dot, energyDotNumber), pipe);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: {healthFormat}");
            Console.WriteLine($"Energy: {energyFormat}");

        }
    }
}
