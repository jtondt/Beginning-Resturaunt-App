using System.Collections.Generic;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class CatData
    {
        public static IList<Animal> Cats { get; private set; }

        static CatData()
        {
            Cats = new List<Animal>();

            Cats.Add(new Animal
            {
                Name = "Eggs and Bacon",
                Location = "$5.99",
                Details = "Two eggs and two pieces of bacon to start your morning.",
                ImageUrl = "http://jaring.id/wp-content/uploads/2016/10/Vatikan-370x175.jpg",
                ImageUrl2 = "https://www.badgerfox.com.au/wp-content/uploads/2018/10/3e2cdf0d8e48b90f5107ff433029ae27-1920x1080.jpg"
            });

            Cats.Add(new Animal
            {
                Name = "Toast",
                Location = "$2.50",
                Details = "Two white pieces of bread toasted golden brown.",
                ImageUrl = "https://thumbor.forbes.com/thumbor/400x400/https://specials-images.forbesimg.com/imageserve/512588150/400x400.jpg?fit=scale&background=000000"
            });

            Cats.Add(new Animal
            {
                Name = "Cereal",
                Location = "$2.99",
                Details = "Large bowl of Frosted flakes, Captain Crunch, or Rasin Bran.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/44/Kix_cereal_closeup_to_show_texture.jpg"
            });

            Cats.Add(new Animal
            {
                Name = "Waffle",
                Location = "$1.99",
                Details = "Stack of golden brown waffles.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/8/88/Waffle.jpg"
            });

            Cats.Add(new Animal
            {
                Name = "Fruit and Donut",
                Location = "$9.99",
                Details = "Plate of fresh fruit and a donut to start your day.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a3/Breakfast_fruits_fastfood.jpg"
            });

            Cats.Add(new Animal
            {
                Name = "Outmeal",
                Location = "$2.99",
                Details = "Bowl of fresh outmeal with brown sugar.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/15/Oatmeal_with_brown_sugar.jpg"
            });

            Cats.Add(new Animal
            {
                Name = "Bagel",
                Location = "$1.99",
                Details = "Golden brown bagel fresh from the oven and choice of butter or cream cheese.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/98/Bagel.jpg"
            });

            Cats.Add(new Animal
            {
                Name = "English Breakfast",
                Location = "$13.99",
                Details = "English breakfast like your mother made.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c9/Full_English_breakfast_at_the_Chalet_Cafe%2C_Cowfold%2C_West_Sussex%2C_England.jpg"
            });

            Cats.Add(new Animal
            {
                Name = "Irish Breakfast",
                Location = "$12.99",
                Details = "Irish breakfast like your mother made.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6b/Irish_breakfast%2C_cooked.JPG"
            });

        }
    }
}
