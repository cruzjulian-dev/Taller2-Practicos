namespace Practico5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGTabla = new System.Windows.Forms.DataGridView();
            this.PBFoto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TRuta = new System.Windows.Forms.TextBox();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.RBHombre = new System.Windows.Forms.RadioButton();
            this.DTFecha = new System.Windows.Forms.DateTimePicker();
            this.TSaldo = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.BFoto = new System.Windows.Forms.Button();
            this.LSaldo = new System.Windows.Forms.Label();
            this.LSexo = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.BAgregar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGTabla
            // 
            this.DGTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apellido,
            this.Nombre,
            this.Fecha_Nacimiento,
            this.Sexo,
            this.Eliminar,
            this.Saldo,
            this.Foto,
            this.Ruta});
            this.DGTabla.Location = new System.Drawing.Point(12, 400);
            this.DGTabla.Name = "DGTabla";
            this.DGTabla.Size = new System.Drawing.Size(868, 170);
            this.DGTabla.TabIndex = 1;
            this.DGTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTabla_CellContentClick);
            // 
            // PBFoto
            // 
            this.PBFoto.Image = ((System.Drawing.Image)(resources.GetObject("PBFoto.Image")));
            this.PBFoto.Location = new System.Drawing.Point(588, 33);
            this.PBFoto.Name = "PBFoto";
            this.PBFoto.Size = new System.Drawing.Size(263, 254);
            this.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBFoto.TabIndex = 2;
            this.PBFoto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TRuta);
            this.panel1.Controls.Add(this.DTFecha);
            this.panel1.Controls.Add(this.TSaldo);
            this.panel1.Controls.Add(this.TApellido);
            this.panel1.Controls.Add(this.TNombre);
            this.panel1.Controls.Add(this.BFoto);
            this.panel1.Controls.Add(this.LSaldo);
            this.panel1.Controls.Add(this.LSexo);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Controls.Add(this.LFecha);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Controls.Add(this.BAgregar);
            this.panel1.Location = new System.Drawing.Point(128, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 361);
            this.panel1.TabIndex = 0;
            // 
            // TRuta
            // 
            this.TRuta.Location = new System.Drawing.Point(147, 251);
            this.TRuta.Name = "TRuta";
            this.TRuta.Size = new System.Drawing.Size(226, 20);
            this.TRuta.TabIndex = 13;
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.BackColor = System.Drawing.Color.Transparent;
            this.RBMujer.Font = new System.Drawing.Font("Gabriola", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMujer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RBMujer.Location = new System.Drawing.Point(141, 6);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(47, 24);
            this.RBMujer.TabIndex = 12;
            this.RBMujer.TabStop = true;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = false;
            // 
            // RBHombre
            // 
            this.RBHombre.AutoSize = true;
            this.RBHombre.BackColor = System.Drawing.Color.Transparent;
            this.RBHombre.Font = new System.Drawing.Font("Gabriola", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBHombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RBHombre.Location = new System.Drawing.Point(23, 9);
            this.RBHombre.Name = "RBHombre";
            this.RBHombre.Size = new System.Drawing.Size(54, 24);
            this.RBHombre.TabIndex = 11;
            this.RBHombre.TabStop = true;
            this.RBHombre.Text = "Hombre";
            this.RBHombre.UseVisualStyleBackColor = false;
            this.RBHombre.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // DTFecha
            // 
            this.DTFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFecha.Location = new System.Drawing.Point(260, 126);
            this.DTFecha.Name = "DTFecha";
            this.DTFecha.Size = new System.Drawing.Size(98, 20);
            this.DTFecha.TabIndex = 10;
            // 
            // TSaldo
            // 
            this.TSaldo.Location = new System.Drawing.Point(142, 214);
            this.TSaldo.Name = "TSaldo";
            this.TSaldo.Size = new System.Drawing.Size(231, 20);
            this.TSaldo.TabIndex = 9;
            this.TSaldo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.TSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TSaldo_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(142, 86);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(231, 20);
            this.TApellido.TabIndex = 8;
            this.TApellido.TextChanged += new System.EventHandler(this.TApellido_TextChanged);
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(142, 43);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(231, 20);
            this.TNombre.TabIndex = 7;
            this.TNombre.TextChanged += new System.EventHandler(this.TNombre_TextChanged);
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombre_KeyPress);
            // 
            // BFoto
            // 
            this.BFoto.Location = new System.Drawing.Point(50, 251);
            this.BFoto.Name = "BFoto";
            this.BFoto.Size = new System.Drawing.Size(80, 20);
            this.BFoto.TabIndex = 6;
            this.BFoto.Text = "Foto";
            this.BFoto.UseVisualStyleBackColor = true;
            this.BFoto.Click += new System.EventHandler(this.BFoto_Click);
            // 
            // LSaldo
            // 
            this.LSaldo.AutoSize = true;
            this.LSaldo.BackColor = System.Drawing.Color.Transparent;
            this.LSaldo.Font = new System.Drawing.Font("Gabriola", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSaldo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LSaldo.Location = new System.Drawing.Point(44, 206);
            this.LSaldo.Name = "LSaldo";
            this.LSaldo.Size = new System.Drawing.Size(30, 20);
            this.LSaldo.TabIndex = 5;
            this.LSaldo.Text = "Saldo:";
            this.LSaldo.Click += new System.EventHandler(this.label2_Click);
            // 
            // LSexo
            // 
            this.LSexo.AutoSize = true;
            this.LSexo.BackColor = System.Drawing.Color.Transparent;
            this.LSexo.Font = new System.Drawing.Font("Gabriola", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSexo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LSexo.Location = new System.Drawing.Point(44, 164);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(26, 20);
            this.LSexo.TabIndex = 4;
            this.LSexo.Text = "Sexo:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.Color.Transparent;
            this.LApellido.Font = new System.Drawing.Font("Gabriola", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LApellido.Location = new System.Drawing.Point(44, 78);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(39, 20);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "Apellido:";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.BackColor = System.Drawing.Color.Transparent;
            this.LFecha.Font = new System.Drawing.Font("Gabriola", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LFecha.Location = new System.Drawing.Point(44, 121);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(81, 20);
            this.LFecha.TabIndex = 2;
            this.LFecha.Text = "Fecha de Nacimiento:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.Color.Transparent;
            this.LNombre.Font = new System.Drawing.Font("Gabriola", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LNombre.Location = new System.Drawing.Point(44, 35);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(38, 20);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre:";
            // 
            // BAgregar
            // 
            this.BAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BAgregar.Image")));
            this.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregar.Location = new System.Drawing.Point(166, 293);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(105, 53);
            this.BAgregar.TabIndex = 0;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAgregar.UseVisualStyleBackColor = true;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.RBMujer);
            this.panel2.Controls.Add(this.RBHombre);
            this.panel2.Location = new System.Drawing.Point(119, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 48);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Fecha_Nacimiento
            // 
            this.Fecha_Nacimiento.HeaderText = "Fecha Nacimiento";
            this.Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // Foto
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Foto.DefaultCellStyle = dataGridViewCellStyle6;
            this.Foto.HeaderText = "Foto";
            this.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Foto.Name = "Foto";
            this.Foto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Ruta
            // 
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.Name = "Ruta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 582);
            this.Controls.Add(this.PBFoto);
            this.Controls.Add(this.DGTabla);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Formulario con DataGrid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Label LSaldo;
        private System.Windows.Forms.Label LSexo;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TSaldo;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Button BFoto;
        private System.Windows.Forms.DateTimePicker DTFecha;
        private System.Windows.Forms.RadioButton RBHombre;
        private System.Windows.Forms.RadioButton RBMujer;
        private System.Windows.Forms.TextBox TRuta;
        private System.Windows.Forms.DataGridView DGTabla;
        private System.Windows.Forms.PictureBox PBFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
    }
}

