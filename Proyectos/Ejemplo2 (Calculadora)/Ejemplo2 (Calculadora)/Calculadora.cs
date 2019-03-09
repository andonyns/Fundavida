using System;

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
            Console.WriteLine("Digite 1 para sumar, 2 para restar, 3 para multiplicar o 4 para dividir");

            var entrada = Console.ReadLine();

            var digito = Convert.ToInt32(entrada);

            return digito;
        }

        //Este metodo debe ejecutar la opcion seleccionada, si la opcion fue 1, debe llamar al metodo suma.
        public void EjecutarOpcion(int operacionSeleccionada)
        {
            if (operacionSeleccionada == 1)
            {
                resultado = Sumar(digito1, digito2);
            }
            else if (operacionSeleccionada == 2)
            {
                resultado = Restar(digito1, digito2);
            }
            else if (operacionSeleccionada == 3)
            {
                resultado = Multiplicar(digito1, digito2);
            }
            else if (operacionSeleccionada == 4)
            {
                resultado = Dividir(digito1, digito2);
            }
            else
            {
                Console.WriteLine("Opcion Invalida");
            }
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
