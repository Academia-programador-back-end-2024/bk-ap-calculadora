decimal primeiroNumerador;
decimal segundoNumerador;
decimal ResultadoOperacao;
const string saida = "exit";
string operacao = string.Empty;

while (operacao != saida)//Laço de repetição
{
    MenuDeOpcoes(ref operacao);//Função para verificar as opções

    if (!ValidarOpcaoMenu(operacao))//Verificar se a opção é valida
    {
        continue;//Pular código posterior e voltar ao menu
    }

    if (operacao == saida)//Verificar se deve encerrar
    {
        break;//Parar repetição
    }
    primeiroNumerador = LerValor();//Função para ler valor
    segundoNumerador = LerValor();//Função para ler valor
    
    //Função para realizar operação matematica
    RealizarOperacaoMatematica(
        primeiroNumerador, 
        segundoNumerador,
        out ResultadoOperacao,// Aqui o out obriga a ter alteração na função
        operacao);

    ImprimirResultado(ResultadoOperacao);
}

static void MenuDeOpcoes(ref string operacao)
{
    Console.Clear();//Limpar a tela
    Console.WriteLine(@"
            Para fazer uma soma digite 1 \r\n
            Para fazer uma subtração digite 2\r\n
            Para fazer uma multiplicação digite 3\r\n
            Para fazer uma divisão digite 4\r\n\r\n
            Para sair, digite 'exit'");

    operacao = Console.ReadLine();
    operacao = operacao == null ? string.Empty : operacao.Trim();
}


// Função para validar se a entrada do usuário é um número de 1 a 4
static bool ValidarOpcaoMenu(string opcao)
{
    int numero;
    if (int.TryParse(opcao, out numero))
    {
        if (numero >= 1 && numero <= 4)
        {
            return true;
        }
    }
    Console.WriteLine("Opção inválida. Por favor, escolha uma opção de 1 a 4.");
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
    return false;
}

static decimal LerValor()
{
    Console.WriteLine("Digite um valor:");
    var valor = Convert.ToDecimal(Console.ReadLine());
    return valor;
}

// Verificar se o segundo número é zero para evitar divisão por zero
static decimal VerificarZero(decimal segundoNumerador)
{
    do
    {
        if (segundoNumerador == 0)
        {
            Console.WriteLine("Não é possível dividir por zero. Escolha outro!");
            segundoNumerador = LerValor();
        }
    } while (segundoNumerador == 0);
    return segundoNumerador;
}

static void RealizarOperacaoMatematica(
    decimal primeiroNumerador, 
    decimal segundoNumerador,
    out decimal ResultadoOperacao,
    string operacao)
{
    switch (operacao)
    {
        case "1"://Somar
            ResultadoOperacao = primeiroNumerador + segundoNumerador;
            break;
        case "2"://Subtração
            ResultadoOperacao = primeiroNumerador - segundoNumerador;
            break;
        case "3"://Multiplicação
            ResultadoOperacao = primeiroNumerador * segundoNumerador;
            break;
        case "4"://Divisão                 
            segundoNumerador = VerificarZero(segundoNumerador);
            ResultadoOperacao = primeiroNumerador / segundoNumerador;
            break;
        default:
            Console.WriteLine("Não reconheço essa operação");
            ResultadoOperacao = 0;
            break;
    }
}

static void ImprimirResultado(decimal ResultadoOperacao)
{
    Console.WriteLine("Resultado da operação escolhida é de : " + ResultadoOperacao);
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
}

//KISS Keep it simple stupid
