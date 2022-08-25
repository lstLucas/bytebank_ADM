using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public Funcionario(string cpf, double salario) {
            Cpf = cpf;
            Salario = salario;  
            totalFuncionarios++;
        }

        public abstract void aumentarSalario();
        public abstract double getBonificacao();

        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int totalFuncionarios { get; private set; }
    }
}
