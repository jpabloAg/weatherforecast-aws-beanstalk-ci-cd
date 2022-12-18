using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WeatherForecastAWSBeanstalk.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static readonly string[] Movies = new[]
        {
            "Avatar", "Batman", "Superman", "Wonder Woman"
        };

        [HttpGet]
        public IEnumerable<string> GetMovies()
        {
            return Movies;
        }

        [HttpGet("pelicula/{id}")]
        public string GetMovieById(int id)
        {
            return Movies[id];
        }
    }
}
