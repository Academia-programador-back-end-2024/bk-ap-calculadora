//Requisito 01 
//Nossa calculadora deve ter a possibilidade de somar dois números

int primeiroNumerador;//camelCase
int segundoNumerador;

int SubtracaoNumeros;//PascalCase
int SomaNumeros;//PascalCase

string saida = "exit";
string operacao;
do
{
    Console.WriteLine("Digite o primeiro valor:");
    primeiroNumerador = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor:");
    segundoNumerador = Convert.ToInt16(Console.ReadLine());


    Console.WriteLine("Deseja fazer uma soma? (add)");
    Console.WriteLine("Deseja fazer uma subtracao? (sub)");
    Console.WriteLine("Para sair, digite 'exit'");

    operacao = Console.ReadLine();


    if (operacao == "add")
    {
        SomaNumeros = primeiroNumerador + segundoNumerador;
        Console.WriteLine("Soma dos valores :" + SomaNumeros);
    }
    else if (operacao == "sub")
    {
        SubtracaoNumeros = primeiroNumerador - segundoNumerador;
        Console.WriteLine("Subtração dos valores :" + SubtracaoNumeros);
    }
    else
    {
        Console.WriteLine("Nao reconheço essa operacao");
    }
} while (operacao != saida);


//Requisito 02 
//Nossa calculadora deve ter a possibilidade de fazer várias operações de soma
//Requisito 03 
//Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração
