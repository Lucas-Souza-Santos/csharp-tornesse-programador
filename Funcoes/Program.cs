using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Sintaxe de função
                Local   Tipo    Retorno     Nome    (Parâmetros)
                Local: 
                    - Public
                    - Private 
                    - Internal
                    - Protected 
                Tipo: 
                    - Static 
                    - Não Static
                Retorno:
                    - void
                    - int 
                    - string
                    - double
                    - bool
            */

            static int Calcular(int a, int b)
            {
                Console.WriteLine("Escolha uma Opção: ");
                Console.WriteLine("0 - Somar ");
                Console.WriteLine("1 - Subtração ");
                Console.WriteLine("2 - Multiplicação ");
                Console.WriteLine("3 - Divisão ");

                int opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("======== Soma ==========");
                        return a + b;
                    case 1:
                        Console.WriteLine("======== Subtração ========");
                        return a - b;
                    case 2:
                        Console.WriteLine("======== Multiplicação ========");
                        return a * b;
                    case 3:
                        Console.WriteLine("======== Divisão ========");
                        if(b != 0)
                        {
                            return a / b;
                        }
                        else
                        {
                            Console.WriteLine("Divisão Por zero!");
                            return 0;
                        }
                    default:
                        Console.WriteLine("Não existe caso para a opção escolhida!");
                        return 0;
                }
            }

            Console.WriteLine(Calcular(4, 5));
            
        }
    }
}
