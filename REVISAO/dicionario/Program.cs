// data: 10/12/2024

// Dicionario: key = nome / value = idade
Dictionary<string, int> alunos = new Dictionary<string, int>();
// adicionar valor ao dicionário
alunos.Add("Gilmar", 40);
alunos.Add("Andreia", 43);
alunos.Add("Kelwin", 15);
// exibir valores do dicionario(exibi a chave e o valor juntos)
foreach(var aluno in alunos)
{
    Console.WriteLine(aluno.ToString());
}
// exibir valores do dicionario(exibi a chave e o valor separados)
foreach(var aluno in alunos)
{
    Console.WriteLine($"Nome: {aluno.Key} ----- Idade: {aluno.Value}");
}
// alterar o valor da idade conforme nome selecionado
alunos["Andreia"] = 42;
// exibir valores do dicionario(exibi a chave e o valor separados)
foreach(var aluno in alunos)
{
    Console.WriteLine($"Nome: {aluno.Key} ----- Idade: {aluno.Value}");
}
// remover valor do dicionário conforme nome selecionado
alunos.Remove("Kelwin");
// exibir valores do dicionario(exibi a chave e o valor separados)
foreach(var aluno in alunos)
{
    Console.WriteLine($"Nome: {aluno.Key} ----- Idade: {aluno.Value}");
}