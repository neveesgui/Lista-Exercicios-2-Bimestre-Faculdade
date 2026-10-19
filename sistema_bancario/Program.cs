double saldo = 0;
int operacoes = 0;
int opcao = 0;
double deposito = 0;
double saque = 0;
double transferir;
double taxa = 0;
double total_debito = 0;

do
{
    Console.Clear();
    Console.WriteLine(" =-=-=-=-=-= SISTEMA BANCÁRIO =-=-=-=-=-=");
    Console.WriteLine("[1]Depositar\n[2]Sacar\n[3]Transferir\n[4]Saldo\n[5]Operaçoes\n[0]Encerrar");
    Console.Write("Selecione a opção desejada: ");
    opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
        Console.Write("Digite o valor do Deposito: R$");
         deposito = double.Parse(Console.ReadLine()!);
        if(deposito > 0){
            saldo += deposito ;
            operacoes++;
            Console.WriteLine("Depósito realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Valor inválido");
        }
        Console.ReadKey();
        break;

        case 2:
            Console.Write("Digite o valor do saque: R$");
            saque= double.Parse(Console.ReadLine()!);
            if (saque > 0 && saque <= saldo){
            saldo -= saque;;
            operacoes++;
            Console.WriteLine("Saque Realizado com sucesso!");
            }
            else
                {
                    Console.WriteLine("Opção Bloqueada: Saldo insuficiente ou Valor inválido.");
                }
        Console.ReadKey();
        break;

        case 3:
            Console.Write("Digite o valor para transferência: R$");
            transferir = double.Parse(Console.ReadLine()!);
            taxa = (transferir > 500) ? 5.0 : 0.0;
            total_debito = transferir + taxa;

        if(transferir > 0 && total_debito <= saldo){
            saldo -= total_debito;
            operacoes++;
                if (taxa > 0)
                {
                    Console.WriteLine($"Transferência Realizada!\nTaxa aplicada: R${taxa:F2}.\nTotal debitado {total_debito:F2}");
                }
                else
                {
                    Console.WriteLine($"Transferência de R${transferir:F2} realizada com sucesso!");
                }
            
        }
        else
        {
            Console.WriteLine("Bloqueado! Saldo Insuficente para cobrir a taxa.");
         }
        Console.ReadKey();
        break;

        case 4:
        Console.WriteLine("=-=-=-= SALDO EM CONTA =-=-=-=");
        Console.WriteLine($"Saldo atual: R${saldo:F2}");
        Console.ReadKey();
        break;

        case 5:
        Console.WriteLine("=-=-=-= Resumo das Operações =-=-=-=");
        Console.WriteLine($"Quantidade de Operações: {operacoes}");
        Console.ReadKey();
        break;

        case 0:
        Console.WriteLine("saiu do sistema!");
        Console.ReadKey();
        break;

        default:
        Console.WriteLine("Erro! Tente novamente");
        Console.ReadKey();
        break;
    }

}
while(operacoes != 0);
