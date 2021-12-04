using System;
using System.Collections.Generic;
using System.Text;

namespace ejerciciosWhile_mientras_
{
    class Ejercicio04
    {
        static void MainT(string[] args)
        {
            /*El Depto.de Seguridad Publica y Transito del D.F.desea saber, de los n autos que entran a la ciudad
            de México, cuantos entran con calcomanía de cada color.Conociendo el último dígito de la placa de
            cada automóvil se puede determinar el color de la calcomanía utilizando la sig.relación:

              DÍGITO             COLOR
              1 o 2             amarilla
              3 o 4             rosada
              5 o 6             roja
              7 o 8             verde
              9 o 0             azul*/

            double digito = 0;
            string color_calcomania = "";
            Console.WriteLine("desea saber el color de las calcomanias  ");
            color_calcomania = (Console.ReadLine());



            while (color_calcomania == "si")
            {
                Console.WriteLine("digite  el ultimo digito de su placa");
                digito = double.Parse(Console.ReadLine());
                switch (digito)
                {
                    case 1: Console.WriteLine("el color de su calcomania es amarrilla"); break;
                    case 2: Console.WriteLine("el color de su calcomania es amarrilla"); break;
                    case 3: Console.WriteLine("el color de su calcomania es rosa"); break;
                    case 4: Console.WriteLine("el color de su calcomania es rosa"); break;
                    case 5: Console.WriteLine("el color de su calcomania es roja"); break;
                    case 6: Console.WriteLine("el color de su calcomania es roja"); break;
                    case 7: Console.WriteLine("el color de su calcomania es verde"); break;
                    case 8: Console.WriteLine("el color de su calcomania es verde"); break;
                    case 9: Console.WriteLine("el color de su calcomania es azul"); break;
                    case 0: Console.WriteLine("el color de su calcomania es azul"); break;
                    default: Console.WriteLine("digito equivocado"); break;

                }
                Console.WriteLine("desea saber el color de otra calcomanias");
                color_calcomania = (Console.ReadLine());
            }
        }
    }
}
