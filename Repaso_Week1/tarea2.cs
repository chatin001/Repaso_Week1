using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Week1
{
    internal class tarea2
    {
        static void Main(string[] args) // Punto de Entrada del programa
    {
        Console.WriteLine("Calculadora de Áreas Geométricas");
        Console.WriteLine("1-Círculo");
        Console.WriteLine("2-Triángulo");
        Console.WriteLine("3-Rectángulo");
        Console.WriteLine("4-Salir");
        Console.Write("Introduzca su elección : ");

        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.Write("Radio de entrada del círculo : ");
                double radio = Convert.ToDouble(Console.ReadLine());
                double areaCirculo = 3.14 * radio * radio;
                Console.WriteLine("El área del círculo es: " + areaCirculo);
                break;

            case 2:
                Console.Write("Base del triángulo: ");
                double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                Console.Write("Altura del triángulo: ");
                double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                double areaTriangulo = 0.5 * baseTriangulo * alturaTriangulo;
                Console.WriteLine("El área del triángulo es: " + areaTriangulo);
                break;

            case 3:
                Console.Write("Longitud del rectángulo: ");
                double longitud = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ancho del rectángulo: ");
                double ancho = Convert.ToDouble(Console.ReadLine());
                double areaRectangulo = longitud * ancho;
                Console.WriteLine("El área del rectángulo es: " + areaRectangulo);
                break;

            case 4:
                Console.WriteLine("Gracias por usar la calculadora.");
                break;

            default:
                Console.WriteLine("Opción no válida");
                break;
        }

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
}
