using Microsoft.EntityFrameworkCore;
using RV.Models;
using RV.Views;
using RV.Views.DTO;

namespace RV.Services.DataProviderServices.SQL
{
    public class SQLNewsDataProvider : INewsDataProvider
    {
        private ApplicationContext _dbContext;

        public SQLNewsDataProvider(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public NewsDTO CreateNews(NewsAddDTO item)
        {
            throw new NotImplementedException();
        }

        public int DeleteNews(int id)
        {
            throw new NotImplementedException();
        }

        public NewsDTO GetNew(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsDTO> GetNews()
        {
            throw new NotImplementedException();
        }

        public NewsDTO UpdateNews(NewsUpdateDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
