using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public Funcionario(string cpf, double salario) {
            Cpf = cpf;
            Salario = salario;  
            totalFuncionarios++;
        }

        public virtual void aumentarSalario() {
            this.Salario *= 1.1;
        
        }
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public virtual double getBonificacao() {
                return Salario * 0.1;
        }
        public static int totalFuncionarios { get; private set; }
    }
}
