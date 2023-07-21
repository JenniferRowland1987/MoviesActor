using Movies_Actors.Models;

namespace Movies_Actors.MovieDB
{
    public class ActorMovieDB
    {
        public static List<Actor> Actors { get; set; } = new List<Actor>
        {
            new Actor{Id = 0, Name="Tom Hanks", Age=65, IsOscarWinner=true},
            new Actor{Id = 1, Name="Leonardo DiCaprio", Age=46, IsOscarWinner=true},
            new Actor{Id = 2, Name="Brad Pitt", Age=58, IsOscarWinner=false},
            new Actor{Id = 3, Name="Meryl Streep", Age=72, IsOscarWinner=true},
        };

        public static List<Movie> Movies { get; set; } = new List<Movie>
        {
            new Movie{Name="Forrest Gump", Genres=new List<string>{"Drama","Romance"},ActorIds=new List<int>{0,1}},
            new Movie{Name="The Revenant", Genres=new List<string>{"Drama","Adventure"},ActorIds=new List<int>{1}},
            new Movie{Name="Fight Club", Genres=new List<string>{"Drama","Thriller"},ActorIds=new List<int>{2}},



        };
    }
}
