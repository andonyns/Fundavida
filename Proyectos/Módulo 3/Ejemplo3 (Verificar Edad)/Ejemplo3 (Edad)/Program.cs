using System;

namespace Ejemplo3__Edad_
{
    class Program
    {
        static void Main(string[] args)
        {
            var verificador = new VerificadorDeEdad();

            var edad = verificador.PedirEdad();

            verificador.VerificarMasDeSetenta(edad);

            verificador.VerificarSiPuedeONoManejar(edad);

            verificador.IdentificarGrupoSegunEdad(edad);

            verificador.DecirSiTieneQueIrAKinder(edad);

            verificador.DecirSiNoTieneVeinte(edad);


            Console.WriteLine("Presione enter para terminar");
            Console.ReadLine();


        }
    }
}
