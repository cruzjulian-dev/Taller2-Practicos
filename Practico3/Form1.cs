using Practico2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practico2
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {

        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {

            //if (string.IsNullOrEmpty(TNombre.Text.Trim()) || string.IsNullOrEmpty(TApellido.Text.Trim()) )
            if (TDni.Text.Trim() == "" || TNombre.Text.Trim() == "" || TApellido.Text.Trim() == "" || TTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LModificar.Text = TNombre.Text.Trim() + " " + TApellido.Text.Trim();
                DialogResult ask = MessageBox.Show("Seguro que desea insertar un nuevo Cliente?", "Confirmar inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show("El Cliente: " + TNombre.Text.Trim() + " " + TApellido.Text.Trim() + " se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (TDni.Text.Trim() == "" || TNombre.Text.Trim() == "" || TApellido.Text.Trim() == "" || TTelefono.Text.Trim() == "")
            {
                MessageBox.Show("No existe cliente para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask;
                ask = MessageBox.Show("Está apunto de eliminar el Cliente: " + TNombre.Text.Trim() + " " + TApellido.Text.Trim(), "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show("El Cliente: " + TNombre.Text.Trim() + " " + TApellido.Text.Trim() + " se elimino correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TDni.Clear();
                    TNombre.Clear();
                    TApellido.Clear();
                    TTelefono.Clear();
                    CNaranja.Checked = false;
                    CVisa.Checked = false;
                    CMastercard.Checked = false;
                    LModificar.Text = "Modificar";
                }
            }
            
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            MDIParent1.ActiveForm.Close();
        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.man;
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.woman;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
