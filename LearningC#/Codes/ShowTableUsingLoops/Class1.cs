using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace LearningC_.Codes.ShowTableUsingLoops
{
    public class Class1
    {
        public static void main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n\n***** Options *****");
                Console.WriteLine("1. Sum of Even from 1 to 50");
                Console.WriteLine("2. Sum of Odd from 1 to 50");
                Console.WriteLine("3. Exit");
                Console.Write("\nEnter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        int sumEven = 0;
                        for (int i = 0; i <= 50; i++)
                        {
                            if (i % 2 == 0)
                            {
                                sumEven += i;
                            }
                        }
                        Console.WriteLine($"Sum of Even: {sumEven}");
                        break;

                    case 2:
                        int sumOdd = 0;
                        for (int i = 0; i <= 50; i++)
                        {
                            if (i % 2 != 0)
                            {
                                sumOdd += i;
                            }
                        }
                        Console.WriteLine($"Sum of Odd: {sumOdd}");
                        break;

                    case 3:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Enter a valid option!");
                        break;
                }
            } while (choice != 3);

            Console.Write("Enter the number till which you want the table: ");
            int tableNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nTable using while loop:");
            int j = 2;
            while (j <= tableNumber)
            {
                int i = 2;
                while (i <= 10)
                {
                    Console.WriteLine($"{j} X {i} = {i * j}");
                    i++;
                }
                j++;
                Console.WriteLine();
            }

            Console.WriteLine("\nTable using for loop:");
            for (int i = 1; i <= 10; i++)
            {
                for (j = 2; j <= tableNumber; j++)
                {
                    Console.Write($"{j} X {i} = {i * j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
