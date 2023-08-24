namespace Practico4
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
            this.LDesde = new System.Windows.Forms.Label();
            this.LHasta = new System.Windows.Forms.Label();
            this.TDesde = new System.Windows.Forms.TextBox();
            this.THasta = new System.Windows.Forms.TextBox();
            this.BGenerar = new System.Windows.Forms.Button();
            this.LLista = new System.Windows.Forms.Label();
            this.LBLista = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Location = new System.Drawing.Point(45, 101);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(38, 13);
            this.LDesde.TabIndex = 0;
            this.LDesde.Text = "Desde";
            this.LDesde.Click += new System.EventHandler(this.label1_Click);
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Location = new System.Drawing.Point(48, 171);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(35, 13);
            this.LHasta.TabIndex = 1;
            this.LHasta.Text = "Hasta";
            // 
            // TDesde
            // 
            this.TDesde.Location = new System.Drawing.Point(107, 98);
            this.TDesde.Name = "TDesde";
            this.TDesde.Size = new System.Drawing.Size(100, 20);
            this.TDesde.TabIndex = 2;
            this.TDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDesde_KeyPress);
            // 
            // THasta
            // 
            this.THasta.Location = new System.Drawing.Point(107, 168);
            this.THasta.Name = "THasta";
            this.THasta.Size = new System.Drawing.Size(100, 20);
            this.THasta.TabIndex = 3;
            this.THasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.THasta_KeyPress);
            // 
            // BGenerar
            // 
            this.BGenerar.Location = new System.Drawing.Point(89, 218);
            this.BGenerar.Name = "BGenerar";
            this.BGenerar.Size = new System.Drawing.Size(118, 23);
            this.BGenerar.TabIndex = 4;
            this.BGenerar.Text = "Generar Funcion";
            this.BGenerar.UseVisualStyleBackColor = true;
            this.BGenerar.Click += new System.EventHandler(this.BGenerar_Click);
            // 
            // LLista
            // 
            this.LLista.AutoSize = true;
            this.LLista.Location = new System.Drawing.Point(406, 72);
            this.LLista.Name = "LLista";
            this.LLista.Size = new System.Drawing.Size(89, 13);
            this.LLista.TabIndex = 5;
            this.LLista.Text = "Lista de Numeros";
            // 
            // LBLista
            // 
            this.LBLista.FormattingEnabled = true;
            this.LBLista.Location = new System.Drawing.Point(273, 98);
            this.LBLista.Name = "LBLista";
            this.LBLista.Size = new System.Drawing.Size(358, 316);
            this.LBLista.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Numeros Pares";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Numeros Impares";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Numeros Primos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBLista);
            this.Controls.Add(this.LLista);
            this.Controls.Add(this.BGenerar);
            this.Controls.Add(this.THasta);
            this.Controls.Add(this.TDesde);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.LDesde);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.TextBox TDesde;
        private System.Windows.Forms.TextBox THasta;
        private System.Windows.Forms.Button BGenerar;
        private System.Windows.Forms.Label LLista;
        private System.Windows.Forms.ListBox LBLista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

