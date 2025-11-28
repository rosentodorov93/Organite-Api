using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Organite.Domain.Repositories;

namespace Organite.Application.Notes.Commands.UpdateNote;

public class UpdateNoteCommandHandler(ILogger<UpdateNoteCommandHandler> logger, INotesRepository repo, IMapper mapper) : IRequestHandler<UpdateNoteCommand, bool>
{
    public async Task<bool> Handle(UpdateNoteCommand request, CancellationToken cancellationToken)
    {
        logger.LogInformation($"Updating note with id : {request.Id}");
        var note = await repo.GetByIdAsync(request.Id);
        if (note == null) 
        {
            return false;
        }

        mapper.Map(request, note);
        await repo.SaveChangesAsync();
        return true;
    }
}
