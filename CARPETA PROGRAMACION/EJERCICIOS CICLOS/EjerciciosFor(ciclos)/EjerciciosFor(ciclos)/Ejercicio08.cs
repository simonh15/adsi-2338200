using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosFor_ciclos_
{
    class Ejercicio08
    {
        static void MainT(string[] args)
        {
            /*Un alumno de la clase de lógica matemática desea desarrollar un programa que calcule el factorial
             de un número N, el cual le dará al usuario, el factorial de un número N, definido matemáticamente
             como N! se obtiene como la multiplicación de todos los números que están desde el 1 hasta el N = 1
             * 2 * 3 * ..... (N-2) * (N-1) * N, como se muestra en la figura, por definición el factorial de 0 es 1.*/
            double n, factorial = 1, contador = 0;

            Console.WriteLine("introduzca el numero");
            n = double.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                contador = contador + 1;
                factorial = factorial * contador;
            }
            Console.WriteLine("el factorial de el numero es igaul a :" + factorial);
        }
    }
}
