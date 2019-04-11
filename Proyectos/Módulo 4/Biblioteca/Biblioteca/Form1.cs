using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        private List<Libro> libros = new List<Libro>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            //Limpiamos la etiqueta de errores ya que se ingresó un valor nuevo
            etiquetaErrores.Text = "";

            try
            {
                var nuevoLibro = new Libro();

                nuevoLibro.nombre = entradaNombre.Text;
                nuevoLibro.codigo = Convert.ToInt32(entradaCodigo.Text);
                nuevoLibro.autor = entradaAutor.Text;
                nuevoLibro.precio = Convert.ToInt32(entradaPrecio.Text);

                bool yaExiste = false;

                for (int i = 0; i < libros.Count(); i++)
                {
                    if(libros[i] != null && libros[i].codigo == nuevoLibro.codigo)
                    {
                        yaExiste = true;
                    }
                }

                if (yaExiste)
                {
                    etiquetaErrores.Text = "El codigo de libro ya esta registrado.";
                } else
                {
                    libros.Add(nuevoLibro);
                    listaDeLibros.Items.Add(nuevoLibro.ObtenerInformacion());
                }
            }
            catch (Exception ex)
            {
                etiquetaErrores.Text = "Alguno de los campos tienen errores. El codigo y precio deben ser numeros.";
            }
        }
    }
}
