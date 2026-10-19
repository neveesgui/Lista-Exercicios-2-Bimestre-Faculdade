int opcao = 0; //Girar o switch case
int quantidade_vendas = 0;  // contador para quantidade de vendas
double produto = 50.00; // Preço do produto em estoque
int estoque = 30; // Estoque do produto
int quantidade_desejada = 0;
string nome_produto = ""; // nome do produto registrado
double sub_total = 0;
double faturamento_total = 0;
double desconto = 0;
double total = 0;
int produtos_vendidos = 0;
int total_operacoes = 0;
string status_estoque = "";

do
{
    Console.Clear();
    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
    Console.WriteLine("SISTEMA INTEGRADO LOJA");
    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
    Console.WriteLine("[1]Registrar Produto\n[2]Realizar Venda\n[3]Faturamento\n[4]Quantidade Vendas\n[5]Relatório\n[0]Encerrar");
    Console.Write("Selecione a opção desejada: ");
    opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
        total_operacoes++;
        Console.WriteLine("=-=-=-= REGISTRO DE PRODUTO =-=-=-=");
        Console.Write("Digite o nome do produto: ");
        nome_produto = Console.ReadLine()!;
        Console.Write("Digite o valor produto: R$");
        produto = double.Parse(Console.ReadLine()!);
        Console.Write("Digite a quantidade a adicionar ao estoque: ");
        estoque += int.Parse(Console.ReadLine()!);
        Console.WriteLine("Registro Realizado com Sucesso!");
        Console.ReadKey();
        break;
   
        case 2:
        total_operacoes++;
        Console.WriteLine("=-=-=-= REGISTRO DE VENDAS =-=-=-=");
        Console.Write("Digite a quantidade desejada: ");
        quantidade_desejada = int.Parse(Console.ReadLine()!);
        if(quantidade_desejada > estoque)
            {
                Console.WriteLine("Bloqueado! Quantidade em estoque insuficiente.");
            }
        else
        {
            estoque -= quantidade_desejada;
            sub_total = produto * quantidade_desejada;
            desconto = (quantidade_desejada > 5) ? sub_total * 0.10 : 0.00;
            total = sub_total - desconto;
            faturamento_total += total;
            produtos_vendidos += quantidade_desejada;
            quantidade_vendas++;
            Console.WriteLine("Venda realizada com sucesso!");
            if(desconto > 0)
                {
                    Console.WriteLine($"Desconto de 10% aplicado: -R${desconto:F2}");
                }
                Console.WriteLine($"Total: R${total:F2}");
        }
        Console.ReadKey();
        break;

        case 3:
        total_operacoes++;
        Console.WriteLine("=-=-=-= SEU FATURAMENTO =-=-=-=");
        Console.WriteLine($"Faturamento Total atual: R${faturamento_total:F2}");
        Console.ReadKey();
        break;

        case 4:
        total_operacoes++;
        Console.WriteLine("=-=-=-= MURAL DE VENDAS =-=-=-=");
        Console.WriteLine($"Transações de vendas concluidas: {quantidade_vendas}");
        Console.WriteLine($" Total de unidades vendidas: {produtos_vendidos}");
        Console.ReadKey();
        break;

        case 5:
        total_operacoes++;
        Console.WriteLine("=-=-=-= RELÁTORIO GERAL =-=-=-=");
        status_estoque = (estoque == 0) ? "Esgotado"
                                : (estoque <= 5) ? "Estoque crítico"
                                : "Estoque regular";
        Console.WriteLine($"Faturamento total: R${faturamento_total:F2}");
        Console.WriteLine($"Quantidade total vendia: {produtos_vendidos} unidades");
        Console.WriteLine($"Estoque restante: {estoque} unidades");
        Console.WriteLine($"Transações: {total_operacoes} operações");
        Console.WriteLine($"Situação do estoque: {status_estoque}");
        Console.ReadKey();
        break;

        case 0:
        Console.WriteLine("SISTEMA ENCERRADO");
        Console.ReadKey();
        break;

        default:
        Console.WriteLine("Erro! Insira um valor válido.");
        Console.ReadKey();
        break;
    }

}
while(opcao != 0);
