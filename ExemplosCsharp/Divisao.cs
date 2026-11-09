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

    
    internal class Divisao
    {
        //Criação do método Main
        public static void Main(string[] args)

        {
            Console.WriteLine("---Programa Divisão---");
            Console.WriteLine("Digite um numero inteiro que deseja dividir");

            int numero01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número que será dividido");
            float numero02 = Convert.ToSingle(Console.ReadLine());

            double resultadoDivisao = numero01 / numero02;

            Console.WriteLine("O resultado da divisão destes dois números será: " + resultadoDivisao);
        }
    }
}
