using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace shopping_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's go shopping!");
            Console.WriteLine("Here are our current items...");
            showItems(); //calls function that displays the 8 things they can order and the prices

            
                List<string> customerList = new List<string>();// establishes user list
            

            string addMore;
            do
           
            {
                Console.WriteLine("What items do you want to add to your list?");
                string foodAdded = Console.ReadLine();
                customerList.Add(foodAdded);
                Console.WriteLine(doYouWantTo()); // asks if they want to add more
                addMore = Console.ReadLine();
      
            }
            while (addMore == "y" || addMore == "Y");


            decimal itemCost = 0;
            Console.WriteLine("Here's what you ordered...");
            foreach (string item in customerList)
            {
                Dictionary<string, decimal> Menu = new Dictionary<string, decimal>()
            {
                {"Greek Yogurt", 1.99m },
                {"Kale", 2.99m },
                {"Dates", 5.99m },
                {"Goat Cheese", 4.99m },
                {"Chicken Breasts", 9.99m },
                {"Brussels Sprouts", 4.50m },
                {"Blueberries", 3.99m },
                {"Tomatoes", 2.99m },

            };
                itemCost += Menu[item];
                Console.WriteLine($"{item}\t\t${Menu[item]}");
            }

            Console.WriteLine($"The total for your order is {itemCost}");




            static string doYouWantTo()
            {
                return ("Do you want to add more items? (y/n)?");
            }


            static void showItems() //function that displays the items they can order
            {
                Dictionary<string, decimal> Menu = new Dictionary<string, decimal>()
            {
                {"Greek Yogurt", 1.99m },
                {"Kale", 2.99m },
                {"Dates", 5.99m },
                {"Goat Cheese", 4.99m },
                {"Chicken Breasts", 9.99m },
                {"Brussels Sprouts", 4.50m },
                {"Blueberries", 3.99m },
                {"Tomatoes", 2.99m },

            };
                foreach (var food in Menu)
                {
                    {
                        Console.WriteLine("{0}, Price {1}", food.Key, food.Value);
                    }
                }
            }




        }
    }
}

