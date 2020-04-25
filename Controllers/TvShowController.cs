using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cloudscribe.Pagination.Models;
using DotnetFlix.Client;
using DotnetFlix.Objects.Discover;
using DotnetFlix.Objects.General;
using DotnetFlix.Objects.TvShows;
using DotnetFlix.Objects.Search;
using Microsoft.AspNetCore.Authorization;

namespace DotnetFlix.Controllers
{
    public class TvShowController : Controller
    {
        [Authorize]
        public IActionResult TvShows()
        {
            return View();
        }


        //SearchMovie Controller
        public async Task<IActionResult> SearchTVShow(string searchString, int? page)
        {

            TMDbClient client = new TMDbClient("02214396be00b0615b4005941508943d");

            if (searchString == null)
            {
                searchString = "&! Invalid Search : Must Enter In Text !&";
            }
            ViewData["Query"] = searchString;

            var pageNumber = page ?? 1;

            await FetchConfig(client);

            return View(await FetchTvShows(client, searchString, pageNumber));
        }
        //Filter TV Controller
        public async Task<IActionResult> FilterTvShow(int[] genres, int? page, DiscoverTvShowSortBy sortby, int year)
        {
            TMDbClient client = new TMDbClient("02214396be00b0615b4005941508943d");

            var pageNumber = page ?? 1;

            await FetchConfig(client);

            return View(FilterTvShows(client, genres, pageNumber, sortby, year));
        }


        //TV Detail Controller
        public async Task<IActionResult> TvShowDetails(int tvId)
        {
            TMDbClient client = new TMDbClient("02214396be00b0615b4005941508943d");

            return View(await FetchTvShowDetails(client, tvId));
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

        //Fetch TV with search string
        private static async Task<PagedResult<TvShow>> FetchTvShows(TMDbClient client, string query, int page)
        {

            SearchContainer<SearchTv> results = await client.SearchTvShowAsync(query, page);

            var getTvShows = (from result in results.Results
                              select new
                              {
                                  Title = result.Name,
                                  PosterPath = result.PosterPath,
                                  Id = result.Id

                              }).ToList().Select(p => new TvShow()
                              {
                                  Name = p.Title,
                                  PosterPath = p.PosterPath,
                                  Id = p.Id
                              });

            var pagedTvShow = new PagedResult<TvShow>
            {
                Data = getTvShows.ToList(),
                TotalItems = results.TotalResults,
                PageNumber = page,
                PageSize = 21
            };

            return pagedTvShow;
        }

        //Fetch TV details for movie detail view
        private static async Task<TvShow> FetchTvShowDetails(TMDbClient client, int tvId)
        {
            TvShow tvDetails = await client.GetTvShowAsync(tvId, TvShowMethods.Credits);

            return tvDetails;
        }


        //Discover TV through filtering
        private static PagedResult<TvShow> FilterTvShows(TMDbClient client, int[] genre, int page, DiscoverTvShowSortBy sortby, int year)
        {
            DiscoverTv query = client.DiscoverTvShowsAsync().WhereGenresInclude(genre).WhereFirstAirDateIsInYear(year).OrderBy(sortby);

            SearchContainer<SearchTv> results = query.Query(page).Result;

            var getTvShows = (from result in results.Results
                              select new
                              {
                                  Name = result.Name,
                                  PosterPath = result.PosterPath,
                                  Id = result.Id

                              }).ToList().Select(p => new TvShow()
                              {
                                  Name = p.Name,
                                  PosterPath = p.PosterPath,
                                  Id = p.Id
                              });
            var pagedTvShow = new PagedResult<TvShow>
            {
                Data = getTvShows.ToList(),
                TotalItems = results.TotalResults,
                PageNumber = page,
                PageSize = 21
            };

            return pagedTvShow;
        }
    }
}