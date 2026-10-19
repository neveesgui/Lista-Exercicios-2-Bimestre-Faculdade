Console.WriteLine("=-=-=-=-=-==-=-=-=");
Console.WriteLine("Sistema de Pedidos");
Console.WriteLine("=-=-=-=-=-==-=-=-=");

Console.WriteLine("[1]Hambúrguer:R$18,00\n[2]Pizza:R$32,00\n[3]Pastel:R$10,00\n[4]Refrigerante:R$6,00");
Console.Write("Digite o número do produto que deseja: ");
double produto = double.Parse(Console.ReadLine());
double preco = 0;

switch (produto)
{
    case 1:
        Console.WriteLine("Produto escolhido: Hambúrguer");
            preco = 18;
        break;
    case 2:
        Console.WriteLine("Produto escolhido: Pizza");
            preco = 32;
        break;
    case 3:
        Console.WriteLine("Produto escolhido: Pastel");
            preco = 10;
        break;
    case 4:
        Console.WriteLine("Produto escolhido: Refrigerante");
            preco = 6;
        break;
    default:
        Console.WriteLine("Produto inválido");
        break;  
}
if (produto >= 1 && produto <= 4)
{
    Console.Write("Digite a quantidade desejada do produto selecionado: ");
    double quantidade = double.Parse(Console.ReadLine());
    Console.WriteLine("Quantidade escolhida: {0}", quantidade);
    double total = quantidade * preco;
    Console.WriteLine("Total: R${0:F2}", total);
}
