using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Typing.Modelo;
using Typing.Control;

namespace Typing.Presentacion
{
    public partial class FormAdminUsuarioModo : Form
    {
        public FormAdminUsuarioModo()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length>2)
            {
                using (TYPINGEntities db = new TYPINGEntities()){
                    USUARIO usuario = null;
                    try
                    {
                       usuario = new USUARIO { UsuarioID = 1, Nombre = "Master", Modo = 6 };
                        db.USUARIO.Add(usuario);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        int modo = 0;
                        if (radioButton1.Checked) modo = 1;
                        if (radioButton2.Checked) modo = 2;
                        if (radioButton3.Checked) modo = 3;
                        if (radioButton4.Checked) modo = 4;
                        if (radioButton5.Checked) modo = 5;
                        if (radioButton6.Checked) modo = 6;
                        
                        usuario = new USUARIO { UsuarioID = 1234, Nombre = txtNombre.Text, Modo = modo };
                        db.USUARIO.Add(usuario);
                        db.SaveChanges();
                    }

                    //db.USUARIO.Add(usuario);
                }
            }
            else
            {
                MessageBox.Show("Ingresa Nombre VAlido...","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Close();
        }
    }
}
