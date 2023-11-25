using System.Data;

namespace DocRaul
{
    public partial class frmPacientes : Form
    {
        bool esBusqueda;
        public int valor = 0;
        public frmPacientes(bool esBusqueda)
        {
            this.esBusqueda = esBusqueda;
            InitializeComponent();
            this.Load += FormLoad;
            dataGridView1.CellDoubleClick += tomarValor;
        }

        private void tomarValor(object? sender, DataGridViewCellEventArgs e)
        {
            if (esBusqueda)
            {
                valor = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FormLoad(object sender, EventArgs e)
        {
            List<int> valores = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                valores.Add(i);
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("valor");
            dt.Rows.Add(1);

            dataGridView1.DataSource = dt;
        }
    }
}