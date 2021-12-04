using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosFor_ciclos_
{
    class Ejercicio02
    {

        static void MainT(string[] args)
        {
            //Leer 10 números e imprimir solamente los números positivos

            double numero;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("\nIngrese un número " + i + ": ");
                _ = double.TryParse(Console.ReadLine(), out numero);

                if (numero > 0)
                {
                    Console.WriteLine("  Número ingresado POSITIVO (" + numero + ").");
                }

            }
        }
    }
}
