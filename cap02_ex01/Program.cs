using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap02_ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome;

            Console.Write("Entre seu nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Ola, " + Nome);

            Console.WriteLine();
            Console.WriteLine("Tecle <Enter> para encerrar...");
            Console.ReadLine();

        }
    }
}


