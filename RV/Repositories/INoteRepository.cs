using RV.Models;

namespace RV.Repository
{
    public interface INoteRepository
    {
        Note CreateNote(Note item);
        List<Note> GetNotes();
        Note GetNote(int id);
        Note UpdateNote(Note item);
        int DeleteNote(int id);
    }
}
