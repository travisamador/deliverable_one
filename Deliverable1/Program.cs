using System;

namespace deliverable1
{
    class Sandwiches
    {
        static void Main(string[] args)
        {
            bool restart = true;
            do
            {
                //ask user how many people are being fed
                Console.WriteLine("How Many people are we making PB & J sandwiches for?");
                int sandwichNum = int.Parse(Console.ReadLine());
                //determine total amounts of ingredients
                double slices = sandwichNum * 2;
                double tablespoonsPB = sandwichNum * 2;
                double teaspoonsJ = sandwichNum * 4;
                //determine total loaves and jars of PB & J
                double loaves = Math.Ceiling(slices / 28);
                double jarsPB = Math.Ceiling(tablespoonsPB / 32);
                double jarsJ = Math.Ceiling(teaspoonsJ / 48);
                //output amounts needed to user
                Console.WriteLine();
                Console.WriteLine("You need:");
                Console.WriteLine();
                Console.WriteLine(slices + " slices of bread");
                Console.WriteLine(tablespoonsPB + " tablespoons of peanut butter");
                Console.WriteLine(teaspoonsJ + " teaspoons of jelly");
                Console.WriteLine();
                Console.WriteLine("which is...");
                Console.WriteLine();
                Console.WriteLine(loaves + " loaves of bread");
                Console.WriteLine(jarsPB + " jars of peanut butter");
                Console.WriteLine(jarsJ + " jars of jelly");
                //ask if user wants to restart
                Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
                string restartAnswer = Console.ReadLine();
                if (restartAnswer != "y" && restartAnswer != "yes")
                {
                    restart = false;
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            while (restart == true);
        }

    }
}
