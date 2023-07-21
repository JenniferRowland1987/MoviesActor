namespace Movies_Actors.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public List<string> Genres { get; set; }
        public List<int> ActorIds { get; set; }
    }
}
