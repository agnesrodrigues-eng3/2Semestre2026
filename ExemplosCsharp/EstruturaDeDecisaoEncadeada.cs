using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCsharp
{
    internal class EstruturaDeDecisaoEncadeada
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Extrutura de decisao encadeda");
            Console.WriteLine("Digite sua idade");
            int idade = Convert.ToInt16(Console.ReadLine());

            if (idade < 16)
            {
                Console.WriteLine("Você não pode votar!");
            }

            else if (idade < 18)
            {
                Console.WriteLine("Voto opicional");
            }

            else
            {
                Console.WriteLine("Voto obrigatorio");
            }

        }
    }
}

