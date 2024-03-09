using RV.Models;

namespace RV.Repository
{
    public interface IStickerRepository
    {
        Sticker CreateSticker(Sticker item);
        List<Sticker> GetStickers();
        Sticker GetSticker(int id);
        Sticker UpdateSticker(Sticker item);
        int DeleteSticker(int id);
    }
}
