using Datos;
using Datos.Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Cita : Form
    {
        Ncita ncita;
        Dcita dcita;
        public Cita()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Citad pace = new Citad()
            {
                Pacientesd = int.Parse(TXTPACIENTE.Text),
                Medicosd = int.Parse(TXTMEDICO.Text),
                Estado = CBESTADO.Checked,
                FechaCita = DateTime.Now
            };
            dcita.Guardar(pace);
            cargarDatos();
        }
        private void cargarDatos()
        {
            var clientes = ncita.TodasLosClientes().ToList().Select(c => new { c.PacienteId, c.MedicoID, c.CitaId }).ToList();
            DGBCITA.DataSource = clientes.ToList();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string citass = TXTCITA.Text;

            if (string.IsNullOrEmpty(citass) || string.IsNullOrWhiteSpace(citass))
            {
                errorProvider1.SetError(TXTCITA, "Debe seleccionar un registro para eliminar");
                return;
            }


            ncita.Eliminar(int.Parse(citass));

            Limpiar();
            cargarDatos();
        }
        void Limpiar()
        {
            TXTCITA.Text = "";
            TXTPACIENTE.Text = "";
            TXTMEDICO.Text = "";
            CBESTADO.Checked = false;
        }
    }
}
