using ReviewsData.Model;

namespace ReviewsData.Service.Games;

public interface IGamesManager
{
    List<Game> Get();
    Game Create(Game game);
    Game Update(Game game);
    void Delete(Game game);
}
