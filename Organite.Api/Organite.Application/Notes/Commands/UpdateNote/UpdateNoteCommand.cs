using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Organite.Application.Notes.Commands.UpdateNote;

public class UpdateNoteCommand() : IRequest<bool>
{
    public int Id { get; set; }

    [StringLength(100, MinimumLength = 3)]
    public string Title { get; set; } = default!;

    [StringLength(200, MinimumLength = 3)]
    public string Content { get; set; } = default!;
    public List<string> Tags { get; set; } = new();
    public bool IsPinned { get; set; }
}
