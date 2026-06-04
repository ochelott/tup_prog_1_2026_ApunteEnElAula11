using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int[] vector = new int[100];
        int contador = 0;

        int BusquedaSecuencial(int buscado)
        {
            int idx = 0; int idxBuscado = -1;
            while (idxBuscado == -1 && idx < contador)
            {
                if (vector[idx] == buscado)
                {
                    idxBuscado = idx;
                  
                }  idx++;
            }
            return idxBuscado;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDatos fDatos = new FormDatos();
            if (fDatos.ShowDialog() == DialogResult.OK)
            {
                int valor = Convert.ToInt32(fDatos.tbValor.Text);
                #region Registrar
                vector[contador] = valor;
                contador++;
                #endregion
            }
            fDatos.Dispose();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FormDatos fDatos = new FormDatos();
            if (fDatos.ShowDialog() == DialogResult.OK)
            {
                int valor = Convert.ToInt32(fDatos.tbValor.Text);
                int idx = BusquedaSecuencial(valor);

                string resultado = $"No Encontrado: {valor} ";
                if (idx != -1)
                {
                    resultado = $"Encontrado: {valor} en posicion: {idx}";
                }
                FormSalidas fSalida = new FormSalidas();
                fSalida.lsbResultados.Items.Add(resultado);
                fSalida.ShowDialog();

            }
        }

    }
}
