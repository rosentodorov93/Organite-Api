using MediatR;
using Organite.Application.Notes.Dtos;

namespace Organite.Application.Notes.Queries.GetNoteById;

public class GetNoteByIdQuery(int id) : IRequest<NoteDto?>
{
    public int Id { get; } = id;
}
