using System;

namespace Repaso_Week1 //Agrupar 
{
    internal class Program 
    {
        static void Main(string[] args) // Punto de Entrada del programa
        {
            

            double primernumero;
            double segundonumero;
            double tercernumero;
            Console.WriteLine("");
            Console.WriteLine("===============");
            Console.WriteLine("Cual es el numero mayor de 3 numeros : ");
            Console.WriteLine("===============");
            

            // Escribir la logica

            // Solicito el primer número
            Console.Write("\nIngrese el primer número: ");
             primernumero = Convert.ToDouble(Console.ReadLine());

            // Solicito el segundo número
            Console.Write("Ingrese el segundo número: ");
             segundonumero = Convert.ToDouble(Console.ReadLine());

            // Solicito el tercer número
            Console.Write("Ingrese el tercer número: ");
             tercernumero = Convert.ToDouble(Console.ReadLine());

            double numeromayor = primernumero = 0;
            if (segundonumero > numeromayor)
            {
                numeromayor = segundonumero;
            }

            if (tercernumero > numeromayor)
             {
                 numeromayor = tercernumero;
            }

            Console.Write(numeromayor);
        }

        }
    }
