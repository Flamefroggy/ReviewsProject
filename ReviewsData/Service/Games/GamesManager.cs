using Microsoft.EntityFrameworkCore;
using ReviewsData.Model;

namespace ReviewsData.Service.Games;

public class GamesManager : IGamesManager
{
    private readonly IDbContextFactory<ReviewsDbContext> _contextFactory;
    
    public GamesManager(IDbContextFactory<ReviewsDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public List<Game> Get()
    {
        using var db = _contextFactory.CreateDbContext();
        try
        {
            return db.Games.Cast<Game>().ToList();
        }
        catch (Exception ex)
        {
            throw new Exception("Не удалось выполнить", ex);
        }
    }

    public Game Create(Game game)
    {
        throw new NotImplementedException();
    }

    public Game Update(Game game)
    {
        throw new NotImplementedException();
    }

    public void Delete(Game game)
    {
        throw new NotImplementedException();
    }
    public Game Get(int id) 
    {
        using var db = _contextFactory.CreateDbContext();
        try
        {
            return db.Games.FirstOrDefault(g => g.Id == id);
        }
        catch (Exception ex)
        {
            throw new Exception("Не удалось выполнить", ex);
        }
    }
}
