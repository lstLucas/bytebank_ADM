﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar:Funcionario
    {
        public Auxiliar(string cpf):base(cpf,2000)
        { }

        public override void aumentarSalario()
        {
            Salario *= 1.1;
        }
        public override double getBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
