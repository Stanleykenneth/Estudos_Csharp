using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F';
            char genero1 = '\u004D';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.8;
            string nome = "Maria Green";

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(genero1);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
        }
    }
}
