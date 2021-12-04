using System;

namespace EjerciciosDoWhile_ciclos_
{
    class Ejercicio01
    {
        static void MainT(string[] args)
        {
            /* int num, suma = 0;
             do
             {
                 Console.WriteLine("Ingrese un numero para sumar(0 para finalizar)");
                 _ = int.TryParse(Console.ReadLine(), out num);
                 if (num != 0)
                 {
                     suma += num; // suma = suma + num
                 }
                 else
                 {
                     Console.WriteLine("ha decidido salir");
                 }
             } while (num != 0);
             Console.WriteLine("La suma de los numeros es:" + suma);  */


            //Ejemplo Validacion Con Do...While
            /* double nota;

             do
             {
                 Console.WriteLine("Ingrese el valor de la nota entre 0 y 5");
                 _ = double.TryParse(Console.ReadLine(), out nota);
                 if (nota < 0 || nota > 5)
                 {
                     Console.WriteLine("Valor no valido, ingrese de nuevo la nota");
                 }
             } while (nota < 0 || nota > 5);*/


            int opcion;
            double num1, num2, suma, resta, multiplicacion, division;
            do
            {

                Console.WriteLine("\n Bienvenido! que operacion desea realizar");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Salir");

                _ = int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Selecciono suma");
                        Console.WriteLine("Digite el primer numero que desea sumar");
                        _ = double.TryParse(Console.ReadLine(), out num1);
                        Console.WriteLine("Digite el segundo numero que desea sumar");
                        _ = double.TryParse(Console.ReadLine(), out num2);
                        suma = num1 + num2;
                        Console.WriteLine("La suma de los dos numeros es:>>>  " + suma);
                        break;
                    case 2:
                        Console.WriteLine("Selecciono Resta");
                        Console.WriteLine("Digite el primer numero que desea Restar");
                        _ = double.TryParse(Console.ReadLine(), out num1);
                        Console.WriteLine("Digite el segundo numero que desea Restar");
                        _ = double.TryParse(Console.ReadLine(), out num2);
                        resta = num1 - num2;
                        Console.WriteLine("La resta de los dos numeros es:>>>  " + resta);
                        break;
                    case 3:
                        Console.WriteLine("Selecciono Multiplicacion");
                        Console.WriteLine("Digite el primer numero que desea Multiplicar");
                        _ = double.TryParse(Console.ReadLine(), out num1);
                        Console.WriteLine("Digite el segundo numero que desea Multiplicar");
                        _ = double.TryParse(Console.ReadLine(), out num2);
                        multiplicacion = num1 * num2;
                        Console.WriteLine("La multiplicacion de los dos numeros es:>>>  " + multiplicacion);
                        break;
                    case 4:
                        Console.WriteLine("Selecciono Division");
                        Console.WriteLine("Digite el Dividendo");
                        _ = double.TryParse(Console.ReadLine(), out num1);
                        Console.WriteLine("Digite el Divisor");
                        _ = double.TryParse(Console.ReadLine(), out num2);
                        division = num1 / num2;
                        Console.WriteLine("El resultado de la division es:>>>  " + division);
                        break;
                    case 5:
                        Console.WriteLine("Selecciono Salir");
                        break;
                    default:
                        Console.WriteLine("La opcion no es valida");
                        break;

                }


            } while (opcion != 5);
        }
    }
}
