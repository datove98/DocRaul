using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace DocRaul
{
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
            this.txtEdad.KeyPress += txtKeyPress;
            this.txtDireccion.KeyPress += txtKeyPress;
            this.btnSave.Click += btn_Click;
        }

        private void btn_Click(object? o, EventArgs args)
        {
            if (o == btnSave)
            {
                SavePacient();
            }
        }

        private void txtKeyPress(object? o, KeyPressEventArgs args)
        {
            if (o == txtEdad)
            {
                args.Handled = !char.IsDigit(args.KeyChar) && !char.IsControl(args.KeyChar);
            }
        }

        private void SavePacient()
        {
            bool a = Utils.ValidateEmail(txtEmail.Text);
            MessageBox.Show(a.ToString());
        } 
    }
}
