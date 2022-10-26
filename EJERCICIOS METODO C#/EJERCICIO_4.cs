using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0, pga = 0, com = 0;
            int pre = 0, tam = 0;
            Console.WriteLine("calcular  el precio total a pagar por cada alumno y total que pagaran  todos los alumnos y cuantos" +
                "tamales les tocara a cada alumno si son 30 alunmnos  que si piden mayor a 200 tamales nos cobraran $8 " +
                "y si pedimos menos de 200 tamales nos cobraran $10 ");

            Console.WriteLine(" ingresa la cantidad de tamales");

            tam = int.Parse(Console.ReadLine());


            if (tam <= 0)
            {
                Console.WriteLine(" verificar precio");

            }
            if (tam >= 200)
            {
                pre = 8;
                total = tam * pre;
                pga = total / 30;
                com = tam / 30;

            }
            else
                if (tam >= 1 && tam < 200)
                {
                    pre = 10;
                    total = tam * pre;
                    pga = total / 30;
                    com = tam / 30;


                }
            Console.WriteLine("precio es: " + pre);
            Console.WriteLine("total es: " + total);
            Console.WriteLine("el pago de cada alumno  es: " + pga);
            Console.WriteLine(" total de tamalesa a cada alumno: " + com);


            Console.ReadKey();

        }
    }
}
