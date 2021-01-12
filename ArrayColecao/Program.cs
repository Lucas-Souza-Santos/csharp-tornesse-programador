using System;
using System.Linq;
using System.Collections.Generic;

namespace ArrayColecao
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Array declaração, preenchendo um array e imprimindo os dados
            string[] a = new string[3];
            a[0] = "Lucas";
            a[1] = "Maria";
            a[2] = "Amanda";

            int[] b = {5, 7, 1};

            Console.WriteLine("Maior Elemento {0}", b.Max());

            Array.Sort(a);

            foreach(string nome in a)
            {
                Console.WriteLine(nome);
            }
            // Coleções
            List<string> c = new List<string>();
            c.Add("Maria");
            c.Add("Joana");
            c.Add("João");
            c.Add("Henrique");

            foreach (var nome in c)
            {
                Console.WriteLine(nome);
            }

        }
    }
}
