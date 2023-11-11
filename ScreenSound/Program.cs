using Aplicatiivo.Modelos;

Banda ira = new Banda("ira");
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(8));
Banda bob = new Banda("bob");

Dictionary<string, Banda> bandasRegistradas = new ();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(bob.Nome, bob);

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            MenuRegistrarBanda menu1 = new();
            menu1.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 2:
            MenuRegistrarAlbum menu2 = new();
            menu2.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 3:
            MenuMostrarBandas menu3 = new();
            menu3.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 4:
            AvaliarBanda menuBanda = new AvaliarBanda();
            menuBanda.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 5:
            ExibirDetalhes menu = new ExibirDetalhes();
            menu.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case -1:
            MenuSair menuSair = new();
            menuSair.Executar(bandasRegistradas);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

ExibirOpcoesDoMenu();

