using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            saludoConNombre.Text = "Hola " + entradaNombre.Text + "!";
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
