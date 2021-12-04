using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosFor_ciclos_
{
    class Ejercicio04
    {
        static void MainT(string[] args)
        {
            //Suponga que se tiene un conjunto de calificaciones de un grupo de 40 alumnos.Realizar un algoritmo
            //para calcular la calificación promedio y la calificación más baja de todo el grupo.

            double calificacion = 0, suma = 0, calificacion_promedio = 0, calificacion_baja;
            calificacion_baja = 99999;

            for (int i = 1; i <= 40; i++)
            {

                Console.WriteLine(" Digite la calificaion :  " + i);
                calificacion = double.Parse(Console.ReadLine());
                //suma iterativa de las calificaciones
                suma = suma + calificacion;
                //calculamos la menor calificacion
                if (calificacion < calificacion_baja)
                {
                    calificacion_baja = calificacion;
                }
            }
            calificacion_promedio = suma / 4;

            Console.WriteLine(" La calififacion promedio es : " + calificacion_promedio);
            Console.WriteLine(" La calificacion mas baja es : " + calificacion_baja);
        }
    }
}
