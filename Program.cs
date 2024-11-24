using System;

class Program
{
    static void Main()
    {
        Estoque estoque = new();

        // Inserindo produtos para fins de teste
        estoque.CadastrarProduto(new("CD/DVD", 12.99, "CD/DVD que pode ser reescrito", 10));
        estoque.CadastrarProduto(new("Notebook", 1780.90, "Notebook Intel Core i7", 5));

        Menu.MenuPrincipal(estoque);
    }
}
