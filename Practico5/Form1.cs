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

                    String carpetaFotos = Application.StartupPath + @"\Fotos\";

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
    }
}
