using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_EntregadorMotorista
{
    internal class Entregador:Funcionario
    {
        private int entregas;

        public int Entregas
        {
            get { return entregas; }
            set { entregas = value; }
        }

        override public  double CalculoSalario()
        {
            return Salario + (entregas * 20.0);
        }

        override public string Mostra()
        {
            return "Tipo: Entregador\n" + base.Mostra() + "\nEntregas Realizadas: " + entregas;
        }
    }
}
