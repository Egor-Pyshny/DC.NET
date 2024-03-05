using RV.Models;
using RV.Views;
using RV.Views.DTO;

namespace RV.Services.DataProviderServices.SQL
{
    public class SQLDataProvider : IDataProvider
    {
        public IUserDataProvider userDataProvider { get; }

        public INewsDataProvider newsDataProvider { get; }

        public INoteDataProvider noteDataProvider { get; }

        public IStickerDataProvider stickerDataProvider { get; }

        public SQLDataProvider(
            IUserDataProvider userDataProvider, 
            INewsDataProvider newsDataProvider, 
            INoteDataProvider noteDataProvider, 
            IStickerDataProvider stickerDataProvider
            )
        {
            this.userDataProvider = userDataProvider;
            this.newsDataProvider = newsDataProvider;
            this.noteDataProvider = noteDataProvider;
            this.stickerDataProvider = stickerDataProvider;
        }
    }
}
