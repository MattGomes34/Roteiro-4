class Pessoa
{
    public string Nome { get; set; } = "";
}

class Casa
{
   
    private Pessoa morador;

    public Casa(Pessoa morador)
    {
        this.morador = morador;
    }

    public void ExibirMorador()
    {
        Console.WriteLine($"O morador da casa é: {morador.Nome}");
    }
}

class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "Maria";

        Casa casa = new Casa(pessoa);   

        casa.ExibirMorador();
    }
}