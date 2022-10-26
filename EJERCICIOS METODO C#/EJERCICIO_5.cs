using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double D = 0, PCD = 0, PSD;
            int PL = 12, CL;
            Console.WriteLine("-------PAPELERIA--------");
            Console.WriteLine("DESCUENTO");
            Console.WriteLine("Ingrese la cantidad de libretas a comprar");
            CL = int.Parse(Console.ReadLine());

            if (CL <= 0)
            {
                Console.WriteLine("!!!!Verificar la cantidad de libretas!!!!");

            }
            else
                if (CL > 1 && CL <= 14)
                {
                    PSD = PL * CL;
                    Console.WriteLine("el precio es de  " + PSD);
                }

                else
                    if (CL >= 15 && CL <= 30)
                    {
                        PSD = PL * CL;
                        D = PSD * 0.20;
                        PCD = PSD - D;
                        Console.WriteLine("El precio sin descuento es de:  " + PSD);
                        Console.WriteLine("El descuento seria de:  " + D);
                        Console.WriteLine("El precio con el descuento ya aplcado seria de:   " + PCD);
                    }
                    else
                        if (CL > 30 && CL <= 50)
                        {
                            PSD = PL * CL;
                            D = PSD * 0.30;
                            PCD = PSD - D;
                            Console.WriteLine("El descuento seria de:  " + D);
                            Console.WriteLine("El precio con el descuento ya aplcado seria de:   " + PCD);
                        }
                        else
                            if (CL > 50)
                            {
                                PSD = PL * CL;
                                D = PSD * 0.50;
                                PCD = PSD - D;
                                Console.WriteLine("El descuento seria de:  " + D);
                                Console.WriteLine("El precio con el descuento ya aplcado seria de:   " + PCD);
                            }


            Console.WriteLine("-------!!!GRACIAS POR SU COMPRA!!!-------");
            Console.ReadKey();

        }
    }
}
