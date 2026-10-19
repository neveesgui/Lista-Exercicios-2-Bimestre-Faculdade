
int opcao = 0;
int votosAna = 0;
int votosBruno = 0;
int votosCarlos = 0;

do
{
    Console.Clear();
    Console.WriteLine("=-=-=-= Urna Eletrônica =-=-=-=");
    Console.WriteLine("CANDIDATOS:\n[1]ANA\n[2]Bruno\n[3]Carlos\n[0]Encerrar Votação");
    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-="); 
    Console.Write("Escolha seu candidato: ");
    opcao = int.Parse(Console.ReadLine()!);
    Console.ReadKey();

    switch(opcao)
    {
        case 1:
        Console.WriteLine("Você votou em Ana!");
        Console.ReadKey();
        votosAna++;
        break;

        case 2:
        Console.WriteLine("Você votou em Bruno!");
        Console.ReadKey();
        votosBruno++;
        break;

        case 3:
        Console.WriteLine("Você votou em Carlos!");
        Console.ReadKey();
        votosCarlos++;
        break;

        case 0:
        Console.WriteLine("Votação Encerrada!");
        Console.ReadKey();
        break;
            default:
            Console.WriteLine("Opção Inválida! Tente novamento.");
            Console.ReadKey();
            break;

    }
}
while(opcao != 0);
Console.WriteLine("=-=-=-=-=-=-=-=-=-");
Console.WriteLine($"Ana: {votosAna} votos");
Console.WriteLine($"Bruno: {votosBruno} votos");
Console.WriteLine($"Carlos: {votosCarlos} votos");
Console.WriteLine("=-=-=-=-=-=-=-=-=-");
Console.ReadKey();

string resultado = (votosAna > votosBruno && votosAna > votosCarlos)
    ? "Ana ganhou a Eleição"
    : (votosBruno > votosAna && votosBruno > votosCarlos) 
        ? "Bruno ganhou a Eleição"
        :(votosCarlos > votosAna && votosCarlos > votosBruno)
            ? "Carlos ganhou a Eleição"
            : "Empate";
Console.WriteLine(resultado);
Console.ReadKey();
