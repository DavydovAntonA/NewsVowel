using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using NewsVowel.Collection;
using NewsVowel.Interface;
using NewsVowel.Models;

namespace NewsVowel.Managers
{
    public class SearchNewsManager
    {
        public void SearchNews(InputParams inputParams, ITextManager textManager)
        {
            var newsApiClient = new NewsApiClient(inputParams.ApiKey);
            var articlesResponse = newsApiClient.GetEverything(new EverythingRequest
            {
                Q = inputParams.SearchWord,
            });
            if (articlesResponse.Status == Statuses.Ok)
            {
                foreach (var article in articlesResponse.Articles)
                {
                    var word = textManager.GetWordMaxOccurrenceOfChars(article.Description, new CollectionCharsVowelRuAndEn());
                    Print(article.Description, word);
                }
            }
            else
            {
                Console.WriteLine(articlesResponse.Error.Message);
            }
        }

        private void Print(string description, string word)
        {
            Console.WriteLine();
            Console.WriteLine("Фрагмент новости:");
            Console.WriteLine(description);
            Console.Write("Cлово с наибольшим количеством гласных: ");
            Console.Write(word);
            Console.WriteLine();
        }
    } 
}
