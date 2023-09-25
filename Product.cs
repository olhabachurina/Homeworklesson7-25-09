using System;


namespace Homeworklesson7_25_09
{
    internal class Product
    {
        public string Name { get; set; }
        public Money Price { get; set; }

        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }

        public void ApplyDiscount(double discountPercentage)
        {
            double discountFactor = 1 - (discountPercentage / 100);
            int discountedPriceHryvnia = (int)(Price.Hryvnia * discountFactor);
            int discountedPriceKopecks = (int)(Price.Kopecks * discountFactor);
            Price.SetValue(discountedPriceHryvnia, discountedPriceKopecks);
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"The product's name: {Name}");
            Console.WriteLine("Product price:");
            Price.Display();
        }
    }
}

