using System;
using System.Globalization;


namespace ConsoleApp1
{// Rafael Do Nascimento Rodrigues RA 210211
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variável da classe Pessoa
            Pessoa A;
            Pessoa B;
            // Instanciamento da variável Pessoa
            A = new Pessoa();
            B = new Pessoa();

            // Informação para a inserção do dado Idade pelo usuário
            Console.WriteLine("Insira a idade da pessoa A ");
            // Dado Idade inserido pelo usuário
            A.Idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            // Informação para a inserção do dado Nome pelo usuário
            Console.WriteLine("Insira o nome da pessoa A ");
            // Dado Nome inserido pelo usuário
            A.Nome = (Console.ReadLine());

            // Informação para a inserção do dado Idade pelo usuário
            Console.WriteLine("Insira a idade da pessoa B ");
            // Dado Idade inserido pelo usuário
            B.Idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // Informação para a inserção do dado Nome pelo usuário
            Console.WriteLine("Insira o nome da pessoa B ");
            // Dado Nome inserido pelo usuário
            B.Nome = (Console.ReadLine());

            //Comparativo que mostra na tela o nome da pessoa mais velha
            if (A.Idade > B.Idade)
            {
                Console.WriteLine("O mais velho é " + A.Nome);
            }
            else if (B.Idade > A.Idade)
            {
                Console.WriteLine("O mais velho é " + B.Nome);
            }
        }
    }
}
