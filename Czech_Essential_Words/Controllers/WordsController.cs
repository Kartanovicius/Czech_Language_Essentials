using System;
using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using Catalog.Entities;
using Catalog.Dtos;

namespace Catalog.Controllers
{
	[ApiController]
	[Route("api/words")]
	public class WordsController : ControllerBase
	{
		public readonly IWordsRepository repository;

		public WordsController(IWordsRepository repository)
        {
			this.repository = repository;
        }

		// GET /words
		[HttpGet]
        public IEnumerable<WordDto> GetWords()
        {
			var words = repository.GetWords().Select(word => word.asDto());

			return words;
		}

		[HttpGet("en")]
		public ActionResult<WordDto> GetWordByEN([FromQuery]string word)
		{
			var result = repository.GetWordByEN(word);

			if (result is null)
			{
				return NotFound();
			}

			return result.asDto();
		}

		[HttpGet("cz")]
		public ActionResult<WordDto> GetWordByCZ([FromQuery]string word)
		{
			var result = repository.GetWordByCZ(word);
			if (result is null)
			{
				return NotFound();
			}
			return result.asDto();
		}

		[HttpGet("cz-ignore-unique-char")]
		public ActionResult<WordDto> GetWordByCzIgnoreUniqueChar([FromQuery] string word)
		{
			var result = repository.GetWordByCzIgnoreUniqueChar(word);
			if (result is null)
			{
				return NotFound();
			}
			return result.asDto();
		}

		[HttpGet("topic")]
        public ActionResult<IEnumerable<WordDto>> GetWordByTopic([FromQuery] string topic)
		{
			var result = repository.GetWordByTopic(topic);
			if (!result.Any())
			{
				return NotFound();
			}
			return result.Select(word => word.asDto()).ToList();
		}

		[HttpGet("random")]
		public WordDto GetRandomWord()
		{
			var result = repository.GetRandomWord();
			return result.asDto();
		}
	}
}
