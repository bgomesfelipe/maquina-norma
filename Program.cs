using MaquinaNorma.Funcoes;

string? comando;

while (true)
{
    Console.Clear();
    Console.WriteLine("===================");
    Console.WriteLine("   MÁQUINA NORMA   ");
    Console.WriteLine("===================");
    Console.WriteLine("[1] - A + B (sem preservar conteúdo)");
    Console.WriteLine("[2] - A + B (preservando conteúdo)");
    Console.WriteLine("[3] - A - B");
    Console.WriteLine("[4] - Teste A < B");
    Console.WriteLine("[5] - Teste A <= B");
    Console.WriteLine("[6] - A % B");
    Console.WriteLine("[*] - Sair");
    Console.Write("\nEscolha uma opção: ");
    comando = Console.ReadLine();
    Console.Clear();

    try
    {
        switch (comando)
        {
            case "1":
                AdicaoSemPreservarConteudo.Executar();
                break;
            case "2":
                AdicaoPreservandoConteudo.Executar();
                break;
            case "3":
                Subtracao.Executar();
                break;
            case "4":
                MenorQue.Executar();
                break;
            case "5":
                MenorIgualQue.Executar();
                break;
            case "6":
                RestoDivisao.Executar();
                break;
            case "*":
                Console.WriteLine("Encerrando programa...");
                Thread.Sleep(2500);
                Console.Clear();
                return;
            default:
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
        Console.Write("Aperte qualquer tecla para continuar... ");
        Console.ReadKey();
    }
}

