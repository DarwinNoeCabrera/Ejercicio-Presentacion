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
            BtnGuardar.Click += BtnGuardar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            npaciented = new Npaciented_();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Paciented pace= new Paciented()
            {
                Nombres = tx.Text,
                Apellidos = txtApellidos.Text,
                Estado = cbEstado.Checked,
                FechaIngreso = DateTime.Now
            };
            dpaciented.Guardar(pace);
            cargarDatos();

        }
  

        private void Paciente_Load(object sender, EventArgs e)
        {
            int proximoId = ObtenerProximoId();

            // Mostrar el próximo ID en el TxtID
            TxtID.Text = proximoId.ToString();

            // Cargar datos en el DataGridView
            this.clientesTableAdapter.Fill(this.proyectoRadDataSet2.Clientes);

            // Asignar el evento CellDoubleClick al DataGridView
            DGVClientes.CellDoubleClick += DGVClientes_CellContentDoubleClick;

            // Crear un DataView y aplicar un filtro para mostrar solo los registros con Estado en true
            DataView dv = new DataView(this.proyectoRadDataSet2.Clientes);
            dv.RowFilter = "Estado = true";

            // Asignar el DataView filtrado al DataGridView
            DGVClientes.DataSource = dv;

        }

        private void cargarDatos()
        {
            var clientes = npaciented.TodasLosClientes().ToList().Select(c => new { c.PacienteId,c.Nombres, c.Apellidos }).ToList();
            DGBPACIENTE.DataSource = clientes.ToList();//nCliente.obtenerCliente();
        }
    }
}
