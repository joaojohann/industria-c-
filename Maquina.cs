using System;

class Maquina
{
    // Atributos
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }

    // Construtor
    public Maquina(int id, string marca, string modelo)
    {
        Id = id;
        Marca = marca;
        Modelo = modelo;
    }

    // Métodos

    public void ExibirInformacoes()
    {
        Console.WriteLine("Identificador da máquina: " + Id);
        Console.WriteLine("Marca da máquina: " + Marca);
        Console.WriteLine("Modelo da máquina: " + Modelo);
    }

    public void IniciarProducao()
    {
        Console.WriteLine("A máquina está iniciando a produção...");
    }
}
