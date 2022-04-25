using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class manUsuario : Form
    {
        public manUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridViewUser);
            fila.Cells[0].Value = txtDNI.Text;
            fila.Cells[1].Value = txtNombre.Text;
            fila.Cells[2].Value = txtApellido.Text;
            fila.Cells[3].Value = dtpFechaNacimiento.Text;
            fila.Cells[4].Value = txtTelefono.Text;
            fila.Cells[5].Value = txtEmail.Text;
            fila.Cells[6].Value = txtDireccion.Text;

            dataGridViewUser.Rows.Add(fila);

            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpFechaNacimiento.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";

        }
    }
}
