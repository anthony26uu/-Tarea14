using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practicas.UI.Consultas
{
    public partial class PeliculaConsulta : Form
    {
        public PeliculaConsulta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Filtrarbutton_Click(object sender, EventArgs e)
        {
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                ListadataGridView.DataSource = BLL.PeliculaBLL.GetList();
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                ListadataGridView.DataSource = BLL.PeliculaBLL.GetListFecha(DesdedateTimePicker.Value.Date, HastadateTimePicker.Value.Date);
            }
        }
    }
}
