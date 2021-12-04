using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDoWhile_ciclos_
{
    class Ejercicio06
    {
        static void MainT(string[] args)
        {
            /*Leer por cada alumno de Diseño estructurado de algoritmos su número de control y su calificación en
            cada una de las 5 unidades de la materia. Al final que escriba el número de control del alumno que
            obtuvo mayor promedio. Suponga que los alumnos tienen diferentes promedios.*/

            int n, control, control2 = 0;
            double a, b, c, d, e, promedio = 0, promedio_mayor = 0;

            Console.WriteLine("Ingrese El Numero De Alumnos que desea sacar el promedio:");
            _ = int.TryParse(Console.ReadLine(), out n);

            do
            {
                Console.WriteLine("Ingrese el numero de control: ");
                _ = int.TryParse(Console.ReadLine(), out control);

                Console.WriteLine("Ingrese la primera nota :");
                _ = double.TryParse(Console.ReadLine(), out a);

                Console.WriteLine("Ingrese la segunda nota :");
                _ = double.TryParse(Console.ReadLine(), out b);

                Console.WriteLine("Ingrese la tercera nota :");
                _ = double.TryParse(Console.ReadLine(), out c);

                Console.WriteLine("Ingrese la cuarta nota :");
                _ = double.TryParse(Console.ReadLine(), out d);

                Console.WriteLine("Ingrese la quinta nota :");
                _ = double.TryParse(Console.ReadLine(), out e);

                promedio = (a + b + c + d + e) / 5;
                Console.WriteLine("El promedio es:" + promedio);

                if (promedio > promedio_mayor)
                {
                    promedio_mayor = promedio;
                    control2 = control;
                }

                n = n - 1;


            } while (n != 0);

            Console.WriteLine("El promedio mayor es: " + promedio_mayor);
            Console.WriteLine("El numero de control del alumno es: " + control2);

        }
    }
}
