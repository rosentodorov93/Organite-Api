using System.ComponentModel.DataAnnotations;

namespace Organite.Application.Notes.Dtos;

public class CreateNoteDto
{
    [StringLength(100, MinimumLength = 3)]
    public string Title { get; set; } = default!;

    [StringLength(200, MinimumLength = 3)]
    public string Content { get; set; } = default!;
    public List<string> Tags { get; set; } = new();
}
