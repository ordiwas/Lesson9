namespace Menu
{
    public class Menu
    {
        public string item { get; set; }
        public double price { get; set; }

        // Overload unary operators ++ and -- 
        public static Menu operator ++(Menu obj)
        {
            ++obj.price;
            return obj;
        }
        public static Menu operator --(Menu obj)
        {
            //obj.number--;
            --obj.price;
            return obj;
        }

        // Overload Comparison Operators > and <
        public static bool operator >(Menu left, Menu right)
        {
            bool larger = false;
            if (left.price > right.price)
                larger = true;
            return larger;
        }

        public static bool operator <(Menu left, Menu right)
        {
            bool smaller = false;
            if (left.price < right.price)
                smaller = true;
            return smaller;
        }

        // Overload Binary Operators + and -
        public static Menu operator +(Menu obj1, Menu obj2)
        {
            Menu Calc3 = new Menu();
            Calc3.price = obj1.price + obj2.price;
            return Calc3;
        }
        public static Menu operator -(Menu obj1, Menu obj2)
        {
            Menu Calc3 = new Menu();
            Calc3.price = obj1.price - obj2.price;
            return Calc3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many food menu items do you want?");
            int m = int.Parse(Console.ReadLine());
            Menu[] food = new Menu[m];
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine($"Write the food item you want and it's price! {i + 1} (Two separate lines for item and price)");
                string a = Console.ReadLine();
                food[i] = new Menu();
                food[i].item = a;
                double b = double.Parse(Console.ReadLine());
                food[i].price = b;
                Console.Write("" + food[i].item + " $" + food[i].price);
                Console.WriteLine();
            }
            
            Console.WriteLine("How many drink menu items do you want?");
            int d = int.Parse(Console.ReadLine());
            Menu[] drink = new Menu[d];
            for (int i = 0; i < drink.Length; i++)
            {
                Console.WriteLine($"Write the drink item you want and it's price! {i + 1} (Two separate lines for item and price)");
                string a = Console.ReadLine();
                drink[i] = new Menu();
                drink[i].item = a;
                double b = double.Parse(Console.ReadLine());
                drink[i].price = b;
                Console.Write("" + drink[i].item + " $" + drink[i].price);
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Food Menu");
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine($"{food[i].item} ${food[i].price}");
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Drink Menu");
            for (int i = 0; i < drink.Length; i++)
            {
                Console.WriteLine($"{drink[i].item} ${drink[i].price}");
            }
            Console.WriteLine("Add 1 to all the food menu prices");
            for (int i = 0; i < food.Length; i++)
            {
                food[i].price++;
            }
            Console.WriteLine("Minus 1 to all the drink menu prices");
            for (int i = 0; i < drink.Length; i++)
            {
                drink[i].price--;
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Food Menu");
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine($"{food[i].item} ${food[i].price}");
            }
            Console.WriteLine("Drink Menu");
            for (int i = 0; i < drink.Length; i++)
            {
                Console.WriteLine($"{drink[i].item} ${drink[i].price}");
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Find all food menu items less than 10");
            for (int i = 0; i < food.Length; i++)
            {
                if (food[i].price < 10)
                {
                    Console.WriteLine($"{food[i].item} ${food[i].price}");
                }
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Find all the drink menu items greater than 5");
            for (int i = 0; i < drink.Length; i++)
            {
                if (drink[i].price > 5)
                {
                    Console.WriteLine($"{drink[i].item} ${drink[i].price}");
                }
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Add 5 to all the food menu prices");
            for (int i = 0; i < food.Length; i++)
            {
                food[i].price+= 5;
            }
            Console.WriteLine("Minus 5 to all the drink menu prices");
            for (int i = 0; i < drink.Length; i++)
            {
                drink[i].price -= 5;
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Food Menu");
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine($"{food[i].item} ${food[i].price}");
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Drink Menu");
            for (int i = 0; i < drink.Length; i++)
            {
                Console.WriteLine($"{drink[i].item} ${drink[i].price}");
            }
        }
    }
}