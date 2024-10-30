using Microsoft.AspNetCore.Mvc;

namespace SkillCheck.Controllers
{
    using SkillCheck.Services;
    using SkillCheck.Structs;

    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly NoteService _noteService;

        public NotesController(NoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet("GetNotes")]
        public async Task<ActionResult<List<Note>>> GetNotes()
        {
            Console.WriteLine("GetNotes");
            var notes = await _noteService.GetNotesAsync();
            return Ok(notes);
        }

        [HttpGet("GetNoteById/{id}")]
        public async Task<ActionResult<Note>> GetNoteById(Guid id)
        {
            Console.WriteLine("GetNoteById");
            var note = await _noteService.GetNoteByIdAsync(id);

            if (note == null)
            {
                return NotFound();
            }

            return Ok(note);
        }

        [HttpPost("CreateNote")]
        public async Task<ActionResult<Note>> CreateNote([FromBody] Note note)
        {
            Console.WriteLine("CreateNote");
            var createdNote = await _noteService.CreateNoteAsync(note.Title, note.Content);
            return CreatedAtAction(nameof(GetNoteById), new { id = createdNote.Id }, createdNote);
        }

        [HttpPost("CreateNoteFromTemplate")]
        public async Task<ActionResult<Note>> CreateNoteFromTemplate([FromBody] Guid templateId)
        {
            Console.WriteLine("CreateNoteFromTemplate");
            var createdNote = await _noteService.CreateNoteFromTemplateAsync(templateId);

            if (createdNote == null)
            {
                return NotFound("Template not found");
            }

            return CreatedAtAction(nameof(GetNoteById), new { id = createdNote.Id }, createdNote);
        }

        [HttpDelete("DeleteNote/{id}")]
        public async Task<IActionResult> DeleteNote(Guid id)
        {
            Console.WriteLine("DeleteNote");
            var result = await _noteService.DeleteNoteAsync(id);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPut("EditNote/{id}")]
        public async Task<IActionResult> EditNote(Guid id, [FromBody] Note note)
        {
            Console.WriteLine("EditNote");
            var result = await _noteService.EditNoteAsync(id, note.Title, note.Content);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpGet("SortNotesBySize")]
        public async Task<ActionResult<List<Note>>> SortNotesBySize()
        {
            Console.WriteLine("SortNotesBySize");
            var notes = await _noteService.SortNotesBySizeAsync();
            return Ok(notes);
        }
    }
}
