using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies_Actors.MovieDB;
using Movies_Actors.Models;

namespace Movies_Actors.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieActorController : ControllerBase
    {
        [HttpGet("SearchActors/{name}")]
        //Hey maybe we'll need the ienumerable thing, maybe not?????????? <IEnumerable<Actor>>
        public ActionResult SearchActors(string name)
        {
            var actor = ActorMovieDB.Actors.Where(actor => actor.Name == name).FirstOrDefault();
            return Ok(actor);
        }

        [HttpGet("GetActor/{id}")]
        public ActionResult GetActor(int id)
        {
            var actor = ActorMovieDB.Actors.Where(actor => actor.Id == id);
            return Ok(actor);
        }

        [HttpGet("GetActors")]
        public ActionResult<IEnumerable<Actor>> GetActors()
        {
            return Ok(ActorMovieDB.Actors);
        }

        [HttpGet("SearchMoviesByActorName")]
        public ActionResult<IEnumerable<Movie>> GetMovieByName(string name)
        {
            var actor = ActorMovieDB.Actors.Where(actor => actor.Name == name).FirstOrDefault();
            var movie = ActorMovieDB.Movies.Where(movie => movie.ActorIds.Contains(actor.Id)).ToList();
            return Ok(movie);            

        }
        [HttpGet("SearchMoviesByActorId")]
        public ActionResult<IEnumerable<Movie>> GetMovieByName(int id)
        {
            
            var movie = ActorMovieDB.Movies.Where(movie => movie.ActorIds.Contains(id)).ToList();
            return Ok(movie);

        }






    }
}
