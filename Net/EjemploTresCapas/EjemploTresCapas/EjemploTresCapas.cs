using EjemploTresCapas.Entidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace EjemploTresCapas
{
    public partial class Presentacion : Form
    {
        private Negocio.Negocio _negocio;
        public Presentacion()
        {
            InitializeComponent();
            _negocio = new Negocio.Negocio(ConfigurationManager.AppSettings["ArchivoDatos"]);
            personaBindingSource.DataSource = new List<Persona>();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                personaBindingSource.DataSource = _negocio.Leer();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (personaBindingSource.DataSource != null && personaBindingSource.DataSource is List<Persona>)
                    _negocio.Grabar(personaBindingSource.DataSource as List<Persona>);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
