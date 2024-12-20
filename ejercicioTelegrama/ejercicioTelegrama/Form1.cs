﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecioEMM2425_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o';
            int numPalabras_EMM2425 = 0;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (rBtnUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            
            //Obtengo el número de palabras que forma el telegrama
            // Error: numPalabras_EMM2425 = textoTelegrama.Length;
            string[] palabras = textoTelegrama.Split(' '); //separa las palabras y las introduce en una estructura
            numPalabras_EMM2425 = palabras.Length; //Obtiene la longitud de la estructura, que será el número de palabras.
                                                   //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
            {
                if (numPalabras_EMM2425 <= 10)
                {
                    coste = 3.0;
                }
                else
                {
                    coste = 0.5 * numPalabras_EMM2425;
                }
            }
            else
            //Si el telegrama es urgente
            {
                if (tipoTelegrama == 'u')
                {
                    if (numPalabras_EMM2425 <= 10)
                    {
                        coste = 6;
                    }
                    else
                    {
                        coste = 5 + 0.75 * (numPalabras_EMM2425 - 10);
                    }
                }
                else
                {
                    coste = 0;
                }
            }
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
