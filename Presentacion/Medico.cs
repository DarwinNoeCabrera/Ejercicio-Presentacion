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
    public partial class Medico : Form
    {
        Dmedico dmedico;
        Nmedico nmedico;
        public Medico()
        {
            InitializeComponent();
        }

        private void BtnAguardar_Click(object sender, EventArgs e)
        {
            Medicod pace = new Medicod()
            {
                Nombres = TXTNOMBRE.Text,
                Apellidos = TXTAPELLIDO.Text,
                Estado = CBESTADO.Checked,
                FechaIngreso = DateTime.Now
            };
            dmedico.Guardar(pace);
            cargarDatos();
        }
        private void cargarDatos()
        {
            var clientes = nmedico.TodasLosClientes().ToList().Select(c => new { c.MedicoId, c.Nombres, c.Apellidos }).ToList();
            DGBMEDICOS.DataSource = clientes.ToList();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string medicods = TXTMEDICO.Text;

            if (string.IsNullOrEmpty(medicods) || string.IsNullOrWhiteSpace(medicods))
            {
                errorProvider1.SetError(TXTMEDICO, "Debe seleccionar un registro para eliminar");
                return;
            }


            nmedico.Eliminar(int.Parse(medicods));

            Limpiar();
            cargarDatos();
        }
        void Limpiar()
        {
            TXTNOMBRE.Text = "";
            TXTAPELLIDO.Text = "";
            CBESTADO.Checked = false;
        }
    }
}

