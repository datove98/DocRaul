using Bussiness.Bussines;
using Data.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocRaul
{
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
            this.Load += frm_Load;
        }

        private void frm_Load(object o, EventArgs args)
        {
            this.dgvConsultas.Rows.Clear();
            this.dgvConsultas.Columns.Add("id","Id");
            this.dgvConsultas.Columns.Add("matter", "Motivo");
            this.dgvConsultas.Columns.Add("dateConsultation", "Fecha de consulta");
            this.dgvConsultas.Columns.Add("commentary", "Comentario");
            this.dgvConsultas.Columns.Add("reminded", "Recordado");
            this.dgvConsultas.Columns.Add("state", "Estado");
            this.dgvConsultas.Columns.Add("idPacient", "Id Paciente");
            LoadData();
        }

        private async Task LoadData()
        {
            var consultas = await Connection.GetListItemsAsync<Consulta>("GetAllConsultas", new
            {

            });
            if (consultas != null)
            {
                foreach (var consulta in consultas)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dgvConsultas);
                    fila.Cells[0].Value = consulta.id;
                    fila.Cells[1].Value = consulta.matter;
                    fila.Cells[2].Value = consulta.dateConsultation;
                    fila.Cells[3].Value = consulta.commentary;
                    fila.Cells[4].Value = consulta.reminded;
                    fila.Cells[5].Value = consulta.state;
                    dgvConsultas.Rows.Add(fila);
                }  
            }
        }
    }
}
