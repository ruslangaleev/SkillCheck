using SkillCheck.Structs;

namespace SkillCheck.Services
{
    public class NoteService
    {
        private readonly List<Note> _notes = new();
        private readonly List<NoteTemplate> _templates = new();

        public async Task<List<Note>> GetNotesAsync()
        {
            await Task.CompletedTask;
            return _notes;
        }

        public async Task<Note> GetNoteByIdAsync(Guid id)
        {
            return _notes.FirstOrDefault(n => n.Id == id);
        }

        public async Task<Note> CreateNoteAsync(string title, string content)
        {
            var note = new Note
            {
                Id = Guid.NewGuid(),
                Title = title,
                Content = content
            };

            _notes.Add(note);

            return note;
        }

        public async Task<Note> CreateNoteFromTemplateAsync(Guid templateId)
        {
            var template = _templates.FirstOrDefault(t => t.Id == templateId);

            if (template is null)
            {
                return null;
            }

            var note = new Note
            {
                Id = Guid.NewGuid(),
                Title = template.Title,
                Content = template.Content
            };

            _notes.Add(note);

            return note;
        }

        public async Task<bool> DeleteNoteAsync(Guid noteId)
        {
            var note = _notes.FirstOrDefault(n => n.Id == noteId);

            if (note is not null)
            {
                _notes.Remove(note);
                return true;
            }

            return false;
        }

        public async Task<bool> EditNoteAsync(Guid noteId, string title, string content)
        {
            var note = _notes.FirstOrDefault(n => n.Id == noteId);

            if (note is not null)
            {
                note.Title = title;
                note.Content = content;
                await Task.CompletedTask;
                return true;
            }

            return false;
        }

        public async Task<List<Note>> SortNotesBySizeAsync()
        {
            return _notes.OrderBy(n => n.Content.Length).ToList();
        }

        public async Task<NoteTemplate> CreateTemplateAsync(string title, string content)
        {
            var template = new NoteTemplate
            {
                Id = Guid.NewGuid(),
                Title = title,
                Content = content
            };

            _templates.Add(template);
            return template;
        }

        public async Task<List<NoteTemplate>> GetTemplatesAsync()
        {
            return _templates;
        }

        public async Task<NoteTemplate> GetTemplateByIdAsync(Guid id)
        {
            return _templates.FirstOrDefault(t => t.Id == id);
        }

        public async Task<bool> DeleteTemplateAsync(Guid templateId)
        {
            var template = _templates.FirstOrDefault(t => t.Id == templateId);

            if (template is not null)
            {
                _templates.Remove(template);
                return true;
            }

            return false;
        }

        public async Task<bool> EditTemplateAsync(Guid templateId, string title, string content)
        {
            var template = _templates.FirstOrDefault(t => t.Id == templateId);

            if (template is not null)
            {
                template.Title = title;
                template.Content = content;
                return true;
            }

            return false;
        }
    }
}
