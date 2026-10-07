class Veiculo
{
    public string Marca { get; set; } = "";
    public string Modelo { get; set; } = "";
    public int NumeroDeRodas { get; set; }

    public virtual void ExibirDados()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Número de rodas: {NumeroDeRodas}");
    }
}

class Carro : Veiculo
{
    public int NumeroDePortas { get; set; }

    public override void ExibirDados()
    {
        base.ExibirDados();   // reaproveita a exibição da classe pai
        Console.WriteLine($"Número de portas: {NumeroDePortas}");
    }
}

class Moto : Veiculo
{
    public bool PossuiBagageiro { get; set; }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Possui bagageiro: {(PossuiBagageiro ? "Sim" : "Não")}");
    }
}

class Program
{
    static void Main()
    {
        Carro carro = new Carro();
        carro.Marca = "Toyota";          
        carro.Modelo = "Corolla";
        carro.NumeroDeRodas = 4;
        carro.NumeroDePortas = 4;      

        Moto moto = new Moto();
        moto.Marca = "Honda";
        moto.Modelo = "CG 160";
        moto.NumeroDeRodas = 2;
        moto.PossuiBagageiro = true;    

        Console.WriteLine("--- Carro ---");
        carro.ExibirDados();

        Console.WriteLine();
        Console.WriteLine("--- Moto ---");
        moto.ExibirDados();
    }
}