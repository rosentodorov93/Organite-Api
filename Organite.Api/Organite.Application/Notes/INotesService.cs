using Organite.Application.Notes.Dtos;
using Organite.Domain.Entities;

namespace Organite.Application.Notes
{
    public interface INotesService
    {
        Task<IEnumerable<NoteDto>> GetAllNotes();
        Task<NoteDto?> GetById(int id);
    }
}