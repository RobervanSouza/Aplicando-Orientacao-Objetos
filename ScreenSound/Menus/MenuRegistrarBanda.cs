

using OpenAI_API;

namespace Aplicatiivo.Modelos;


internal  class MenuRegistrarBanda: Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);



        var client = new OpenAIAPI("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");

        var chat = client.Chat.CreateConversation();

        chat.AppendSystemMessage($"descreva a {nomeDaBanda} ira em um paragrafo");

        string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        banda.Resumo = resposta;

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }

}
