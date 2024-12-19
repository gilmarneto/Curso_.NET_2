// data: 19/12/2024

class Media
{
    // Construtor 1
    public Media(double n1, double n2)
    {
        Console.WriteLine($"{Math.Round((n1 + n2) / 2, 1)}");
    }
    // Construtor 2
    public Media(double n1, double n2, double n3)
    {
        Console.WriteLine($"{Math.Round((n1 + n2 + n3) / 3, 1)}");
    }
}