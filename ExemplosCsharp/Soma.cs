//Importação de pacotes/biblioteca
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;


//namespace: Cria pacotes lógicos para organizar o código e evitar conflitos entre casses com o mesmo nome.
namespace ExemplosCsharp
{

    // Cração de calsses
    internal class Soma
    {
        //Criação do método Main
        public static void Main(string[] args)
     
        {
            Console.WriteLine("---Programa Soma---");
            Console.WriteLine("Digite um número inteiro que deseja somar");

           int numero01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro");
            int numero02 = Convert.ToInt32(Console.ReadLine());

            int resultadoSoma = numero01 + numero02;

            Console.WriteLine("O resultado da soma destes dois números será: " + resultadoSoma);
        }
    }
}
