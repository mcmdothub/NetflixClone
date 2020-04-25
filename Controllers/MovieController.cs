using cloudscribe.Pagination.Models;
using DotnetFlix.Client;
using DotnetFlix.Objects.Discover;
using DotnetFlix.Objects.General;
using DotnetFlix.Objects.Movies;
using DotnetFlix.Objects.Search;
using DotnetFlix.Objects.TvShows;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFlix.Controllers
{
    public class MovieController : Controller
    {
        //Index Controller
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Movies()
        {
            return View();
        }

        [Authorize]
        public ActionResult BrowseNowPlaying()
        {
            return View();
        }

        [Authorize]
        public ActionResult BrowsePopular()
        {
            return View();
        }

        [Authorize]
        public ActionResult BrowseUpComing()
        {
            return View();
        }

        [Authorize]
        public ActionResult TvShows()
        {
            return View();
        }

        [Authorize]
        public ActionResult MyList()
        {
            return View();
        }

        [Authorize]
        public ActionResult Kids()
        {
            return View();
        }

        [Authorize]
        public ActionResult Notifications()
        {
            return View();
        }



        // MOVIES

        //SearchMovie Controller
        public async Task<IActionResult> SearchMovie(string searchString, int? page)
        {

            TMDbClient client = new TMDbClient("02214396be00b0615b4005941508943d");

            if (searchString == null)
            {
                searchString = "&! Invalid Search : Must Enter In Text !&";
            }
            ViewData["Query"] = searchString;

            var pageNumber = page ?? 1;

            await FetchConfig(client);

            return View(await FetchMovies(client, searchString, pageNumber));
        }

        //FilterMovie Controller
        public async Task<IActionResult> FilterMovie(int[] genres, int? page, DiscoverMovieSortBy sortby, int year)
        {
            TMDbClient client = new TMDbClient("02214396be00b0615b4005941508943d");

            var pageNumber = page ?? 1;

            await FetchConfig(client);

            return View(FilterMovies(client, genres, pageNumber, sortby, year));
        }

        //MovieDetail Controller
        public async Task<IActionResult> MovieDetails(int movieId)
        {
            TMDbClient client = new TMDbClient("02214396be00b0615b4005941508943d");

            return View(await FetchMovieDetails(client, movieId));
        }


        //Fetch Json
        private static async Task FetchConfig(TMDbClient client)
        {
            FileInfo configJson = new FileInfo("config.json");

            if (configJson.Exists && configJson.LastWriteTimeUtc >= DateTime.UtcNow.AddHours(-1))
            {
                string json = System.IO.File.ReadAllText(configJson.FullName, Encoding.UTF8);

                client.SetConfig(JsonConvert.DeserializeObject<TMDbConfig>(json));

            }
            else
            {
                var config = await client.GetConfigAsync();

                string json = JsonConvert.SerializeObject(config);
                System.IO.File.WriteAllText(configJson.FullName, json, Encoding.UTF8);
            }
        }

        //Fetch Movies with search string
        private static async Task<PagedResult<Movie>> FetchMovies(TMDbClient client, string query, int page)
        {

            SearchContainer<SearchMovie> results = await client.SearchMovieAsync(query, page);

            var getMovies = (from result in results.Results
                             select new
                             {
                                 Title = result.Title,
                                 PosterPath = result.PosterPath,
                                 Id = result.Id

                             }).ToList().Select(p => new Movie()
                             {
                                 Title = p.Title,
                                 PosterPath = p.PosterPath,
                                 Id = p.Id
                             });

            var pagedMovie = new PagedResult<Movie>
            {
                Data = getMovies.ToList(),
                TotalItems = results.TotalResults,
                PageNumber = page,
                PageSize = 21
            };

            return pagedMovie;
        }

        //Fetch movie details for movie detail view
        private static async Task<Movie> FetchMovieDetails(TMDbClient client, int movieId)
        {
            Movie movieDetails = await client.GetMovieAsync(movieId, MovieMethods.Credits);

            return movieDetails;
        }

        //Discover Movie through filtering
        private static PagedResult<Movie> FilterMovies(TMDbClient client, int[] genre, int page, DiscoverMovieSortBy sortby, int year)
        {
            DiscoverMovie query = client.DiscoverMoviesAsync().IncludeWithAllOfGenre(genre).WherePrimaryReleaseIsInYear(year).OrderBy(sortby);

            SearchContainer<SearchMovie> results = query.Query(page).Result;

            var getMovies = (from result in results.Results
                             select new
                             {
                                 Title = result.Title,
                                 PosterPath = result.PosterPath,
                                 Id = result.Id

                             }).ToList().Select(p => new Movie()
                             {
                                 Title = p.Title,
                                 PosterPath = p.PosterPath,
                                 Id = p.Id
                             });
            var pagedMovie = new PagedResult<Movie>
            {
                Data = getMovies.ToList(),
                TotalItems = results.TotalResults,
                PageNumber = page,
                PageSize = 21
            };

            return pagedMovie;
        }

    }


}