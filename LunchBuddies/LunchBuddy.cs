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
        //public void Eat(Restaurant restaurant)
        //{
        //    Console.WriteLine($"{FirstName} {LastName} is currently eating at {restaurant.Name}.");
        //}

        //version 2:
        //public void Eat(Restaurant restaurant, string food)
        //{
        //    Console.WriteLine($"{FirstName} {LastName} is currently eating {food} from {restaurant.Name} at the desk.");
        //}

        //version 3:
        //public void Eat(Restaurant restaurant, List<LunchBuddy> companions)
        //{
        //    //Console.WriteLine($"My budy, {FirstName}, is currently eating at {restaurant.Name}.");
        //    Console.WriteLine($"My buddies are currently at {restaurant.Name}: ");
        //}

        //version 4:
        public void Eat(Restaurant restaurant, string food, List<LunchBuddy> companions)
        {
            Console.WriteLine($"My budy, {FirstName}, just ordered {food} at {restaurant.Name}.");
        }



    }
}
