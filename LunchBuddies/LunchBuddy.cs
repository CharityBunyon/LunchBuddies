using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    public class LunchBuddy
    {
        //declaring properties
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        
        
        public LunchBuddy(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
        //creating methods
        //Will select a random restaurant name from a list of strings (List of restaurant names can come from anywhere), print to console that the buddy is at that restaurant, and also return the restaurant.
        public void Eat()
        {
            var resturant = new Resturant();
            Console.WriteLine($"{Firstname} {Lastname} is eating at {resturant.Name}.");
        }

        //Will output that the buddy ate that specific food at the office.
        public void Eat(string food)
        {
            Console.WriteLine($"{Firstname} {Lastname} is eating {food} in their office.");
        }

        //Will select a random restaurant name from a list of strings, print to console that the buddy is at that restaurant, and also output the first name of each lunch buddy in the specified list.
        public void Eat(List<LunchBuddy> companions)
        {
            var restaurant = new Resturant();
            var firstNames = new List<string> { };
            foreach (var companion in companions)
            {
                var first = companion.Firstname;
                firstNames.Add(first);
            }
            string buddies = string.Join(", ", firstNames);
            Console.WriteLine($"{Firstname} {Lastname} is at {restaurant.Name} with {buddies}.");
        }

        //Will select a random restaurant name from a list of strings, print to console that the buddy at that restaurant, and ordered the specified food, with the first name of the teammates specified in the list.
        public void Eat(string food, List<LunchBuddy> companions)
        {
            var resturant = new Resturant();
            var firstNames = new List<string> { };
            foreach (var companion in companions)
            {
                var first = companion.Firstname;
                firstNames.Add(first);
            }
            string buddies = string.Join(", ", firstNames);
            Console.WriteLine($" Just ordered some {food} at {resturant.Name} with {buddies}.");
        }
    }
}
