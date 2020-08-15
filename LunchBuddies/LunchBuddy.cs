using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; }
        public string LastName { get; }

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }


        //version 1:
        public void Eat(Restaurant restaurant)
        {
            Console.WriteLine($"Method 1: {FirstName} {LastName} is currently eating at {restaurant.Name}.");
        }

        //version 2:
        public void Eat(Restaurant restaurant, string food)
        {
            Console.WriteLine($"Method 2: {FirstName} {LastName} is currently eating {food} from {restaurant.Name} at the office.");
        }

        //version 3:
        public void Eat(Restaurant restaurant, List<LunchBuddy> companions)
        {
            Console.WriteLine($"Method 3: {FirstName} is currently eating lunch at {restaurant.Name} with a few buddies: ");
            foreach (var name in companions)
            {
                Console.WriteLine($"{name.FirstName}");
            }
        }

        //version 4:
        public void Eat(Restaurant restaurant, string food, List<LunchBuddy> companions)
        {
            Console.WriteLine($"Method 4: {FirstName} is currently eating {food} at {restaurant.Name} with a few buddies: ");
            foreach (var name in companions)
            {
                Console.WriteLine($"{name.FirstName}");
            }

        }



    }
}
