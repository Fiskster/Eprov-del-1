using System;

namespace Eprov_del_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctInput = false;
            while(!correctInput)
            { //simple UI 
                Console.WriteLine("Which hero would you like?");
                Console.WriteLine("1. Minotaur");
                Console.WriteLine("2. Mech");
                Console.WriteLine("3. Undead");
                Console.WriteLine("Press 1,2 or 3 respectivily on your keyboard to choose a character.");
                ConsoleKeyInfo UI = Console.ReadKey();
                if (UI.Key == ConsoleKey.D1) //shows info about selected character
                {
                 Minotaur minotaur = new Minotaur(); 
                 minotaur.showInfo();
                 correctInput = true; 
                 
                }
                if (UI.Key == ConsoleKey.D2) //shows info about selected character
                {
                 Mech bot = new Mech();
                 bot.showInfo();
                 correctInput = true; 
                 
                }
                if (UI.Key == ConsoleKey.D3) //shows info about selected character
                {
                 Undead undead = new Undead();
                 undead.showInfo();
                 correctInput = true; 
                 
                }
                else
                {
                    Console.WriteLine("Please enter a number.");
           }
                Console.ReadLine();
            }
        }
            //Fick slut på tid så han inte sätta in target dummyn :)
    }
}
