Console.WriteLine("=-=-=-=-=-==-=-=-=");
Console.WriteLine("Caixa Eletrônico");
Console.WriteLine("[1]Sacar\n[2]Depositar");
Console.WriteLine("=-=-=-=-=-==-=-=-=");

double saldo = 1000;
Console.WriteLine("Saldo atual: R${0:F2}", saldo);
Console.WriteLine("=-=-=-=-=-==-=-=-=");

Console.Write("Selecione a operação desejada: ");
int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.Write("Digite o valor que você deseja sacar: R$");
        double saque = double.Parse(Console.ReadLine());
        double novoSaldo_saque = saldo - saque;
        Console.WriteLine("Novo saldo: R${0:F2}", novoSaldo_saque);
        break;
    case 2:
        Console.Write("Digite o valor que você deseja depositar: R$");
        double deposito = double.Parse(Console.ReadLine());
        double novoSaldo_deposito = saldo + deposito;
        Console.WriteLine("Novo saldo: R${0:F2}", novoSaldo_deposito);
        break;
    default:
        Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
        break;
}
Console.WriteLine("=-=-=-=-=-==-=-=-=");