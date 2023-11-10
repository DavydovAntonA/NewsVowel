using NewsVowel.Managers;
using NewsVowel.Models;

do
{
    string? apiKey;

    do
    {
        Console.WriteLine("Введите API key:");
        apiKey = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(apiKey))
        {
            Console.WriteLine("API key не может быть пустым");
        }
    }
    while (string.IsNullOrWhiteSpace(apiKey));

    string? searchWord;

    Console.WriteLine("Введите слово для поиска (по умолчанию космос):");
    searchWord = Console.ReadLine();

    var inputParams = new InputParams
    {
        ApiKey = apiKey,
        SearchWord = string.IsNullOrWhiteSpace(searchWord) ? "космос" : searchWord
    };

    var searchNews = new SearchNewsManager();

    searchNews.SearchNews(inputParams, new TextManager());
}
while (Console.ReadKey().Key != ConsoleKey.Escape);