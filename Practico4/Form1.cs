using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
                        CTorta.Series.Clear();
                        CTorta.Titles.Clear();
                        CTorta.Titles.Add("Conteo de números");
                        List<int> series = new List<int>(); // cantidad de elementos
                        List<int> puntos = new List<int>(); // cantidad de puntos por cada elemento
                        while (desde <= hasta)
                        {
                            LBLista.Items.Add(desde);
                            series.Add(desde);
                            puntos.Add(desde);
                            desde++;
                        }
                        for (int j = 0; j < series.Count; j++)
                        {
                            Series s = CTorta.Series.Add(series[j].ToString());
                            //s.Label = puntos[j].ToString();
                            //s.Points.AddXY(puntos[j], puntos[j]); Agrega eje horizontal y vertical
                            s.Points.Add(puntos[j]); //Agrega solo eje vertical
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
                        CTorta.Series.Clear();
                        CTorta.Titles.Clear();
                        CTorta.Titles.Add("Numeros Pares");
                        List<int> series = new List<int>(); // cantidad de elementos
                        List<int> puntos = new List<int>(); // cantidad de puntos por cada elemento

                        while (desde <= hasta)
                        {
                            if (desde % 2 == 0)
                            {
                 
                                LBLista.Items.Add(desde);

                                series.Add(desde);
                                puntos.Add(desde);
                                
                            }
                            
                            desde++;
                        }

                        for (int j=0; j < series.Count; j++)
                        {
                            Series s = CTorta.Series.Add(series[j].ToString());
                            //s.Label = puntos[j].ToString();
                            //s.Points.AddXY(puntos[j], puntos[j]); Agrega eje horizontal y vertical
                            s.Points.Add(puntos[j]); //Agrega solo eje vertical
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
                        CTorta.Series.Clear();
                        CTorta.Titles.Clear();
                        CTorta.Titles.Add("Numeros Impares");
                        List<int> series = new List<int>(); // cantidad de elementos
                        List<int> puntos = new List<int>(); // cantidad de puntos por cada elemento
                        while (desde <= hasta)
                        {
                            if (desde % 2 != 0)
                            {
                                LBLista.Items.Add(desde);
                                series.Add(desde);
                                puntos.Add(desde);
                            }

                            desde++;
                        }
                        for (int j = 0; j < series.Count; j++)
                        {
                            Series s = CTorta.Series.Add(series[j].ToString());
                            //s.Label = puntos[j].ToString();
                            //s.Points.AddXY(puntos[j], puntos[j]); Agrega eje horizontal y vertical
                            s.Points.Add(puntos[j]); //Agrega solo eje vertical
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

        private void BNumPrimos_Click(object sender, EventArgs e)
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
                        CTorta.Series.Clear();
                        CTorta.Titles.Clear();
                        CTorta.Titles.Add("Numeros Primos");
                        List<int> series = new List<int>(); // cantidad de elementos
                        List<int> puntos = new List<int>(); // cantidad de puntos por cada elemento
                        while (desde <= hasta)
                        {

                            //Un número primo es un número entero con exactamente dos divisores integrales, 1 y el número mismo
                            bool primo = true;
                            if(desde <= 1)
                            {
                                desde = 2;
                            }

                            for (i = 2; i <= (desde / 2); i++)
                            {
                                int div = desde % i;
                                if (div == 0)
                                {
                                    primo = false;
                                    break;
                                }
                            }

                            if (desde / 1 == desde && desde / desde == 1 && primo == true)
                            {
                                LBLista.Items.Add(desde);
                                series.Add(desde);
                                puntos.Add(desde);
                            }

                            desde++;
                        }
                        for (int j = 0; j < series.Count; j++)
                        {
                            Series s = CTorta.Series.Add(series[j].ToString());
                            //s.Label = puntos[j].ToString();
                            //s.Points.AddXY(puntos[j], puntos[j]); Agrega eje horizontal y vertical
                            s.Points.Add(puntos[j]); //Agrega solo eje vertical
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

        private void TDesde_Validating(object sender, CancelEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
