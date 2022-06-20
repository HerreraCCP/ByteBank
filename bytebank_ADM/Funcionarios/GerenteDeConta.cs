namespace bytebank_ADM.Funcionarios;

public class GerenteDeConta : FuncionarioAutenticavel
{
    private static readonly double salarioGC = 4000;
    
    public GerenteDeConta(string cpf)  : base(cpf, salarioGC) { }

    public override double GetBonificacao() => this.Salario * 0.25;

    public override void AumentarSalario() => this.Salario *= 1.05;
}