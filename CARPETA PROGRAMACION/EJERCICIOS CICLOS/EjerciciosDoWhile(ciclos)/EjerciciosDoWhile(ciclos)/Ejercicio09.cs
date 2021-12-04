using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDoWhile_ciclos_
{
    class Ejercicio09
    {
        static void MainT(string[] args)
        {
            /*9.Escribir un programa que muestre el siguiente menú y que permita pasar magnitudes de grados a
            radianes y de radianes a grados.
            1.Pasar de grados a radianes
            2.Pasar de radianes a grados
            3.Salir del programa*/

            double gradoradian, radiangrado;
            int n;
            do
            {
                Console.WriteLine("  1 | Pasar de grados a radianes ");
                Console.WriteLine("  2 | Pasar de radianes a grado ");
                Console.WriteLine("  3 | Salir del programa ");
                _ = int.TryParse(Console.ReadLine(), out n);

                if (n == 1)
                {
                    Console.WriteLine("Ingrese los grados que quiere convertir a radianes: ");
                    _ = double.TryParse(Console.ReadLine(), out gradoradian);
                    gradoradian = gradoradian * 3.141592 / 180;
                    Console.WriteLine("La conversion de grados a radian es de: " + gradoradian + "Radianes\n");
                }
                else if (n == 2)
                {
                    Console.WriteLine("Ingrese los radianes que quiere convertir a grados: ");
                    _ = double.TryParse(Console.ReadLine(), out gradoradian);
                    gradoradian = gradoradian * 180 / 3.141592;
                    Console.WriteLine("La conversion de radian a grados es de: " + gradoradian + "Grados\n");
                }
                if (n < 1 || n > 3)
                {
                    Console.WriteLine("Seleccione una de las opciones validas\n");
                }
            } while (n != 3);
            Console.WriteLine("\n<<<Usted a salido del programa>>>");


        }
    }
}
