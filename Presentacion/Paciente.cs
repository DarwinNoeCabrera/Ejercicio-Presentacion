using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Core;
using Datos.Modelo;
using Negocio;

namespace Presentacion
{
    public partial class Paciente : Form
    {
        private readonly UnitOfWork unitOfWork;
        Paciented paciented;
        Npaciented_ npaciented;
        Dpaciented dpaciented;
        public Paciente()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            npaciented = new Npaciented_();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Paciented pace= new Paciented()
            {
                Nombres = TXTNOMBRE.Text,
                Apellidos = TXTAPELLIDO.Text,
                Estado = CBESTADO.Checked,
                FechaIngreso = DateTime.Now
            };
            dpaciented.Guardar(pace);
            cargarDatos();

        }
  

        private void Paciente_Load(object sender, EventArgs e)
        {
            cargarDatos();

        }

        private void cargarDatos()
        {
            var clientes = npaciented.TodasLosClientes().ToList().Select(c => new { c.PacienteId,c.Nombres, c.Apellidos }).ToList();
            DGBPACIENTE.DataSource = clientes.ToList();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string pacienteidd = TXTPACIENTE.Text;

            if (string.IsNullOrEmpty(pacienteidd) || string.IsNullOrWhiteSpace(pacienteidd))
            {
                errorProvider1.SetError(TXTPACIENTE, "Debe seleccionar un registro para eliminar");
                return;
            }


            npaciented.Eliminar(int.Parse(pacienteidd));

            Limpiar();
            cargarDatos();
        }

        void Limpiar()
        {
            TXTNOMBRE.Text = "";
            TXTAPELLIDO.Text = "";
            CBESTADO.Checked=false;
        }
    }
}
