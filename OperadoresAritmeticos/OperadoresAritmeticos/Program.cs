using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            int n4 = 10 / 8;
            double n5 = (double)10 / 8; // Se não quizer fazer o casting (no caso double); basta apenas colocar 10.0 e 8.0. 

            // Formula de bascara

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; // Essa formula representa B² (b * b).

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(x1);


            //  double delta = b * b - 4.0 * a * c; // função alternativa para formula de bascara Delta = Math.Pow(b, 2.0)

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}
