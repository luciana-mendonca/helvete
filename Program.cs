using System;

namespace Helvete
{
    class Program
    {
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            Start();
            Encounters.FirstEncounter();
        }

        static void Start()
        {
            Console.WriteLine("Welcome to Helvete!\n");
            Console.WriteLine("Type your name:");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\nYou awake in a cold, stone, dark room. You feel dazed and are having trouble remembering");
            Console.WriteLine("anything about your past.");

            if (currentPlayer.name == "")
            {
                Console.WriteLine("\nYou can't even remember your own name...");
            }
            else
            {
                Console.WriteLine("\nYou know your name is " + currentPlayer.name + ".");
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You grope around in the darkness until you find a door handle. You feel some resistance as");
            Console.WriteLine("you turn the handle, but the rusty lock breaks with little effort. You see your captor");
            Console.WriteLine("standing with his back to you outside the door.");
                
        }
    }
}
