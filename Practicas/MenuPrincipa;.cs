using Practicas.UI.Consultas;
using Practicas.UI.Retgistros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPeliculas db = new RegistroPeliculas();
            db.Show();
        }

        private void actoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroActores db = new RegistroActores();
            db.Show();
        }

        private void peliculasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PeliculaConsulta db = new PeliculaConsulta();
            db.Show();
        }
    }
}
