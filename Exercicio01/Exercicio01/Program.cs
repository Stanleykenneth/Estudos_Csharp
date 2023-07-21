using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritário";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine();
            Console.WriteLine(" Produtos:\n" + "  {0}, cujo o preço é $ {1}.", produto1, preco1);
            Console.WriteLine("  {0}, cujo o preço é $ {1}.",produto2, preco2);
            Console.WriteLine();
            Console.WriteLine(" Produtos:\n" + "  {0}, cujo o preço é R$ {1}.", produto1, preco1.ToString("F2", CultureInfo.InvariantCulture) + " (Imprimindo valor monetário Brasileiro)");
            Console.WriteLine("  {0}, cujo o preço é R$ {1}.", produto2, preco2.ToString("F2", CultureInfo.InvariantCulture) + " (Imprimindo valor monetário Brasileiro)");
            Console.WriteLine();
            Console.WriteLine(" Registro: "  + $"{idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine();
            Console.WriteLine(" Medida com oito casa decimais: {0}", medida);
            Console.WriteLine(" Arredondando (Três casas decimais):" +  $" {medida:F3}" );
            Console.WriteLine(" Separador decimal invariant culture: " + "{0}", medida.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();

        }
    }
}
