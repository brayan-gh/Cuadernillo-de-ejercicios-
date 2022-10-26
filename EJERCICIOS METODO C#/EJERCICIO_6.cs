using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_55
{
    class Program
    {
        static void Main(string[] args)
        {
            double PT, PCP, PF;
            Console.WriteLine("-------SUPERMERCADO--------");
            Console.WriteLine("--------PROMOCION-----------");
            Console.WriteLine("INGRESE LA CANTIDAD TOTAL A PAGAR");
            PT = double.Parse(Console.ReadLine());

            if (PT <= 0)
            {
                Console.WriteLine("!!!!VERIFICAR QUE LA CANTIDAD SEA LA CORRECTA!!!!");

            }
            else
                if (PT > 0 && PT < 1000)
                {

                    Console.WriteLine("-------NO ES VALIDA LA PROMOCION-------");
                    Console.WriteLine("EL PRECIO SE MANTIENE EN: " + PT);
                }
                else
                    if (PT >= 1000 && PT <= 1500)
                    {
                        PCP = PT * 0.10;
                        PF = PCP + PT;
                        Console.WriteLine("el precio es de  " + PF);
                    }

                    else
                        if (PT > 1500 && PT <= 2000)
                        {
                            PCP = PT * 0.20;
                            PF = PCP + PT;
                            Console.WriteLine("El precio se devuelve es de:  " + PCP);
                            Console.WriteLine("El precio con la promocion aplicada es de:   " + PF);
                        }
                        else
                            if (PT > 2000 && PT <= 3000)
                            {
                                PCP = PT * 0.30;
                                PF = PCP + PT;
                                Console.WriteLine("El precio se devuelve es de:  " + PCP);
                                Console.WriteLine("El precio con la promocion aplicada es de:   " + PF);
                            }
                            else
                                if (PT > 3000)
                                {
                                    PCP = PT * 0.40;
                                    PF = PCP + PT;
                                    Console.WriteLine("El precio se devuelve es de:  " + PCP);
                                    Console.WriteLine("El precio con la promocion aplicada es de:   " + PF);
                                }


            Console.WriteLine("!!!VUELVA PRONTO!!!");
            Console.ReadKey();

        }
    }
}
