using System;

namespace Ejemplo4__Sumar_10_numeros_
{
    class Ciclos
    {

        public void Forma1()
        {
            var numeroActual = 1;
            var resultado = 0;

            while (numeroActual <= 10)
            {
                resultado = resultado + numeroActual;
                numeroActual = numeroActual + 1;
            }

            Console.WriteLine("El resultado es:" + resultado);
        }

        public void Forma2()
        {
            var numeroActual = 1;
            var resultado = 0;

            while (numeroActual <= 10)
            {
                resultado = resultado + numeroActual;
                numeroActual++;
            }

            Console.WriteLine("El resultado es:" + resultado);

        }

        public void Forma3()
        {
            var numeroActual = 1;
            var resultado = 0;


            do
            {
                resultado = resultado + numeroActual;
                numeroActual++;
            } while (numeroActual <= 10);

            Console.WriteLine("El resultado es:" + resultado);

        }

        public void Forma4()
        {
            var resultado = 0;

            for (int numeroActual = 1; numeroActual <= 10; numeroActual++)
            {
                resultado = resultado + numeroActual;
            }

            Console.WriteLine("El resultado es:" + resultado);
        }

    }
}
