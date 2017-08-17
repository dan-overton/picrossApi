using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleWeb.Controllers
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<int> Answer { get; set; }
    }
    
    [Route("api/[controller]")]
    public class GamesController : Controller
    {
        IEnumerable<Game> games = new List<Game> {
            new Game{
                Id = 1,
                Name = "Sailing Boat",
                Answer = new List<int> {0, 0, 0, 0, 1, 1, 0, 0, 0, 0,
                      0, 0, 0, 0, 1, 1, 1, 0, 0, 0,
                      0, 0, 0, 0, 1, 0, 1, 1, 0, 0,
                      0, 0, 0, 0, 1, 0, 0, 1, 1, 1,
                      0, 0, 0, 0, 1, 0, 0, 0, 1, 1,
                      0, 0, 0, 0, 1, 1, 1, 1, 1, 1,
                      0, 0, 0, 0, 1, 0, 0, 0, 0, 0,
                      1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                      0, 1, 1, 0, 1, 0, 1, 0, 1, 1,
                      0, 0, 1, 1, 1, 1, 1, 1, 1, 0
                }
            },
            new Game {
                Id = 2,
                Name = "Smiley Face",
				Answer = new List<int> {
					0, 0, 1, 1, 1, 1, 1, 1, 0, 0,
					0, 1, 0, 0, 0, 0, 0, 0, 1, 0,
					1, 0, 0, 0, 0, 0, 0, 0, 0, 1,
					1, 0, 0, 1, 0, 0, 1, 0, 0, 1,
					1, 0, 0, 0, 0, 0, 0, 0, 0, 1,
					1, 0, 0, 0, 0, 0, 0, 0, 0, 1,
					1, 0, 1, 0, 0, 0, 0, 1, 0, 1,
					1, 0, 0, 1, 1, 1, 1, 0, 0, 1,
					0, 1, 0, 0, 0, 0, 0, 0, 1, 0,
					0, 0, 1, 1, 1, 1, 1, 1, 0, 0}
            },
		    new Game {
				Id = 3,
				Name = "Coffee",
				Answer = new List<int> {
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 1, 1, 1, 1, 1, 1, 1, 0, 0,
					0, 1, 0, 0, 0, 0, 0, 1, 1, 1,
					0, 1, 0, 0, 0, 0, 0, 1, 0, 1,
					0, 1, 0, 0, 0, 0, 0, 1, 0, 1,
					0, 1, 0, 0, 0, 0, 0, 1, 1, 1,
					0, 1, 0, 0, 0, 0, 0, 1, 0, 0,
					0, 0, 1, 0, 0, 0, 1, 0, 0, 0,
					0, 0, 0, 1, 1, 1, 0, 0, 0, 0,
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
			}
        };

        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return games;
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var game = games.FirstOrDefault(g => g.Id == id);

            if(game == null) 
            {
                return NotFound();
            }

            return new ObjectResult(game);
        }
    }
}
