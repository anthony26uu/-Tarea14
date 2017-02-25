using Practicas.BLL;
using Practicas.DAL;
using Practicas.Entidades;
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
    public partial class RegistroPeliculas : Form
    {
        Entidades.Peliculas peliculas;
        public RegistroPeliculas()
        {
            InitializeComponent();
            Limpiar();
        }


        private void Limpiar()
        {
            peliculas = new Peliculas();
            peliculaIdTextBox.Clear();
            nombreTextBox.Clear();
            fechaEstrenoDateTimePicker.Value=DateTime.Today;
            DetalledataGridView.DataSource = null;
            errorProviderNombre.Clear();
           
        }
        private bool Validar()
        {
            if(string.IsNullOrEmpty(nombreTextBox.Text))
            {
                errorProviderNombre.SetError(nombreTextBox, "El campo Esta Vacio");
              return  false;
            }
            return true;
        }
        private Peliculas LlenarCampos()
        {
            string actores = actorComboBox.SelectedValue.ToString();
            peliculas.Nombre = nombreTextBox.Text;
            peliculas.PeliculaEstreno = fechaEstrenoDateTimePicker.Value;
            peliculas.ActorId = Utilidades.TOINT(actores);
            return peliculas;
        }
        private void RegistroPeliculas_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }
        private void LlenarCombo()
        {
            var llenar = new DetalleDb();
            List<Actores> lista = BLL.ActoresBLL.GetList();
            actorComboBox.DataSource =lista ;
            actorComboBox.DisplayMember = "Nombre";
            actorComboBox.ValueMember = "ActorId";
        }
        private  void LLenarGrid(Entidades.Peliculas pelicula)
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = pelicula.actores;
        }



        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
      
        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            peliculas = LlenarCampos();
            BLL.PeliculaBLL.Guardar(peliculas);

            if (!Validar())
            {
                MessageBox.Show("Por favor llenar los Campos Vacios");
            }
            else if (BLL.PeliculaBLL.Guardar(peliculas))
            {
                MessageBox.Show("Pelicula Guardada Con exito");

            }

            Limpiar();
        }

        private void Agregarbutton_Click_1(object sender, EventArgs e)
        {
            Entidades.Actores actores = new Entidades.Actores();
            actores = (Entidades.Actores)actorComboBox.SelectedItem;
            peliculas.actores.Add(actores);

            LLenarGrid(peliculas);

        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            peliculas = BLL.PeliculaBLL.Buscar(Utilidades.TOINT(peliculaIdTextBox.Text));
            if (peliculas != null)
            {

                nombreTextBox.Text = peliculas.Nombre;
                fechaEstrenoDateTimePicker.Value = peliculas.PeliculaEstreno;
                LLenarGrid(peliculas);
            }
            else
            {
                MessageBox.Show("La pelicula no esta creada");
            }
        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            var pelicula = BLL.PeliculaBLL.Buscar(Utilidades.TOINT(peliculaIdTextBox.Text));
            if (pelicula != null)
            {
                if (PeliculaBLL.Eliminar(pelicula))
                    MessageBox.Show("La pelicula ha sido eliminada");
            }
            else
            {
                MessageBox.Show("Problemas al Eliminar Pelicula");
            }
            Limpiar();
        }
    }
}
