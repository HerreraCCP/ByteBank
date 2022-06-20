using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Utilitario;

public class ParceiroComercial: IAutenticavel
{
    public string Senha { get; set; }
    public bool Autenticar(string senha) => Senha == senha;
}