// data: 19/12/2024

class Pessoa
{
    // Atributos privados
    private string? _nome;
    private int _idade;
    private string? _cidade;

    // Método construtor
    public Pessoa(string nome, int idade, string cidade)
    {
        _nome = nome;
        _idade = idade;
        _cidade = cidade;
        // Exibir a mensagem do método
        Console.WriteLine(Mensagem());
    }

    // Método que irá retornar uma mensagem
    private string Mensagem()
    {
        return $"O {_nome} tem {_idade} anos e mora na cidade de {_cidade}.";
    }
}