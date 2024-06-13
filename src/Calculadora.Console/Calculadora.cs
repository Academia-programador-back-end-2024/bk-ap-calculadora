
namespace Operacao.Matematica;

public class Calculadora
{
    const string saida = "exit";

    private decimal primeiroNumerador;

    public decimal PrimeiroNumerador
    {
        get
        {
            return primeiroNumerador;
        }
        set
        {
            primeiroNumerador = value;
        }
    }


    public decimal SegundoNumerador { get; set; }
    public decimal ResultadoOperacao { get; set; }

    public string Operacao { get; set; } = string.Empty;

    public void MenuDeOpcoes()
    {
        Console.Clear();//Limpar a tela
        Console.WriteLine(@"
            Para fazer uma soma digite 1 \r\n
            Para fazer uma subtração digite 2\r\n
            Para fazer uma multiplicação digite 3\r\n
            Para fazer uma divisão digite 4\r\n\r\n
            Para sair, digite 'exit'");

        Operacao = Console.ReadLine();
        Operacao = Operacao == null ? string.Empty : Operacao.Trim();
    }

    public bool DevoContinuar()
    {

        MenuDeOpcoes();//Função para verificar as opções

        return ValidarOpcaoMenu();
    }

    // Função para validar se a entrada do usuário é um número de 1 a 4
    public bool ValidarOpcaoMenu()
    {
        int numero;
        if (int.TryParse(Operacao, out numero))
        {
            if (numero >= 1 && numero <= 4)
            {
                return true;
            }
        }
        if (Operacao == saida)//Verificar se deve encerrar
        {
            return false;//Parar repetição
        }
        Console.WriteLine("Opção inválida. Por favor, escolha uma opção de 1 a 4.");
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
        return false;
    }

    public decimal LerValor()
    {
        Console.WriteLine("Digite um valor:");
        var valor = Convert.ToDecimal(Console.ReadLine());
        return valor;
    }

    public void RealizarOperacaoMatematica()
    {
        switch (Operacao)
        {
            case "1"://Somar
                ResultadoOperacao = Somar();
                break;
            case "2"://Subtração
                ResultadoOperacao = primeiroNumerador - SegundoNumerador;
                break;
            case "3"://Multiplicação
                ResultadoOperacao = primeiroNumerador * SegundoNumerador;
                break;
            case "4"://Divisão                 
                //VerificarZero(SegundoNumerador);
                ResultadoOperacao = PrimeiroNumerador / SegundoNumerador;
                break;
            default:
                Console.WriteLine("Não reconheço essa operação");
                ResultadoOperacao = 0;
                break;
        }
    }

    private decimal VerificarZero(decimal numerador)
    {
        do
        {
            if (numerador == 0)
            {
                Console.WriteLine("Não é possível dividir por zero. Escolha outro!");
                numerador = LerValor();
            }
        } while (numerador == 0);
        return numerador;
    }

    private decimal Somar()
    {
        return PrimeiroNumerador + SegundoNumerador;
    }

    public void ImprimirResultado()
    {
        Console.WriteLine("Resultado da operação escolhida é de : " + ResultadoOperacao);
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}
