using DotnetFlix.Client;
using DotnetFlix.Objects.General;
using DotnetFlix.Objects.Movies;
using DotnetFlix.Objects.Search;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFlix.ViewComponents
{
    public class PopularViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            TMDbClient client = new TMDbClient("02214396be00b0615b4005941508943d");

            SearchContainer<SearchMovie> popularMovies = await client.GetMoviePopularListAsync();

            var getPopularMovies = (from result in popularMovies.Results.Take(30)
                                    select new
                                    {
                                        Title = result.Title,
                                        PosterPath = result.BackdropPath,
                                        Id = result.Id

                                    }).ToList().Select(p => new Movie()
                                    {
                                        Title = p.Title,
                                        PosterPath = "https://image.tmdb.org/t/p/original/" + p.PosterPath,
                                        Id = p.Id
                                    });

            return View(getPopularMovies);
        }
    }
}
