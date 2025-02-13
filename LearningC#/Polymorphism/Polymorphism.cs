using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Polymorphism
{
    public class Polymorphism
    {
        public static void main(string[] args)
        {

            /*
                In this methods can have same name but their functionality is different. 

             */

            Eatables eat1 = new Eatables();
            eat1.howDoesitTastes();

            Lemon eat2 = new Lemon();
            eat2.howDoesitTastes();

            Sugar eat3 = new Sugar();
            eat3.howDoesitTastes();
        }
    }


    class Eatables
    {
        public string taste = "simple";
        public void howDoesitTastes()
        {
            Console.WriteLine(taste);
        }
    }

    class Lemon : Eatables
    {
        public Lemon()
        {
            this.taste = "bitter";
        }
    }

    class Sugar : Eatables
    {
        public Sugar()
        {
            this.taste = "sweet";
        }
    }


}
