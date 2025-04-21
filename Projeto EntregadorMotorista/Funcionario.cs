using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_EntregadorMotorista
{
    internal class Funcionario
    {
        private  string? nome;
        private double salario;

        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        virtual public double CalculoSalario()
        {
            return salario;
        }

        virtual public string Mostra()
        {
            return "Nome: " + nome + "\n" + "Salario Base: " + salario;
        }
    }
}
