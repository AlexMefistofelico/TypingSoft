using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Typing.Modelo;

namespace Typing.Presentacion
{
    public partial class FormAdminUsuario : Form
    {
        public FormAdminUsuario()
        {
            InitializeComponent();
        }
        public void cargarDatos()
        {
            using (TYPINGEntities db = new TYPINGEntities())
            {
                dataGridViewUsuarios.DataSource = (from us in db.USUARIO select new { us.UsuarioID, us.Modo, us.Nombre }).ToList();
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e){
            FormAdminUsuarioModo frmUsuario = new FormAdminUsuarioModo();
            frmUsuario.ShowDialog();

            cargarDatos();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAdminUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tYPINGDataSet.USUARIO' Puede moverla o quitarla según sea necesario.
            this.uSUARIOTableAdapter.Fill(this.tYPINGDataSet.USUARIO);
            cargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var db = new TYPINGEntities())
            {
                int id = Convert.ToInt32(dataGridViewUsuarios.Rows[dataGridViewUsuarios.CurrentCellAddress.Y].Cells[0].Value);
                var reg = db.USUARIO.Where(x => x.UsuarioID == id).FirstOrDefault();
                if(MessageBox.Show("Desea Eliminar Dato", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    db.USUARIO.Remove(reg);
                    db.SaveChanges();

                }

            }
            cargarDatos();
        }
    }
}
