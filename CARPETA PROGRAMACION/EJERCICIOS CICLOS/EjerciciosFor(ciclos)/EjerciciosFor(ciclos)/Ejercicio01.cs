using System;

namespace EjerciciosFor_ciclos_
{
    class Ejercicio01
    {
        static void MainT(string[] args)
        {
            //Calcular el promedio de un alumno que tiene 7 calificaciones en la materia de Diseño Estructurado
            //de Algoritmos.

            double promedio = 0;
            double suma = 0;
            double numero;

            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine(" Digite la calificacion de Diseño Estructurado " + i);
                _ = double.TryParse(Console.ReadLine(), out  numero);

                promedio = (suma += numero) / 7; 
            }
            Console.WriteLine(" Su promedio es : " + promedio);
        }
    }
}
