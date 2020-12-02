﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesObjetoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblCalcularResultado_Click(object sender, EventArgs e)
        {
            Fraccion f1 = new Fraccion((int)numEntero1.Value, (int)numNumerador1.Value,(int)numDenominador1.Value);
            Fraccion f2 = new Fraccion((int)numEntero2.Value, (int)numDenominador2.Value);
            Fraccion resultado =null;
            switch (cboOperacion.Text)
            {
                case "+":
                    resultado = f1.Sumar(f2);
                    break;
                case "-":
                    resultado = f1.Restar(f2);
                    break;
                case "/":
                    resultado = f1.Dividir(f2);
                    break;
                case "*":
                    resultado = f1.Multiplicar(f2);
                    break;
                default:
                    MessageBox.Show("Falta seleccionar la operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    break;
            }
            lblLinea.Text = "_________";
            if (resultado.Entero ==0)
            {
                lblResultado.Text = "";
            }
            else
            {
                lblResultado.Text = resultado.Entero + "";
            }
            if (resultado.Numerador ==0)
            {
                lblResultadoNumerador.Text = "";
                lblResultadoDenominador.Text = "";
            }
            else
            {
                lblResultadoNumerador.Text = "";
                lblResultadoDenominador.Text = "";
                lblLinea.Text = "";
            }

            lblResultado.Text = resultado.Entero+"";
            lblResultadoNumerador.Text = resultado.Numerador + ""; ;
            lblResultadoDenominador.Text = resultado.Denominador + ""; ;
        }
    }
}
