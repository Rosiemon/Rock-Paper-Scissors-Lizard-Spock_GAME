﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game Game = new Game();
            Computer computer = new Computer();

            Game.PlayGame();

            Console.ReadLine();
        }
    }
}