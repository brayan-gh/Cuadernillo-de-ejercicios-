using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double edad, fa, fn;
            
            Console.WriteLine("Ingresa el año  actual");
            fa = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu año de nacimiento");
            fn = Double.Parse(Console.ReadLine());
            edad = fa - fn;
            Console.WriteLine("Tu edad es: " + edad);
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
                Console.WriteLine("Puedes votar");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
                Console.WriteLine("No puedes votar");
            }
        }
    }
}
