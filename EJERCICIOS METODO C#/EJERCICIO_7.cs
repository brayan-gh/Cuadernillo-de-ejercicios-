using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa Temperatura");
            double tem = Convert.ToDouble(Console.ReadLine());
            if (tem >= 30)
            {
                Console.WriteLine("Está haciendo mucho calor");
            }
            else
            {
                if (tem < 30 && tem >= 15)
                {
                    Console.WriteLine("El clima es normal");
                }
                else
                {
                    if (tem < 15 && tem >= 1)
                    {
                        Console.WriteLine("Esta haciendo mucho  frio");
                    }

                }
            }
            Console.ReadLine();

        }
    }
}
