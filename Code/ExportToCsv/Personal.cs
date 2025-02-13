using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.ExportToCsv
{
    public class Personal
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Electric Fan", Description = "Portable electric fan for cooling.", Category = "Home & Kitchen" },
                new Product { Id = 2, Name = "Sports Watch", Description = "Water-resistant sports watch with fitness tracking.", Category = "Electronics & Gadgets" },
                new Product { Id = 3, Name = "Yoga Mat", Description = "Non-slip mat for yoga and exercise.", Category = "Sports & Fitness" },
                new Product { Id = 4, Name = "Bluetooth Speaker", Description = "Wireless Bluetooth speaker with deep bass.", Category = "Electronics & Gadgets" },
                new Product { Id = 5, Name = "Running Shoes", Description = "Comfortable shoes designed for running.", Category = "Footwear" },
                new Product { Id = 6, Name = "Leather Wallet", Description = "Stylish wallet made of premium leather.", Category = "Jewelry & Accessories" },
                new Product { Id = 7, Name = "Fitness Tracker", Description = "Track your workouts and heart rate with this device.", Category = "Sports & Fitness" },
                new Product { Id = 8, Name = "Wooden Dining Table", Description = "Elegant wooden dining table with modern design.", Category = "Home & Furniture" },
                new Product { Id = 9, Name = "Wireless Earbuds", Description = "Bluetooth wireless earbuds for music and calls.", Category = "Electronics & Gadgets" },
                new Product { Id = 10, Name = "Hair Dryer", Description = "Compact and efficient hair dryer.", Category = "Beauty & Personal Care" }
            };

            // Optionally, print the products
            foreach (var product in products)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Description: {product.Description}, Category: {product.Category}");
            }

            string filePath = "C:\\Users\\adityao\\source\\repos\\LearningC#\\Code\\ExportToCsv\\FileManagement.csv";
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Id,Name,Description,Category");
                foreach (var product in products)
                {
                    writer.WriteLine($"{product.Id}, {product.Name}, {product.Description}, {product.Category}");
                }
            }


        }
    }

    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Category { get; set; }

    }
}
