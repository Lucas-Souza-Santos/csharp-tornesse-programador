using System;

class OperadoresCondicionais
{
    static void Main()
    {
        var a = (1 == 1 ? "SIM": "Não");
        Console.WriteLine(a);
        
        var x = 1;
        if(x == 1)
        {
            Console.WriteLine("Entrou aqui!!!");
        }
        else if(x == 2)
        {
            Console.WriteLine("Não ele entrou aqui!!!");
        }
        else
        {
            Console.WriteLine("Finalmente.");
        }

        switch (x)
        {
            case 1:
                Console.WriteLine("Caso 1");
                break;
            default:
                Console.WriteLine("Nenhum caso");
        }
    }
}