using System;

class ForEach 
{
    static void Main()
    {
        int[] a = {1, 2, 3};

        foreach (var v in a)
        {
            Console.WriteLine(v);
        }
    }
}