using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        public List<string> choices = new List<string>();
        Random random = new Random();
        public void Load(int data)
        {
            choices.Add("Rock");
            choices.Add("Paper");
            choices.Add("Scissors");
            choices.Add("Lizard");
            choices.Add("Spock");
        }

        public string MakeChoice()
        {
            int choice = random.Next(choices.Count);
            Console.WriteLine(choices[choice]);
            return choices[choice];
        }
    }
}
