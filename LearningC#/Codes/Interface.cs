//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LearningC_.Codes
//{
//    public class Interface
//    {
//        public void status(int status) {
//            Console.WriteLine("Hello World.");
//        }
//    }
//    public static void sumOfparameter<Type>(ref Type item1, ref Type item2)
//        {
//            try
//            {
//                if (typeof(Type) == typeof(string))
//                {
//                    string result = (string)(object)item1 + " " + (string)(object)item2;
//                    Console.WriteLine("Concatenated String: " + result);
//                }
//                else if (typeof(Type) == typeof(decimal))
//                {
//                    decimal add = (decimal)(object)item1 + (decimal)(object)item2;
//                    Console.WriteLine("Addition of two decimal: " + add);
//                }
//                else if (typeof(Type) == typeof(int))
//                {
//                    int sum = (int)(object)item1 + (int)(object)item2;
//                    Console.WriteLine("Addition of two integer : " + sum);
//                }
//                else
//                {
//                    throw new InvalidOperationException("The parameter should be interger or string or decimal.");
//                }
//            }
//            catch (InvalidOperationException error)
//            {
//                Console.WriteLine(error.Message);
//            }

//        }

//    }
//}
