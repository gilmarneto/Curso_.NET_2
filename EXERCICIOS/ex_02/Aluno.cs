// data: 19/12/2024

class Aluno
{
    // Atributos
    public string? Nome {get; set;}
    public double Nota1 {get; set;}
    public double Nota2 {get; set;}

    // Método para retornar a média do aluno
    private double MediaAluno()
    {
        return (Nota1+Nota2)/2;
    }
    //Método para exibir a situação do aluno
    private string SituacaoAluno(double media) // neste caso eu vou retornar uma String e não um double, então coloco string depois de private. 
    {
        return media >= 7?"Aprovado":"Reprovado";
    }

    public void Mensagem()
    {
        double obterMedia = Math.Round(MediaAluno(), 1);
        string obterSituacao = SituacaoAluno(obterMedia);
        Console.WriteLine($"O aluno {Nome}, ficou com a média {obterMedia} e foi {obterSituacao}.");
    }
}
