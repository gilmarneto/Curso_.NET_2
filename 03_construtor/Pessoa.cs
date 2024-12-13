// data: 11/12/2024

class Pessoa
{
    // Construtor 1
    public Pessoa()
    {
        Console.WriteLine("Olá!!");
    }

    // Construtor 2
    public Pessoa(string nome)
    {
        Console.WriteLine($"Olá {nome}");
    }

    // Construtor 3
    public Pessoa(string nome, int idade)
    {
        Console.WriteLine($"Olá {nome}, sua idade é {idade} anos.");
    }
}