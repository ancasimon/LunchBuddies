using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        public List<string> RestaurantList { get; set; }
        public string Name { get; set; }
        
        public Restaurant()
        {
            Random rnd = new Random();
            var restauratList = new List<string>() { "Merchants", "Hattie Bs", "Sinema", "The Loveless Cafe", "Five Points Pizza", "Mangia", "Margot", "Marche", "Martin's BBQ", "Smiling Elephant" };

            //generate a random index for a restaurant name:
            int restaurantIndex = rnd.Next(restauratList.Count); //Next(Int32) returns a non-negative random integer that is less than the specified maximum!!

            Console.WriteLine($"The selected restaurant is {restauratList[restaurantIndex]}.");
            //return restauratList[restaurantIndex];
        }


    }
}
