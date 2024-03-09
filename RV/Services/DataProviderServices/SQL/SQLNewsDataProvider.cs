using AutoMapper;
using RV.Models;
using RV.Repositories;
using RV.Views;
using RV.Views.DTO;

namespace RV.Services.DataProviderServices.SQL
{
    public class SQLNewsDataProvider : INewsDataProvider
    {
        private INewsRepository _repository;
        private IMapper _mapper;

        public SQLNewsDataProvider(INewsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public NewsDTO CreateNews(NewsAddDTO item)
        {
            item.created = DateTime.UtcNow;
            item.modified = DateTime.UtcNow;
            News n = _mapper.Map<News>(item);
            var res = _repository.CreateNews(n);
            return _mapper.Map<NewsDTO>(res);
        }

        public int DeleteNews(int id)
        {
            int res = _repository.DeleteNews(id);
            return res;
        }

        public NewsDTO GetNew(int id)
        {
            return _mapper.Map<NewsDTO>(_repository.GetNew(id));
        }

        public List<NewsDTO> GetNews()
        {
            List<NewsDTO> res = [];
            foreach (News n in _repository.GetNews())
            {
                res.Add(_mapper.Map<NewsDTO>(n));
            }
            return res;
        }

        public NewsDTO UpdateNews(NewsUpdateDTO item)
        {
            var n = _mapper.Map<News>(item);
            var res = _repository.UpdateNews(n);
            return _mapper.Map<NewsDTO>(res);
        }
    }
}
