

using System.ComponentModel.DataAnnotations;
using static System.Reflection.Metadata.BlobBuilder;
using Thursday.Model;

namespace Practice_LinQ._30_Jan
{
    public class Class1
    {

        public static void main(string[] args)
        {
            var categories = new string[]
      {
            "Electronics & Gadgets", "Clothing & Apparel", "Footwear", "Home & Furniture",
            "Beauty & Personal Care", "Books & Stationery", "Sports & Fitness",
            "Toys & Baby Products", "Groceries & Essentials", "Automotive Accessories",
            "Healthcare & Wellness", "Jewelry & Accessories"
      };

            var random = new Random();
            var products = new List<Product>();

            for (int i = 1; i <= 50; i++)
            {
                var product = new Product
                {
                    Id = i,
                    Name = $"Product {i}",
                    Price = random.Next(1, 10001), 
                    Category = categories[random.Next(categories.Length)],
                    Description = $"This is a description for Product {i}."
                };
                products.Add(product);
            }
            Console.Write("\n\n\n This is the final list : ");

            // Print the generated products
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}, Category: {product.Category}, Description: {product.Description}");
            }

            var list = products.Where(i =>( (i.Price >= 3000) || (i.Category == "Books & Stationery"))).ToList();

            Console.WriteLine("\n\n\n This is the final list : ");

            foreach (var product in list)
            {
                Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}, Category: {product.Category}, Description: {product.Description}");
            }
        }
    }



    

}
