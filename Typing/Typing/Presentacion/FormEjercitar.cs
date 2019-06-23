﻿using System;
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
        public int Indice, PulsaCorrectos, PulsaErrores;
        public Color ClCorrecto, ClError;
        public Pen lapizTeclado, lapizMano;
        public int x_teclado, y_teclado, x_mano, y_mano, x_t, y_t, x_m, y_m;
        public bool dobleTecla,llamadaInterna;
        public FormEjercitar()
        {
            llamadaInterna = true;
            lapizTeclado = new Pen(Color.Orange, 8);
            lapizMano = new Pen(Color.Cyan, 6);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) { this.Close(); }
        public void cargarInicio()
        {
            llamadaInterna = true;
            ClCorrecto = Color.Cyan;
            ClError = Color.Red;
            Indice = PulsaCorrectos = PulsaErrores = 0;
            using (var db = new TYPINGEntities())
            {
                parrafo = (from texto in db.LECCION where texto.LeccionID == 28 select texto.Parrafo).FirstOrDefault().ToString();
            }
            parrafo = parrafo.Replace("\r\n", "\n");
            richTextBoxPrincipal.Text = parrafo;
            /***si es un caracter***/
            dobleTecla = Char.IsUpper(parrafo[0]) ||
                                 parrafo[0] == 'á' ||
                                 parrafo[0] == 'é' ||
                                 parrafo[0] == 'í' ||
                                 parrafo[0] == 'ó' ||
                                 parrafo[0] == 'ú';
            //la primera tecla a tipear
            dibujar(parrafo[Indice]);//mandamos el char marcado para tipear para saber con que dedos hacerlo...                                    
            dibujarEnTeclado();
            dibujarEnMano();
            richTextBoxPrincipal.Select(0,parrafo.Length);
            richTextBoxPrincipal.SelectionColor = Color.Black;
        }
        public void cargarInicio(string p,int niv,int lec)
        {
            llamadaInterna = false;
            lblNivel.Text = niv.ToString();
            lblLeccion.Text = lec.ToString();
            lblUsuario.Text = "Anonimo";

            ClCorrecto = Color.Cyan;
            ClError = Color.Red;
            Indice = PulsaCorrectos = PulsaErrores = 0;
            parrafo = p.Replace("\r\n", "\n");
            richTextBoxPrincipal.Text = parrafo;
            /***si es un caracter***/
            dobleTecla = Char.IsUpper(parrafo[0]) ||
                                 parrafo[0] == 'á' ||
                                 parrafo[0] == 'é' ||
                                 parrafo[0] == 'í' ||
                                 parrafo[0] == 'ó' ||
                                 parrafo[0] == 'ú';
            //la primera tecla a tipear
            dibujar(parrafo[Indice]);//mandamos el char marcado para tipear para saber con que dedos hacerlo...                                    
            dibujarEnTeclado();
            dibujarEnMano();
            richTextBoxPrincipal.Select(0, parrafo.Length);
            richTextBoxPrincipal.SelectionColor = Color.Black;
        }
        private void FormEjercitar_Load(object sender, EventArgs e)
        {
            if (llamadaInterna)
            {
                cargarInicio();
            }
            else
            {
                cargarInicio(parrafo,Convert.ToInt32(lblNivel.Text), Convert.ToInt32(lblNivel.Text));
            }
        }
        private void setT(int x, int y)//solo para reducir codigo 
        {
            x_teclado = x;
            y_teclado = y;
        }
        private void setM(int x, int y)//solo para reducir codigo 
        {
            x_mano = x;
            y_mano = y;
        }
        private void dibujar(char caracter)
        {
            switch (caracter)
            {
                case ' ': setT(211, 136); setM(106, 41); dobleTecla = false; break;
                case '\n': setT(460, 64); setM(157, 13); dobleTecla = false; break;
                //PRIMERA FILA
                case '|': setT(18, 16); setM(12, 13); dobleTecla = false; break;
                case '°': setT(18, 16); setM(12, 13); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case '1': setT(47, 16); setM(12, 13); dobleTecla = false; break;
                case '!': setT(47, 16); setM(12, 13); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case '2': setT(80, 16); setM(25, 8); dobleTecla = false; break;
                case '"': setT(80, 16); setM(25, 8); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case '3': setT(112, 16); setM(38, 4); dobleTecla = false; break;
                case '#': setT(112, 16); setM(38, 4); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case '4': setT(143, 16); setM(51, 10); dobleTecla = false; break;
                case '$': setT(143, 16); setM(51, 10); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case '5': setT(173, 16); setM(51, 10); dobleTecla = false; break;
                case '%': setT(173, 16); setM(51, 10); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case '6': setT(207, 16); setM(120, 10); dobleTecla = false; break;
                case '&': setT(207, 16); setM(120, 10); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                case '7': setT(239, 16); setM(120, 10); dobleTecla = false; break;
                case '/': setT(239, 16); setM(120, 10); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                case '8': setT(269, 16); setM(133, 4); dobleTecla = false; break;
                case '(': setT(269, 16); setM(133, 4); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                case '9': setT(302, 16); setM(144, 8); dobleTecla = false; break;
                case ')': setT(302, 16); setM(144, 8); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                case '0': setT(334, 16); setM(157, 13); dobleTecla = false; break;
                case '=': setT(334, 16); setM(157, 13); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                case '\'': setT(365, 16); setM(157, 13); dobleTecla = false; break;
                case '?': setT(365, 16); setM(157, 13); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                case '¿': setT(399, 16); setM(157, 13); dobleTecla = false; break;
                case '¡': setT(399, 16); setM(157, 13); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                //SEGUNDA FILA
                case 'q': setT(62, 49); setM(12, 13); dobleTecla = false; break;
                case 'Q': setT(62, 49); setM(12, 13); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case 'w': setT(94, 49); setM(25, 8); dobleTecla = false; break;
                case 'W': setT(94, 49); setM(25, 8); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case 'e': setT(126, 49); setM(38, 4); dobleTecla = false; break;
                case 'é': setT(126, 49); setM(38, 4); dobleTecla = true; x_t = 248; y_t = 49; x_m = 157; y_m = 13; break;
                case 'E': setT(126, 49); setM(38, 4); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;
                case 'É': setT(126, 49); setM(38, 4); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;///

                case 'r': setT(158, 49); setM(51, 10); dobleTecla = false; break;
                case 'R': setT(158, 49); setM(51, 10); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case 't': setT(189, 49); setM(51, 10); dobleTecla = false; break;
                case 'T': setT(189, 49); setM(51, 10); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case 'y': setT(222, 49); setM(120, 10); dobleTecla = false; break;
                case 'Y': setT(222, 49); setM(120, 10); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                case 'u': setT(254, 49); setM(120, 10); dobleTecla = false; break;
                case 'ú': setT(254, 49); setM(120, 10); dobleTecla = true; x_t = 380; y_t = 49; x_m = 157; y_m = 13; break;
                case 'U': setT(254, 49); setM(120, 10); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;
                case 'Ú': setT(254, 49); setM(120, 10); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;///

                case 'i': setT(286, 49); setM(133, 4); dobleTecla = false; break;
                case 'í': setT(286, 49); setM(133, 4); dobleTecla = true; x_t = 380; y_t = 49; x_m = 157; y_m = 13; break;
                case 'I': setT(286, 49); setM(133, 4); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;
                case 'Í': setT(286, 49); setM(133, 4); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;///
                    
                case 'o': setT(318, 49); setM(144, 8); dobleTecla = false; break;
                case 'ó': setT(318, 49); setM(144, 8); dobleTecla = true; x_t = 380; y_t = 49; x_m = 157; y_m = 13; break;
                case 'O': setT(318, 49); setM(144, 8); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;
                case 'Ó': setT(318, 49); setM(144, 8); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;///


                case 'p': setT(348, 49); setM(157, 13); dobleTecla = false; break;
                case 'P': setT(348, 49); setM(157, 13); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                case '´': setT(380, 49); setM(157, 13); dobleTecla = false; break;
                case '¨': setT(380, 49); setM(157, 13); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                case '+': setT(412, 49); setM(157, 13); dobleTecla = false; break;
                case '*': setT(412, 49); setM(157, 13); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                //TERCERA FILA
                case 'a': setT(77, 79);setM(12, 13);dobleTecla = false; break;
                case 'á': setT(77, 79); setM(12, 13); dobleTecla = true; x_t = 439;y_t = 108; x_m = 157;y_m = 13; break;
                case 'A': setT(77, 79); setM(12, 13); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;
                case 'Á': setT(77, 79); setM(12, 13); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;//*

                case 's': setT(108, 79); setM(25,8); dobleTecla = false; break;
                case 'S': setT(108, 79); setM(25,8); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case 'd': setT(140, 79); setM(38, 4); dobleTecla = false; break;
                case 'D': setT(140, 79); setM(38, 4); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case 'f': setT(174, 79); setM(51, 10); dobleTecla = false; break;
                case 'F': setT(174, 79); setM(51, 10); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case 'g': setT(204, 79); setM(51, 10); dobleTecla = false; break;
                case 'G': setT(204, 79); setM(51, 10); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case 'h': setT(236, 79); setM(120, 10); dobleTecla = false; break;
                case 'H': setT(236, 79); setM(120, 10); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                case 'j': setT(269, 79); setM(120, 10); dobleTecla = false; break;
                case 'J': setT(269, 79); setM(120, 10); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                case 'k': setT(301, 79); setM(133, 4); dobleTecla = false; break;
                case 'K': setT(301, 79); setM(133, 4); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                case 'l': setT(332, 79); setM(144, 8); dobleTecla = false; break;
                case 'L': setT(332, 79); setM(144, 8); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                case 'ñ': setT(363, 79); setM(157, 13); dobleTecla = false; break;
                case 'Ñ': setT(363, 79); setM(157, 13); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                case '{': setT(396, 79); setM(157, 13); dobleTecla = false; break;
                case '[': setT(396, 79); setM(157, 13); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                //CUARTA FILA
                case 'z': setT(93, 108); setM(12, 13); dobleTecla = false; break;
                case 'Z': setT(93, 108); setM(12, 13); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case 'x': setT(125, 108); setM(25, 8); dobleTecla = false; break;
                case 'X': setT(125, 108); setM(25, 8); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case 'c': setT(158, 108); setM(38, 4); dobleTecla = false; break;
                case 'C': setT(158, 108); setM(38, 4); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case 'v': setT(189, 108); setM(51, 10); dobleTecla = false; break;
                case 'V': setT(189, 108); setM(51, 10); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case 'b': setT(223, 108); setM(51, 10); dobleTecla = false; break;
                case 'B': setT(223, 108); setM(51, 10); dobleTecla = true; x_t = 439; y_t = 108; x_m = 157; y_m = 13; break;

                case 'n': setT(255, 108); setM(120, 10); dobleTecla = false; break;
                case 'N': setT(255, 108); setM(120, 10); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                case 'm': setT(286, 108); setM(120, 10); dobleTecla = false; break;
                case 'M': setT(286, 108); setM(120, 10); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                case ',': setT(318, 108); setM(133, 4); dobleTecla = false; break;
                case ';': setT(318, 108); setM(133, 4); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                case '.': setT(352, 108); setM(144, 8); dobleTecla = false; break;
                case ':': setT(352, 108); setM(144, 8); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

                case '-': setT(380, 108); setM(157, 13); dobleTecla = false; break;
                case '_': setT(380, 108); setM(157, 13); dobleTecla = true; x_t = 23; y_t = 108; x_m = 12; y_m = 13; break;

            }
        }
        private void FormEjercitar_KeyPress(object sender, KeyPressEventArgs e) { }
        private void FormEjercitar_KeyUp(object sender, KeyEventArgs e) { }

        private void richTextBoxPrincipal_KeyUp(object sender, KeyEventArgs e){
        }
        private void richTextBoxPrincipal_KeyPress(object sender, KeyPressEventArgs e) {
            if (Indice == parrafo.Length) {
                return;
                
            }
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
            dibujar(parrafo[Indice]);//mandamos el char marcado para tipear para saber con que dedos hacerlo...                                    
            dibujarEnTeclado();
            dibujarEnMano();
        }

        public void dibujarEnTeclado(){
            pictureBoxTeclado.Image = pictureBoxTeclado.Image;
            pictureBoxTeclado_Paint(new object(), new PaintEventArgs(pictureBoxTeclado.CreateGraphics(), new Rectangle()));
        }
        public void dibujarEnMano()
        {
            pictureBox1.Image = pictureBox1.Image;
            pictureBox1_Paint(new object(), new PaintEventArgs(pictureBox1.CreateGraphics(), new Rectangle()));
        }

        private void richTextBoxPrincipal_KeyDown(object sender, KeyEventArgs e){

        }
        private void richTextBoxPrincipal_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void pictureBoxTeclado_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(lapizTeclado, x_teclado, y_teclado,9,9);
            if(dobleTecla)
                e.Graphics.DrawEllipse(lapizTeclado, x_t, y_t, 9, 9);
        }


        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            if (llamadaInterna)
            {
                cargarInicio();
            }
            else
            {
                cargarInicio(parrafo,Convert.ToInt32(lblNivel.Text),Convert.ToInt32(lblLeccion));
            }
        }

        private void pictureBoxTeclado_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void pictureBoxTeclado_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxTeclado_MouseClick(object sender, MouseEventArgs e)
        {
            //dentro de el teclado de para hallar x,y del cada una de las teclas
            dibujarEnTeclado();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            dibujarEnMano();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {//paint de manos...
            e.Graphics.DrawEllipse(lapizMano, x_mano, y_mano, 8,8);
            if(dobleTecla)
                e.Graphics.DrawEllipse(lapizMano, x_m, y_m, 8, 8);
        }

        private void btnReloj_Click(object sender, EventArgs e)
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
