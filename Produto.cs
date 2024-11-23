class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public string Descricao { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nome, double preco, string descricao, int quantidade)
    {
        this.Nome = nome;
        this.Preco = preco;
        this.Descricao = descricao;
        this.Quantidade = quantidade;
    }

    public void AdicionarQuantidade(int numero)
    {
        if (numero <= 0)
        {
            throw new ArgumentNullException("Defina uma quantidade correta!");
        }
        this.Quantidade += numero;
    }

    public void RemoverQuantidade(int numero)
    {
        if (numero <= 0)
        {
            throw new ArgumentNullException("Defina uma quantidade correta!");
        }
        this.Quantidade -= numero;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"\nProduto: {Nome}:");
        Console.WriteLine($"Preço: {Preco}");
        Console.WriteLine($"Descrição: {Descricao}");
        Console.WriteLine($"Quantidade: {Quantidade}");
    }
}