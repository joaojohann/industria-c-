using System;
using System.Collections.Generic;

class LinhaProducao
{
    // Atributos
    public int Numero { get; set; }
    public string Tipo { get; set; }
    public int Capacidade { get; set; }
    private List<Maquina> maquinas;

    // Construtor
    public LinhaProducao(int numero, string tipo, int capacidade)
    {
        Numero = numero;
        Tipo = tipo;
        Capacidade = capacidade;
        maquinas = new List<Maquina>();
    }

    // Métodos

    public void ExibirDetalhes()
    {
        Console.WriteLine("Número da linha de produção: " + Numero);
        Console.WriteLine("Tipo de produto fabricado: " + Tipo);
        Console.WriteLine("Capacidade de produção (produtos por hora): " + Capacidade);
    }
    public void AdicionarMaquina(Maquina maquina)
    {
        maquinas.Add(maquina);
    }
}


