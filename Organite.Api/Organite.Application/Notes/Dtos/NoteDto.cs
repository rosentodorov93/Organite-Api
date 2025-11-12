using Organite.Domain.Entities;

namespace Organite.Application.Notes.Dtos;

public class NoteDto
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;
    public string Content { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public List<string> Tags { get; set; } = new();
    public bool IsPinned { get; set; }

    public static NoteDto? FromEntity(Note? note)
    {
        if (note == null) return null;
        return new NoteDto()
        {
            Id = note.Id,
            Title = note.Title,
            Content = note.Content,
            CreatedAt = note.CreatedAt,
            UpdatedAt = note.UpdatedAt,
            Tags = note.Tags,
            IsPinned = note.IsPinned,
        };
    }
}
