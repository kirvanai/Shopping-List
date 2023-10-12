namespace Shopping_List
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, decimal> shoppingMenu = new Dictionary<string, decimal>();
            List<string> shoppingList = new List<string>();
            shoppingMenu.Add("Bread", 4.99m);
            shoppingMenu.Add("Deli Meat", 12.99m);
            shoppingMenu.Add("Cheese", 7.99m);
            shoppingMenu.Add("Lettuce", 2.99m);
            shoppingMenu.Add("Tomato", 1.49m);
            shoppingMenu.Add("Mustard", 5.49m);
            shoppingMenu.Add("Mayonnaise", 5.99m);
            shoppingMenu.Add("Apple", 1.99m);
            shoppingMenu.Add("Chips", 4.49m);

            Console.WriteLine("Welcome to the one stop sandwich shop!");
            foreach (var item in shoppingMenu)
            {
                string key = item.Key;
                decimal value = item.Value;
                Console.WriteLine($"{key, 10}   ${value, -10}");

            }
            Console.WriteLine("Input item to add to cart:");
            string addedToCart = Console.ReadLine();
            bool goOn = true;

            while (goOn == true)
            {

            if (shoppingMenu.ContainsKey(addedToCart))
            {
                shoppingList.Add(addedToCart);
                Console.WriteLine("Add more to cart? y/n?");
                string shopMore = Console.ReadLine().ToLower();
                    while (shopMore != "y" && shopMore != "n")
                    {
                        Console.WriteLine("Incorrect input. y/n?");
                        shopMore = Console.ReadLine().ToLower();
                    }
                    if (shopMore == "y")
                    {
                        Console.WriteLine("Input item to add to cart:");
                        addedToCart = Console.ReadLine();
                    }
                    else
                    {
                        decimal total = 0;
                        foreach(string item in shoppingList)
                        {
                            decimal price = shoppingMenu[item];
                            total += price;
                            Console.WriteLine($"{item, 10}  ${price, -10}");
                        }
                            Console.WriteLine($"     Total: ${total, -10}");
                            break;
                    }

                }
            else
            {
                Console.WriteLine("Item not found. Input item to add to cart:");
                addedToCart = Console.ReadLine();
                

            }

            }

        }
    }
}