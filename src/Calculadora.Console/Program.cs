//Requisito 01 
//Nossa calculadora deve ter a possibilidade de somar dois números

decimal primeiroNumerador;//camelCase
decimal segundoNumerador;// decimal

decimal ResultadoOperacao = 0;

string saida = "exit";
string operacao = "";

while (operacao != saida)
{
    Console.Clear();

    Console.WriteLine("Para fazer uma soma digite 1");
    Console.WriteLine("Para fazer uma subtracao digite 2");
    Console.WriteLine("Para fazer uma multiplicação digite 3");
    Console.WriteLine("Para fazer uma divisão digite 4");
    Console.WriteLine("Para sair, digite 'exit'");

    operacao = Console.ReadLine();

    if( operacao == saida)
    {
        //Faz sair do laço de repetição
        break;
    }

    if(Convert.ToInt16(operacao) > 4) // >= != < <= // || ou &&
    {
        Console.WriteLine("Nao reconheço essa operacao");
        continue;
    }

    Console.WriteLine("Digite o primeiro valor:");
    primeiroNumerador = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor:");
    segundoNumerador = Convert.ToDecimal(Console.ReadLine());
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
            ResultadoOperacao = primeiroNumerador / segundoNumerador;
            break;
        default:
            Console.WriteLine("Nao reconheço essa operacao");
            break;
    }
    Console.WriteLine("Resultado da operação escolhida é de :" + ResultadoOperacao);

};


//Requisito 02 
//Nossa calculadora deve ter a possibilidade de fazer várias operações de soma
//Requisito 03 
//Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração
//Requisito 04 
//Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática
//07 Nossa calculadora deve realizar as operações com números com duas casas decimais

//Nossa calculadora deve validar a opções do menu 