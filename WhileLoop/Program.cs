namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a los while loops");
            //int contador = 0;
            //while (contador < 10)
            //{
            //    Console.WriteLine("El valor es: " + contador);
            //contador++;
            //}
            //Console.WriteLine("Fin bucle");

            // Tabla de Multiplicar
            // 10 = 10x1,10x2 10x3.... 10x12

          
            int contadortabla = 1;

            Console.WriteLine("Ingrese el valior de la tabla de multiplciar");
            
            int valorTabla;
            int resultado;
            valorTabla = Convert.ToInt32(Console.ReadLine());
            while (contadortabla <= 12)
            {
                Console.WriteLine("El numero es: " + contadortabla);
                resultado = valorTabla * contadortabla;
                Console.WriteLine("latabla del numero: " + valorTabla + " es igual a " + +valorTabla+ "x" + contadortabla + "="+ resultado);
                contadortabla++;
            }
            

        }
    }
}
