using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDoWhile_ciclos_
{
    class Ejercicio02
    {
        static void MainT(string[] args)
        {
            /*Un alumno de la clase de lógica matemática desea desarrollar un algoritmo y diagrama de flujo en el
            cual introduzca un número entero positivo e invierta los dígitos del número. Mostrar el número
            invertido.*/

            int numeroIngresado, numeroMedio = 0, numeroInvertido = 0;

            do
            {
                Console.WriteLine("Ingrese un numero entero positivo:");
                _ = int.TryParse(Console.ReadLine(), out numeroIngresado);

            } while (numeroIngresado <= 0);

            do
            {
                numeroInvertido = numeroInvertido * 10 + numeroMedio % 10;
                numeroMedio = numeroIngresado / 10;
            } while (numeroMedio > 0);
            Console.WriteLine("Numero ingresado: " + numeroIngresado + "\nNumero Invertido: " + numeroInvertido);

        }
    }
}
