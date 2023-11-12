namespace Aplicatiivo.Modelos;
internal class ExibirDetalhes: Menu
{
    
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda bandas = bandasRegistradas[nomeDaBanda];
            Console.WriteLine(bandas.Resumo);
            
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {bandas.Media}.");
            Console.WriteLine($"\n Discografia");
            foreach (Album album in bandas.Albuns)
            {
                Console.WriteLine($" {album.Nome} -> {album.Media} ");
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
           

        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
           
        }
    }
}
