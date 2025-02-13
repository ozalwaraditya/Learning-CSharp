using System;

class A
{
    public virtual void Show() // Virtual method for overriding
    {
        Console.WriteLine("Inside A");
    }
}

class B : A
{
    public override void Show() // Overriding base class method
    {
        Console.WriteLine("Inside B (Overridden)");
    }
}

class Program
{
    static void Main()
    {
        A obj1 = new A();
        obj1.Show();  // Output: Inside A

        B obj2 = new B();
        obj2.Show();  // Output: Inside B (Overridden)

        A obj3 = new B(); 
        obj3.Show();  // Output: Inside B (Overridden) --> Calls derived method due to polymorphism
    }
}
