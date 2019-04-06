using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Libro
    {
        public int codigo;
        public string nombre;
        public string autor;
        public int precio;

        public string ObtenerInformacion()
        {
            var info = "Codigo " + codigo + ". " +nombre + ". Escrito por: " + autor + ". El precio es: " + precio;
            return info;
        }
    }
}
