using System.Collections.Generic;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class DogData
    {
        public static IList<Animal> Dogs { get; private set; }

        static DogData()
        {
            Dogs = new List<Animal>();

            Dogs.Add(new Animal
            {
                Name = "French Fries",
                Location = "$3.99",
                Details = "Golden french fries from Idaho potatoes.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/92/French_fries_in_Poland.jpg"
            });

            Dogs.Add(new Animal
            {
                Name = "Hanburger",
                Location = "$9.99",
                Details = "Just like a big Mac but better with a twist.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/9a/Big_Mac_hamburger.jpg"
            });

            Dogs.Add(new Animal
            {
                Name = "Hot Dog",
                Location = "$5.99",
                Details = "Hot dog with all the toppings.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4e/Hot_Dog_%285076302395%29.jpg"
            });

            Dogs.Add(new Animal
            {
                Name = "Onion Rings",
                Location = "$4.99",
                Details = "Golden brown onion rings with a variety of dips.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/48/Burger_King_Onion_Rings_in_Bag_%2819043880786%29.jpg"
            });

            Dogs.Add(new Animal
            {
                Name = "Italian Sandwich",
                Location = "$8.99",
                Details = "Italian sandwich all roll.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a2/Italian_sandwich.jpg"
            });

            Dogs.Add(new Animal
            {
                Name = "French Onion Soup",
                Location = "$5.99",
                Details = "Large bowl of French Onion soup topped with cheese.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/f/fd/French_Onion_Soup_%286635668505%29.jpg"
            });

            Dogs.Add(new Animal
            {
                Name = "Chicken Noddle Soup",
                Location = "$5.99",
                Details = "Large bowl of Chicken Noddle soup with fresh roasted chicken.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b3/Chicken_Noodle_Soup.jpg"
            });

            Dogs.Add(new Animal
            {
                Name = "Tomato Soup",
                Location = "$5.99",
                Details = "Large bowl of Tomato soup with fresh locally grown tomato.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b5/Tomato_soup.jpg"
            });

            Dogs.Add(new Animal
            {
                Name = "Beef Barley Soup",
                Location = "$5.99",
                Details = "Large bowl of Beef Barley soup with fresh slices of bread.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/8/81/Beef_barley_soup_%2815439896429%29.jpg"
            });


        }
    }
}


