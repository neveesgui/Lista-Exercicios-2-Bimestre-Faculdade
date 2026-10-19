int opcao = 0;
int estoque = 50;
int totalVendas = 0;

do
{
    Console.Clear();
Console.WriteLine("=-=-=-=-=-==-=-=-=");
Console.WriteLine("Controle de Estoque");
Console.WriteLine("=-=-=-=-=-==-=-=-=");
Console.WriteLine("[1]Realizar Venda\n[2]Adicionar Estoque\n[3]Consultar Estoque\n[4]Gerar Relatório\n[5]Sair");
Console.WriteLine("=-=-=-=-=-==-=-=-=");
Console.Write("Digite a opção desejada: ");
opcao = int.Parse(Console.ReadLine()!);
int quantidade = 0;

    switch (opcao)
    {
        case 1:
            Console.WriteLine("=-=-=-Realizar Venda=-=-=-=");
            Console.Write("Digite a quantidade de produtos a serem vendidos: ");
            quantidade = int.Parse(Console.ReadLine()!);
            if (quantidade > estoque)
            {
                Console.WriteLine("Quantidade indisponível em estoque");
                Console.ReadKey();
            }
            else
            {
                estoque -= quantidade;
                totalVendas += quantidade;
                Console.WriteLine($"Venda realizada com sucesso! Estoque atual: {estoque}");
                Console.ReadKey();
            }
            break;
        case 2:
            Console.WriteLine("=-=-=-Adicionar Estoque=-=-=-=");
            Console.Write("Digite a quantidade de produtos a serem adicionados: ");
            quantidade = int.Parse(Console.ReadLine()!);
            estoque += quantidade;
            Console.WriteLine($"Estoque atualizado com sucesso! Estoque atual: {estoque}");
            Console.ReadKey();
            break;
        case 3:
            Console.WriteLine("=-=-=-Consultar Estoque=-=-=-=");
            string consulta = (estoque <= 10) ? "Estoque baixo" : "Estoque normal";
            string nomeProduto = Console.ReadLine()!;
            Console.WriteLine($"{consulta} {nomeProduto}: {estoque}");
            Console.WriteLine($"A quantidade de produtos em estoque é: {estoque}");
            Console.ReadKey();
            break;
        case 4:
            Console.WriteLine("=-=-=-Relatória Geral=-=-=-=");
            string relatorio = (estoque <= 10) ? "Estoque baixo" : "Estoque normal";
            string nomeProdutoRelatorio = Console.ReadLine()!;
            Console.WriteLine($"{relatorio} {nomeProdutoRelatorio}: {estoque} produtos");
            Console.WriteLine($"Total de vendas: {totalVendas} produtos");
            Console.ReadKey();
            break;
        case 5:
            Console.WriteLine("Saindo do sistema...");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Opção inválida");
            Console.ReadKey();
            break;
    }
} while (opcao != 5);
Console.Clear();
Console.WriteLine("Programa encerrado.");
