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

    internal class Subtracao
    {
        //Criação do método Main
        public static void Main(string[] args)
       
        {
            Console.WriteLine("---Programa Subtrair---");
            Console.WriteLine("Digite um numero inteiro que deseja subtrair");

           int numero01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro que será subtraido");
            int numero02 = Convert.ToInt32(Console.ReadLine());

            int resultadoSubtracao = numero01 - numero02;

            Console.WriteLine("O resultado da subtração destes dois números será: " + resultadoSubtracao);
        }
    }
}
