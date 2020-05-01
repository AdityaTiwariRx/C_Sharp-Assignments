using System;

class Program
    {
    static void Main()
    {
        Console.WriteLine("Enter Your target?");
        int Target = int.Parse(Console.ReadLine());
        int Start = 0;

        while (Start <= Target)
        {
            Console.WriteLine(Start + " ");
            Start = Start + 2;
        }



    }
    }

