
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Thursday.ExportToCsv
{
    public class Personal
    {
        public static void main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Electric Fan", Description = "Portable electric fan for cooling.", Category = "Home & Kitchen" },
                new Product { Id = 2, Name = "Sports Watch", Description = "Water-resistant sports watch with fitness tracking.", Category = "Electronics & Gadgets" },
                new Product { Id = 3, Name = "Yoga Mat", Description = "Non-slip mat for yoga and exercise.", Category = "Sports & Fitness" },
                new Product { Id = 4, Name = "Bluetooth Speaker", Description = "Wireless Bluetooth speaker with deep bass.", Category = "Electronics & Gadgets" },
            };

            // Optionally, print the products
            //foreach (var product in products)
            //{
            //    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Description: {product.Description}, Category: {product.Category}");
            //}

            string filePath = "C:\\Users\\adityao\\source\\repos\\LearningC#\\Thursday\\ExportToCsv\\FileManagement.csv";
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Id,Name,Description,Category");
                foreach (var product in products)
                {
                    writer.WriteLine($"{product.Id}, {product.Name}, {product.Description}, {product.Category}");
                }
            }

            Console.WriteLine("Successfully Updated");


            using (var reader = new StreamReader(filePath))
            {
                bool header = true;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (header)
                    {
                        header = false;
                        continue;
                    }

                    var cell = line.Split(',');

                    Product product = new Product
                    {
                        Id = Convert.ToInt32(cell[0]),
                        Name = cell[1],
                        Description = cell[2],
                        Category = cell[3]
                    };

                    Console.WriteLine($"{product.Id}, {product.Name}, {product.Description}, {product.Category}");

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
}
