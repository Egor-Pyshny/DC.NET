using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RV.Models;
using RV.Views.DTO;

namespace RV.Services.DataProviderServices.SQL
{
    public class SQLNoteDataProvider : INoteDataProvider
    {
        private ApplicationContext _dbContext;
        private IMapper _mapper;

        public SQLNoteDataProvider(ApplicationContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public NoteDTO CreateNote(NoteAddDTO item)
        {
            Note n = _mapper.Map<Note>(item);
            _dbContext.Add(n);
            _dbContext.SaveChanges();
            return _mapper.Map<NoteDTO>(n);
        }

        public int DeleteNote(int id)
        {
            int res = _dbContext.Notes.Where(n => n.id == id).ExecuteDelete();
            _dbContext.SaveChanges();
            return res;
        }

        public NoteDTO GetNote(int id)
        {
            var res = _dbContext.Notes.Where(n => n.id == id).ToList();
            Note n;
            if (res.Count > 0)
            {
                n = res[0];
                return _mapper.Map<NoteDTO>(n);
            }
            else return null;
        }

        public List<NoteDTO> GetNotes()
        {
            List<NoteDTO> res = [];
            foreach (Note n in _dbContext.Notes)
            {
                res.Add(_mapper.Map<NoteDTO>(n));
            }
            return res;
        }

        public NoteDTO UpdateNote(NoteUpdateDTO item)
        {
            var res = _dbContext.Notes.Where(n => n.id == item.id).ToList();
            Note n;
            if (res.Count > 0)
            {
                n = res[0];
            }
            else return null;
            if (item.newsId != null)
            {
                n.newsId = (int)item.newsId;
            }
            if (item.content != null)
            {
                n.content = item.content;
            }
            _dbContext.Update(n);
            _dbContext.SaveChanges();
            return _mapper.Map<NoteDTO>(n);
        }
    }
}
