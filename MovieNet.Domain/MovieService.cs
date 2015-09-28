using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDbLib.Objects.Movies;

namespace MovieNet.Domain
{
    public class MovieService : ServiceBase
    {
        public object GetMovieById(int movieId)
        {
            var result = client.GetMovie(movieId);
            return result;
        }
    }
}
