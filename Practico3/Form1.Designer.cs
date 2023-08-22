namespace Practico2
{
    partial class Formulario1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario1));
            this.LNya = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LModificar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CMastercard = new System.Windows.Forms.CheckBox();
            this.CVisa = new System.Windows.Forms.CheckBox();
            this.CNaranja = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LNuevoCliente = new System.Windows.Forms.Label();
            this.RBVaron = new System.Windows.Forms.RadioButton();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.BSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.Location = new System.Drawing.Point(17, 13);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(95, 13);
            this.LNya.TabIndex = 0;
            this.LNya.Text = "Nombre y Apellido:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(17, 207);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(51, 13);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "* Nombre";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(17, 143);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(51, 13);
            this.LApellido.TabIndex = 2;
            this.LApellido.Text = "* Apellido";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(17, 79);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(33, 13);
            this.LDni.TabIndex = 3;
            this.LDni.Text = "* DNI";
            // 
            // BGuardar
            // 
            this.BGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BGuardar.Image")));
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardar.Location = new System.Drawing.Point(20, 548);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(99, 55);
            this.BGuardar.TabIndex = 4;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BEliminar.Image")));
            this.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminar.Location = new System.Drawing.Point(147, 548);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(99, 55);
            this.BEliminar.TabIndex = 5;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(83, 76);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(124, 20);
            this.TDni.TabIndex = 6;
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(83, 140);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(124, 20);
            this.TApellido.TabIndex = 7;
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(83, 204);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(124, 20);
            this.TNombre.TabIndex = 8;
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombre_KeyPress);
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.BackColor = System.Drawing.SystemColors.Control;
            this.LModificar.ForeColor = System.Drawing.Color.Crimson;
            this.LModificar.Location = new System.Drawing.Point(133, 13);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(50, 13);
            this.LModificar.TabIndex = 9;
            this.LModificar.Text = "Modificar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.CMastercard);
            this.panel1.Controls.Add(this.CVisa);
            this.panel1.Controls.Add(this.CNaranja);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TTelefono);
            this.panel1.Controls.Add(this.LTelefono);
            this.panel1.Controls.Add(this.LModificar);
            this.panel1.Controls.Add(this.TNombre);
            this.panel1.Controls.Add(this.TApellido);
            this.panel1.Controls.Add(this.TDni);
            this.panel1.Controls.Add(this.LDni);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Controls.Add(this.LNya);
            this.panel1.Location = new System.Drawing.Point(20, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 416);
            this.panel1.TabIndex = 10;
            // 
            // CMastercard
            // 
            this.CMastercard.AutoSize = true;
            this.CMastercard.Location = new System.Drawing.Point(127, 375);
            this.CMastercard.Name = "CMastercard";
            this.CMastercard.Size = new System.Drawing.Size(79, 17);
            this.CMastercard.TabIndex = 15;
            this.CMastercard.Text = "Mastercard";
            this.CMastercard.UseVisualStyleBackColor = true;
            // 
            // CVisa
            // 
            this.CVisa.AutoSize = true;
            this.CVisa.Location = new System.Drawing.Point(127, 352);
            this.CVisa.Name = "CVisa";
            this.CVisa.Size = new System.Drawing.Size(46, 17);
            this.CVisa.TabIndex = 14;
            this.CVisa.Text = "Visa";
            this.CVisa.UseVisualStyleBackColor = true;
            // 
            // CNaranja
            // 
            this.CNaranja.AutoSize = true;
            this.CNaranja.Location = new System.Drawing.Point(127, 329);
            this.CNaranja.Name = "CNaranja";
            this.CNaranja.Size = new System.Drawing.Size(63, 17);
            this.CNaranja.TabIndex = 13;
            this.CNaranja.Text = "Naranja";
            this.CNaranja.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tarjeta de creditos:";
            // 
            // TTelefono
            // 
            this.TTelefono.Location = new System.Drawing.Point(83, 264);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(124, 20);
            this.TTelefono.TabIndex = 11;
            this.TTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TTelefono_KeyPress);
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(17, 267);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(49, 13);
            this.LTelefono.TabIndex = 10;
            this.LTelefono.Text = "Telefono";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(304, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LNuevoCliente
            // 
            this.LNuevoCliente.AutoSize = true;
            this.LNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNuevoCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LNuevoCliente.Location = new System.Drawing.Point(151, 21);
            this.LNuevoCliente.Name = "LNuevoCliente";
            this.LNuevoCliente.Size = new System.Drawing.Size(178, 29);
            this.LNuevoCliente.TabIndex = 12;
            this.LNuevoCliente.Text = "Nuevo Cliente";
            // 
            // RBVaron
            // 
            this.RBVaron.AutoSize = true;
            this.RBVaron.Checked = true;
            this.RBVaron.Location = new System.Drawing.Point(304, 224);
            this.RBVaron.Name = "RBVaron";
            this.RBVaron.Size = new System.Drawing.Size(53, 17);
            this.RBVaron.TabIndex = 13;
            this.RBVaron.TabStop = true;
            this.RBVaron.Text = "Varon";
            this.RBVaron.UseVisualStyleBackColor = true;
            this.RBVaron.CheckedChanged += new System.EventHandler(this.RBVaron_CheckedChanged);
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.Location = new System.Drawing.Point(401, 224);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(51, 17);
            this.RBMujer.TabIndex = 14;
            this.RBMujer.TabStop = true;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = true;
            this.RBMujer.CheckedChanged += new System.EventHandler(this.RBMujer_CheckedChanged);
            // 
            // BSalir
            // 
            this.BSalir.Image = ((System.Drawing.Image)(resources.GetObject("BSalir.Image")));
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSalir.Location = new System.Drawing.Point(363, 548);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(89, 55);
            this.BSalir.TabIndex = 15;
            this.BSalir.Text = "Salir";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 615);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.RBMujer);
            this.Controls.Add(this.RBVaron);
            this.Controls.Add(this.LNuevoCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Name = "Formulario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Formulario";
            this.Load += new System.EventHandler(this.Formulario1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNya;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CMastercard;
        private System.Windows.Forms.CheckBox CVisa;
        private System.Windows.Forms.CheckBox CNaranja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TTelefono;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LNuevoCliente;
        private System.Windows.Forms.RadioButton RBVaron;
        private System.Windows.Forms.RadioButton RBMujer;
        private System.Windows.Forms.Button BSalir;
    }
}

