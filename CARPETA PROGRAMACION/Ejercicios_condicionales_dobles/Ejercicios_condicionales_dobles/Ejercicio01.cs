﻿using System;

namespace Ejercicios_condicionales_dobles
{
    class Ejercicio01
    {
        static void MainTemporal(string[] args)
        {
            /*Desarrollar un algoritmo que lea dos números y los imprima en forma ascendente.*/

            double Num1, Num2;

            Console.WriteLine("Hello World!");
            Console.WriteLine("escriba el primer numero");
            Num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("escriba el segundo numero");
            Num2 = double.Parse(Console.ReadLine());

            if (Num1 < Num2)
            {
                Console.WriteLine("<------------------------>");
                Console.WriteLine(Num1);
                Console.WriteLine(Num2);
            }
            else
            {
                Console.WriteLine("<------------------------>");
                Console.WriteLine(Num2);
                Console.WriteLine(Num1);
            }
        }
    }
}
