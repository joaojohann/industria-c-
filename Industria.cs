using System;
using System.Collections.Generic;

class Indústria
{
    // Atributos
    public string Nome { get; set; }
    public string Localização { get; set; }
    public int AnoFundacao { get; set; }
    private List<LinhaProducao> linhasProducao;

    // Construtor
    public Indústria(string nome, string localizacao, int anoFundacao)
    {
        Nome = nome;
        Localização = localizacao;
        AnoFundacao = anoFundacao;
        linhasProducao = new List<LinhaProducao>();
    }

    // Métodos

    public void ExibirInformacoes()
    {
        Console.WriteLine("Nome da indústria: " + Nome);
        Console.WriteLine("Localização: " + Localização);
        Console.WriteLine("Ano de Fundação: " + AnoFundacao);
    }

    public void AdicionarLinhaProducao(LinhaProducao linhaProducao)
    {
        linhasProducao.Add(linhaProducao);
    }
}




