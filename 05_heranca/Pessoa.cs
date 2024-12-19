// data: 13/12/2024 e 16/12/2024

class Pessoa
{
    // Exemplo da aula de Herança
    // protected string? Nome;
    // protected int Idade;

    // Exemplo da aula de Base
    private string? _nome;
    private int _idade;

    // Método construtor, referente a aula de Base
    public Pessoa(string nome, int idade)
    {
        _nome = nome;
        _idade = idade;
    }

    protected void ApresentarPessoa()
    {
        // Console.WriteLine($"Nome: {Nome}");
        // Console.WriteLine($"Idade: {Idade}");

        Console.WriteLine($"Nome: {_nome}");
        Console.WriteLine($"Idade: {_idade}");
    }
}