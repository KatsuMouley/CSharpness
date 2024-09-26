using Microsoft.AspNetCore.Mvc;
using Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameConsole> consoles = new List<GameConsole> // Renomeado para GameConsole
{
    new GameConsole { Nome = "PlayStation 5", Valor = 5000.00 },
    new GameConsole { Nome = "Xbox Series X", Valor = 4999.99 },
    new GameConsole { Nome = "Nintendo Switch", Valor = 2999.99 },
    new GameConsole { Nome = "Sega Genesis Mini", Valor = 699.99 },
    new GameConsole { Nome = "Sony PlayStation 4 Pro", Valor = 3499.99 },
    new GameConsole { Nome = "Xbox One X", Valor = 3999.99 },
    new GameConsole { Nome = "Nintendo Wii U", Valor = 1499.99 },
    new GameConsole { Nome = "Atari VCS", Valor = 1299.99 },
    new GameConsole { Nome = "Neo Geo Mini", Valor = 999.99 },
    new GameConsole { Nome = "Steam Deck", Valor = 2499.99 }
};

app.MapGet("/", () => "Ola Mundo! Sou a primeira API CRUD de Katsu Mouley Escrita em C#!");
app.MapGet("/ola mundo", () => "Hello World! hehehehhehe OI MUNDO, huahahauhaua Ola planeta!");


//GET: /api/produto/listar
app.MapGet("/console/listar", () =>
{
    if (consoles.Count > 0)
    {
        return Results.Ok(consoles);
    }
    return Results.NotFound();
});

app.Run();
