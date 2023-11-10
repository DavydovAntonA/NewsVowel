using NewsVowel.Interface;

namespace NewsVowel.Collection
{
    public abstract class CollectionCharsBase : HashSet<char>, ICollectionChars
    {
        public CollectionCharsBase(int count) : base(count) { }
        public virtual bool ContainsChar(char item)
        {
            return Contains(item);
        }
    }
}
