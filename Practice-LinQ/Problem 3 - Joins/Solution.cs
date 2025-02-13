using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_LinQ.Problem_3___Joins
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
    }

    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ContactName { get; set; }
        public string Country { get; set; }
    }

    public class Solution
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>
            {
                new Order { OrderID = 10308, CustomerID = 2, OrderDate = new DateTime(1996, 9, 18) },
                new Order { OrderID = 10309, CustomerID = 37, OrderDate = new DateTime(1996, 9, 19) },
                new Order { OrderID = 10310, CustomerID = 77, OrderDate = new DateTime(1996, 9, 20) },
                new Order { OrderID = 10311, CustomerID = 22, OrderDate = new DateTime(1996, 9, 21) },
                new Order { OrderID = 10312, CustomerID = 3, OrderDate = new DateTime(1996, 9, 22) },
                new Order { OrderID = 10313, CustomerID = 11, OrderDate = new DateTime(1996, 9, 23) },
                new Order { OrderID = 10314, CustomerID = 2, OrderDate = new DateTime(1996, 9, 24) },
                new Order { OrderID = 10315, CustomerID = 7, OrderDate = new DateTime(1996, 9, 25) },
                new Order { OrderID = 10316, CustomerID = 77, OrderDate = new DateTime(1996, 9, 26) },
                new Order { OrderID = 10317, CustomerID = 32, OrderDate = new DateTime(1996, 9, 27) },
                new Order { OrderID = 10318, CustomerID = 2, OrderDate = new DateTime(1996, 9, 28) },
                new Order { OrderID = 10319, CustomerID = 37, OrderDate = new DateTime(1996, 9, 29) },
                new Order { OrderID = 10320, CustomerID = 1, OrderDate = new DateTime(1996, 9, 30) },
                new Order { OrderID = 10321, CustomerID = 2, OrderDate = new DateTime(1996, 10, 1) },
                new Order { OrderID = 10322, CustomerID = 3, OrderDate = new DateTime(1996, 10, 2) }
            };

            List<Customer> customers = new List<Customer>
            {
                new Customer { CustomerID = 1, CustomerName = "Alfreds Futterkiste", ContactName = "Maria Anders", Country = "Germany" },
                new Customer { CustomerID = 2, CustomerName = "Ana Trujillo Emparedados y helados", ContactName = "Ana Trujillo", Country = "Mexico" },
                new Customer { CustomerID = 3, CustomerName = "Antonio Moreno Taquería", ContactName = "Antonio Moreno", Country = "Mexico" },
                new Customer { CustomerID = 33, CustomerName = "Antonio Moreno Taquería", ContactName = "Antonio Moreno", Country = "Mexico" },
                new Customer { CustomerID = 37, CustomerName = "Coles", ContactName = "James", Country = "USA" },
                new Customer { CustomerID = 3, CustomerName = "Antonio Moreno Taquería", ContactName = "Antonio Moreno", Country = "Mexico" },
                new Customer { CustomerID = 71, CustomerName = "Overture Inc.", ContactName = "Sarah Williams", Country = "Canada" },
                new Customer { CustomerID = 11, CustomerName = "Overture Inc.", ContactName = "Sarah Williams", Country = "Canada" }
            };

            //PerformInnerJoin(orders, customers);
            //PerformLeftJoin(orders, customers);
            //PerformRightJoin(orders, customers);
            //FullOuterJoin(orders, customers);
        }

        //Inner Join
        public static void PerformInnerJoin(List<Order> orders, List<Customer> customers)
        {
            var joinnedList = 
                from ord in orders
                join cus in customers
                on ord.CustomerID equals cus.CustomerID
                select new
                {
                    CustomerName = cus.CustomerName,
                    OrderId = ord.OrderID,
                };

            foreach (var item in joinnedList) { 
                Console.WriteLine(item.CustomerName + " " + item.OrderId);
            }
        }

        //Left Join
        public static void PerformLeftJoin(List<Order> orders, List<Customer> customers)
        {
            var leftJoinnedList = from order in orders
                                  join customer in customers
                                  on order.CustomerID equals customer.CustomerID into newGrp
                                  from customer in newGrp.DefaultIfEmpty()
                                  select new
                                  {
                                      OrderId = order.OrderID,
                                      CustomerName = customer?.CustomerName ?? "No Customer"
                                  };
            foreach (var item in leftJoinnedList) { 
                Console.WriteLine($"{item.OrderId} :  {item.CustomerName}");
            }
        }
    
        //Right Join
        public static void PerformRightJoin(List<Order> orders, List<Customer> customers)
        {
            var rightJoinnedList =
                 from customer in customers
                 join order in orders
                 on customer.CustomerID equals order.CustomerID into customerGrp
                 from order in customerGrp.DefaultIfEmpty()
                 select new
                 {
                     OrderId = order?.OrderID ?? 0000,
                     CustomerName = customer.CustomerName
                 };

            foreach (var item in rightJoinnedList) {
                Console.WriteLine($"{item.CustomerName} - {item.OrderId}");
            }
        }

        //Full Outter Join
        public static void FullOuterJoin (List<Order> orders, List<Customer> customers)
        {
            var outterJoinList =
                (
                    from order in orders
                    join customer in customers
                    on order.CustomerID equals customer.CustomerID into orderGrp
                    from customer in orderGrp.DefaultIfEmpty()
                    select new
                    {
                        OrderId = order.OrderID,
                        CustomerName = customer?.CustomerName ?? "No Customer"
                    }
                ).Union(
                    from customer in customers
                    join order in orders
                    on customer.CustomerID equals order.CustomerID into customerGrp
                    from order in customerGrp.DefaultIfEmpty()
                    select new
                    {
                        OrderId = order?.OrderID ?? 0,
                        CustomerName = customer.CustomerName
                    }
                    );

            foreach (var element in outterJoinList) {
                Console.WriteLine($"{element.CustomerName}  -----  {element.OrderId}");
            }
        }
    }
}
