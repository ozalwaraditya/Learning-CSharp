using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    internal class Code1
    {
       public static void Main(string[] args)
        {
             Console.Write("Enter the number till which you want table : ");
            var con = Console.ReadLine();
            int tableNumber = Convert.ToInt32(con);
            
            for (int i = 1; i <= 10; i++)
            {
                for(int j = 2; j <=tableNumber; j++)
                {
                    Console.Write($"{j} X {i} = {(i*j)} \t");
                }
            Console.WriteLine();
            }
        }
    }
}
