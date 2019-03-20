using System;

namespace Ejemplo_5__Arreglos_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[5];

            notas[0] = 25;
            notas[1] = 50;
            notas[2] = 75;
            notas[3] = 100;
            notas[4] = 60;

            var total = 0;

            for(int posicion = 0; posicion < notas.Length; posicion++)
            {
                total = total + notas[posicion];
            }

            //notas.Length nos da el total de elementos en el arreglo
            double promedio = total / notas.Length;

            Console.WriteLine("Su promedio es: " + promedio);

            Console.ReadKey();

        }
    }
}
