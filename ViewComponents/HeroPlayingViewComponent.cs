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
    public class HeroPlayingViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            TMDbClient client = new TMDbClient("02214396be00b0615b4005941508943d");

            SearchContainer<SearchMovie> nowPlaying = await client.GetMovieNowPlayingListAsync();

            var getHeroPlaying = (from result in nowPlaying.Results.Take(1)
                                 select new
                                 {
                                     Title = result.Title,
                                     PosterPath = result.BackdropPath,
                                     ReleaseDate = result.ReleaseDate,
                                     VoteAverage = result.VoteAverage,
                                     Video = result.Video,
                                     Genre = result.GenreIds,
                                     Id = result.Id

                                 }).ToList().Select(p => new Movie()
                                 {
                                     Title = p.Title,
                                     PosterPath = "https://image.tmdb.org/t/p/original/" + p.PosterPath,
                                     ReleaseDate = p.ReleaseDate,
                                     VoteAverage = p.VoteAverage,                                     
                                     Genre = p.Genre,
                                     Id = p.Id,
                                     Video = p.Video
                                 });

            return View(getHeroPlaying);
        }

    }
}
