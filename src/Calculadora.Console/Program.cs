using Operacao.Matematica;

Calculadora calculadora = new Calculadora();

while (calculadora.DevoContinuar())//Laço de repetição
{
    calculadora.PrimeiroNumerador = calculadora.LerValor();
    calculadora.SegundoNumerador = calculadora.LerValor();
    calculadora.RealizarOperacaoMatematica();
    calculadora.ImprimirResultado();
}
