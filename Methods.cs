using System;
using System.Globalization;

class Program
    {
   public  static void Main()
    {
        Program P = new Program();
        int Sum = P.Add(10, 20);

        Console.WriteLine("Sum={0}", Sum);
    }
    public int Add(int FN,int SN)
    {
        return SN + FN;
    }
    }

