namespace RellenandoComboboxDinamicamente
{
    partial class VentanaComobobox
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbEquipos = new System.Windows.Forms.ComboBox();
            this.btnCargaValores = new System.Windows.Forms.Button();
            this.btnbLimpiarItems = new System.Windows.Forms.Button();
            this.btnMostrarItems = new System.Windows.Forms.Button();
            this.txtVistaValorSeleccionado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargaBD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbEquipos
            // 
            this.cmbEquipos.FormattingEnabled = true;
            this.cmbEquipos.Location = new System.Drawing.Point(12, 12);
            this.cmbEquipos.Name = "cmbEquipos";
            this.cmbEquipos.Size = new System.Drawing.Size(260, 21);
            this.cmbEquipos.TabIndex = 0;
            this.cmbEquipos.SelectedIndexChanged += new System.EventHandler(this.cmbEquipos_SelectedIndexChanged);
            // 
            // btnCargaValores
            // 
            this.btnCargaValores.Location = new System.Drawing.Point(12, 39);
            this.btnCargaValores.Name = "btnCargaValores";
            this.btnCargaValores.Size = new System.Drawing.Size(260, 23);
            this.btnCargaValores.TabIndex = 1;
            this.btnCargaValores.Text = "Cargar Valores Emula BD";
            this.btnCargaValores.UseVisualStyleBackColor = true;
            this.btnCargaValores.Click += new System.EventHandler(this.btnCargaValores_Click);
            // 
            // btnbLimpiarItems
            // 
            this.btnbLimpiarItems.Location = new System.Drawing.Point(12, 97);
            this.btnbLimpiarItems.Name = "btnbLimpiarItems";
            this.btnbLimpiarItems.Size = new System.Drawing.Size(260, 23);
            this.btnbLimpiarItems.TabIndex = 2;
            this.btnbLimpiarItems.Text = "Limpiar Items";
            this.btnbLimpiarItems.UseVisualStyleBackColor = true;
            this.btnbLimpiarItems.Click += new System.EventHandler(this.btnbLimpiarItems_Click);
            // 
            // btnMostrarItems
            // 
            this.btnMostrarItems.Location = new System.Drawing.Point(12, 126);
            this.btnMostrarItems.Name = "btnMostrarItems";
            this.btnMostrarItems.Size = new System.Drawing.Size(260, 23);
            this.btnMostrarItems.TabIndex = 3;
            this.btnMostrarItems.Text = "Seleccionar item";
            this.btnMostrarItems.UseVisualStyleBackColor = true;
            this.btnMostrarItems.Click += new System.EventHandler(this.btnMostrarItems_Click);
            // 
            // txtVistaValorSeleccionado
            // 
            this.txtVistaValorSeleccionado.Location = new System.Drawing.Point(12, 177);
            this.txtVistaValorSeleccionado.Name = "txtVistaValorSeleccionado";
            this.txtVistaValorSeleccionado.Size = new System.Drawing.Size(184, 20);
            this.txtVistaValorSeleccionado.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vista valor seleccionado";
            // 
            // btnCargaBD
            // 
            this.btnCargaBD.Location = new System.Drawing.Point(12, 68);
            this.btnCargaBD.Name = "btnCargaBD";
            this.btnCargaBD.Size = new System.Drawing.Size(260, 23);
            this.btnCargaBD.TabIndex = 6;
            this.btnCargaBD.Text = "Cargar Valores BD";
            this.btnCargaBD.UseVisualStyleBackColor = true;
            this.btnCargaBD.Click += new System.EventHandler(this.btnCargaBD_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VentanaComobobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCargaBD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVistaValorSeleccionado);
            this.Controls.Add(this.btnMostrarItems);
            this.Controls.Add(this.btnbLimpiarItems);
            this.Controls.Add(this.btnCargaValores);
            this.Controls.Add(this.cmbEquipos);
            this.Name = "VentanaComobobox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipos Futbol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEquipos;
        private System.Windows.Forms.Button btnCargaValores;
        private System.Windows.Forms.Button btnbLimpiarItems;
        private System.Windows.Forms.Button btnMostrarItems;
        private System.Windows.Forms.TextBox txtVistaValorSeleccionado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargaBD;
        private System.Windows.Forms.Button button1;
    }
}

