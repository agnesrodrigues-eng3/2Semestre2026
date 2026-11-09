using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCsharp
{
    internal class EstruturaDeDecisaoComposta
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Extrutura de decisao Composta");
            Console.WriteLine("Digite sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 18)
            {
                Console.WriteLine("Você não pode dirigir!");
            }

            else
            {
                Console.WriteLine("Você pode dirigir");
            }
            
        }
    }
}
