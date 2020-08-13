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

            var companions = new List<LunchBuddy>();
            companions.Add(newBuddy);
            companions.Add(coworkerBuddy);


            var restaurant1 = new Restaurant();
            Console.WriteLine($"{restaurant1.Name} is the name of the selected restaurant!");

            //version 1 of the Eat() method:
            //newBuddy.Eat(restaurant1);

            //version 2 of the Eat() method:
            //newBuddy.Eat(restaurant1, "fried goodness");

            //version 3 of the Eat() method:
            //newBuddy.Eat(restaurant1, companions);
            //coworkerBuddy.Eat(restaurant1, companions);

            //ANCA Note: WIP!!!! still working on version 3 - I cannot get the names to get displayed in a single list; they get displayed afetr the method is run again for each - which is what I indicated below --but I am wondering if I cna just call the method and then go through the companions list??
            //foreach (var item in companions)
            //{
            //    item.Eat(restaurant1, companions);
            //    Console.WriteLine($"{item.FirstName}");
            //}

            //version 4 of the Eat() method:   //ANCA QUESTION: do we really need to pass in the list of companions as an argument to the Eat method for versions 3 and 4???
            //and shouldn't there be a list of foods? or are they all eating the smae thing??
            foreach (var item in companions)
            {
                item.Eat(restaurant1, "fancy pasta dish", companions);
            }
            
        }
    }
}
