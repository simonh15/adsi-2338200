using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDoWhile_ciclos_
{
    class Ejercicio07
    {
		static void MainT(string[] args)
		{
			/*Hacer un programa que lea caracteres desde teclado hasta que lea 10 veces la letra 'a'. Por cada
            carácter leído que no sea una 'a' debe mostrar un mensaje indicándolo. Cuando lea las 10 letras 'a'
            el programa terminará.*/

			int contA = 0, i = 1;
			String letra, cadena;

			do
			{
				Console.WriteLine("Ingrese una letra");
				cadena = Console.ReadLine();

				letra = cadena.ToLower();

				if (letra == "a")
				{
					contA++;
					Console.WriteLine("La letra ingresada fue: " + cadena);
					Console.WriteLine("El total de letras A hasta el momento es: " + contA);
				}
				else
				{
					Console.WriteLine("La letra ingresada fue: " + cadena);
				}
				i++;
			} while (contA < 10);



		}
	}
}
