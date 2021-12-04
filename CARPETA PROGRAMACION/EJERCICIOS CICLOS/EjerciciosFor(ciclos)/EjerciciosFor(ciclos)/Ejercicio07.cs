using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosFor_ciclos_
{
    class Ejercicio07
    {
        static void MainT(string[] args)
        {
            /*Al cerrar un expendio de naranjas, 15 clientes recibirán un 15 % de descuento si compran más de 10
            kilos.Determinar cuánto pagará cada cliente y cuanto percibirá la tienda por esas compras.*/
            double kilos = 0, precio = 0, pagar_cliente = 0, recibira_tienda = 0, descuento = 0;

            Console.WriteLine("Ingrese el precio de kilo de naraja :");
            precio = double.Parse(Console.ReadLine());


            for (int i = 1; i <=15; i++)
            {
                Console.WriteLine("\nIngrese la cantidad de  kilos ");
                kilos = double.Parse(Console.ReadLine());

                if (kilos > 10)
                {
                    descuento = (precio * kilos) * 0.15;
                    pagar_cliente = (precio * kilos) - descuento;
                    Console.WriteLine("\nEl cliente " + i + " pagara " + pagar_cliente);
                    recibira_tienda = recibira_tienda + pagar_cliente; //acumulador = acumulador + variable 24000+30600+28050
                }
                else
                {
                    pagar_cliente = precio * kilos;
                    Console.WriteLine("\nEl cliente " + i + " pagara " + pagar_cliente);
                    recibira_tienda = recibira_tienda + pagar_cliente; //acumulador = acumulador + variable 24000+30600+28050+12000= 94650
                }

            }
            Console.WriteLine("\nLa tienda recibira " + recibira_tienda);


        
        }
    }
}
