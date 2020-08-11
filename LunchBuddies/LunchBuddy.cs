﻿using System;
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

        public void Eat()
        {
            var selectedRestaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is currently eating at {selectedRestaurant}");
        }
    }
}