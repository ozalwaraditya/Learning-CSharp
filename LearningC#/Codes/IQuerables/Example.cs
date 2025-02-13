using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Codes.IQuerables
{
    public class Example
    {
        public static void main(string[] args)
        {

            var querableList = new[]
            {
                    new Product { Name = "KeyBoard", Price = 500 , StockQuantity = 100 },
                    new Product { Name = "Monitor", Price = 450 , StockQuantity = 650 },
                    new Product { Name = "Mouse", Price = 590 , StockQuantity = 150 },
                    new Product { Name = "Pencik", Price = 890 , StockQuantity = 177 },

            }.AsQueryable();

            querableList.Where(i => i.Price >= 500)
                .Select(i => i.Name);

            foreach (var querable in querableList)
            {
                Console.WriteLine(querable.Name);
            }
        }

    }

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
