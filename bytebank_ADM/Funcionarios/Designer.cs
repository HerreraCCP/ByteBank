namespace bytebank_ADM.Funcionarios;

public class Designer : Funcionario
{
    private static readonly double salarioDiretor = 3000;
    
    public Designer(string cpf) : base(cpf: cpf, salarioDiretor) { }
    public override double GetBonificacao() => Salario * 0.17;

    public override void AumentarSalario() => this.Salario *= 1.11;
}