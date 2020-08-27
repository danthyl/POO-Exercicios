using System;

namespace POO_ATV1_26._08._2020
{
    class Pessoas
    {
        public string p1, p2; //pessoas
        public int idadep1, idadep2; //idade das pessoas
    }

    class Program
    {      
        static void Main(string[] args)
        {
            Pessoas pessoa1, pessoa2;

            pessoa1 = new Pessoas();
            pessoa2 = new Pessoas();

            Console.WriteLine("Escreva seu nome e idade: ");
            pessoa1.p1 = Console.ReadLine();
            pessoa1.idadep1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva seu nome e idade: ");
            pessoa2.p2 = Console.ReadLine();
            pessoa2.idadep2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados 1° Pessoa: ");
            Console.WriteLine("Nome: " + pessoa1.p1);
            Console.WriteLine("Idade: " + pessoa1.idadep1);
            Console.WriteLine("Dados 2° Pessoa: ");
            Console.WriteLine("Nome: " + pessoa2.p2);
            Console.WriteLine("Idade: " + pessoa2.idadep2);

            if(pessoa1.idadep1 > pessoa2.idadep2)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.p1); // tá rodando só o segundo
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.p2);
            }

            Console.ReadKey();
        }
    }
}
