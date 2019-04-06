using System;

namespace Ejemplo2__Calculadora_
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculadora();

            calc.Iniciar();

            Console.WriteLine("Presione enter para terminar");
            Console.ReadLine();
        }
    }
}
