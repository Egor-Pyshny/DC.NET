using RV.Models;

namespace RV.Repositories
{
    public interface INewsRepository
    {
        News CreateNews(News item);
        List<News> GetNews();
        News GetNew(int id);
        News UpdateNews(News item);
        int DeleteNews(int id);
    }
}
