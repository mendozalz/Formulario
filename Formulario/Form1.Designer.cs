namespace Formulario
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
            this.nombre = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grilla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(43, 40);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(47, 13);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre:";
            this.nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(43, 113);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(46, 13);
            this.usuario.TabIndex = 1;
            this.usuario.Text = "Usuario:";
            this.usuario.Click += new System.EventHandler(this.usuario_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(182, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(182, 113);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(182, 72);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 5;
            this.txtApellido.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apellido:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(183, 148);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Location = new System.Drawing.Point(44, 148);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(35, 13);
            this.Edad.TabIndex = 6;
            this.Edad.Text = "Edad:";
            this.Edad.Click += new System.EventHandler(this.Edad_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(47, 217);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(191, 217);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar\r\n";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grilla
            // 
            this.grilla.AllowUserToOrderColumns = true;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(353, 40);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(426, 377);
            this.grilla.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView grilla;
    }
}

