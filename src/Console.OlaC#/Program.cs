namespace OlaC_;

internal class Program
{
    static void Main(string[] args)
    {
        string nome = "George";
        char primeiraLetraDoNome = 'A';
        int idade = 36;
        bool tenhoPet = true;
        decimal quantoTenhoNaCarteira = 0.75m;

        Console.WriteLine("Hello, World!");

        Console.WriteLine($"Sou o {nome} tenho a primeira letra {primeiraLetraDoNome} com idade {idade} e possuou pet {tenhoPet} com dinheiro na carteira {quantoTenhoNaCarteira}");
    }
}
