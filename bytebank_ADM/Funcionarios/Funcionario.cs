namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public Funcionario(string cpf, double salario)
        {
            Salario = salario;
            Cpf = cpf; 
            TotalDeFuncionarios++;
        }
        
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }

        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
    }
}
