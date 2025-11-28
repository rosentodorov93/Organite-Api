using MediatR;
using Microsoft.AspNetCore.Mvc;
using Organite.Application.Notes;
using Organite.Application.Notes.Commands.CreateNote;
using Organite.Application.Notes.Commands.DeleteNote;
using Organite.Application.Notes.Commands.UpdateNote;
using Organite.Application.Notes.Dtos;
using Organite.Application.Notes.Queries.GetAllNotes;
using Organite.Application.Notes.Queries.GetNoteById;

namespace Organite.Api.Controllers
{
    [ApiController]
    [Route("api/notes")]
    public class NotesController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllNotes()
        {
            var notes = await mediator.Send(new GetAllNotesQuery());
            return Ok(notes);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var note = await mediator.Send(new GetNoteByIdQuery(id));
            if (note == null) 
            {
                return NotFound();
            }

            return Ok(note);
        }
        [HttpPost]
        public async Task<IActionResult> CreateNote([FromBody] CreateNoteCommand command)
        {
            var id = await mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id }, null);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateNote([FromRoute] int id, UpdateNoteCommand command)
        {
            command.Id = id;
            var isUpdated = await mediator.Send(command);
            if (isUpdated)
            {
                return NoContent();
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNote([FromRoute] int id)
        {
            var isDeleted = await mediator.Send(new DeleteNoteCommand(id));
            if (isDeleted)
            {
                return NoContent();
            }

            return NotFound();
        }
    }
}
