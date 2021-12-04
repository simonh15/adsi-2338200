using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDoWhile_ciclos_
{
    class Ejercicio08
    {
        static void MainT(string[] args)
        {
            /*Hacer un programa que lea caracteres desde teclado y vaya contando las vocales que aparecen. El
            programa terminará cuando lea el carácter # y entonces mostrará un mensaje indicando cuántas
            vocales ha leído (cuántas de cada una de ellas).*/

            int contA = 0, contE = 0, contI = 0, contO = 0, contU = 0, i = 1;
            string letra, cadena;


            do
            {
                Console.WriteLine("Ingrese una letra");
                cadena = Console.ReadLine();

                letra = cadena.ToLower();
                if (letra == "a")
                {
                    contA++;
                    Console.WriteLine("La letra ingresada fue: " + cadena);
                    Console.WriteLine("El total de vocales 'a' hasta el momento es:" + contA);
                }
                if (letra == "e")
                {
                    contE++;
                    Console.WriteLine("La letra ingresada fue: " + cadena);
                    Console.WriteLine("El total de vocales 'e' hasta el momento es:" + contE);
                }
                if (letra == "i")
                {
                    contI++;
                    Console.WriteLine("La letra ingresada fue: " + cadena);
                    Console.WriteLine("El total de vocales 'i' hasta el momento es:" + contI);
                }
                if (letra == "o")
                {
                    contO++;
                    Console.WriteLine("La letra ingresada fue: " + cadena);
                    Console.WriteLine("El total de vocales 'o' hasta el momento es:" + contO);
                }
                if (letra == "u")
                {
                    contU++;
                    Console.WriteLine("La letra ingresada fue: " + cadena);
                    Console.WriteLine("El total de vocales 'u' hasta el momento es:" + contU);
                }
                i++;
            } while (letra != "#");


            Console.WriteLine("La vocal A se leyo..." + contA);
            Console.WriteLine("La vocal E se leyo..." + contE);
            Console.WriteLine("La vocal I se leyo..." + contI);
            Console.WriteLine("La vocal O se leyo..." + contO);
            Console.WriteLine("La vocal U se leyo..." + contU);
        }
    }
}
