using Microsoft.AspNetCore.Mvc;
using Organite.Application.Notes;
using Organite.Application.Notes.Dtos;

namespace Organite.Api.Controllers
{
    [ApiController]
    [Route("api/notes")]
    public class NotesController(INotesService notesService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllNotes()
        {
            var notes = await notesService.GetAllNotes();
            return Ok(notes);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var note = await notesService.GetById(id);
            if (note == null) 
            {
                return NotFound();
            }

            return Ok(note);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateNoteDto noteDto)
        {
            var id = await notesService.Create(noteDto);
            return CreatedAtAction(nameof(GetById), new { id }, null);
        }
    }
}
