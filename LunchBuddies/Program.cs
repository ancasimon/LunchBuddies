using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var newBuddy = new LunchBuddy("Anna", "Smith");
            var coworkerBuddy = new LunchBuddy("Reese", "Carter");
            var runnerBuddy = new LunchBuddy("Erin", "BestRunner");
            var mamaBuddy = new LunchBuddy("Veronica", "S");

            var companions = new List<LunchBuddy>();
            //companions.Add(newBuddy);
            companions.Add(coworkerBuddy);
            companions.Add(runnerBuddy);
            companions.Add(mamaBuddy);


            var restaurant1 = new Restaurant();
            //Console.WriteLine($"{restaurant1.Name} is the name of the selected restaurant!");

            //version 1 of the Eat() method:
            newBuddy.Eat(restaurant1);

            //version 2 of the Eat() method:
            newBuddy.Eat(restaurant1, "fried goodness");

            //version 3 of the Eat() method:
            newBuddy.Eat(restaurant1, companions);

            //version 4 of the Eat() method:   
            //and shouldn't there be a list of foods? or are they all eating the same thing??
            newBuddy.Eat(restaurant1, "fancy pasta dish", companions);
        }
    }
}
