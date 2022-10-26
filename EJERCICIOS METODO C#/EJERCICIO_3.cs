using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion;


            double resultad = 0, resultado = 0, pre = 0;
            Console.WriteLine("deseo comer en una fonda pero solo cuento con 50 pesos que bebida y comida " +
                "puedo comprar que este dentro de mi presupuesto");
            Console.WriteLine(" selecciona una opcion: ");
            Console.WriteLine(" s=gorditas de pollo ");
            Console.WriteLine(" r=torta de milanesa");
            Console.WriteLine(" t=enchiladas con secina");
            Console.WriteLine(" c=caldo de res");
            Console.WriteLine(" d=adobo de pollo");
            opcion = char.Parse(Console.ReadLine());
            if (opcion == 's' || opcion == 'r' || opcion == 't' || opcion == 'c' || opcion == 'd')
            {

                switch (opcion)
                {
                    case 's':
                        resultad = 30;

                        break;

                    case 'r':
                        resultad = 40;

                        break;

                    case 't':
                        resultad = 35;

                        break;
                    case 'c':
                        resultad = 45;

                        break;
                    case 'd':
                        resultad = 50;

                        break;

                }
                Console.WriteLine("----el precio de la comida es ---- :" + resultad);
                {

                }
                Console.WriteLine(" selecciona una opcion: ");
                Console.WriteLine(" 1-agua de sabor");
                Console.WriteLine(" 2-refresco coca");
                Console.WriteLine(" 3-agua simple");
                Console.WriteLine(" 4=refresco de sabor");
                Console.WriteLine(" selecciona una opcion");
                opcion = char.Parse(Console.ReadLine());
                if (opcion == '1' || opcion == '2' || opcion == '3' || opcion == '4')
                {

                    switch (opcion)
                    {
                        case '1':
                            resultado = 10;

                            break;

                        case '2':
                            resultado = 18;

                            break;

                        case '3':
                            resultado = 8;

                            break;
                        case '4':
                            resultado = 12;

                            break;
                    }
                    {
                        pre = resultad + resultado;

                        Console.WriteLine("--- el precio de la bebida ---:" + resultado);
                        Console.WriteLine("----el precio a pagar por la bebida y comida es----  :" + pre);
                    }
                    if (pre <= 50)
                    {
                        Console.WriteLine(" *** el precio esta dentro de presupuesto ***");
                    }
                    if (pre > 50)
                    {
                        Console.WriteLine("!!!!!!el precio es mayor al presupuesto!!!! ");
                    }

                    Console.ReadKey();
                }
            }
        }
    }
}
