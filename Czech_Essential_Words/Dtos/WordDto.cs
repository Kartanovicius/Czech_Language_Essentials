using System;
namespace Catalog.Dtos
{
    public record WordDto
    {
        public Guid Id { get; init; }
        public string? CZ { get; init; }
        public string? EN { get; init; }
        public string? ExampleSentanceCZ { get; init; }
        public string? ExampleSentanceEN { get; init; }
        public string? Difficulty { get; init; }
        public string? Topic { get; init; }
        public string? PartOfSpeech { get; init; }
        public string[]? Collection { get; init; }
    }
}

