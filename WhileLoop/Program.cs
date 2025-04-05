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

          
            //int contadortabla = 1;

            //Console.WriteLine("IMPRIMIR PATRONES");
            
            //int valorTabla;
            //int resultado;
            //valorTabla = Convert.ToInt32(Console.ReadLine());
            //while (contadortabla <= 12)
            //{
            //    Console.WriteLine("El numero es: " + contadortabla);
            //    resultado = valorTabla * contadortabla;
            //    Console.WriteLine("latabla del numero: " + valorTabla + " es igual a " + +valorTabla+ "x" + contadortabla + "="+ resultado);
            //    contadortabla++;
            //}


            // Imprimir cuadro con patrones de 1 al 5
            //int inicio = 1;

            //while(inicio<=5)
            //    {
            //    int b = 1;
            //    while (b <= 5)
            //    {
            //        Console.Write(b + " ");
            //        b++;
            //    }
            //    Console.WriteLine(""); // salto de Linea

            //    inicio++;


                // Ejercicio de while loop

                int inicio = 1;
                while (inicio <= 5)
                {
                    int b = 1;
                    while (b <= inicio) // Aquí limitamos hasta el valor actual de inicio
                    {
                        Console.Write(b + " ");
                        b++;
                    }
                    Console.WriteLine(""); // Salto de línea
                    inicio++;
                }

            // patron de izquierda a derecha 

            int inicio2 = 1;
            while (inicio2 <= 5)
            {
                // Primero imprimimos los espacios
                int espacios = 5 - inicio2;
                int e = 1;
                while (e <= espacios)
                {
                    Console.Write("  ");  
                    e++;
                }

                // Luego imprimimos los números
                int b = 1;
                while (b <= inicio2)
                {
                    Console.Write(b + " ");
                    b++;
                }

                Console.WriteLine(""); // Salto de línea
                inicio2++;

            }

        
}
            
    }
 
}
