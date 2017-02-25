using Practicas.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practicas.UI.Retgistros
{
    public partial class RegistroActores : Form
    {
        public RegistroActores()
        {
            InitializeComponent();
            Limpiar();
        }

        private void Limpiar()
        {
            nombreTextBox.Clear();
            actorIdTextBox.Clear();
            nombreTextBox.Focus();
            errorProviderNombre.Clear();
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                errorProviderNombre.SetError(nombreTextBox, "Campo Esta vacio");
                return false;
            }
            return true;
        }


        private void RegistroActores_Load(object sender, EventArgs e)
        {
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var pelicula = BLL.ActoresBLL.Buscar(Utilidades.TOINT(actorIdTextBox.Text));
            if (pelicula != null)
            {
                if (ActoresBLL.Eliminar(pelicula))
                    MessageBox.Show("El Actor ha sido eliminado");
            }
            else
            {
                MessageBox.Show("Problemas al Eliminar el actor");
            }
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Entidades.Actores actor = new Entidades.Actores(); 
            if(!Validar())
            {
                MessageBox.Show("Llene los Campos");
            }
            else
            {
               
                actor.ActorId = Utilidades.TOINT(actorIdTextBox.Text);
                actor.Nombre = nombreTextBox.Text;
             

                if (BLL.ActoresBLL.Guardar(actor))
                {
                    MessageBox.Show("Actor Guardado con exito");

                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }
            }
            Limpiar();
    
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var actor = BLL.ActoresBLL.Buscar(Utilidades.TOINT(actorIdTextBox.Text));

            if (actor != null)
            {
                
                nombreTextBox.Text = actor.Nombre;
              
             
            }
            else
            {
                MessageBox.Show("Actor no esta creado");
            }



        }
    }
}
