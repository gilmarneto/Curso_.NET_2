// data: 06/12/2024

// Vamos ver 3 exemplos de objetos
//Ex: 01
// Pessoa obj1 = new Pessoa();
// obj1.Nome = "Gilmar";
// obj1.Idade = 40;
// obj1.Apresentacao();

// Ex: 02
// Pessoa obj2 = new();
// obj2.Nome = "Andreia";
// obj2.Idade = 43;
// obj2.Apresentacao();

// Ex: 03
Pessoa obj3 = new()
{
    Nome = "Kelwin",
    Idade = 15
};
string retorno = obj3.VerificaIdade();
obj3.Apresentacao();
Console.WriteLine(retorno);
