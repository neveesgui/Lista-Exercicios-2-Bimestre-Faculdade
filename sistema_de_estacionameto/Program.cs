double preco_hora = 5.00;
int veiculos = 0;
int movimentacoes = 0;
int opcao = 0;
do
{
Console.WriteLine("=-=-=-=-=-==-=-=-=");
Console.WriteLine("Sistema de Estacionamento");
Console.WriteLine("=-=-=-=-=-==-=-=-=");
Console.WriteLine("[1]Cadastrar Entrada\n[2]Registrar Saída\n[3]Quantidade de veículos\n[4]Sair");
Console.Write("Selecione a operação desejada: ");
opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Cadastrar Entrada");
            Console.Write("Digite o modelo do veículo: ");
            string modelo = Console.ReadLine();
            veiculos++;
            movimentacoes++;
            break;
        case 2:
            Console.WriteLine("Registrar Saída");
            if (veiculos > 0){
            Console.Write("Quantidade de horas estacionadas: ");
            double horas = double.Parse(Console.ReadLine());            
            double valor_total = horas * preco_hora;
            double valor_desconto = horas <= 2 ? valor_total * 0.10 : 0;
            valor_total -= valor_desconto;
            Console.WriteLine($"Valor total a ser pago: R$ {valor_total:F2}");
            veiculos--;
            movimentacoes++;
            }
            else{
                Console.WriteLine("Não há veículos no estacionamento.");
            }
            break;
        case 3:
            Console.WriteLine("Quantidade de veículos");
            Console.WriteLine($"Total de veículos: {veiculos}");
            break;
        case 4:
            Console.WriteLine("Sair");
            Console.WriteLine("Encerrando o sistema...");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;

    }
}
while (opcao != 4);

for (int i = 1; i <= movimentacoes; i++)
{
    Console.WriteLine($"Movimentação Registrada: {i} ");
}
Console.WriteLine($"Total de movimentações: {movimentacoes}");