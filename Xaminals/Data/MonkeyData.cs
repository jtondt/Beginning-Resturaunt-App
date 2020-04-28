using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class MonkeyData
    {
        public static IList<Animal> Monkeys { get; private set; }

        static MonkeyData()
        {
            Monkeys = new List<Animal>();

            Monkeys.Add(new Animal
            {
                Name = "T-Bone Steak",
                Location = "$14.99",
                Details = "T-Bone steak grilled to perfection served with fries.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/3/36/Steak_03_bg_040306.jpg"
            });

            Monkeys.Add(new Animal
            {
                Name = "Spaghetti",
                Location = "$9.99",
                Details = "Large plate of spaghetti with you choice of toppings only.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/98/Spaghetti-prepared.jpg"
            });


            Monkeys.Add(new Animal
            {
                Name = "Maine Lobster",
                Location = "$24.99",
                Details = "Pot full of Maine Lobster served with butter (Seaonsal item).",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/cd/SteamedLobster.jpg"
            });

            Monkeys.Add(new Animal
            {
                Name = "Filet Mignon",
                Location = "$19.99",
                Details = "The best Filet Mignon cooked to perfection.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/66/Filet_Mignon_with_Asparagus_Spears.jpg"
            });

            Monkeys.Add(new Animal
            {
                Name = "Fried Chicken",
                Location = "$7.99",
                Details = "Four pieces of the best fried chicken in the Pocono's.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/2/2c/Fried-Chicken-Set.jpg"
            });

            Monkeys.Add(new Animal
            {
                Name = "Roasted Chicken",
                Location = "$12.99",
                Details = "Roasted chiken with beans.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6e/Roasted_chicken_with_pilav_and_beans.jpg"
            });

            Monkeys.Add(new Animal
            {
                Name = "Fish and Chips",
                Location = "$11.99",
                Details = "The best Fish and Chips in the area.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/eb/Fried_fish_sandwich_with_french_fries.jpg"
            });

            Monkeys.Add(new Animal
            {
                Name = "Sword Fish",
                Location = "$19.99",
                Details = "A plate of fresh sword fish grilled to perfection.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/9a/Marinated_grill_swordfish.jpeg"
            });

        }
    }
}
