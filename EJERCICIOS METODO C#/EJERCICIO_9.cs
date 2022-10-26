using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_9
{
    class Program
    {
        static void Main(string[] args)
        {
            char opciones;
            double prec = 0, cost = 0, ca;
            Console.WriteLine("calcular el precio  si quiero viajar a los lugares con unos amigos  " +
                " siempre partiendo de huejutal si cada lugar tiene un costo diferente  " +
                "  y el total a pagar depende de  las personas que viajen");
            Console.WriteLine("ingresa la contidad de personas");
            ca = double.Parse(Console.ReadLine());
            Console.WriteLine(" selecciona una opion");
            Console.WriteLine("a=atlapexco");
            Console.WriteLine("x=xochiatipan");
            Console.WriteLine("h=huautla");
            Console.WriteLine("y=yahualica");
            opciones = char.Parse(Console.ReadLine());

            if (opciones == 'a' | opciones == 'x' | opciones == 'h' | opciones == 'y')
            {
                switch (opciones)
                {
                    case 'a':
                        cost = 20;
                        prec = cost * ca;
                        break;
                    case 'x':
                        cost = 28;
                        prec = cost * ca;
                        break;
                    case 'h':
                        cost = 22;
                        prec = cost * ca;
                        break;
                    case 'y':
                        cost = 26;
                        prec = cost * ca;
                        break;


                }
                Console.WriteLine("el costo por el destibo es:" + cost);
                Console.WriteLine("el precio por total de personas:" + prec);


                
                    Console.ReadKey();
                
            }
        }
    }
}
