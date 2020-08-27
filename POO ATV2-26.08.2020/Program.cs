using System;

namespace POO_ATV2_26._08._2020
{
    class Funcionario
    {
        public string nome;
        public double salario;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Funcionario A, B;
            A = new Funcionario();
            B = new Funcionario();

            Console.WriteLine("Escreva seu nome e salário");
            A.nome = Console.ReadLine();
            A.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva seu nome e salário");
            B.nome = Console.ReadLine();
            B.salario = double.Parse(Console.ReadLine());

            double m = (A.salario + B.salario) / 2;

            Console.WriteLine("1° Funcionário: ");
            Console.WriteLine("Nome: " + A.nome);
            Console.WriteLine("Salário: " + A.salario);
            Console.WriteLine("2° Funcionário: ");
            Console.WriteLine("Nome: " + B.nome);
            Console.WriteLine("Salário: " + B.salario);
            Console.WriteLine("Salário médio: " + m);
            Console.ReadKey();
        }
    }
}
