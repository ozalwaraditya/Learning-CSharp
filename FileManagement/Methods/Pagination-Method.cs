using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement.Methods
{
    //Method - Return List of Items present on that page.
    //Input Parameter - (number of item per page, page number ) 
    public class Method___Pagination
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Pagination");

            List<Product> products = new List<Product>();
            for (int i = 0; i < 100; i++)
            {
                products.Add(new Product() { Name = "Product-" + (i + 1), Id = (i + 1) });
            }

            int itemsPerPage = 11;
            int pageNumber = 3;

            var resultList = GetPageItemsOptimized(products, itemsPerPage, pageNumber);

            Console.WriteLine($"Products on page number {pageNumber}");
            foreach (var product in resultList)
            {
                Console.WriteLine(product.Id);
            }
        }

        //List --> Linq

        public static List<Product> GetPageItems(List<Product> products,int itemsPerPage, int pageNumber) { 
            List<Product> result = new List<Product>();
            int totalProducts = products.Count;
            int startingPoint = (pageNumber - 1) * itemsPerPage;

            if (totalProducts % itemsPerPage == 0) // All pages are full
            {
                for (int i = startingPoint; i < startingPoint + itemsPerPage; i++)
                {
                    result.Add(products[i]);
                }
            }
            else
            {
                if (pageNumber != (int)Math.Ceiling(totalProducts / (double)itemsPerPage)) // Not the last page
                {
                    for (int i = startingPoint; i < startingPoint + itemsPerPage; i++)
                    {
                        result.Add(products[i]);
                    }
                }
                else // Last page
                {
                    for (int i = startingPoint; i < totalProducts; i++)
                    {
                        result.Add(products[i]);
                    }
                }
            }
            return result;
        }

        //Optimized
        public static List<Product> GetPageItemsOptimized(List<Product> products, int itemsPerPage, int pageNumber)
        {
            int startingPoint = (pageNumber - 1) * itemsPerPage;
            if (startingPoint % itemsPerPage == 0) // Items are equal on all Pages
            {
                return products.Skip(startingPoint).Take(itemsPerPage).ToList();
            }
            else
            {
                if (pageNumber == ((products.Count / itemsPerPage) + 1)) return products.Skip(startingPoint).Take(itemsPerPage).ToList(); // PageNumber is InBetween

                return products.Skip(startingPoint).ToList(); //On-Last-Page
            }

        }
    }
}