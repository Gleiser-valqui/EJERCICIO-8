using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota;
            Console.WriteLine("ingrese una nota:");
            nota = Convert.ToInt32(Console.ReadLine());
            if (nota >= 16)
            {
                Console.WriteLine("exelente");
            }
            else if (nota == 14 || nota == 15)
            {
                Console.WriteLine("muy bueno");
            }
            else if (nota<= 13 && nota >= 11)
            {
                Console.WriteLine("bueno");
            }
            else
            {
                Console.WriteLine("insuficiente");
            }
                
        }
    }
}
