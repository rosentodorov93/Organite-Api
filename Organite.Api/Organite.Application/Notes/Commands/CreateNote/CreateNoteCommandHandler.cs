using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Organite.Application.Notes.Dtos;
using Organite.Domain.Entities;
using Organite.Domain.Repositories;

namespace Organite.Application.Notes.Commands.CreateNote;

public class CreateNoteCommandHandler(ILogger<CreateNoteCommandHandler> logger, INotesRepository repo, IMapper mapper) : IRequestHandler<CreateNoteCommand, int>
{
    public async Task<int> Handle(CreateNoteCommand request, CancellationToken cancellationToken)
    {
        var note = mapper.Map<Note>(request);
        var id = await repo.Create(note);
        logger.LogInformation($"Create new note id: {id}");

        return id;
    }
}
