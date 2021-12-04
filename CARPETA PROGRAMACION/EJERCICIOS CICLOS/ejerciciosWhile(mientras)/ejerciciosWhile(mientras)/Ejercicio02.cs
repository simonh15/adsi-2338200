using System;
using System.Collections.Generic;
using System.Text;

namespace ejerciciosWhile_mientras_
{
    class Ejercicio02
    {
        static void MainT(string[] args)
        {
            /*En una empresa se requiere calcular el salario semanal de cada uno de los n obreros que laboran en
            ella.El salario se obtiene de la sig.forma:
            Si el obrero trabaja 40 horas o menos se le paga $20 por hora

            Si trabaja más de 40 horas se le paga $20 por cada una de las primeras 40 horas y $25 por cada hora
             extra.*/

            double salario_semanal = 0, horas_trabajadas = 0, horas_extras1 = 0;
            string conocer_salario = "", horas_extras;

            Console.WriteLine("desea saber el  salario semanal");
            conocer_salario = (Console.ReadLine());

            while (conocer_salario == "si")
            {
                Console.WriteLine("horas trabajadas");
                horas_trabajadas = double.Parse(Console.ReadLine());

                if (horas_trabajadas <= 40)
                    salario_semanal = 20;

                Console.WriteLine("usted trabajo horas extras");
                horas_extras = (Console.ReadLine());
                if (horas_extras == "si")
                {
                    Console.WriteLine("horas que usted trabajo ");
                    horas_extras1 = double.Parse(Console.ReadLine());
                    salario_semanal = horas_trabajadas * horas_extras1;
                }

                Console.WriteLine("digite NO para saber su salario y SI para ingresar otro obrero");
                conocer_salario = (Console.ReadLine());
            }
            Console.WriteLine("su salario es  " + salario_semanal);
        }
    }
}