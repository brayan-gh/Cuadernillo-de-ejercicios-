using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_0
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultado = "";
            char opciones;

            Console.WriteLine("probabilidad tengo de aprobar la materia segun las opciones que me dan ");
            Console.WriteLine(" seleciona una opcion ");
            Console.WriteLine(" a=entrego trabajos ");
            Console.WriteLine(" b= no entrego trabajos");
            opciones = char.Parse(Console.ReadLine());

            Console.WriteLine(" seleciona una opcion ");
            Console.WriteLine(" c=paso el examen ");
            Console.WriteLine(" d= no paso el examen");
            opciones = char.Parse(Console.ReadLine());

            Console.WriteLine(" seleciona una opcion ");
            Console.WriteLine(" e= practico los codigos ");
            Console.WriteLine(" f= no practico los codigos");
            opciones = char.Parse(Console.ReadLine());

            if (opciones == 'a' | opciones == 'b' | opciones == 'c' | opciones == 'd' | opciones == 'e' | opciones == 'f')
            {
                switch (opciones)
                {
                    case 'a':
                        resultado = " apruebo";
                        break;
                    case 'b':
                        resultado = " repruebo";
                        break;
                    case 'c':
                        resultado = " apruebo";
                        break;
                    case 'd':
                        resultado = " repruebo";
                        break;
                    case 'e':
                        resultado = " apruebo";
                        break;
                    case 'f':
                        resultado = " repruebo";
                        break;

                }
                Console.WriteLine(" es probable que" + resultado);

            }
            Console.ReadKey();

        }
    }
}
