using Microsoft.AspNetCore.Mvc;

namespace SkillCheck.Controllers
{
    using SkillCheck.Services;
    using SkillCheck.Structs;

    [Route("api/[controller]")]
    [ApiController]
    public class TemplatesController : ControllerBase
    {
        private readonly NoteService _noteService;

        public TemplatesController(NoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet("GetTemplates")]
        public async Task<ActionResult<List<NoteTemplate>>> GetTemplates()
        {
            Console.WriteLine("GetTemplates");
            var templates = await _noteService.GetTemplatesAsync();
            return Ok(templates);
        }

        [HttpGet("GetTemplateById/{id}")]
        public async Task<ActionResult<NoteTemplate>> GetTemplateById(Guid id)
        {
            Console.WriteLine("GetTemplateById");
            var template = await _noteService.GetTemplateByIdAsync(id);

            if (template == null)
            {
                return NotFound();
            }

            return Ok(template);
        }

        [HttpPost("CreateTemplate")]
        public async Task<ActionResult<NoteTemplate>> CreateTemplate([FromBody] NoteTemplate template)
        {
            Console.WriteLine("CreateTemplate");
            var createdTemplate = await _noteService.CreateTemplateAsync(template.Title, template.Content);
            return CreatedAtAction(nameof(GetTemplateById), new { id = createdTemplate.Id }, createdTemplate);
        }

        [HttpDelete("DeleteTemplate/{id}")]
        public async Task<IActionResult> DeleteTemplate(Guid id)
        {
            Console.WriteLine("DeleteTemplate");
            var result = await _noteService.DeleteTemplateAsync(id);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPut("EditTemplate/{id}")]
        public async Task<IActionResult> EditTemplate(Guid id, [FromBody] NoteTemplate template)
        {
            Console.WriteLine("EditTemplate");
            var result = await _noteService.EditTemplateAsync(id, template.Title, template.Content);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
