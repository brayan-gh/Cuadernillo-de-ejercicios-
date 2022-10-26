using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double descuento, preciot, precp, precplayera, prectenis;

            Console.WriteLine("Ingresa el precio del pantalon");
            precp = Double.Parse(Console.ReadLine());
            if (precp >= 500)
            {
                descuento = precp * 10 / 100;
                preciot = precp - descuento;
                Console.WriteLine("El precio final por el pantalon es: " + preciot);
                Console.WriteLine("El descuento aplicado por el pantalon es:" + descuento);
            }
            else
            {
                Console.WriteLine("El precio final es:" + precp);
                Console.WriteLine("No aplica descuento");
            }


            Console.WriteLine("ingresa el precio de la playera");
            precplayera = Double.Parse(Console.ReadLine());
            if (precplayera >= 300)
            {
                descuento = precplayera * 10 / 100;
                preciot = precplayera - descuento;
                Console.WriteLine("El precio final por la playera es: " + preciot);
                Console.WriteLine("El descuento aplicado por la playera es:" + descuento);
            }
            else
            {
                Console.WriteLine("El precio final es:" + precplayera);
                Console.WriteLine("No aplica descuento");
            }


            Console.WriteLine("Ingresa el precio del tenis");
            prectenis = Double.Parse(Console.ReadLine());
            if (prectenis >= 800)
            {
                descuento = prectenis * 15 / 100;
                preciot = prectenis - descuento;
                Console.WriteLine("El precio final por los tenis es:" + preciot);
                Console.WriteLine("El descuento aplicado por los tenis: " + descuento);
            }
            else
            {
                Console.WriteLine("El precio final es: " + prectenis);
                Console.WriteLine("No aplica descuento");
            }

        }
    }
}
