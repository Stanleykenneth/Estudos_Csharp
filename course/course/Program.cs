using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(idade);  
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));


            // placeholders
            Console.WriteLine(" {0} têm {1} anos e têm saldo igual a {2} reais.", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));

            // interpolação

            Console.WriteLine($" {nome} têm {idade} anos e têm saldo igual a {saldo:F2} reais.");
            Console.WriteLine($" {nome} têm {idade} anos e têm saldo igual a {saldo.ToString("F2", CultureInfo.InvariantCulture)} reais.");

            // Concatenação

            Console.WriteLine(" " + nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reias.");
        }
    }
}
