using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworklesson7_25_09
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Exercise 1");
            Console.Write("         ");
            Console.Write("Enter product name: ");
            string productName = Console.ReadLine();
            Console.Write("Enter the whole part of the product price (hryvnia): ");
            int productPriceRub = int.Parse(Console.ReadLine());
            Console.Write("Enter product price kopecks: ");
            int productPriceKop = int.Parse(Console.ReadLine());
            Console.Write("Enter the discount as a percentage: ");
            double discountPercentage = double.Parse(Console.ReadLine());

            Money productPrice = new Money(productPriceRub, productPriceKop);
            

            Product product = new Product(productName, productPrice);

            product.ApplyDiscount(discountPercentage);

            Console.WriteLine("\nProduct information after discount:");
            product.DisplayInfo();
            Console.Write("Exercise 2 ");
            Console.Write("         ");
            Device kettle = new Kettle("Kettle", "BrandX");
            Device microwave = new Microwave("Microwave", "MicrowaveCorp");
            Device car = new Car("Car", "Toyota");
            Device steamship = new Steamship("teamship", "SteamBoatInc");

            kettle.Show();
            kettle.Sound();
            kettle.Desc();

            microwave.Show();
            microwave.Sound();
            microwave.Desc();

            car.Show();
            car.Sound();
            car.Desc();

            steamship.Show();
            steamship.Sound();
            steamship.Desc();
        }
    }
}
    

    

