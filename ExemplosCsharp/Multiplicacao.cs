//Importação de pacotes/biblioteca
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;


//namespace: Cria pacotes lógicos para organizar o código e evitar conflitos entre classes com o mesmo nome.
namespace ExemplosCsharp
{

    internal class Multiplicacao
    {
        //Criação do método Main
        public static void Main(string[] args)
       
        {
            Console.WriteLine("---Programa multiplicação---");
            Console.WriteLine("Digite um numero inteiro que deseja multiplicar");

           int numero01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro que será multiplicado");
            int numero02 = Convert.ToInt32(Console.ReadLine());

            int resultadoMultiplicacao = numero01 * numero02;

            Console.WriteLine("O resultado da multiplição destes dois números será: " + resultadoMultiplicacao);
        }
    }
}
