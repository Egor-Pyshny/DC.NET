using AutoMapper;
using RV.Models;
using RV.Views.DTO;

namespace RV.Services.Mappers
{
    public class NewsMapper : Profile
    {
        public NewsMapper()
        {
            CreateMap<News, NewsDTO>();
        }
    }
}
