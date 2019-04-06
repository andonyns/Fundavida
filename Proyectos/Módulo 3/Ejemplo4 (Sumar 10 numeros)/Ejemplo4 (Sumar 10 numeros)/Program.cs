using System;

namespace Ejemplo4__Sumar_10_numeros_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presione 1 para ejecutar while, dos para while con cambio, tres para do while, 4 para for");

            var entrada = Console.ReadLine();

            var seleccion = Convert.ToInt32(entrada);

            var cic = new Ciclos();

            switch(seleccion)
            {
                case 1:
                    cic.Forma1();
                    break;
                case 2:
                    cic.Forma2();
                    break;
                case 3:
                    cic.Forma3();
                    break;
                case 4:
                    cic.Forma4();
                    break;
            }


            Console.WriteLine("Presione enter para terminar");
            Console.ReadLine();
        }
    }
}
