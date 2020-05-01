using System;
using System.Globalization;

class Program
    {
    static void Main()
    {
        int[] Nums = new int[3];
        Nums[0] = 101;
        Nums[1] = 102;
        Nums[2] = 103;

        // ForEach

        foreach (int k in Nums)
        {
            Console.WriteLine(k);
        }

        //ForLoop

        for(int i=0;i<=Nums.Length;i++)
        {
            Console.WriteLine(Nums[i]);
 }

    }
    }

