using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosFor_ciclos_
{
    class Ejercicio06
    {
        static void Main(string[] args)
        {
            /*Una persona debe realizar un muestreo con 50 personas para determinar el promedio de peso de los
            niños, jóvenes, adultos y adultos mayores que existen en su zona habitacional.Se determinan las
            categorías con base en la sig, tabla

                      CATEGORIA                  EDAD
                         Niños                  0 – 12
                         Jóvenes                13 - 29
                         Adultos                30 - 59
                     Adultos Mayores         60 en adelante

            Se debe solicitar la edad y el peso de cada persona y calcular y mostrar el promedio por categoría.*/
            double peso = 0, acumuladorNino = 0, acumuladorJoven = 0, acumuladorAdulto = 0, acumuladorAdultoMayor = 0, contadorNino = 0, contadorJoven = 0, contadorAdulto = 0, contadorAdultoMayor = 0; ;
            int edad = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingrese la edad\n");
                _ = int.TryParse(Console.ReadLine(), out edad);

                Console.WriteLine("Ingrese la peso\n");
                _ = double.TryParse(Console.ReadLine(), out peso);

                if (edad <= 12)
                {
                    Console.WriteLine(" Niño ");
                    acumuladorNino = acumuladorNino + peso;
                    contadorNino = contadorNino + 1;
                }

                if (edad >=13 && edad <= 29 )
                {
                    Console.WriteLine(" Joven ");
                    acumuladorJoven = acumuladorJoven + peso;
                    contadorJoven = contadorJoven + 1;
                }

                if (edad >= 30 && edad <= 59)
                {
                    Console.WriteLine(" Adulto ");
                    acumuladorAdulto = acumuladorAdulto + peso;
                    contadorAdulto = contadorAdulto + 1;
                }

                if ( edad >= 60)
                {
                    Console.WriteLine(" Adulto Mayor  ");
                    acumuladorAdultoMayor = acumuladorAdultoMayor + peso;
                    contadorAdultoMayor = contadorAdultoMayor + 1; 
                }
            }
            if (acumuladorNino == 0)
            {
                Console.WriteLine("No hay personas en esta categoria\n");
            }
            else 
            {
                Console.WriteLine("\nel promedio de peso de los niños es  " + (acumuladorNino / contadorNino));
            } 

            if (acumuladorJoven == 0)
            {
                Console.WriteLine("No hay personas en esta categoria\n");
            }
            else
            {
                Console.WriteLine("\nel promedio de peso de los jovenes es  " + (acumuladorJoven / contadorJoven));
            }
                

            if (acumuladorAdulto == 0)
            {
                Console.WriteLine("No hay personas en esta categoria\n");
            }
            else
            {
                Console.WriteLine("\nel promedio de peso de los adulto es " + (acumuladorAdulto / contadorAdulto));
            }
                

            if (acumuladorAdultoMayor == 0)
            {
                Console.WriteLine("No hay personas en esta categoria\n");
            }
            else
            {
                Console.WriteLine("\nel promedio de peso de los adultos mayores es   " + (acumuladorAdultoMayor / contadorAdultoMayor));
            }
                
        }
    }
}
