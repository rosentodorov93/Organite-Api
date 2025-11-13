using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Organite.Application.Notes.Dtos;
using Organite.Domain.Repositories;

namespace Organite.Application.Notes.Queries.GetAllNotes;

public class GetAllNotesQueryHandler(ILogger<GetAllNotesQueryHandler> logger, IMapper mapper, INotesRepository repo) : IRequestHandler<GetAllNotesQuery, IEnumerable<NoteDto>>
{
    public async Task<IEnumerable<NoteDto>> Handle(GetAllNotesQuery request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Fetching all notes");
        var notes = await repo.GetAllAsync();

        var notesDtos = mapper.Map<IEnumerable<NoteDto>>(notes);

        return notesDtos!;
    }
}
