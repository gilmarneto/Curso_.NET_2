// data: 10/12/2024

List<double> minhaLista = new List<double>();

minhaLista.Add(5.5);
minhaLista.Add(7.2);
minhaLista.Add(9.0);
minhaLista.Add(1.3);
// exibir valor na posição 1
Console.WriteLine(minhaLista[1]);
// ver a quantidade de valores na lista
Console.WriteLine(minhaLista.Count);
// somando todos os valores da lista, exemplo 1
Console.WriteLine(minhaLista.Sum());
Console.WriteLine("--------------------------------");
// somando todos os valores da lista, exemplo 2
double soma = 0;
for (int i = 0; i < minhaLista.Count; i++)
{
    soma += minhaLista[i]; 
}
Console.WriteLine(soma);

