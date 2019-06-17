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

namespace Typing.Presentacion
{
    public partial class FormEjercitar : Form
    {
        public String parrafo;
        public int Indice;
        public FormEjercitar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FormEjercitar_Load(object sender, EventArgs e)
        {
            Indice = 0;
            richTextBoxPrincipal.Select(Indice, 1);
           
            using (var db = new TYPINGEntities())
            {
                parrafo = (from texto in db.LECCION where texto.LeccionID == 1 select texto.Parrafo).FirstOrDefault().ToString();
            }
            richTextBoxPrincipal.Text = parrafo;
        }

        private void FormEjercitar_KeyPress(object sender, KeyPressEventArgs e){
            //evento en formulario envano
        }

        private void FormEjercitar_KeyUp(object sender, KeyEventArgs e){
            //evento en formulario envano
        }

        private void richTextBoxPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void richTextBoxPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Indice++;
            richTextBoxPrincipal.Select(Indice,1);
            lblUsuario.Text = "-"+e.KeyChar+"-" +parrafo[Indice-1]+"-";
            if (e.KeyChar == parrafo[Indice-1])
                richTextBoxPrincipal.SelectionColor = Color.Cyan;
            else
                richTextBoxPrincipal.SelectionColor = Color.Red;
        }

        private void richTextBoxPrincipal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
