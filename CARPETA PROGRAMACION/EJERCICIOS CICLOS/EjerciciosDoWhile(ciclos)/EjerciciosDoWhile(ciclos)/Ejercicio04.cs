using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDoWhile_ciclos_
{
    class Ejercicio04
    {
        static void MainT(string[] args)
        {
            /*En la Cámara de Diputados se levanta una encuesta con todos los integrantes con el fin de determinar
		    que porcentaje de los n diputados esta a favor del Tratado de Libre Comercio, que porcentaje esta en
		    contra y que porcentaje se abstiene de opinar.
		    El programa debe preguntar si se desea continuar ingresando datos.*/

            int a = 0, b = 0, c = 0, total = 0, x, n;
            double porcentajecontra, porcentajefavor, porcentajeabstiene;

            do
            {
                Console.WriteLine("Cual es su opinión acerca del tratado de libre comercio");
                Console.WriteLine("     1   =   A favor");
                Console.WriteLine("     2   =   En contra");
                Console.WriteLine("     3   =   Se abstiene a votar");
                _ = int.TryParse(Console.ReadLine(), out n);

                if (n >= 1 && n <= 3)
                {
                    if (n == 1)
                    {
                        a = a + 1;
                    }
                    else if (n == 2)
                    {
                        b = b + 1;
                    }
                    else
                    {
                        c = c + 1;
                    }

                    total = total + 1;
                    Console.WriteLine("el total: " + total);

                }
                else
                {
                    Console.WriteLine("Ingrese un numero válido");
                }
                Console.WriteLine("Deseas continuar con otra encuesta?");
                Console.WriteLine("     1  =   Si");
                Console.WriteLine("Escriba otro numero para finalizar");
                _ = int.TryParse(Console.ReadLine(), out x);
            } while (x == 1);
            porcentajefavor = (double)a / total * 100;
            porcentajecontra = (double)b / total * 100;
            porcentajeabstiene = (double)c / total * 100;

            Console.WriteLine("El " + porcentajefavor + "% está a favor.");
            Console.WriteLine("El " + porcentajecontra + "% está en contra");
            Console.WriteLine("El " + porcentajeabstiene + "% se abstiene a votar");

        }
    }
}
