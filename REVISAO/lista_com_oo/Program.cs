// data: 27/12/2024

Carros carro = new();
carro.marca = "Chevrolet";
carro.modelo = "Onix";
carro.ano = 2013;

// Adicionar valor na lista
Lista.Carro.Add(carro);

// Exibir valores da lista
for (int i = 0; i < Lista.Carro.Count; i++)
{
    Console.WriteLine($"Marca: {Lista.Carro[i].marca}");
    Console.WriteLine($"Modelo: {Lista.Carro[i].modelo}");
    Console.WriteLine($"Ano: {Lista.Carro[i].ano}");
    Console.WriteLine("----------------------------------------");
}
