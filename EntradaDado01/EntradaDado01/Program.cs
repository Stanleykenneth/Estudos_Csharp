using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaDado01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

           /* string s = Console.ReadLine();

            string[] v = s.Split(' ');  // Split acrescenta um espaço em branco entre os campos preenchidos.  */          

            // Forma mais simples de se escrever
            string[] v = Console.ReadLine().Split(' '); 

            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine();
            Console.WriteLine("Você digitou: " + frase);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            // Para que os comando seja exibido, basta no input, digita-los na mesma linha. 

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }
    }
}
