using System;

class Program
{
    static void Main()
    {
        // Criando uma indústria fictícia
        Indústria minhaIndústria = new Indústria("F2 iluminaçao", "Curitiba", 2010);
        
        // Criando duas linhas de produção
        LinhaProducao linha1 = new LinhaProducao(1, "Lampada", 100);
        LinhaProducao linha2 = new LinhaProducao(2, "Perfil", 150);
        
        // Criando duas máquinas para cada linha de produção
        Maquina maquina11 = new Maquina(1, "Seladora", "Modelo1");
        Maquina maquina12 = new Maquina(2, "Serra", "Modelo2");
        Maquina maquina21 = new Maquina(3, "Prençadeira", "Modelo3");
        Maquina maquina22 = new Maquina(4, "Ferro de solda", "Modelo4");
        
        // Definindo o tipo de produto produzido por cada máquina
        Produto produto1 = new Produto("Embalagem", 1001, 50.0m);
        Produto produto2 = new Produto("Perfil", 1002, 60.0m);
        Produto produto3 = new Produto("lampada", 1003, 70.0m);
        Produto produto4 = new Produto("Fita de led", 1004, 80.0m);

        // Adicionando máquinas às linhas de produção
        linha1.AdicionarMaquina(maquina11);
        linha1.AdicionarMaquina(maquina12);
        linha2.AdicionarMaquina(maquina21);
        linha2.AdicionarMaquina(maquina22);

        // Exibindo todas as informações
        Console.WriteLine("Informações da Indústria:");
        minhaIndústria.ExibirInformacoes();
        Console.WriteLine();

        Console.WriteLine("Detalhes da Linha de Produção 1:");
        linha1.ExibirDetalhes();
        Console.WriteLine();

        Console.WriteLine("Detalhes da Linha de Produção 2:");
        linha2.ExibirDetalhes();
        Console.WriteLine();

        Console.WriteLine("Produtos produzidos pelas máquinas:");
        maquina11.ExibirInformacoes();
        Console.WriteLine($"Tipo de Produto: {produto1.Nome}, Código: {produto1.Codigo}, Preço: {produto1.Preco}");
        Console.WriteLine();

        maquina12.ExibirInformacoes();
        Console.WriteLine($"Tipo de Produto: {produto2.Nome}, Código: {produto2.Codigo}, Preço: {produto2.Preco}");
        Console.WriteLine();

        maquina21.ExibirInformacoes();
        Console.WriteLine($"Tipo de Produto: {produto3.Nome}, Código: {produto3.Codigo}, Preço: {produto3.Preco}");
        Console.WriteLine();

        maquina22.ExibirInformacoes();
        Console.WriteLine($"Tipo de Produto: {produto4.Nome}, Código: {produto4.Codigo}, Preço: {produto4.Preco}");
    }
}
