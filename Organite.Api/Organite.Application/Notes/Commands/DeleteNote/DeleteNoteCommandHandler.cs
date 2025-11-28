using MediatR;
using Microsoft.Extensions.Logging;
using Organite.Domain.Repositories;
using System.ComponentModel.DataAnnotations;

namespace Organite.Application.Notes.Commands.DeleteNote;

public class DeleteNoteCommandHandler(ILogger<DeleteNoteCommandHandler> logger, INotesRepository repo) : IRequestHandler<DeleteNoteCommand, bool>
{
    public async Task<bool> Handle(DeleteNoteCommand request, CancellationToken cancellationToken)
    {
        logger.LogInformation($"Deleting note with id: {request.Id}");
        var note = await repo.GetByIdAsync(request.Id);
        if (note == null) 
        {
            return false;
        }

        await repo.Delete(note);
        return true;
    }
}
