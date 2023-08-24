using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BGenerar_Click(object sender, EventArgs e)
        {
            LBLista.Text = "";
            if (TDesde.Text.Trim() != "" && THasta.Text.Trim() != "" )
            {
                int i;
                char error = 'n';
                for (i=0; i<THasta.TextLength; i++)
                {
                    if (!char.IsNumber(THasta.Text[i]))
                    {
                        error = 's';
                        MessageBox.Show("Hay al menos un caracter no numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                for (i = 0; i < TDesde.TextLength; i++)
                {
                    if (!char.IsNumber(TDesde.Text[i]))
                    {
                        error = 's';
                        MessageBox.Show("Hay al menos un caracter no numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                if (error != 's')
                {
                    int desde = int.Parse(TDesde.Text);
                    int hasta = int.Parse(THasta.Text);
                    
                     while (desde <= hasta)
                    { 
                        LBLista.Items.Add(desde);
                        desde++;
                    }
                }

            }
            else
            {
                MessageBox.Show("Debes completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
