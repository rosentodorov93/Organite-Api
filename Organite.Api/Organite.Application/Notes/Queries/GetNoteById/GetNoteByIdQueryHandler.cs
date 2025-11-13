using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Organite.Application.Notes.Dtos;
using Organite.Domain.Repositories;

namespace Organite.Application.Notes.Queries.GetNoteById;

public class GetNoteByIdQueryHandler(ILogger<GetNoteByIdQueryHandler> logger, IMapper mapper, INotesRepository repo) : IRequestHandler<GetNoteByIdQuery, NoteDto?>
{
    public async Task<NoteDto?> Handle(GetNoteByIdQuery request, CancellationToken cancellationToken)
    {
        logger.LogInformation($"Getting note with id: {request.Id}");
        var note = await repo.GetByIdAsync(request.Id);

        var noteDto = mapper.Map<NoteDto>(note);

        return noteDto;
    }
}
