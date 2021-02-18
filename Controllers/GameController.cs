using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestApplication.Models;

namespace TestApplication.controllers
{
    [ApiController]
    [Route("[controller]")]

    public class GamesController : ControllerBase
    {
        public static List<Games> GetGames()
        {
            List<Games> games = new List<Games>();
            games.Add(new Games(){Id = 1, Name = "Game 1", Price = 10});
            games.Add(new Games(){Id = 2, Name = "Game 1", Price = 15});
            games.Add(new Games(){Id = 3, Name = "Game 1", Price = 20});
            games.Add(new Games(){Id = 4, Name = "Game 1", Price = 25});
            games.Add(new Games(){Id = 5, Name = "Game 1", Price = 30});
            return games;
        }

        [HttpGet]

        public IEnumerable<Games> GetGames_list()
        {
            return GetGames();
        }

        [HttpGet("{id}")]

        public ActionResult<Games> GetGame_byId(int id)
        {
            var games = GetGames().Find(x => x.Id == id);
            if(games != null)
            {
                return games;
            }
            else
            {
                return NotFound();
            }
            
            
        }
    }
}
