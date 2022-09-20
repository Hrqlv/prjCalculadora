using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculadora calc = new Calculadora();
        bool EstadoIgual = false;

        private void bt0_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.setDigito(bt0.Text);
            lbVisor.Text = calc.Visor;
        }

        private void TestarIgual(object sender, EventArgs e)
        {
            if(EstadoIgual == true)
            {
                EstadoIgual = false;
                btC_Click(sender, e);
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.setDigito(bt1.Text);
            lbVisor.Text = calc.Visor;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.setDigito(bt2.Text);
            lbVisor.Text = calc.Visor;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.setDigito(bt3.Text);
            lbVisor.Text = calc.Visor;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.setDigito(bt4.Text);
            lbVisor.Text = calc.Visor;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.setDigito(bt5.Text);
            lbVisor.Text = calc.Visor;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.setDigito(bt6.Text);
            lbVisor.Text = calc.Visor;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.setDigito(bt7.Text);
            lbVisor.Text = calc.Visor;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.setDigito(bt8.Text);
            lbVisor.Text = calc.Visor;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.setDigito(bt9.Text);
            lbVisor.Text = calc.Visor;
        }

        private void btC_Click(object sender, EventArgs e)
        {
            calc.Visor = "0";
            lbVisor.Text = calc.Visor;
            lbCalculo.Text = calc.Aux1 + " " +
               calc.Op + " " + calc.Aux2 +
               " = " + calc.Resultado;
        }

        private void btCE_Click(object sender, EventArgs e)
        {
            calc.Visor = "0";
            lbVisor.Text = calc.Visor;
            lbCalculo.Text = calc.Aux1 + " " +
               calc.Op + " " + calc.Aux2 +
               " = " + calc.Resultado;
        }

        private void btSomar_Click(object sender, EventArgs e)
        {
            calc.Op = "+";
            lbCalculo.Text = calc.Aux1 + " " +
               calc.Op + " " + calc.Aux2 +
               " = " + calc.Resultado;
        }

        private void btSubtrair_Click(object sender, EventArgs e)
        {
            calc.Op = "-";
            lbCalculo.Text = calc.Aux1 + " " +
               calc.Op + " " + calc.Aux2 +
               " = " + calc.Resultado;
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            calc.Op = "*";
            lbCalculo.Text = calc.Aux1 + " " +
               calc.Op + " " + calc.Aux2 +
               " = " + calc.Resultado;
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            calc.Op = "/";
            lbCalculo.Text = calc.Aux1 + " " +
               calc.Op + " " + calc.Aux2 +
               " = " + calc.Resultado;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            calc.Calcular();
            lbVisor.Text = calc.Visor;
            EstadoIgual = true;
        }

        private void btPontoDecimal_Click(object sender, EventArgs e)
        {
            calc.PontoDecimal();
            lbVisor.Text = calc.Visor;
        }

        private void btInverterSinal_Click(object sender, EventArgs e)
        {
            calc.InverterSinal();
            lbVisor.Text = calc.Visor;
        }

        private void btFraçao_Click(object sender, EventArgs e)
        {
            calc.Fracao();
            lbVisor.Text = calc.Visor;
            EstadoIgual = true;
            lbCalculo.Text = calc.Aux1 + " " +
               calc.Op + " " + calc.Aux2 +
               " = " + calc.Resultado;
        }

        private void btQuadrado_Click(object sender, EventArgs e)
        {
            calc.Quadrado();
            lbVisor.Text = calc.Visor;
            EstadoIgual = true;
            lbCalculo.Text = calc.Aux1 + " " +
               calc.Op + " " + calc.Aux2 +
               " = " + calc.Resultado;
        }

        private void btRaiz_Click(object sender, EventArgs e)
        {
            calc.RaizQuadrada();
            lbVisor.Text = calc.Visor;
            EstadoIgual = true;
            lbCalculo.Text = calc.Aux1 + " " +
               calc.Op + " " + calc.Aux2 +
               " = " + calc.Resultado;
        }

        private void btBackSpace_Click(object sender, EventArgs e)
        {
            calc.BackSpace();
            lbVisor.Text = calc.Visor;
        }

        private void btE_Click(object sender, EventArgs e)
        {
            calc.Euller();
            lbVisor.Text = calc.Visor;
            lbCalculo.Text = calc.Aux1 + " " +
               calc.Op + " " + calc.Aux2 +
               " = " + calc.Resultado;
        }

        private void btPi_Click(object sender, EventArgs e)
        {
            calc.PI();
            lbVisor.Text = calc.Visor;
            EstadoIgual = true;
            lbCalculo.Text = calc.Aux1 + " " +
               calc.Op + " " + calc.Aux2 +
               " = " + calc.Resultado;
        }

        private void btTangente_Click(object sender, EventArgs e)
        {
            calc.Tangente();
            lbVisor.Text = calc.Visor;
            EstadoIgual = true;
            lbCalculo.Text = calc.Aux1 + " " +
               calc.Op + " " + calc.Aux2 +
               " = " + calc.Resultado;
        }

        private void btCosseno_Click(object sender, EventArgs e)
        {
            calc.Cosseno();
            lbVisor.Text = calc.Visor;
            EstadoIgual = true;
            lbCalculo.Text = calc.Aux1 + " " +
               calc.Op + " " + calc.Aux2 +
               " = " + calc.Resultado;
        }

        private void btSeno_Click(object sender, EventArgs e)
        {
            calc.Seno();
            lbVisor.Text = calc.Visor;
            EstadoIgual = true;
            lbCalculo.Text = calc.Aux1 + " " +
               calc.Op + " " + calc.Aux2 +
               " = " + calc.Resultado;
        }

        private void btLog_Click(object sender, EventArgs e)
        {
            calc.Logaritmo();
            lbVisor.Text = calc.Visor;
            EstadoIgual = true;
        }

        private void btPorcentagem_Click(object sender, EventArgs e)
        {
            calc.Porcentagem();
            lbVisor.Text = calc.Visor;
            EstadoIgual = true;
            lbCalculo.Text = calc.Aux1 + " " +
               calc.Op + " " + calc.Aux2 +
               " = " + calc.Resultado;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                TestarIgual(sender, e);
                calc.setDigito(e.KeyChar.ToString());
                lbVisor.Text = calc.Visor;
            }
            if (e.KeyChar == '+') calc.Op = "+";
            if (e.KeyChar == '-') calc.Op = "-";
            if (e.KeyChar == '*') calc.Op = "*";
            if (e.KeyChar == '/') calc.Op = "/";
            if (e.KeyChar == '=')btCalcular_Click(sender,e);
            lbCalculo.Text = calc.Aux1 + " " +
                calc.Op + " " + calc.Aux2 +
                " = " + calc.Resultado;
        }
    }
}
