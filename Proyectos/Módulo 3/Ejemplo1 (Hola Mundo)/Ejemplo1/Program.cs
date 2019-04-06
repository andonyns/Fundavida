using System;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var saludo = new Saludo();

            saludo.PedirNombre();

            saludo.ImprimirSaludo();

            //Agregamos ReadLine para que espere un enter.
            Console.WriteLine("Presione enter para terminar.");
            Console.ReadLine();
        }
    }
}
