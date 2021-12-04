using System;
using System.Collections.Generic;
using System.Text;

namespace ejerciciosWhile_mientras_
{
    class Ejercicio05
    {
        static void MainT(string[] args)
        {
            //Obtener el promedio de calificaciones de un grupo de n alumnos.

            double n = 0 , x = 1 , nota = 0 , acumulador_notas = 0 , contar_notas = 0 , promedio = 0 ;

            Console.WriteLine(" Ingrese el numero de alumnos : ");
           // n = double.Parse(Console.ReadLine());
            _= double.TryParse(Console.ReadLine() , out n);
            while ( x <= n )
            {
                Console.WriteLine(" Ingrese la nota : ");
                _ = double.TryParse(Console.ReadLine() , out nota);
                acumulador_notas = acumulador_notas + nota;
                contar_notas = contar_notas + 1;
                promedio = acumulador_notas / contar_notas;

                x = x + 1;
                
            }
            Console.WriteLine(" El promedio de calificaciones es : " + promedio);
        }
    }
}
