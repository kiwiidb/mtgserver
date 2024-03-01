using Microsoft.EntityFrameworkCore;

public class Db : DbContext
{

    public Db(DbContextOptions options) : base(options) { }
    public DbSet<Game> Games { get; set; }
    public DbSet<Player> Players { get; set; }

}

