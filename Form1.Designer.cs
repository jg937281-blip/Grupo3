namespace RegistroPacientes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnVerAtendidos = new System.Windows.Forms.Button();
            this.lstAtendidos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Font = new System.Drawing.Font("Script MT Bold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(256, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(392, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de pacientes";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(42, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(293, 36);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del paciente:";
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNombre.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(47, 132);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 30);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPrioridad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrioridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrioridad.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.Location = new System.Drawing.Point(31, 182);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(318, 36);
            this.lblPrioridad.TabIndex = 3;
            this.lblPrioridad.Text = "Seleccione la prioridad:";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPrioridad.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(47, 224);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(226, 32);
            this.cmbPrioridad.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(77, 279);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(167, 47);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar paciente";
            this.btnRegistrar.UseMnemonic = false;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lstPacientes
            // 
            this.lstPacientes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lstPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstPacientes.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 24;
            this.lstPacientes.Location = new System.Drawing.Point(437, 97);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(371, 196);
            this.lstPacientes.TabIndex = 6;
            // 
            // btnAtender
            // 
            this.btnAtender.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAtender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtender.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtender.Location = new System.Drawing.Point(437, 326);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(371, 42);
            this.btnAtender.TabIndex = 7;
            this.btnAtender.Text = "Atender siguiente paciente";
            this.btnAtender.UseMnemonic = false;
            this.btnAtender.UseVisualStyleBackColor = false;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnVerAtendidos
            // 
            this.btnVerAtendidos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVerAtendidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerAtendidos.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAtendidos.Location = new System.Drawing.Point(437, 374);
            this.btnVerAtendidos.Name = "btnVerAtendidos";
            this.btnVerAtendidos.Size = new System.Drawing.Size(371, 42);
            this.btnVerAtendidos.TabIndex = 8;
            this.btnVerAtendidos.Text = "Ver pacientes atendidos";
            this.btnVerAtendidos.UseMnemonic = false;
            this.btnVerAtendidos.UseVisualStyleBackColor = false;
            this.btnVerAtendidos.Click += new System.EventHandler(this.btnVerAtendidos_Click);
            // 
            // lstAtendidos
            // 
            this.lstAtendidos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lstAtendidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstAtendidos.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAtendidos.FormattingEnabled = true;
            this.lstAtendidos.ItemHeight = 24;
            this.lstAtendidos.Location = new System.Drawing.Point(437, 422);
            this.lstAtendidos.Name = "lstAtendidos";
            this.lstAtendidos.Size = new System.Drawing.Size(371, 196);
            this.lstAtendidos.TabIndex = 9;
            this.lstAtendidos.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 727);
            this.Controls.Add(this.lstAtendidos);
            this.Controls.Add(this.btnVerAtendidos);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Ravie", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnVerAtendidos;
        private System.Windows.Forms.ListBox lstAtendidos;
    }
}

