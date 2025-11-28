using MediatR;

namespace Organite.Application.Notes.Commands.DeleteNote;

public class DeleteNoteCommand(int id) : IRequest<bool>
{
    public int Id { get; } = id;
}
