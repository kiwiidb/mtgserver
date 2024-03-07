using System.Text.Json.Serialization;
using System;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Console;
using Microsoft.OpenApi.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
var connectionString = builder.Configuration.GetConnectionString("sqlite") ?? "";
builder.Services.AddDbContext<Db>(options => options.UseSqlite(connectionString));
builder.Services.Configure<JsonOptions>(
	options => {
		    options.SerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
	}
);
builder.Services.AddSwaggerGen(c =>
{
     c.SwaggerDoc("v1", new OpenApiInfo { Title = "MtgServer API", Description = "", Version = "v1" });
});

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var dbContext = services.GetRequiredService<Db>();
        dbContext.Database.Migrate();
    }
    catch (Exception ex)
    {
        // Handle error
        Console.WriteLine($"An error occurred while migrating the database: {ex.Message}");
    }
}
app.UseSwagger();
app.UseSwaggerUI(c =>
{
   c.SwaggerEndpoint("/swagger/v1/swagger.json", "MtgServer API V1");
});

app.MapPost("/players", (Db db, Player newPlayer) => {
    db.Add(newPlayer);	
	db.SaveChanges();
	return Results.Created($"/players/{newPlayer.Id}", newPlayer);
});

app.MapGet("/players", (Db db) => {
	return db.Players.Include(p => p.Decks).ToList();
});
app.MapGet("/games", (Db db) => {
	return db.Games.ToList();
});
//add deck for player
app.MapPost("/players/{id}/decks", (int id, Db db, Deck d) => {
	var p = db.Players
	.Include(p => p.Decks)
	.SingleOrDefault(p => p.Id == id);
    p?.Decks?.Add(d);
	db.SaveChanges();
});
//create game
app.MapPost("/games", (Db db, Game g) => {
    db.Add(g);	
	db.SaveChanges();
	return Results.Created($"/players/{g.Id}", g);
});

//calculate ranking
app.MapGet("/ranking", (Db db) => {
	var games = db.Games.ToList();
	var players = db.Players.ToList();
	var res = new List<Ranking>();
	foreach (var p in players) {
		res.Add(new Ranking(){
			Name = p.Name,
			Wins = 0,
		});
	}
	foreach (var g in games) {
	var r = res.Find(r => r.Name == g.Winner);
	if (r != null){
		r.Wins += 1;
	}
	}
	return res.OrderBy(o => o.Wins).Reverse().ToList();
});

app.Run();
