using System;

public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("ParentClass Constructor Called");
    }
    public ParentClass(string Message)
    {
        Console.WriteLine(Message);
    }

}
public class ChildClass : ParentClass
{
    public ChildClass():base("Derived Class controlling Parent Class")
    {
        Console.WriteLine("ChildClass Constructor Called");
    }
}

class Program
{
    public static void Main()
    {
        ChildClass cc = new ChildClass();
    }

}

