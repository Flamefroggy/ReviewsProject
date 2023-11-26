using Microsoft.EntityFrameworkCore;
using ReviewsData.Model;
using System.Xml.Linq;

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
            //return db.Games.Cast<Game>().OrderBy(g => g.Name).ToList();
            return db.Games.Cast<Game>().ToList();
        }
        catch (Exception ex)
        {
            throw new Exception("Не удалось выполнить", ex);
        }
    }

    public Game Create(Game game)
    {
        using var db = _contextFactory.CreateDbContext();
        try
        {
            db.Games.Add(game);
            db.SaveChanges();
            return game;
        }
        catch (Exception ex)
        {
            throw new Exception("Не удалось выполнить", ex);
        }
    }

    public Game Update(Game game)
    {
        using var db = _contextFactory.CreateDbContext();
        try
        {
            db.Games.Update(game);
            db.SaveChanges();
            return game;
        }
        catch (Exception ex)
        {
            throw new Exception("Не удалось выполнить", ex);
        }
    }

    public void Delete(Game game)
    {
        using var db = _contextFactory.CreateDbContext();
        try
        {
            db.Games.Remove(game);
            db.SaveChanges();
            return ;
        }
        catch (Exception ex)
        {
            throw new Exception("Не удалось выполнить", ex);
        }
    }
    public Game GetById(int id) 
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
