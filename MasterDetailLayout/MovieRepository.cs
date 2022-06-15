using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailLayout
{
    class MovieRepository
    {
        List<Movie> movies = new List<Movie>
        {
            new Movie
            {
                Id = 1,
                Title = "Star Trek: Beyond",
                ReleaseDate = new DateTime(2016,07,22),
                Director = "Justin Lin",
                IsColor = true,
                Format = "2.35:1",
                Genre ="Sci-Fi"
            },
            new Movie
            {
                Id = 1,
                Title = "Star Wars: The Last Jedi",
                ReleaseDate = new DateTime(2017,12,15),
                Director = "Ryan Johnson",
                IsColor = true,
                Format = "2.39:1",
                Genre ="Epic Space Opera"
            }
        };
        public List<Movie> GetAll()
        {
            return movies;
        }
        public void AddNew(Movie movie)
        {
            movies.Add(movie);
        }
        public void Update(Movie movieToUpdate)
        {
            foreach (Movie movie in movies)
            {
                if (movie.Id == movieToUpdate.Id)
                {
                    movies.Remove(movie);
                    movies.Add(movieToUpdate);
                    break;
                }
            }
        }
    }
}
