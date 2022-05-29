using Catalog.Entities;

namespace Catalog.Repositories
{
    public interface IWordsRepository
    {
        IEnumerable<Word> GetWords();
        Word GetWord(Guid id);
        Word GetRandomWord();
        Word GetWordByCZ(string word);
        Word GetWordByCzIgnoreUniqueChar(string word);
        Word GetWordByEN(string word);
        IEnumerable<Word> GetWordByTopic(string topic);
        void CreateWord(Word word);
        void UpdateWord(Word word);
        void DeleteWord(Guid id);
    }
}