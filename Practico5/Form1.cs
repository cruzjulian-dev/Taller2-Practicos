using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DGTabla.Rows.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Title = "Abrir imagen";
                file.Filter = "Archivos Imagenes|*.jpg|Archivos Imagenes|*.jpeg|Archivos Imagenes|*.bmp|Archivos Imagenes | *.png";
                

                if (file.ShowDialog() == DialogResult.OK)
                {
                    string nombreArchivo = Path.GetFileName(file.FileName);
                    PBFoto.Image = Image.FromFile(file.FileName);                    
                    TRuta.Text = file.FileName;

                    String carpetaFotos = Application.StartupPath + @"\Fotos\"; //raiz del proyecto /bin/Debug

                    try
                    {
                        if (!Directory.Exists(carpetaFotos))
                        {
                            Directory.CreateDirectory(carpetaFotos);
                        }


                        PBFoto.Image.Save(carpetaFotos +  nombreArchivo);

                    } catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }

            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            if (TNombre.Text.Trim() == "" || TApellido.Text.Trim() == "" || TSaldo.Text.Trim() == "" || TRuta.Text.Trim() == "" || (RBHombre.Checked == false && RBMujer.Checked == false))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                String sexo;
                if (RBHombre.Checked)
                {
                    sexo = "Hombre";
                }
                else
                {
                    sexo = "Mujer";
                }

                if (int.Parse(TSaldo.Text) < 50)
                {
                    
                    DGTabla.Rows.Add(TApellido.Text, TNombre.Text, DTFecha.Text, sexo, "Eliminar", TSaldo.Text, PBFoto.Image, TRuta.Text);
                    //falta agregar backcolor rojo
                }
                else
                {
                    DGTabla.Rows.Add(TApellido.Text, TNombre.Text, DTFecha.Text, sexo, "Eliminar", TSaldo.Text, PBFoto.Image, TRuta.Text);
                }


            }
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName; //obtengo la ruta de la raiz del proyecyo
            PBFoto.ImageLocation = projectDirectory + @"\img\avatar.jpg";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void DGTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGTabla.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("Seguro que quieres eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int filaSeleccionada = DGTabla.CurrentRow.Index;
                    DGTabla.Rows.RemoveAt(filaSeleccionada);
                }
                
            }
        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {
            TNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TNombre.Text);
            TNombre.SelectionStart = TNombre.Text.Length;
        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {
            TApellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TApellido.Text);
            TApellido.SelectionStart = TApellido.Text.Length;
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
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

        private void TSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
