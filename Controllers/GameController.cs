using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Modul10_103022400142.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Components.Route("[controller]")]
    public class GameController : ControllerBase
    {
        private static List<Game> games = new List<Game>
            {
            new Game {Id = 1,Name =  "Valorant", Developer = "Riot Games", ReleaseYear = 2020, Genre = "FPS", Rating = 8.5, Platforms = ["PC"], Modes = ["Multiplayer"],isOnline = true, Harga = 0 },
            //new Game { 1,  "GTA V", "Rockstar Games",2013, "Open World", 9.5, ["PC"], ["Multiplayer"], true, 300000 },
            //new Game { 1,  "The Witcher 3", "CD Project Red",2015, "RPG", 9.7, ["PC"], ["Single Player"], false, 250000 },
        };

        [HttpGet]
        public IEnumerable<List<Game>> Get()
        {
            return games;
        }
        [HttpGet("{id}")]
        public Game GetById(int id)
        {
            return Games[id];
        }
        [HttpPost]
        public void Post(Game newGame)
        {
            Games.Add(newGame);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Games.RemoveAt(id);
        }

        [HttpPut("{id}")]
        
        public void put(int id, Game updatedGame)
        {
            var index = Game.FindIndex(g => g.Id == id);
            if (index != -1)
                return NotFound();
                Games[index] = updatedGame;
            return Ok("update Game");

        }
    }
}
