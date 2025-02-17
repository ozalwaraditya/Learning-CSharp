namespace Code
{
    public class Class1
    {
        public static void main(string[] args)
        {
            //*****************   CODE 4 - Array display in reverse order.

            //Console.Write("Enter the size of the array : ");
            //var siz = Console.ReadLine();
            //var size = int.Parse(siz);
            //int[] array = new int[size];

            //for (int k = 0; k < size; k++)
            //{
            //    Console.Write($"Enter the {(k + 1)}th element of the array. ");
            //    var ele = Console.ReadLine();
            //    var element = int.Parse(ele);
            //    array[k] = element;
            //}

            //Console.WriteLine("Actual Array : ");
            //for (int l = 0; l < size; l++)
            //{
            //    Console.Write($"Array " + array[l]);
            //}



            //*****************   CODE 3 - do while usage
            int choice = 0;
            do
            {
                Console.WriteLine("\n\n***** Options *****");
                Console.WriteLine("1. Sum of Even from 1 to 50 : ");

                Console.WriteLine("2. Sum of Odd from 1 to 50 : ");
                Console.WriteLine("3. Exit.");

                Console.WriteLine("\nEnter you choice : ");
                var ch = Console.ReadLine();
                choice = int.Parse(ch);
                switch (choice)
                {
                    case 1:
                        int sumEven = 0;

                        for (int m = 0; m <= 50; m++)
                        {
                            if (m % 2 == 0)
                            {
                                sumEven += m;
                            }
                        }
                        Console.WriteLine($"Sum of Even : {sumEven}");
                        choice = 3;
                        break;
                    case 2:
                        int sumOdd = 0;

                        for (int n = 0; n <= 50; n++)
                        {
                            if (n % 2 != 0)
                            {
                                sumOdd += n;
                            }
                        }
                        Console.WriteLine($"Sum of Even : {sumOdd}");
                        choice = 3;
                        break;
                    case 3:
                        break;

                    default:
                        Console.WriteLine("Enter valid Option!!!!!");
                        break;
                }
            }
            while (choice != 3);





            //*****************   CODE 2  - Display table using while loop

            Console.Write("Enter the number till which you want table : ");
            var con = Console.ReadLine();
            int tableNumber = Convert.ToInt32(con);
            int i = 1;
            int j = 2;



            while (j <= tableNumber)
            {
                i = 2;
                while (i <= 10)
                {
                    Console.WriteLine($"{j} X {i} = {(i * j)}");
                    i++;
                }
                j++;
                Console.WriteLine();
            }


            //*****************   CODE 1 - Display table using for loop

            for (i = 1; i <= 10; i++)
            {
                for (j = 2; j <= tableNumber; j++)
                {
                    Console.Write($"{j} X {i} = {(i * j)} \t");
                }
                Console.WriteLine();
            }

        }
    }
}
