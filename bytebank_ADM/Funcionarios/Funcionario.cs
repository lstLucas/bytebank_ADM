using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public Funcionario(string cpf) {
            Cpf = cpf;
            totalFuncionarios++;
        }
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; set; }

        public virtual double getBonificacao() {
                return Salario * 0.1;
        }
        public static int totalFuncionarios { get; private set; }
    }
}
