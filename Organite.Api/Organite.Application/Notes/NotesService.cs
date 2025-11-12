using AutoMapper;
using Microsoft.Extensions.Logging;
using Organite.Application.Notes.Dtos;
using Organite.Domain.Repositories;

namespace Organite.Application.Notes;

internal class NotesService(INotesRepository repo, ILogger<NotesService> logger, IMapper mapper) : INotesService
{
    public async Task<IEnumerable<NoteDto>> GetAllNotes()
    {
        logger.LogInformation("Fetching all notes");
        var notes = await repo.GetAllAsync();

        var notesDtos = mapper.Map<IEnumerable<NoteDto>>(notes);

        return notesDtos!;
    }

    public async Task<NoteDto?> GetById(int id)
    {
        logger.LogInformation($"Getting note with id: {id}");
        var note = await repo.GetByIdAsync(id);

        var noteDto = mapper.Map<NoteDto>(note);

        return noteDto;
    }
}
