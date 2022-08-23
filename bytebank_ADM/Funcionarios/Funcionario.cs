using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        // 0 - Funcionário
        // 1 - Diretor
        // 2 - Designer
        // N - ...

        private int _tipo;

        public Funcionario(int _tipo) {
            this._tipo = _tipo;
        }
        public string nome { get; set; }
        public string cpf { get; set; }
        public double salario { get; set; }

        public double getBonificacao() {
            if (_tipo == 1)
                return salario;
            else
                return salario * 0.1;
        }
    }
}
