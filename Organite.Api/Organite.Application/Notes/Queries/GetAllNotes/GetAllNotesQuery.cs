using MediatR;
using Organite.Application.Notes.Dtos;

namespace Organite.Application.Notes.Queries.GetAllNotes;

public class GetAllNotesQuery : IRequest<IEnumerable<NoteDto>>
{
}
