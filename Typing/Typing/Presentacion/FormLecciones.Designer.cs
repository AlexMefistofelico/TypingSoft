namespace Typing.Presentacion
{
    partial class FormLecciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxNivel = new System.Windows.Forms.ListBox();
            this.listBoxLeccion = new System.Windows.Forms.ListBox();
            this.textBoxParrafo = new System.Windows.Forms.TextBox();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNivel = new System.Windows.Forms.Label();
            this.labelLeccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxNivel
            // 
            this.listBoxNivel.FormattingEnabled = true;
            this.listBoxNivel.Location = new System.Drawing.Point(32, 58);
            this.listBoxNivel.Name = "listBoxNivel";
            this.listBoxNivel.ScrollAlwaysVisible = true;
            this.listBoxNivel.Size = new System.Drawing.Size(58, 186);
            this.listBoxNivel.TabIndex = 0;
            // 
            // listBoxLeccion
            // 
            this.listBoxLeccion.FormattingEnabled = true;
            this.listBoxLeccion.Location = new System.Drawing.Point(110, 58);
            this.listBoxLeccion.Name = "listBoxLeccion";
            this.listBoxLeccion.ScrollAlwaysVisible = true;
            this.listBoxLeccion.Size = new System.Drawing.Size(59, 186);
            this.listBoxLeccion.TabIndex = 1;
            // 
            // textBoxParrafo
            // 
            this.textBoxParrafo.Location = new System.Drawing.Point(201, 34);
            this.textBoxParrafo.Multiline = true;
            this.textBoxParrafo.Name = "textBoxParrafo";
            this.textBoxParrafo.Size = new System.Drawing.Size(569, 186);
            this.textBoxParrafo.TabIndex = 2;
            // 
            // btnRealizar
            // 
            this.btnRealizar.Location = new System.Drawing.Point(298, 251);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(75, 40);
            this.btnRealizar.TabIndex = 3;
            this.btnRealizar.Text = "Realizar";
            this.btnRealizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(392, 251);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 40);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(29, 25);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(31, 13);
            this.lblNivel.TabIndex = 5;
            this.lblNivel.Text = "Nivel";
            // 
            // labelLeccion
            // 
            this.labelLeccion.AutoSize = true;
            this.labelLeccion.Location = new System.Drawing.Point(107, 25);
            this.labelLeccion.Name = "labelLeccion";
            this.labelLeccion.Size = new System.Drawing.Size(45, 13);
            this.labelLeccion.TabIndex = 6;
            this.labelLeccion.Text = "Leccion";
            // 
            // FormLecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 316);
            this.Controls.Add(this.labelLeccion);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRealizar);
            this.Controls.Add(this.textBoxParrafo);
            this.Controls.Add(this.listBoxLeccion);
            this.Controls.Add(this.listBoxNivel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLecciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLecciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNivel;
        private System.Windows.Forms.ListBox listBoxLeccion;
        private System.Windows.Forms.TextBox textBoxParrafo;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label labelLeccion;
    }
}