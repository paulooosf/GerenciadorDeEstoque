class Estoque
{
    public List<Produto>? ListaProdutos { get; set; }

    public Estoque()
    {
        ListaProdutos = new List<Produto>();
    }

    public void ListarProdutos()
    {
        if (ListaProdutos.Count == 0)
        {
            Console.WriteLine("\nNenhum produto cadastrado até o momento!");
        }
        else
        {
            foreach (var produto in ListaProdutos)
            {
                produto.ExibirInformacoes();
            }
        }
    }
}