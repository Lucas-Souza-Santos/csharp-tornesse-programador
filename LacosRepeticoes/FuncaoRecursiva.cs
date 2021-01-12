using System;

class While
{
    static void Main()
    {
        looping(1);
    }
        public static void looping(int a)
        {  
            Console.WriteLine(a);
            if(a < 3)
            {
                looping(a + 1);
            }
        }
    
}