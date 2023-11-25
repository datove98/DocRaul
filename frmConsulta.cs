using Data;
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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
            button1.Click += btnClick;
        }

        private void btnClick(object? o, EventArgs e)
        {
            if (o == button1)
            {
                abriPantallaPacientes();
            }
        }

        private void abriPantallaPacientes()
        {
            frmPacientes pacientes = new frmPacientes(true);
            DialogResult dr = pacientes.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                int valor = pacientes.valor;
            }
        }

        private async Task testConnection()
        {
            var list = await ConsultasData.GetConsultas(1);
            MessageBox.Show("Test");
        }
    }
}
