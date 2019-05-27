using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing.Presentacion {
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            asignarColorPanel(pnlPrincipal,Color.Cyan);//panel mayor
            asignarColorPanel(pnlColor1, Color.Red);
            asignarColorPanel(pnlColor2,RGB(4,5,6));
            asignarColorPanel(pnlColor3, RGB(55,77,88));

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TypingSoft","Acerca De: ",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Color RGB(int R,int G,int B)
        {
            return Color.FromArgb(((int)(((byte)(R)))), ((int)(((byte)(G)))), ((int)(((byte)(B)))));
        }
        public void asignarColorPanel(Panel panel,Color color){//damos color a los paneles de estadisticas
            panel.BackColor = color;
            //panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            //panel.Location = new System.Drawing.Point(228, 81);
            //panel.Size = new System.Drawing.Size(50, 137);

        }

        private void btnAdminUsuarios_Click(object sender, EventArgs e)
        {
            FormAdminUsuario frmAdminUsuario = new FormAdminUsuario();
            frmAdminUsuario.ShowDialog();
        }
    }
}
