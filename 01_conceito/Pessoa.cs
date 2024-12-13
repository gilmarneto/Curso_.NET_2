// data: 06/12/2024

// Classe
class Pessoa
{
    // Atributos
    public string? Nome;
    public int Idade;

    // Método de apresentação (Sem Retorno)
    public void Apresentacao()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}");
    }

    // // Método que verifica idade, se é maior ou menor de 18 anos (Com Retorno)
    public string VerificaIdade()
    {
        return Idade >= 18 ? "Sou maior de idade":"Sou menor de idade";
    }
}