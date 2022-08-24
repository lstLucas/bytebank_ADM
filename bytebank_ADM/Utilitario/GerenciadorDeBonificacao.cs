using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public void Registrar(Funcionario funcionario) {
            this.totalBonificacao += funcionario.getBonificacao(); 
        }

        public double getBonificacao() {
            return this.totalBonificacao;
        }

        private double totalBonificacao;
    }
}
