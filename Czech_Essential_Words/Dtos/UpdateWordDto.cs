using System;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record UpdateWordDto
    {
        [Required]
        public string? CZ { get; init; }
        [Required]
        public string? EN { get; init; }
        [Required]
        public string? ExampleSentanceCZ { get; init; }
        [Required]
        public string? ExampleSentanceEN { get; init; }
        [Required]
        public string? Difficulty { get; init; }
        [Required]
        public string? Topic { get; init; }
        [Required]
        public string? PartOfSpeech { get; init; }
        [Required]
        public string[]? Collection { get; init; }
    }
}

