class Menu
{
    public static void MenuPrincipal()
    {
        Console.WriteLine("============================================");
        Console.WriteLine("Bem vindo ao gerenciamento de estoque!");
        Console.WriteLine("Selecione uma opção:");
        Console.WriteLine("1 - Visualizar produtos no estoque");
        Console.WriteLine("2 - Adicionar um ou mais produtos no estoque");
        Console.WriteLine("3 - Remover um ou mais produtos no estoque");
        Console.WriteLine("4 - Cadastrar novo produto");
        Console.WriteLine("5 - Sair do sistema");
        Console.WriteLine("============================================");
        Console.Write("Digite sua opção: ");
        int opcao = int.Parse(Console.ReadLine());

        switch(opcao)
        {
            case 1: 
                //Estoque.ListarProdutos();
                break;
            case 2: 
                //MenuAdicionar();
                break;
            case 3: 
                //MenuRemover();
                break;
            case 4: 
                //MenuCadastro():
                break;
            case 5:
                Console.WriteLine("\nAté a próxima!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("\nDigite uma opção válida!");
                MenuPrincipal();
                break;
        }
    }
}