using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_.Polymorphism
{
    public class MethodOverriding
    {

        public static void main(string[] args)
        {
            OverLoadingAndOverRiding obj = new OverLoadingAndOverRiding();
            obj.setDetails(124);
            obj.printDetails();
            Console.WriteLine("Method is overidden.....");
            obj.setDetails(123, "aditya");
            obj.printDetails();
        }
    }
    class OverLoadingAndOverRiding
    {
        public int roll;
        public string name = "Default";

        public void setDetails(int roll)
        {
            this.roll = roll;
        }
        public void setDetails(int roll, string name)
        {
            this.roll = roll;
            this.name = name;
        }

        public void printDetails()
        {
            Console.WriteLine("Name : " + this.name);
            Console.WriteLine("Roll : " + this.roll);

        }

    }
}