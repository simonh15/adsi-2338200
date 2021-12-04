using System;
using System.Collections.Generic;
using System.Text;

namespace ejerciciosWhile_mientras_
{
    class Ejercicio03
    {
        static void MainT(string[] args)
        {
            /*Determinar cuantos hombres y cuantas mujeres se encuentran en un grupo de n personas,
            suponiendo que los datos son extraídos alumno por alumno.*/

            double hombres = 0, mujeres = 0, sexo = 0;
            string encuesta = "";

            Console.WriteLine("desea participar en una encuesta");
            encuesta = (Console.ReadLine());

            while (encuesta == "si")
            {
                Console.WriteLine("¿digite 1. si es hombre 2. si es mujer");
                sexo = double.Parse(Console.ReadLine());

                if (sexo == 1)
                    hombres = hombres + 1;
                else if (sexo == 2)
                    mujeres = mujeres + 1;
                Console.WriteLine("desea participar en una encuesta");
                encuesta = (Console.ReadLine());
            }
            Console.WriteLine("el numero de hombres es " + hombres);
            Console.WriteLine("el numero de mujeres es " + mujeres);

        }


    }
}
