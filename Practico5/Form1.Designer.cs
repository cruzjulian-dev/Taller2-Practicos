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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PBFoto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 400);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(868, 170);
            this.dataGridView1.TabIndex = 1;
            // 
            // PBFoto
            // 
            this.PBFoto.Location = new System.Drawing.Point(588, 33);
            this.PBFoto.Name = "PBFoto";
            this.PBFoto.Size = new System.Drawing.Size(263, 254);
            this.PBFoto.TabIndex = 2;
            this.PBFoto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.RBMujer);
            this.panel1.Controls.Add(this.RBHombre);
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
            this.panel1.Size = new System.Drawing.Size(428, 340);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 13;
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.BackColor = System.Drawing.SystemColors.MenuText;
            this.RBMujer.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMujer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RBMujer.Location = new System.Drawing.Point(260, 164);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(70, 29);
            this.RBMujer.TabIndex = 12;
            this.RBMujer.TabStop = true;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = false;
            // 
            // RBHombre
            // 
            this.RBHombre.AutoSize = true;
            this.RBHombre.BackColor = System.Drawing.SystemColors.MenuText;
            this.RBHombre.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBHombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RBHombre.Location = new System.Drawing.Point(142, 167);
            this.RBHombre.Name = "RBHombre";
            this.RBHombre.Size = new System.Drawing.Size(89, 29);
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
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(142, 86);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(231, 20);
            this.TApellido.TabIndex = 8;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(142, 43);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(231, 20);
            this.TNombre.TabIndex = 7;
            // 
            // BFoto
            // 
            this.BFoto.Location = new System.Drawing.Point(50, 251);
            this.BFoto.Name = "BFoto";
            this.BFoto.Size = new System.Drawing.Size(80, 20);
            this.BFoto.TabIndex = 6;
            this.BFoto.Text = "Foto";
            this.BFoto.UseVisualStyleBackColor = true;
            // 
            // LSaldo
            // 
            this.LSaldo.AutoSize = true;
            this.LSaldo.BackColor = System.Drawing.SystemColors.MenuText;
            this.LSaldo.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSaldo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LSaldo.Location = new System.Drawing.Point(44, 206);
            this.LSaldo.Name = "LSaldo";
            this.LSaldo.Size = new System.Drawing.Size(78, 33);
            this.LSaldo.TabIndex = 5;
            this.LSaldo.Text = "Saldo:";
            this.LSaldo.Click += new System.EventHandler(this.label2_Click);
            // 
            // LSexo
            // 
            this.LSexo.AutoSize = true;
            this.LSexo.BackColor = System.Drawing.SystemColors.MenuText;
            this.LSexo.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSexo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LSexo.Location = new System.Drawing.Point(44, 164);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(70, 33);
            this.LSexo.TabIndex = 4;
            this.LSexo.Text = "Sexo:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.SystemColors.MenuText;
            this.LApellido.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LApellido.Location = new System.Drawing.Point(44, 78);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(98, 33);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "Apellido:";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.BackColor = System.Drawing.SystemColors.MenuText;
            this.LFecha.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LFecha.Location = new System.Drawing.Point(44, 121);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(210, 33);
            this.LFecha.TabIndex = 2;
            this.LFecha.Text = "Fecha de Nacimiento:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.SystemColors.MenuText;
            this.LNombre.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LNombre.Location = new System.Drawing.Point(44, 35);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(92, 33);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre:";
            // 
            // BAgregar
            // 
            this.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregar.Location = new System.Drawing.Point(161, 287);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(105, 40);
            this.BAgregar.TabIndex = 0;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAgregar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 582);
            this.Controls.Add(this.PBFoto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Formulario con DataGrid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox PBFoto;
    }
}

