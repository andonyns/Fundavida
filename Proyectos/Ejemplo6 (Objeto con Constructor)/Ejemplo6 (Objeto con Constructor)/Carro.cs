using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo6__Objeto_con_Constructor_
{
    class Carro
    {
        int ruedas;
        string marca;
        string modelo;
        string color;
        int motor;
        double gasolina;

        public Carro(string nuevaMarca, string nuevoModelo)
        {
            marca = nuevaMarca;
            modelo = nuevoModelo;
        }

        public Carro(string nuevaMarca, string nuevoModelo, string nuevoColor)
        {
            marca = nuevaMarca;
            modelo = nuevoModelo;
            color = nuevoColor;
        }

        public void LlenarGasolina(int cantidad)
        {
            gasolina = gasolina + cantidad;
        }

        public bool TieneGasolina()
        {
            return gasolina > 0;
        }

        public void Manejar()
        {
            Console.WriteLine("Manejando...");
            //Lo opuesto a ++
            gasolina--;
            Console.WriteLine("Carro: " + marca + " " + modelo + ". Me queda " + gasolina + " de Gasolina");
        }

    }
}
