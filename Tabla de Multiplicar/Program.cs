namespace Tabla_de_Multiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mostrar título del programa
            Console.WriteLine("PROGRAMA PARA MOSTRAR LA TABLA DE MULTIPLICACIÓN");
            Console.WriteLine("-----------------------------------------------");

            // Solicitar el numero al usuario
            Console.Write("INTRODUZCA EL NÚMERO (TABLA A CALCULAR): ");

            // Leer el número ingresado por el usuario
            int numero = Convert.ToInt32(Console.ReadLine());

            // Mostrar la tabla de multiplicacion
            Console.WriteLine("Tabla de multiplicación del " + numero + ":");
            Console.WriteLine("---------------------------");

            // Ciclo para mostrar la tabla del 1 al 12
            for (int i = 1; i <= 12; i++)
            {
                int resultado = numero * i;
                Console.WriteLine(numero + " x " + i + " = " + resultado);
            }

            Console.ReadKey();
        }
    }
}
