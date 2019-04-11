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
                var libro = new Libro();
                libro.nombre = entradaNombre.Text;

                libro.codigo = Convert.ToInt32(entradaCodigo.Text);
                libro.autor = entradaAutor.Text;
                libro.precio = Convert.ToInt32(entradaPrecio.Text);

                listaDeLibros.Items.Add(libro.ObtenerInformacion());
            }
            catch (Exception ex)
            {
                etiquetaErrores.Text = "Alguno de los campos tienen errores. El codigo y precio deben ser numeros.";
            }
        }
    }
}
