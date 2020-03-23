using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    public class Resturant
    {
        private List<string> _resturants { get; } = new List<string> { "Saint Anejo", "Sundshine Cafe", "Melrose", "Firehouse"};
        public string Name { get; set; }
       
        public Resturant()
        {
            Random random = new Random();
            // Instantiate random number generator

            Name = _resturants[random.Next(_resturants.Count)]; //count is equal to the length method on strings and other collections 
            // Within the name variable I'm grabbing a non-negative random integer which will be the index of my Resturants List
        }
   
    }
}
