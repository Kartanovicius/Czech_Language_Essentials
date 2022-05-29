using Catalog.Entities;

namespace Catalog.Repositories
{
    public interface IWordsRepository
    {
        Word GetRandomWord();
        Word GetWordByCZ(string word);
        Word GetWordByCzIgnoreUniqueChar(string word);
        Word GetWordByEN(string word);
        IEnumerable<Word> GetWordByTopic(string topic);
        IEnumerable<Word> GetWords();
    }
}