using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Catalog.Entities;
using RemoveAccents;

namespace Catalog.Repositories
{

    public class InMemWordsRepository : IWordsRepository
    {
        private readonly List<Word> words = new()
        {
            new Word { Id = Guid.NewGuid(), CZ = "týden", EN = "week", ExampleSentanceCZ = "Týden má sedm dní.", ExampleSentanceEN = "There are seven days in a week.", Difficulty = "easy", Topic = "date", PartOfSpeech = "noun", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "rok", EN = "year", ExampleSentanceCZ = "jeden kalendářní rok", ExampleSentanceEN = "one calendar year", Difficulty = "easy", Topic = "date", PartOfSpeech = "noun", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "dnes", EN = "today", ExampleSentanceCZ = "Vypadá dnes smutně.", ExampleSentanceEN = "She looks really sad today.", Difficulty = "easy", Topic = "date", PartOfSpeech = "verb", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "zítra", EN = "tomorrow", ExampleSentanceCZ = "zítra v 10:10", ExampleSentanceEN = "tomorrow at 10:10", Difficulty = "easy", Topic = "date", PartOfSpeech = "verb", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "včera", EN = "yesterday", ExampleSentanceCZ = "Včera jsem si vzal volno.", ExampleSentanceEN = "I took a day off yesterday.", Difficulty = "easy", Topic = "date", PartOfSpeech = "verb", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "kalendář", EN = "calendar", ExampleSentanceCZ = " Zapsal jsem naše výročí do kalendáře.", ExampleSentanceEN = "I marked our anniversary on the calendar.", Difficulty = "easy", Topic = "date", PartOfSpeech = "noun", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "vteřina", EN = "second", ExampleSentanceCZ = "Na stopkách zbývá padesát osm vteřin.", ExampleSentanceEN = "There are fifty eight seconds left on the stopwatch.", Difficulty = "easy", Topic = "date", PartOfSpeech = "noun", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "hodina", EN = "hour", ExampleSentanceCZ = "Hodina má 60 minut.", ExampleSentanceEN = "There are 60 minutes in an hour.", Difficulty = "easy", Topic = "date", PartOfSpeech = "noun", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "minuta", EN = "minute", ExampleSentanceCZ = "Minuta má šedesát vteřin.", ExampleSentanceEN = "There are sixty seconds in a minute.", Difficulty = "easy", Topic = "date", PartOfSpeech = "noun", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "hodin", EN = "o'clock", ExampleSentanceCZ = "Každé ráno se probouzím v šest hodin.", ExampleSentanceEN = "I wake up every morning at six o'clock a.m.", Difficulty = "easy", Topic = "date", PartOfSpeech = "noun", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "hodiny", EN = "clock", ExampleSentanceCZ = "Nástěnné hodiny visí na stěně.", ExampleSentanceEN = "The wall clock is hanging on the wall.", Difficulty = "easy", Topic = "date", PartOfSpeech = "noun", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "moci", EN = "can", ExampleSentanceCZ = "On umí řídit, ale ne moc dobře.", ExampleSentanceEN = "He can drive, but not very well.", Difficulty = "easy", Topic = "auxiliary", PartOfSpeech = "verb", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "používat", EN = "use", ExampleSentanceCZ = "Programátor použil počítač.", ExampleSentanceEN = "The programmer used the computer.", Difficulty = "easy", Topic = "auxiliary", PartOfSpeech = "verb", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "dělat", EN = "do", ExampleSentanceCZ = "Žena dělá úkoly.", ExampleSentanceEN = "The woman does housework.", Difficulty = "easy", Topic = "auxiliary", PartOfSpeech = "verb", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "jít", EN = "go", ExampleSentanceCZ = "jít rovně vpřed", ExampleSentanceEN = "go straight ahead", Difficulty = "easy", Topic = "action", PartOfSpeech = "verb", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "přijít", EN = "come", ExampleSentanceCZ = "Měls přijít.", ExampleSentanceEN = "You should've come.", Difficulty = "easy", Topic = "action", PartOfSpeech = "verb", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "dělat", EN = "make", ExampleSentanceCZ = "Kuchař udělal pomerančový džus.", ExampleSentanceEN = "The chef made orange juice.", Difficulty = "easy", Topic = "action", PartOfSpeech = "verb", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "vidět", EN = "see", ExampleSentanceCZ = "Turisté viděli západ slunce.", ExampleSentanceEN = "The tourists saw the sunset. ", Difficulty = "easy", Topic = "action", PartOfSpeech = "verb", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "daleký", EN = "far", ExampleSentanceCZ = "daleko", ExampleSentanceEN = "far away", Difficulty = "easy", Topic = "distance", PartOfSpeech = "adjective", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "blízko", EN = "near", ExampleSentanceCZ = "Jak je to blízko?", ExampleSentanceEN = "How is that close?", Difficulty = "easy", Topic = "distance", PartOfSpeech = "adjective", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "malý", EN = "small", ExampleSentanceCZ = "", ExampleSentanceEN = "", Difficulty = "easy", Topic = "size", PartOfSpeech = "adjective", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "dobrý", EN = "good", ExampleSentanceCZ = "Zelenina je pro vás dobrá.", ExampleSentanceEN = "Vegetables are good for you.", Difficulty = "easy", Topic = "basic", PartOfSpeech = "adjective", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "krásný", EN = "beautiful", ExampleSentanceCZ = "Krásná herečka.", ExampleSentanceEN = "Beautiful actress.", Difficulty = "easy", Topic = "basic", PartOfSpeech = "adjective", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "škaredý", EN = "ugly", ExampleSentanceCZ = "Jen škaredý sen.", ExampleSentanceEN = "It's just a bad dream.", Difficulty = "easy", Topic = "basic", PartOfSpeech = "adjective", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "složitý", EN = "difficult", ExampleSentanceCZ = "Angličtina je složitá.", ExampleSentanceEN = "English is difficult.", Difficulty = "easy", Topic = "basic", PartOfSpeech = "adjective", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "snadný", EN = "easy", ExampleSentanceCZ = "Snadný problém.", ExampleSentanceEN = "Easy problem.", Difficulty = "easy", Topic = "basic", PartOfSpeech = "adjective", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "špatný", EN = "bad", ExampleSentanceCZ = "Opravdu špatný.", ExampleSentanceEN = "This is really bad.", Difficulty = "easy", Topic = "basic", PartOfSpeech = "adjective", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "blízký", EN = "near", ExampleSentanceCZ = "Žiji blízko univerzity.", ExampleSentanceEN = "I live near the university.", Difficulty = "easy", Topic = "distance", PartOfSpeech = "adjective", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "Ano", EN = "Yes", ExampleSentanceCZ = "Ano, jsem v pořádku.", ExampleSentanceEN = "Yes, I'm fine.", Difficulty = "easy", Topic = "basic", PartOfSpeech = "interjections", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "Ne", EN = "No", ExampleSentanceCZ = "Ne. Bylo to neštěstí.", ExampleSentanceEN = "No. It was an accident.", Difficulty = "easy", Topic = "basic", PartOfSpeech = "interjections", Collection = new string[] { "100_essentials" } },
            new Word { Id = Guid.NewGuid(), CZ = "Nashledanou", EN = "Goodbye", ExampleSentanceCZ = "Nashledanou Hildo. Zítra.", ExampleSentanceEN = "See you tomorrow Hilda.", Difficulty = "easy", Topic = "basic", PartOfSpeech = "noun", Collection = new string[] { "100_essentials" } },
        };

        public IEnumerable<Word> GetWords()
        {
            return words;
        }

        public Word GetWord(Guid id)
        {
            return words.Where(item => item.Id == id).SingleOrDefault();
        }

        public Word GetWordByEN(string word)
        {
            return words.Where(item => item.EN == word).SingleOrDefault();
        }

        public Word GetWordByCZ(string word)
        {
            return words.Where(item => item.CZ == word).SingleOrDefault();
        }

        public Word GetWordByCzIgnoreUniqueChar(string word)
        {
            return words.Where(item => RemoveAccent.getString(item.CZ) == RemoveAccent.getString(word)).SingleOrDefault();
        }

        public IEnumerable<Word> GetWordByTopic(string topic)
        {
            return words.Where(item => item.Topic == topic);
        }

        public Word GetRandomWord()
        {
            Random rnd = new Random();
            int wordIndex = rnd.Next(0, words.Count());

            return words[wordIndex];
        }

        public void CreateWord(Word word)
        {
            words.Add(word);
        }

        public void UpdateWord(Word word)
        {
            var index = words.FindIndex(existingWord => existingWord.Id == word.Id);
            words[index] = word;
        }

        public void DeleteWord(Guid id)
        {
            var index = words.FindIndex(existingWord => existingWord.Id == id);
            words.RemoveAt(index);
        }
    }
}

