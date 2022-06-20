namespace bytebank_ADM.Funcionarios;

public class Auxiliar : Funcionario
{
    private static readonly double salarioDiretor = 3000;
    
    public Auxiliar(string cpf) : base(cpf: cpf, salarioDiretor) { }
    public override double GetBonificacao() =>  Salario * 0.2;

    public override void AumentarSalario() => this.Salario *= 1.1;
}