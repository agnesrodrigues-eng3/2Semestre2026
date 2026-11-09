//Importação de pacotes/biblioteca
using System;//Contém comandos básicos do sistema, como entrada e saida no console (Console.Writeline)
using System.Collections.Generic;//Permite trabalhar com listas e coleções genéricas
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;//Fornesce classes para a manipulação avançada de textos e códificações de caracteres  


//namespace: Cria pacotes lógicos para organizar o código e evitar conflitos entre casses com o mesmo nome.
namespace ExemplosCsharp
{

    // Cração de calsses
    // internal: Modificador de acesso que permite que esta classe seja vista apenas dentro deste projeto.
    // class: Define o molde (estrutura) que agrupa dados e comportamentos para criar objetos.
    internal class SomaDetalhada
    {
        //Criação do método Main
        public static void Main(string[] args)
        // public: Modificador de acesso que libera o método para ser executado de qualquer lugar (inclusive pelo sistema).
        // static: Permite que o método seja executado diretamente pela classe, sem precisar criar um objeto ('new Soma()').
        // void: Tipo de retorno vazio; indica que o método executa uma tarefa, mas não devolve nenhum valor ao final.
        // Main: Ponto de entrada (entry point) oficial; é o primeiro método que o computador executa ao iniciar o programa.
        // (string[] args): Parâmetro que recebe possíveis argumentos de texto enviados pela linha de comando ao abrir o programa.
        {
            Console.WriteLine("---Programa Soma---");
            Console.WriteLine("Digite um número inteiro que deseja somar");

            
        // int numero01: Declara uma variável chamada 'numero01' que guarda apenas números inteiros.
        // Console.ReadLine(): Lê tudo o que o usuário digitar no teclado (sempre retorna como texto/string).
        // Convert.ToInt32(): Converte o texto lido para um número inteiro de 32 bits (suporta valores de -2 bilhões a +2 bilhões; 16 e 64 mudam apenas essa capacidade
           int numero01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro");
            int numero02 = Convert.ToInt32(Console.ReadLine());

            int resultadoSoma = numero01 + numero02;

            Console.WriteLine("O resultado da soma destes dois números será: " + resultadoSoma);
        }
    }
}
//Console.WriteLine(); é como o visulag, ele exibe o resultado e pula uma linha
//Console.Write(); ele não pula uma linha ao exibir o resultado na tela
//Class: são um conjunto de objetos/ Toda vez que trabalho com orientação a objetos, fica mais facil de organizar e vizualizar.
//Objeto:Conjunto de característica especifícas