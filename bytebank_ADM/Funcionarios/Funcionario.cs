using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public double salario { get; set; }

        public double getBonificacao() {
            return salario * 0.1;
        }
    }
}
