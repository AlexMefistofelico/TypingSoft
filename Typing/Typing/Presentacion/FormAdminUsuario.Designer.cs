namespace Typing.Presentacion
{
    partial class FormAdminUsuario
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tYPINGDataSet = new Typing.TYPINGDataSet();
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOTableAdapter = new Typing.TYPINGDataSetTableAdapters.USUARIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPINGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.dataGridViewUsuarios.AllowUserToResizeRows = false;
            this.dataGridViewUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(21, 25);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(511, 178);
            this.dataGridViewUsuarios.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(27, 226);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 57);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(295, 226);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 57);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(161, 226);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 57);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(429, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 57);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tYPINGDataSet
            // 
            this.tYPINGDataSet.DataSetName = "TYPINGDataSet";
            this.tYPINGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataMember = "USUARIO";
            this.uSUARIOBindingSource.DataSource = this.tYPINGDataSet;
            // 
            // uSUARIOTableAdapter
            // 
            this.uSUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // FormAdminUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 315);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdminUsuario";
            this.Load += new System.EventHandler(this.FormAdminUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPINGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancel;
        private TYPINGDataSet tYPINGDataSet;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        private TYPINGDataSetTableAdapters.USUARIOTableAdapter uSUARIOTableAdapter;
    }
}