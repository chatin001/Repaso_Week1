using System;

namespace Repaso_Week1 //Agrupar 
{
    internal class Program 
    {
        static void Main(string[] args) // Punto de Entrada del programa
        {
            int edad = 22;
            double numerodecimal = 10.00;   
            char caracter = '1';
            bool esMayordeEdad = true;
            string nombre = "Andre"; // Tipo de datos de Referencia

            if (edad > 18)
            {
                Console.WriteLine("Soy mayor de edad"); // Imprime string dentro de un runtime
            }
            else {
                Console.WriteLine("NO eres mayor de edad"); // Imprime string dentro de un runtime
            }

            // dias de la semana
            Console.WriteLine("================");
            Console.WriteLine("Dias de la semana");
            String diaSemana = "lunes";

            switch (diaSemana) {

                case "Lunes":
                    Console.WriteLine("El dia es Lunes");
                    break;

                case "Martes":
                    Console.WriteLine("El dia es Martes");
                    break;
            }
            {
                    Console.WriteLine("No es dia de la semana");
            }


            // Comprobar si un numeo es impar o par

            int numeroAcomprobar;
            Console.WriteLine("");
            Console.WriteLine("===============");
            Console.WriteLine("Ingresa el valor a comprobar: ");
            Console.WriteLine("===============");
            numeroAcomprobar = Convert.ToInt32(Console.ReadLine());

            // Comprobacion

            if (numeroAcomprobar % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else {
                Console.WriteLine("El numero es impar");

            }

           



        }
    }
}
