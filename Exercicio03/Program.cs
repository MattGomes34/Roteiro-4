interface IVeiculo
{
    void Mover();
}

class Carro : IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("O carro esta em movimento");
    }
}

class Bicicleta : IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("A bicicleta está em movimento");
    }
}

class Program
{
    static void Main()
    {
        Carro carro = new Carro();
        Bicicleta bicicleta = new Bicicleta();

        carro.Mover();
        bicicleta.Mover();
    }
}