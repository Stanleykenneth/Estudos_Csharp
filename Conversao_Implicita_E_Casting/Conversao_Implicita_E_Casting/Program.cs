using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Conversao_Implicita_E_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // conversão implicita

            float x = 4.5f;
             double y = x;

             Console.WriteLine(y);


            // Conversão Explícita
            double a;
            float b;

            a = 5.1;
            b = (float) a;

            Console.WriteLine(b);

            // Conversão com Explícita com globalization

            double w;
            float z;

            w = 5.1;
            z = (float) w;

            Console.WriteLine(z.ToString("F1", CultureInfo.InvariantCulture)); // Deu ceto => nesse caso eu troquei a virgula (,) por ponto (.) no console.write

            // Casting de Inteiro para Double

            int c = 5;
            int d = 2;

           

            double resultado = (double) c / d;

            Console.WriteLine(resultado);


        }
    }
}
