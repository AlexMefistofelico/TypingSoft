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
        public int Indice,PulsaCorrectos,PulsaErrores;
        public Color ClCorrecto, ClError;
        public FormEjercitar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){this.Close();}

        private void FormEjercitar_Load(object sender, EventArgs e){
            ClCorrecto = Color.Cyan;
            ClError    = Color.Red;
            Indice = PulsaCorrectos = PulsaErrores = 0;
            using (var db = new TYPINGEntities()){
                parrafo = (from texto in db.LECCION where texto.LeccionID == 26 select texto.Parrafo).FirstOrDefault().ToString();
            }
            parrafo = parrafo.Replace("\r\n","\n");
            richTextBoxPrincipal.Text = parrafo;
        }

        private void FormEjercitar_KeyPress(object sender, KeyPressEventArgs e) { }
        private void FormEjercitar_KeyUp(object sender, KeyEventArgs e) { }

        private void richTextBoxPrincipal_KeyUp(object sender, KeyEventArgs e){
        }
        private void richTextBoxPrincipal_KeyPress(object sender, KeyPressEventArgs e) {
            if (Indice==0){//si es el primer caracter seleccion por adelantado
                richTextBoxPrincipal.Select(Indice, 1);
            }
            //lblUsuario.Text = "+"+Indice+"+"+e.KeyChar+"+"+parrafo[Indice]+"+";//solo para test
            if (e.KeyChar==parrafo[Indice]||(parrafo[Indice]=='\n'&&e.KeyChar=='\r')){//si son el mismo caracter 
                richTextBoxPrincipal.SelectionColor = ClCorrecto;//pintamos celeste
                PulsaCorrectos++;
            } else{
                
                richTextBoxPrincipal.SelectionColor = ClError;//pintamos rojo
                PulsaErrores++;
            }
            Indice++;
            richTextBoxPrincipal.Select(Indice, 1);//marcamos el sig. caracter el que toca teclear
            if (Indice == parrafo.Length)
            {//si recorremos el final de la cadena
                MessageBox.Show(String.Format("total PUlsa:{0}\nCorrectos: {1}\nIncorrectos: {2} ", (PulsaCorrectos + PulsaErrores), PulsaCorrectos, PulsaErrores));
                return;
            }
        }
        private void richTextBoxPrincipal_KeyDown(object sender, KeyEventArgs e){

        }
        private void richTextBoxPrincipal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblErrores_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxPrincipal_Enter(object sender, EventArgs e){}

        private void lblLeccion_Click(object sender, EventArgs e)
        {

        }
    }
}
