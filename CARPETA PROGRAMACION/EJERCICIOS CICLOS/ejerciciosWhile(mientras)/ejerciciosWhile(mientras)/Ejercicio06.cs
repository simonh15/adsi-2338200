using System;
using System.Collections.Generic;
using System.Text;

namespace ejerciciosWhile_mientras_
{
    class Ejercicio06
    {
        static void MainT(string[] args)
        {
            //Calcular el promedio de edades de hombres, mujeres y de todo un grupo de n alumnos.

            double n = 0, x = 1, sexo, edad, edad_mujeres = 0, edad_hombres = 0, numero_mujeres = 0, promedio_mujeres = 0, numero_hombres = 0, promedio_hombres = 0;



            Console.WriteLine("Escribe el numero de personas de todo el grupo");
            _ = double.TryParse(Console.ReadLine(), out n);

            while (x <= n)
            {
                Console.WriteLine("\nEscribe un numero de acuerdo a tu sexo ");
                Console.WriteLine("\n1 = Mujer");
                Console.WriteLine("2 = Hombre");
                _ = double.TryParse(Console.ReadLine(), out sexo);
                Console.WriteLine("\nEscribe tu edad ");
                _ = double.TryParse(Console.ReadLine(), out edad);

                if (sexo == 1)
                {
                    Console.WriteLine(" Mujer ");
                    edad_mujeres = edad_mujeres + edad;
                    numero_mujeres = numero_mujeres +1 ;
                    promedio_mujeres = edad_mujeres / numero_mujeres;
                }
                else if (sexo == 2)
                {
                    Console.WriteLine(" Hombre ");
                    edad_hombres = edad_hombres + edad;
                    numero_hombres = numero_hombres +1;
                    promedio_hombres = edad_hombres / numero_hombres;
                }

                x = x + 1;
            }
            
            Console.WriteLine("\nEl promedio de edades de las mujeres del grupo es " + promedio_mujeres);
            Console.WriteLine("\nEl promedio de edades de los hombres " + promedio_hombres);
            Console.WriteLine("\nEl promedio de la edad de todo el grupo es " + (edad_mujeres + edad_hombres) / n);
        }
    }
}
