using System;
using System.Collections.Generic;
using System.Text;

namespace ejerciciosWhile_mientras_
{
    class Ejercicio08
    {
        static void Main(string[] args)
        {
            //Encontrar el mayor valor de un conjunto de n números dados.

            double x = 1, n, total, numero_mayor = 0;

            Console.WriteLine(" Escriba el total de numeros a calcular ");
            _ = double.TryParse(Console.ReadLine(), out total);

            while ( x <= total)
            {
                Console.WriteLine(" Escriba un numero : ");
                _ = double.TryParse(Console.ReadLine(), out n);

                if ( x == 1 )
                {
                    numero_mayor = n;
                }
                else if ( n > numero_mayor)
                {
                    numero_mayor = n;
                }
                x = x + 1;
            }
            Console.WriteLine(" El numero mayor es : " + numero_mayor);
        }
    }
}
