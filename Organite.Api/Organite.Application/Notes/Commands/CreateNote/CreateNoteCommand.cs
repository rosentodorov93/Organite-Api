using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Organite.Application.Notes.Commands.CreateNote
{
    public class CreateNoteCommand : IRequest<int>
    {
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; } = default!;

        [StringLength(200, MinimumLength = 3)]
        public string Content { get; set; } = default!;
        public List<string> Tags { get; set; } = new();
    }
}
