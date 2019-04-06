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

        public string ObtenerInformacion()
        {
            var info = "Codigo " + codigo + ". " +nombre + ". Escrito por: " + autor;
            return info;
        }
    }
}
