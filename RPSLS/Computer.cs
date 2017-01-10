using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        public override void GetName()
        {
            Random random = new Random();
            List<string> names = new List<string> {"Cortana", "Alexa", "Siri", "Elvis", "Hercules", "Apollo"};
            name = names[random.Next(0, 5)];
            Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("\nHello! My name is {0} and I'll be your opponent. \n", name); Console.ResetColor();
        }
        public override void MakeChoice()
        {
            Random random = new Random();
            List<int> choices = new List<int> { 1, 2, 3, 4, 5};
            choice = choices[random.Next(1, 4)];
            Console.WriteLine(choice);
        }
    }
}