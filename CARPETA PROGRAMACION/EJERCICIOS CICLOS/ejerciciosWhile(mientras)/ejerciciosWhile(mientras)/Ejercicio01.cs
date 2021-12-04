using System;

namespace ejerciciosWhile_mientras_
{
    class Ejercicio01
    {
        static void MainT(string[] args)
        {
            /* Una compañía de seguros tiene contratados a n vendedores. Cada uno hace tres ventas a la semana.
                Su política de pagos es que un vendedor recibe un sueldo base, y un 10% extra por comisiones de
                sus ventas. El gerente de su compañía desea saber cuanto dinero obtendrá en la semana cada
                vendedor por concepto de comisiones por las tres ventas realizadas, y cuanto tomando en cuenta 
                su sueldo base y sus comisiones.   */

            int numVendedores = 0, i = 1, numVentas = 1;
            double sueldoBase = 0, comisiones = 0, sueldoTotal, venta = 0;

            while (numVendedores <= 0)
            {
                Console.Write("Ingrese la cantidad de vendedores que tiene la compañia: ");
                _ = int.TryParse(Console.ReadLine(), out numVendedores);
            }

            while (i <= numVendedores)
            {
                Console.WriteLine("\n  Vendedor " + i + ": ");

                while (sueldoBase <= 0)
                {
                    Console.Write("Ingrese el sueldo base del vendedor: ");
                    _ = double.TryParse(Console.ReadLine(), out sueldoBase);
                }

                //Ciclo para las comisiones de las 3 ventas
                while (numVentas <= 3)
                {
                    while (venta <= 0)
                    {
                        Console.Write("Ingrese el valor de la venta " + numVentas + ": ");
                        _ = double.TryParse(Console.ReadLine(), out venta);
                    }
                    comisiones = comisiones + (venta * 10 / 100);
                    numVentas++;
                    venta = 0;
                }
                sueldoTotal = sueldoBase + comisiones;
                Console.WriteLine("El trabajador " + i + " recibe por comisiones $" + comisiones + ".\n" +
                    "Recibe en total $" + sueldoTotal + ".");
                sueldoBase = 0;
                numVentas = 1;
                comisiones = 0;
                i++;
            }
        }
    }
} 
