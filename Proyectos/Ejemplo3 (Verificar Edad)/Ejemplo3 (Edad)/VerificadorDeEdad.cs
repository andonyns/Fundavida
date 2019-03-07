using System;

namespace Ejemplo3__Edad_
{
    class VerificadorDeEdad
    {

        public int PedirEdad()
        {
            Console.WriteLine("Digite su edad:");
            var entrada1 = Console.ReadLine();
            var edad = Convert.ToInt32(entrada1);

            return edad;
        }

        public void VerificarMasDeSetenta(int edad)
        {
            if (edad > 70)
            {
                Console.WriteLine("Tiene más de 70 años");
            }
        }

        public void VerificarSiPuedeONoManejar(int edad)
        {
            if (edad < 18)
            {
                Console.WriteLine("No puede manejar");
            }
            else
            {
                Console.WriteLine("Si puede manejar");
            }
        }

        public void IdentificarGrupoSegunEdad(int edad)
        {
            if (edad >= 65)
            {
                Console.WriteLine("Es adulto mayor");
            }
            else if (edad >= 18)
            {
                Console.WriteLine("Es adulto");
            }
            else
            {
                Console.WriteLine("Es niño");
            }
        }

        public void DecirSiTieneQueIrAKinder(int edad)
        {
            if (edad == 6)
            {
                Console.WriteLine("Debe ir a kinder");
            }
            else
            {
                Console.WriteLine("Es muy joven, o muy viejo para ir a kinder");
            }
        }

        public void DecirSiNoTieneVeinte(int edad)
        {
            if (edad != 20)
            {
                Console.WriteLine("No tiene 20");
            }

            Console.WriteLine("Ya verifique si tenía 20 o no");
        }





    }
}
