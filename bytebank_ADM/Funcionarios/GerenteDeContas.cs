using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas:Funcionario
    {
        public GerenteDeContas(string cpf):base(cpf,4000)
        { }
        public override void aumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double getBonificacao()
        {
            return Salario * 0.25;
        }
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

        public string Senha { get; set; }
    }
}
