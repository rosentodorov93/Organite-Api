using Organite.Domain.Entities;

namespace Organite.Application.Notes
{
    public interface INotesService
    {
        Task<IEnumerable<Note>> GetAllNotes();
        Task<Note?> GetById(int id);
    }
}