using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo2__Calculadora_
{
    class Calculadora
    {
        int digito1;
        int digito2;
        int resultado;

        public void Iniciar()
        {
            Console.WriteLine("Calculadora: ");


            PedirDatos();

            var opcionElegida = ElegirOpcion();

            EjecutarOpcion(opcionElegida);

            ImprimirResultado();

        }

        //Este metodo debe pedir al usuario que ingrese 1 para sumar, 2 para restar, 3 para multiplicar o 4 para dividir
        public int ElegirOpcion()
        {
            //De momento solo devolvemos uno para decir que la opcion elegida fue sumar
            return 1;
        }

        //Este metodo debe ejecutar la opcion seleccionada, si la opcion fue 1, debe llamar al metodo suma.
        public void EjecutarOpcion(int operacionSeleccionada)
        {
            //De momento siempre va a hacer la suma, sin preguntar la opcion. Esto debe cambiar
            resultado = Sumar(digito1, digito2);
        }


        public void PedirDatos()
        {
            Console.WriteLine("Digite el primer número:");

            var entrada1 = Console.ReadLine();

            digito1 = Convert.ToInt32(entrada1);

            Console.WriteLine("Digite el segundo número:");

            var entrada2 = Console.ReadLine();

            digito2 = Convert.ToInt32(entrada2);
        }

        public void ImprimirResultado()
        {
            Console.WriteLine("El resultado es: " + resultado);
        }

        public int Sumar(int digito1, int digito2)
        {
            var suma = digito1 + digito2;
            return suma;
        }

        public int Multiplicar(int digito1, int digito2)
        {
            var multi = digito1 * digito2;
            return multi;
        }

        public int Restar(int digito1, int digito2)
        {
            var resta = digito1 - digito2;
            return resta;
        }

        public int Dividir(int digito1, int digito2)
        {
            var division = digito1 / digito2;
            return division;
        }


    }
}
