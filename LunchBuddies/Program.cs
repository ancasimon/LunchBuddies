using System;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var newBuddy = new LunchBuddy("Anna", "Smith");

            //var restaurant = new Restaurant();

            newBuddy.Eat();
            
        }
    }
}
