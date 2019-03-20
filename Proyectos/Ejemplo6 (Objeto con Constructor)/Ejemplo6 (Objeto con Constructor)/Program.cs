using System;

namespace Ejemplo6__Objeto_con_Constructor_
{
    class Program
    {
        static void Main(string[] args)
        {

            var carro1 = new Carro("Toyota", "Yaris");
            var carro2 = new Carro("Nissan", "Sentra");
            var carro3 = new Carro("Hyundai", "Elantra");

            carro1.LlenarGasolina(5);
            carro2.LlenarGasolina(8);
            carro3.LlenarGasolina(10);


            while (carro1.TieneGasolina())
            {
                carro1.Manejar();
            }

            Console.WriteLine("Terminé de manejar el carro1");


            Console.ReadKey();
        }
    }
}
