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
            LBLista.Items.Clear();
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
                        if (error == 's')
                        {
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Hay al menos un caracter no numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }

                if (error != 's')
                {
                    int desde = int.Parse(TDesde.Text);
                    int hasta = int.Parse(THasta.Text);

                    if (desde <= hasta)
                    {
                        while (desde <= hasta)
                        {
                            LBLista.Items.Add(desde);
                            desde++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo 'Desde' debe ser menor que el campo 'Hasta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else
            {
                MessageBox.Show("Debes completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void THasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LBLista.Items.Clear();
            if (TDesde.Text.Trim() != "" && THasta.Text.Trim() != "")
            {
                int i;
                char error = 'n';
                for (i = 0; i < THasta.TextLength; i++)
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
                        if (error == 's')
                        {
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Hay al menos un caracter no numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }

                if (error != 's')
                {
                    int desde = int.Parse(TDesde.Text);
                    int hasta = int.Parse(THasta.Text);

                    if (desde <= hasta)
                    {
                        while (desde <= hasta)
                        {
                            if (desde % 2 == 0)
                            {
                                LBLista.Items.Add(desde);
                            }
                            
                            desde++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo 'Desde' debe ser menor que el campo 'Hasta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else
            {
                MessageBox.Show("Debes completar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BNumImpares_Click(object sender, EventArgs e)
        {
            LBLista.Items.Clear();
            if (TDesde.Text.Trim() != "" && THasta.Text.Trim() != "")
            {
                int i;
                char error = 'n';
                for (i = 0; i < THasta.TextLength; i++)
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
                        if (error == 's')
                        {
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Hay al menos un caracter no numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }

                if (error != 's')
                {
                    int desde = int.Parse(TDesde.Text);
                    int hasta = int.Parse(THasta.Text);

                    if (desde <= hasta)
                    {
                        while (desde <= hasta)
                        {
                            if (desde % 2 != 0)
                            {
                                LBLista.Items.Add(desde);
                            }

                            desde++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo 'Desde' debe ser menor que el campo 'Hasta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
