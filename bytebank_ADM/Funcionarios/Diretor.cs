using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        private static readonly double salarioDiretor = 5000;
        
        public Diretor(string cpf) : base(cpf: cpf, salarioDiretor) { }
        public override double GetBonificacao() => Salario * 0.5;

        public override void AumentarSalario() => this.Salario *= 1.15;
    }
}
