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
namespace Typing.Presentacion {
    public partial class Principal : Form
    {
        public static int ID;
        public static bool inicio;
        public const int tamañoAltoConstante = 137;
        public const int tamañoAnchoConstante = 50;

        public Principal()
        {
            InitializeComponent();
        }

        public void asignaPanel(Panel panel,Color color, int alpha,int max)
        {
            Size tam_ = panel.Size;//rescatamos tamaño
            Point punt = panel.Location;//rescatamos punto inicio
            int a = (int)((double)alpha * ((double)tamañoAltoConstante / max));
            panel.Location = new Point(punt.X,punt.Y+ tamañoAltoConstante-a);
            panel.Size = new Size(tam_.Width,a);
            panel.BackColor = color;
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            inicio = true;
            
            using (TYPINGEntities db = new TYPINGEntities())
            {
                var r = (from pro in db.PROGRESO where (from p in db.PROGRESO select p.Fecha).Min() == pro.Fecha select pro).FirstOrDefault();
                var reg = (from us in db.USUARIO where us.UsuarioID == r.UsuarioID select us).FirstOrDefault();

                lblUsuario.Text = reg.Nombre;
                lblLeccion.Text = "LECCION: "+r.Leccion.ToString();
                lblNivel.Text = r.Nivel.ToString();

                var lista = (from lec in db.PROGRESO where lec.UsuarioID == r.UsuarioID select lec.PPMC).ToList();
                int max = 0,sum =0,i,j = lista.Count() - 1;
                string cad = "";
                Panel[] vectPanel = {pnlColor1,pnlColor2,pnlColor3,pnlColor4,pnlColor5,pnlColor6,pnlColor7,pnlColor8,pnlColor9,pnlColor10};
                Color[] vectColor = { Color.CadetBlue,Color.Chartreuse,Color.Cyan,Color.DarkBlue,Color.DarkCyan,Color.Cornsilk,Color.DarkCyan, Color.CadetBlue, Color.Chartreuse, Color.Cyan};
                Label[] vectLabel = { label4,label5,label6,label7,label8,label9,label10,label11,label12,label13 };
                for (i=0;i<10&&j>=0;i++)
                {
                    if (lista[j] > max)
                        max = Convert.ToInt32(lista[j]);
                    sum += Convert.ToInt32(lista[j--]);
                 //   cad += lista[j--];
                   // cad += " ";
                }
                label1.Text = "jhoselinm";
                j = lista.Count() - 1;
                for (i = 0; i < 10 && j >= 0; i++)
                {

                    asignaPanel(vectPanel[i], vectColor[i], Convert.ToInt32(lista[j]), max);
                    vectLabel[i].Text = lista[j--].ToString();

                }

                lblPPM.Text = (sum / (i)).ToString();

               // MessageBox.Show(cad);
            }
            /****INICIO_PANELES-ASIGNACION******/
            
            /****  FIN_PANELES-ASIGNACION ******/

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

        private void btnEjercitar_Click(object sender, EventArgs e)
        {
            FormEjercitar frmEjercitar = new FormEjercitar();
            frmEjercitar.Show();
        }

        private void btnLecciones_Click(object sender, EventArgs e)
        {
            FormLecciones frmLecciones = new FormLecciones();
            frmLecciones.ShowDialog();
        }

        private void btnEjercitar_MouseEnter(object sender, EventArgs e)
        {
            //BackColor = Color.Cyan;
        }

        private void btnEjercitar_MouseLeave(object sender, EventArgs e)
        {
            //BackColor = Color.Red;
        }

        private void pnlPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
