using NewsVowel.Interface;

namespace NewsVowel.Managers
{
    /// <summary>
    /// Мэнаджер по работе с текстом
    /// </summary>
    public class TextManager : ITextManager
    {
        /// <summary>
        /// Поиск слова в тексте с максимальным количеством символов
        /// </summary>
        /// <param name="text">Текст</param>
        /// <param name="collectionChars">Символы</param>
        /// <returns></returns>
        public string GetWordMaxOccurrenceOfChars(string text, ICollectionChars collectionChars)
        {
            string word = string.Empty;

            char[] sk = { ' ', '.', ',', '!', '?', ':', ';', '(', ')', '<', '>', '\t' };

            string[] parts = text.Split(sk, StringSplitOptions.RemoveEmptyEntries);
            var mostVowels = 0;

            foreach (var part in parts)
            {
                var numberOfVowels = 0;
                foreach (var symbol in part)
                {
                    if (collectionChars.ContainsChar(symbol)) numberOfVowels++;
                }

                if (mostVowels < numberOfVowels)
                {
                    mostVowels = numberOfVowels;
                    word = part;
                }
            }

            return word;
        }
    }
}
