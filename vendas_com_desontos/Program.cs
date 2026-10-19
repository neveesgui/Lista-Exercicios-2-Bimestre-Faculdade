using System.Globalization;

double total_bruto = 0;
int quantidade = 0;
double preco = 0;
string continuar = "";
do
{
    Console.Clear();
    Console.WriteLine("=-=-=-= SISTEMA DE VENDAS =-=-=-=");
    Console.Write("Nome do produto: ");
    string produto = Console.ReadLine()!;
    Console.Write("Quantidade do produto: ");
    quantidade = int.Parse(Console.ReadLine()!);
    Console.Write("Preço do produto: R$ ");
    preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);  // CultureInfo.InvariantCulture, serve para a maquina reconhecer o ponto no terminal e nao só a virgula
    total_bruto += quantidade * preco;
    Console.ReadKey();

    Console.Write("Dese adicionar outro produto? (S/N):");
    continuar = Console.ReadLine()!.Trim().ToUpper(); //aceitar maiuscula e menuscula
    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=");
    Console.ReadKey();

}
while(continuar == "S");

double desconto = (total_bruto > 1000) ? 0.15
                : (total_bruto > 500) ? 0.10
                : (total_bruto > 200) ? 0.05
                :0.0;
double valor_desconto = total_bruto * desconto;
double total = total_bruto - valor_desconto;

Console.WriteLine("=-=-=-=-= Resumo da Venda =-=-=-=-=");
Console.WriteLine($"Total Bruto: R${total_bruto:F2} ");
Console.WriteLine($"Desconto: R${valor_desconto:F2} ");
Console.WriteLine($"Total: {total:F2} ");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
