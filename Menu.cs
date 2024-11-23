using System.ComponentModel.DataAnnotations;

class Menu
{
    public static void MenuPrincipal(Estoque estoque)
    {
        Console.WriteLine("\n============================================");
        Console.WriteLine("Bem vindo ao gerenciamento de estoque!");
        Console.WriteLine("Selecione uma opção:");
        Console.WriteLine("1 - Visualizar produtos no estoque");
        Console.WriteLine("2 - Adicionar estoque de produtos");
        Console.WriteLine("3 - Remover estoque de produtos");
        Console.WriteLine("4 - Cadastrar novo produto");
        Console.WriteLine("5 - Sair do sistema");
        Console.WriteLine("============================================");
        Console.Write("Digite sua opção: ");
        int opcao = int.Parse(Console.ReadLine());

        switch(opcao)
        {
            case 1: 
                estoque.ListarProdutos();
                MenuPrincipal(estoque);
                break;
            case 2: 
                MenuAdicionar(estoque);
                break;
            case 3: 
                MenuRemover(estoque);
                break;
            case 4:
                MenuCadastro(estoque);
                break;
            case 5:
                Console.WriteLine("\nAté a próxima!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("\nDigite uma opção válida!");
                MenuPrincipal(estoque);
                break;
        }
    }

    public static void MenuAdicionar(Estoque estoque)
    {
        Console.WriteLine("\n======================");
        Console.WriteLine("Produtos disponíveis: ");
        estoque.ListarProdutos();
        Console.Write("\nQual produto você deseja adicionar? ");
        var nome = Console.ReadLine();

        var produto = estoque.ListaProdutos.FirstOrDefault(p => p.Nome == nome);

        if (produto != null)
        {
            Console.Write("\nQual a quantidade que você deseja adicionar? ");
            int quantidade = int.Parse(Console.ReadLine());
            if (quantidade <= 0)
            {
                Console.WriteLine("Digite uma quantidade válida!");
                MenuAdicionar(estoque);
            }
            else
            {
                produto.AdicionarQuantidade(quantidade);
                Console.WriteLine($"Você adicionou {quantidade} produtos do tipo {produto.Nome}!");
                MenuPrincipal(estoque);
            }
        }
        else
        {
            Console.WriteLine("Produto não encontrado!");
            MenuAdicionar(estoque);
        }
    }

    public static void MenuRemover(Estoque estoque)
    {
        Console.WriteLine("\n======================");
        Console.WriteLine("Produtos disponíveis: ");
        estoque.ListarProdutos();
        Console.Write("\nQual produto você deseja remover? ");
        var nome = Console.ReadLine();

        var produto = estoque.ListaProdutos.FirstOrDefault(p => p.Nome == nome);

        if (produto != null)
        {
            Console.Write("\nQual a quantidade que você deseja remover? ");
            int quantidade = int.Parse(Console.ReadLine());
            if (quantidade <= 0)
            {
                Console.WriteLine("Digite uma quantidade válida!");
                MenuAdicionar(estoque);
            }
            else
            {
                produto.RemoverQuantidade(quantidade);
                Console.WriteLine($"\nVocê removeu {quantidade} produtos do tipo {produto.Nome}!");
                MenuPrincipal(estoque);
            }
        }
        else
        {
            Console.WriteLine("Produto não encontrado!");
            MenuAdicionar(estoque);
        }
    }

    public static void MenuCadastro(Estoque estoque)
    {
        Console.WriteLine("\n========================");
        Console.WriteLine("Cadastro de produtos");
        Console.Write("Digite o nome do produto: ");
        var nome = Console.ReadLine();
        Console.Write("\nDigite o preço do produto: ");
        var preco = double.Parse(Console.ReadLine());
        Console.Write("\nDigite uma descrição para o produto: ");
        var descricao = Console.ReadLine();
        Console.Write("\nVocê deseja incluir uma quantidade do produto? (S/N) ");
        var opcao = Console.ReadLine();
        var quantidade = 0;
        if (opcao == "S" || opcao == "s")
        {
            Console.Write("\nDigite a quantidade do produto: ");
            quantidade = int.Parse(Console.ReadLine());
        }

        var produto = new Produto(nome, preco, descricao, quantidade);
        estoque.ListaProdutos.Add(produto);

        Console.WriteLine("\nProduto cadastrado! Listando informações:");
        produto.ExibirInformacoes();

        MenuPrincipal(estoque);
    }
}