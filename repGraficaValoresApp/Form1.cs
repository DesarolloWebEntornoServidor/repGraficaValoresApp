using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repGraficaValoresApp
{
    public partial class Representación : Form
    {

        int min = 0,
         max = 0,
        cantidad = 1;
     
        public Representación()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void minimo_ValueChanged(object sender, EventArgs e)
        {
            minimo.Maximum = maximo.Value;
            maximo.Minimum = minimo.Value;
        }

        private void maximo_ValueChanged(object sender, EventArgs e)
        {
            minimo.Maximum = maximo.Value;
            maximo.Minimum = minimo.Value;
        }

        public void btnGenerar_Click(object sender, EventArgs e)
        {

            String resultado = "";

            min = (Int32)minimo.Value;
            max = (Int32)maximo.Value;
            cantidad = (Int32)cantFrecuencia.Value;

            int numAleatorio, numAleatorio2;
            int[] tablaAleatoria = new int[cantidad];
            int[] tablaAleatoria2 = new int[cantidad];

            Random r = new Random();
            Random r1 = new Random();

            for (int i = 0; i < cantidad; i++)
            {
                numAleatorio = r.Next(min, max + 1);
                tablaAleatoria[i] = numAleatorio;

            }
            for (int i = 0; i < cantidad; i++)
            {
                numAleatorio2 = r1.Next(20);
                tablaAleatoria2[i] = numAleatorio2;

            }
            for (int i = 0; i < tablaAleatoria.Length; i++)
            {
                resultado += tablaAleatoria[i].ToString() + "\r\n";
                valorReal.Text = resultado + "\r\n";

            }

            resultado = "";
            int emax = tablaAleatoria2[0];
            int emin = tablaAleatoria2[0];


            for (int i = 0; i < tablaAleatoria2.Length; i++)
            {
                if (tablaAleatoria2[i] > emax) // Verifica valor máximo
                    emax = tablaAleatoria2[i];

                if (tablaAleatoria2[i] < emin) // verifica Valor Minimo
                    emin = tablaAleatoria2[i];

                resultado += tablaAleatoria2[i].ToString() + "\r\n";
                valorRelativo.Text = resultado + "\r\n";

            }

            resultado = "";
            float calculo = 0;

            for (int i = 0; i < cantidad; i++)
            {
                calculo = ((float)tablaAleatoria[i] * tablaAleatoria2[i] / 100);
                resultado += calculo.ToString() + "\r\n";
                errorAbsoluto.Text = resultado;
            }

            panelLinea.Invalidate();

        }

        private void panelLinea_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = this.CreateGraphics();
     
            Pen pen = new Pen(Brushes.Black, 0.1F);

            float x1 = 0;
            float y1 = 0;

            float y2 = 0;

            String resultado = "";


            int numAleatorio, numAleatorio2;
            int[] tablaAleatoria = new int[cantidad];
            int[] tablaAleatoria2 = new int[cantidad];

            Random r = new Random();
            Random r1 = new Random();

            for (int i = 0; i < cantidad; i++)
            {
                numAleatorio = r.Next(min, max + 1);
                tablaAleatoria[i] = numAleatorio;

            }
            for (int i = 0; i < cantidad; i++)
            {
                numAleatorio2 = r1.Next(20);
                tablaAleatoria2[i] = numAleatorio2;

            }
            for (int i = 0; i < tablaAleatoria.Length; i++)
            {
                resultado += tablaAleatoria[i].ToString() + "\r\n";
                valorReal.Text = resultado + "\r\n";

            }

            resultado = "";
            int emax = tablaAleatoria2[0];
            int emin = tablaAleatoria2[0];


            for (int i = 0; i < tablaAleatoria2.Length; i++)
            {
                if (tablaAleatoria2[i] > emax) // Verifica valor máximo
                    emax = tablaAleatoria2[i];

                if (tablaAleatoria2[i] < emin) // verifica Valor Minimo
                    emin = tablaAleatoria2[i];

                resultado += tablaAleatoria2[i].ToString() + "\r\n";
                valorRelativo.Text = resultado + "\r\n";

            }

            resultado = "";
            float calculo = 0;

            for (int i = 0; i < cantidad; i++)
            {
                calculo = ((float)tablaAleatoria[i] * tablaAleatoria2[i] / 100);
                resultado += calculo.ToString() + "\r\n";
                errorAbsoluto.Text = resultado;
            }


            float H = panelLinea.Height;
            float App = emax - emin;
            float Y = 0;
            float x2 = 0;


            x1 = (panelLinea.Width / (float)cantidad);

             y1 = panelLinea.Height / 2;

            resultado = "";
            for (int x = 0; x < cantidad; x++)
            {
                Y = (emax - tablaAleatoria2[x]) * H / App;
                if (Y >= 0)
                {
                    resultado += Y.ToString("N2") + "\r\n";
                    valoresY.Text = resultado;
                }


                e.Graphics.DrawLine(pen, x1 * x, y1, x2 + x1, Y);
                x2 = (x1 * x) + x1;
                y1 = Y;
            }


            pen.Dispose();
        }

    }
}
