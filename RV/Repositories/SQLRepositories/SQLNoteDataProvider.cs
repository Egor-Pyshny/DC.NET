using Microsoft.EntityFrameworkCore;
using RV.Models;
using RV.Repository;

namespace RV.Repositories.SQLRepositories
{
    public class SQLNoteRepository : INoteRepository
    {
        private ApplicationContext _dbContext;

        public SQLNoteRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Note CreateNote(Note item)
        {
            _dbContext.Add(item);
            _dbContext.SaveChanges();
            return item;
        }

        public int DeleteNote(int id)
        {
            int res = _dbContext.Notes.Where(n => n.id == id).ExecuteDelete();
            _dbContext.SaveChanges();
            return res;
        }

        public Note GetNote(int id)
        {
            var res = _dbContext.Notes.Where(n => n.id == id).ToList();
            Note n;
            if (res.Count > 0)
            {
                n = res[0];
                return n;
            }
            else return null;
        }

        public List<Note> GetNotes()
        {            
            return _dbContext.Notes.ToList();
        }

        public Note UpdateNote(Note item)
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
            return n;
        }
    }
}
