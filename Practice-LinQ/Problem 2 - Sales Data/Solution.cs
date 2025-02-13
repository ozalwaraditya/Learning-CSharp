using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice_LinQ.Problem_2___Sales_Data
{

    public class SalesTransaction
    {
        public string Region { get; set; }       // Region of the transaction (e.g., "North America", "Europe")
        public string Product { get; set; }      // Name of the product sold
        public double Amount { get; set; }       // Total monetary value of the sale
        public int Quantity { get; set; }        // Quantity of products sold (helps in identifying best-sellers)
        public DateTime Date { get; set; }       // Date of the transaction (useful for  trends or filtering)
    }

    class Program
    {
        static void main(string[] args)
        {
            List<SalesTransaction> transactions = GenerateRandomTransactions(15);

            // Display the transactions
            Console.WriteLine("List of Sales Transactions:");
            foreach (var transaction in transactions)
            {
                Console.WriteLine($"Region: {transaction.Region}, Product: {transaction.Product}, " +
                                  $"Amount: {transaction.Amount:C}, Quantity: {transaction.Quantity}, Date: {transaction.Date:d}");
            }


            //Implementation
            //Method 1
            Console.WriteLine();
            Console.WriteLine("Total Sales Amount : " + TotalSalesAmount(transactions));

            //Method 2
            var dictionary = GetSalesByRegion(transactions);

            foreach(var group in dictionary)
            {
                Console.Write($"{group.Key} : ");
                foreach(var item in group.Value)
                {
                    Console.Write($"{item.Product} ");
                }
                Console.WriteLine();
            }

            //Method 3
            Console.WriteLine("\nTop Selling Product's List....") ;
            var topProductList = TopSellingProduct(transactions);
            int i = 1;
            foreach(var item in topProductList)
            {
                Console.WriteLine($"{i} : {item.Amount}");
                i++;
            }


            //Method 4
            Console.WriteLine("Product's List and their sellings.") ;
            var productList = ProductSalesCount(transactions);
            foreach (var element in productList)
            {
                Console.WriteLine(element.Key + " : " + element.Value);
            }

            //Method 5
            var last30DaysProducts = LastMonthSellignProduct(transactions);
            foreach(var element in last30DaysProducts)
            {
                Console.WriteLine(element.Product + " - " + element.Date);
            }

            //Method 6
            var dict = TotalCountAsPerRegion(transactions);
            foreach(var pair in dict)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }
        }


        //Creates List
        static List<SalesTransaction> GenerateRandomTransactions(int count)
        {
            var random = new Random();
            var regions = new[] { "North America", "Europe", "Asia", "South America", "Africa" };
            var products = new[] { "Laptop", "Smartphone", "Tablet", "Headphones", "Smartwatch" };
            var transactions = new List<SalesTransaction>();

            for (int i = 0; i < count; i++)
            {
                var transaction = new SalesTransaction
                {
                    Region = regions[random.Next(regions.Length)],   // Random region
                    Product = products[random.Next(products.Length)], // Random product
                    Amount = Math.Round(random.NextDouble() * 1000, 2), // Random amount between 0 and 1000
                    Quantity = random.Next(1, 101),                 // Random quantity between 1 and 100
                    Date = DateTime.Now.AddDays(-random.Next(0, 365)) // Random date in the past year
                };
                transactions.Add(transaction);
            }

            return transactions;
        }
        
        //Methods

        static double TotalSalesAmount (List<SalesTransaction> sales)
        {
            return Math.Round(sales.Sum(s => s.Amount),2);
        }
    
        static Dictionary<string, List<SalesTransaction>> GetSalesByRegion(List<SalesTransaction> transactions)
        {
            var listGroupedByRegion = transactions.GroupBy(s => s.Region);
            var dict = new Dictionary<string, List<SalesTransaction>>();

            foreach (var s in listGroupedByRegion) {
                dict.Add(s.Key, s.ToList());
            }
            return dict;
        }
        
        static List<SalesTransaction> TopSellingProduct(List<SalesTransaction> transactions)
        {
            return transactions.OrderByDescending(s => s.Amount).Take(3).ToList();
        }

        static Dictionary<string, int> ProductSalesCount(List<SalesTransaction> transactions) {
            var groupByProduct = transactions.GroupBy(i => i.Product);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<int> products = new List<int>();
            foreach (var item in groupByProduct) {
                dict.Add(item.Key ,item.Sum(i => i.Quantity));
            }
            return dict;
        }

        static List<SalesTransaction> LastMonthSellignProduct(List<SalesTransaction> transactions) {
            return transactions.Where( i=> i.Date >=  DateTime.Now.AddDays(-30)).ToList();
        }

        //Display total count as per Region
        static Dictionary<string, int> TotalCountAsPerRegion(List<SalesTransaction> transactions) {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var item in transactions.GroupBy(i => i.Region))
            {
                dict.Add(item.Key, item.Sum(i => i.Quantity));
            }
            return dict;
        }
    
    }
}
