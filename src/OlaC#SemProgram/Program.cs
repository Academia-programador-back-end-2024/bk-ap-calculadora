string nome;
char primeiraLetraDoNome;
int idade;
bool tenhoPet;
decimal quantoTenhoNaCarteira;

Console.WriteLine("Qual o seu nome ? ");
nome = Console.ReadLine();

Console.WriteLine("Qual sua idade ? ");
idade = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Você tem pet (0/1)?");
tenhoPet = Convert.ToBoolean(Console.ReadLine());

primeiraLetraDoNome = nome[0];

Console.WriteLine("Quanto você tem na carteira?");
quantoTenhoNaCarteira = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Sou o {nome} tenho a primeira letra {primeiraLetraDoNome} com idade {idade} e possuou pet {tenhoPet} com dinheiro na carteira {quantoTenhoNaCarteira}");

Console.ReadKey();