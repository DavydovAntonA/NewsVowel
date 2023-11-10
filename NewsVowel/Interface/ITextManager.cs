namespace NewsVowel.Interface
{
    public interface ITextManager
    {
        string GetWordMaxOccurrenceOfChars(string text, ICollectionChars collectionChars);
    }
}
