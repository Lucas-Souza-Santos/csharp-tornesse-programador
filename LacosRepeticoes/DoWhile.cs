using System;

class While
{
    static void Main()
    {
        int a = 1;
        do 
        {
            if (a == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine(a);
                a++;
            }
        }
        while (a <= 10);        
    }
}