// data: 18/12/2024
class Produto
{
    public string? Nome;
    public double Valor;
    public string? Pagamento;
    public double Desconto;

    public void ExibirProduto()
    {
        if(Pagamento == "aVista")
        {
            Desconto = Valor * (10.0 / 100);
            Console.WriteLine($"Produto: {Nome} ----- Forma de pagamento: à vista ----- Valor total com 10% de desconto: R$ {(Valor-Desconto).ToString("F2")}");
        }
        else
        {
            Console.WriteLine($"Produto: {Nome} ----- Forma de pagamento: à prazo ----- Valor sem desconto: R$ {Valor.ToString("F2")}");
        }
    }
}