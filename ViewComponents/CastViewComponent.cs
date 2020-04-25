using DotnetFlix.Client;
using DotnetFlix.Objects.Movies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFlix.ViewComponents
{
    public class CastViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int movieId)
        {
            TMDbClient client = new TMDbClient("02214396be00b0615b4005941508943d");

            Movie movieDetails = await client.GetMovieAsync(movieId, MovieMethods.Credits);

            return View(movieDetails);
        }
    }
}
