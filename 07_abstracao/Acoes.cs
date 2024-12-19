// data: 17//2024

// para criar uma classe abstrata usamos o abstract
abstract class Acoes
{
    // Métodos criados
    public abstract void Falar();
    public abstract void Andar();

    // Métodos opcionais
    public void Pular()
    {
        Console.WriteLine("Estou pulando.");
    }
}