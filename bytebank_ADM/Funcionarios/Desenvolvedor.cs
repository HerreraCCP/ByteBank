namespace bytebank_ADM.Funcionarios;

public class Desenvolvedor: Funcionario
{
    private static readonly double salarioDesenvolvedor = 3000;
    
    public Desenvolvedor(string cpf) : base(cpf, salarioDesenvolvedor) { }

    public override void AumentarSalario() => this.Salario *= 0.15;

    public override double GetBonificacao() => this.Salario * 0.1;
}