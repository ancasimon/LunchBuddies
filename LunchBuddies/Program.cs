using System;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var newBuddy = new LunchBuddy("Anna", "Smith");

            var restaurant1 = new Restaurant();
            Console.WriteLine($"{restaurant1.Name} is the name of the selected restaurant!");

            newBuddy.Eat(restaurant1);
            
        }
    }
}
