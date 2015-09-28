namespace MovieNetApi
{
    using Nancy;
    using MovieNet.Domain;

    public class MoviesModule : NancyModule
    {
        public static MovieService service = new MovieService(); 
     
        public MoviesModule()
        {
            Get["/Movies/{id}"] = parameters =>
            {
                return service.GetMovieById(parameters.id);
            };

        }
    }
}