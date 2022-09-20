using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prjCalculadora
{
    public class Calculadora
    {
        public string Visor { get; set; }
        public double Aux1 { get; set; }
        public double Aux2 { get; set; }
        public double Resultado { get; set; }
       
        private string op;
        public string Op {
            get { return op; }
            set {
                Aux1 = Double.Parse(Visor);
                Visor = "0";
                Aux2 = 0;
                Resultado = 0;
                op = value;
                }
        }
        public Calculadora()
        {
            Visor = "0";
            Aux1 = 0;
            Aux2 = 0;
            Resultado = 0;
            Op = "";
        }
        public void setDigito(string digito)
        {
            if (Visor.Equals("0")) Visor = digito;
            else Visor += digito;
        }
        public void Calcular()
        {
            if (Aux2 == 0) Aux2 = double.Parse(Visor);
            else Aux1 = Resultado;
            if (Op.Equals("+")) Resultado = Aux1 + Aux2;
            if (Op.Equals("-")) Resultado = Aux1 - Aux2;
            if (Op.Equals("*")) Resultado = Aux1 * Aux2;
            if (Op.Equals("/")) Resultado = Aux1 / Aux2;
            Visor = Resultado.ToString();
        }
        public void PontoDecimal()
        {
            if (!Visor.Contains(","))
            {
                Visor += ",";
            }
        }
        public void InverterSinal()
        {
            double num = Double.Parse(Visor) * -1;
            Visor = num.ToString();
        }
        public void Fracao()
        {
            double num = 1/Double.Parse(Visor);
            Visor = num.ToString();
            Resultado = Double.Parse(Visor);
        }
        public void Quadrado()
        {
            double num = Double.Parse(Visor);
            Visor = (num*num).ToString();
            Resultado = Double.Parse(Visor);
        }
        public void RaizQuadrada()
        {
            double num = Double.Parse(Visor);
            Visor = Math.Sqrt(num).ToString();
            Resultado = Double.Parse(Visor);
        }
        public void Backspace()
        {
            Visor = Visor.Substring(0, Visor.Length - 1);
            if (Visor.Length == 0) Visor = "0";
        }
        public void Euller()
        {
            Visor = Math.E.ToString();
            Resultado = Double.Parse(Visor);
        }
        public void PI()
        {
            Visor = Math.PI.ToString();
            Resultado = Double.Parse(Visor);
        }
        public void Tangente()
        {
            double num = Double.Parse(Visor);
            Visor = Math.Tan(num/180 *Math.PI).ToString();
            Resultado = Double.Parse(Visor);
        }
        public void Cosseno()
        {
            double num = Double.Parse(Visor);
            Visor = Math.Cos(num / 180 * Math.PI).ToString();
            Resultado = Double.Parse(Visor);
        }
        public void Seno()
        {
            double num = Double.Parse(Visor);
            Visor = Math.Sin(num / 180 * Math.PI).ToString();
            Resultado = Double.Parse(Visor);
        }
        public void Logaritmo()
        {
            double num = Double.Parse(Visor);
            Visor = Math.Log10(num).ToString();
            Resultado = Double.Parse(Visor);
        }
        public void Porcentagem()
        {
            double p = Double.Parse(Visor);
            double resultado = Aux1 * p / 100;
            Visor = resultado.ToString();
        }

        internal void BackSpace()
        {
            throw new NotImplementedException();
        }
    }
}