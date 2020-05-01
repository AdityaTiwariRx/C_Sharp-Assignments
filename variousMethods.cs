//Value Parameters
using System;

class Program
    {

   public  static void Main()
    {
        int i = 0;

        SimpleMethod(i);

        Console.WriteLine(i);
    }
    public static void SimpleMethod(int j)
    {
        j = 101;
    }
    }

//Reference Parameters
using System;

class Program
    {
   public  static void Main()
    {
        int i = 0;

        SimpleMethod(i);

        Console.WriteLine(ref i);
    }
    public static void SimpleMethod(ref int j)
    {
        j = 101;
    }
    }

//Out Parameters

using System;

class Program
    {
   public  static void Main()
    {
        int Total = 0;
        int Product = 0;
        Calculate(10, 20, out Total, out Product);

        Console.WriteLine("Sum ={0} & Product={0}",Total,Product);
    }
    public static void Calculate(int FN,int SN,out int Sum,out int Product)
    {
        Sum = FN + SN;
        Product = FN + SN;
    }
    }

//Parameter Arrays

using System;

class Program
    {
   public  static void Main()
    {
        int[] Numbers = new int[3];
        Numbers[0]= 101;
        Numbers[1] = 102;
        Numbers[2] = 103;

        ParamsMethod(Numbers);
    }
    public static void ParamsMethod(params int[] Numbers) 
    {
        Console.WriteLine("Elements : {0}", Numbers.Length);
        foreach(int i in Numbers)
        {
            Console.WriteLine(i);
        }
    }
    }


