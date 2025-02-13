using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Codes.StringManipulation
{
    public class StringManipulation
    {
        public static void main(string[] args)
        {

            /*
                Things which we can do with String.

                Concatenation.
                Substring.
                Joining.
                Trimming.

             */


            string str = "Hello World!!!!";

            Console.WriteLine(str[8]);
            Console.WriteLine(str.Substring(1, 8));   // Substring(starting index, length);


            int index = str.IndexOf("!");     //Finding Element - IndexOf(element);
            Console.WriteLine(index);



            string[] srtArray = new string[3] { "royal enfield", "bajaj", "yamaha" };  //Joining one array of string into single array.
            string bikes = string.Join(", ", srtArray);
            Console.WriteLine(bikes);

        }
    }
}
