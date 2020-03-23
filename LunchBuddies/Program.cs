using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
           

            LunchBuddy lunchBuddy1 = new LunchBuddy("Charity", "Bunyon");

            LunchBuddy lunchBuddy2= new LunchBuddy("Jameka", "Echols");

            LunchBuddy lunchBuddy3 = new LunchBuddy("Jeressia", "Williamson");

            LunchBuddy lunchBuddy4 = new LunchBuddy("Chelsey", "Miles");

            LunchBuddy lunchBuddy5 = new LunchBuddy("Danielle", "Kinzer");


            List<LunchBuddy> companions = new List<LunchBuddy> { };
            companions.Add(lunchBuddy1);
            companions.Add(lunchBuddy2);
            companions.Add(lunchBuddy3);
            companions.Add(lunchBuddy4);

            lunchBuddy1.Eat();
            lunchBuddy2.Eat("Crepes");
            lunchBuddy3.Eat(companions);
            lunchBuddy4.Eat("Pizza", companions);
            Console.ReadLine();

        }



    }
}
