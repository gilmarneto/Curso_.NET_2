// data: 10/12/2024
// criando um dicionário com chave e lista
Dictionary<string, List<int>> medias = new Dictionary<string, List<int>>();
// para adicionar uma nova chave e valores na lista
medias.Add("Gilmar", new List<int> {6});
medias.Add("Andreia", new List<int> {8});
medias.Add("Kelwin", new List<int> {9});
// para adicionar valores na lista com uma chave já criada
medias["Gilmar"].Add(5);
medias["Gilmar"].Add(7);
medias["Gilmar"].Add(10);
// exibir valores
foreach(var media in medias)
{
    Console.WriteLine($"Aluno: {media.Key}");
    Console.WriteLine("Notas do aluno: " + string.Join(", ", media.Value));
}
