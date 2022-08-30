using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor:Funcionario
    {
        public Diretor(string cpf):base(cpf,5000)
        { }

        public override void aumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double getBonificacao()
        {
            return Salario * 0.5;
        }
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

        public string Senha { get; set; }


    }
}
