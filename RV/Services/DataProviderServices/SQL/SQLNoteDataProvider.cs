using Microsoft.EntityFrameworkCore;
using RV.Models;
using RV.Views.DTO;

namespace RV.Services.DataProviderServices.SQL
{
    public class SQLNoteDataProvider : INoteDataProvider
    {
        private ApplicationContext  _dbContext;

        public SQLNoteDataProvider(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        public NoteDTO CreateNote(NoteAddDTO item)
        {
            throw new NotImplementedException();
        }

        public int DeleteNote(int id)
        {
            throw new NotImplementedException();
        }

        public NoteDTO GetNote(int id)
        {
            throw new NotImplementedException();
        }

        public List<NoteDTO> GetNotes()
        {
            throw new NotImplementedException();
        }

        public NoteDTO UpdateNote(NoteUpdateDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
