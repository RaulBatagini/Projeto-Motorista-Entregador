using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_EntregadorMotorista
{
    internal class Motorista:Funcionario
    {
        private double horasextras;
        
        public double HorasExtras
        {
            get { return horasextras; }
            set { horasextras = value; }
        }

        override public double CalculoSalario()
        {
            return Salario + (HorasExtras * 50.0);
        }

        override public string Mostra()
        {
            return "Tipo: Motorista\n" + base.Mostra() + "\nHoras Extras: " + horasextras;
        }
    }
}
