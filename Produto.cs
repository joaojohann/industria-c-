using System;

class Produto
{
    // Atributos
    public string Nome { get; set; }
    public int Codigo { get; set; }
    public decimal Preco { get; private set; }

    // Construtor
    public Produto(string nome, int codigo, decimal preco)
    {
        Nome = nome;
        Codigo = codigo;
        Preco = preco;
    }

    // Métodos
    public void ExibirDetalhes()
    {
        Console.WriteLine("Nome do produto: " + Nome);
        Console.WriteLine("Código do produto: " + Codigo);
        Console.WriteLine("Preço do produto: " + Preco);
    }

    public void AtualizarPreco(decimal novoPreco)
    {
        Preco = novoPreco;
        Console.WriteLine("Preço do produto atualizado para: " + Preco);
    }
}
