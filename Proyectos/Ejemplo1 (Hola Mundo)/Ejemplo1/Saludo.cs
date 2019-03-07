using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo1
{
    class Saludo
    {
        string nombre;

        public void PedirNombre()
        {
            Console.WriteLine("Bienvenido. Digite su nombre:");
            nombre = Console.ReadLine();
        }

        public void ImprimirSaludo()
        {
            var saludo = "Hola ";
            Console.WriteLine(saludo + nombre);
        }
    }
}
