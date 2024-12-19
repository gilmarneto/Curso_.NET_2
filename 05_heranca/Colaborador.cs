// data: 13/12/2024 e 16/12/2024

class Colaborador : Pessoa
{
    // atributos privados
    private string? _cargo;
    private double _salario;

    // Para carregar os atributos com os valores e chamar os métodos, vamos criar um método construtor
    public Colaborador(string nome, int idade, string cargo, double salario) : base(nome, idade)
    {
        // No caso não precisamos do nome e nem idade, os besmes estão no contrutor da classe Pessoa
        // Nome = nome;
        // Idade = idade;
        _cargo = cargo;
        _salario = salario;   

        ApresentarPessoa();
        ApresentarColaborador();
    }

    // Método para apresentar os dados do colaborador
    private void ApresentarColaborador()
    {
        Console.WriteLine($"Cargo: {_cargo}");
        Console.WriteLine($"Salário: {_salario}");
    }
}