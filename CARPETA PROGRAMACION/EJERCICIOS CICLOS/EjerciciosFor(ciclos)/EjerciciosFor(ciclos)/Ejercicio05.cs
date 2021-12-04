using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosFor_ciclos_
{
    class Ejercicio05
    {
        static void MainT(string[] args)
        {
            //Calcular e imprimir la tabla de multiplicar de un número cualquiera. Imprimir el multiplicando, el
            //multiplicador y el producto.

            int numero;

            Console.WriteLine(" Ingrese el numero que desea multiplicar .");
            _ = int.TryParse(Console.ReadLine(), out numero);

            for ( int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " * " + i + " = " + (numero * i));
                Console.WriteLine(" El multiplicando es : " + numero);
                Console.WriteLine(" El multplicador es : " + i);
                Console.WriteLine(" El producto es : " + (numero * i));
            }
        }
    }
}
