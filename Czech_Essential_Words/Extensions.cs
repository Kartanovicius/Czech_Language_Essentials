using System;
using Catalog.Dtos;
using Catalog.Entities;

namespace Catalog
{
	public static class Extensions
	{
		public static WordDto asDto(this Word word)
		{
			return new WordDto
			{
				Id = word.Id,
				CZ = word.CZ,
				EN = word.EN,
				ExampleSentanceCZ = word.ExampleSentanceCZ,
				ExampleSentanceEN = word.ExampleSentanceEN,
				Difficulty = word.Difficulty,
				Topic = word.Topic,
				PartOfSpeech = word.PartOfSpeech,
				Collection = word.Collection

			};
		}
	}
}

