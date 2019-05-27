using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing.Presentacion
{
    public partial class FormAdminUsuario : Form
    {
        public FormAdminUsuario()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormAdminUsuarioModo frmUsuario = new FormAdminUsuarioModo();
            frmUsuario.ShowDialog();
        }
    }
}
