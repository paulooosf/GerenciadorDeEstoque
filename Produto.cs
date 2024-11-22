class Produto
{
    string Nome { get; set; }
    double Preco { get; set; }
    string Descricao { get; set; }
    int Quantidade { get; set; }

    public Produto (string nome, double preco, string descricao, int quantidade)
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
}