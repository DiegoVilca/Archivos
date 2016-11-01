using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscrituraEnArchivo; //necesario

namespace UIGuardador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Persona unaPersona = new Persona(txtNombre.Text, txtClave.Text);
            Guardador.GuardarPersona(unaPersona);
            CargarListado(Guardador.RetornarListado());
            
        }

        public void CargarListado(List<Persona> listado)
        {
            lstListado.Items.Clear();

            foreach (Persona item in listado)
            {
                lstListado.Items.Add(item);
            }
        }
       
    }
}
