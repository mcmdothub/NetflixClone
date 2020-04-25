using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DotnetFlix.Objects.General;
using DotnetFlix.Objects.Search;
using DotnetFlix.Objects.Trending;
using DotnetFlix.Objects.TvShows;
using DotnetFlix.Rest;

namespace DotnetFlix.Client
{
    public partial class TMDbClient
    {
        public async Task<SearchContainer<SearchMovie>> GetTrendingMoviesAsync(TimeWindow timeWindow, CancellationToken cancellationToken = default(CancellationToken))
        {
            RestRequest req = _client.Create("trending/movie/{time_window}");
            req.AddUrlSegment("time_window", timeWindow.ToString());

            RestResponse<SearchContainer<SearchMovie>> resp = await req.ExecuteGet<SearchContainer<SearchMovie>>(cancellationToken).ConfigureAwait(false);

            return resp;
        }

        public async Task<SearchContainer<SearchTv>> GetTrendingTvAsync(TimeWindow timeWindow, CancellationToken cancellationToken = default(CancellationToken))
        {
            RestRequest req = _client.Create("trending/tv/{time_window}");
            req.AddUrlSegment("time_window", timeWindow.ToString());

            RestResponse<SearchContainer<SearchTv>> resp = await req.ExecuteGet<SearchContainer<SearchTv>>(cancellationToken).ConfigureAwait(false);

            return resp;
        }

        public async Task<SearchContainer<SearchPerson>> GetTrendingPeopleAsync(TimeWindow timeWindow, CancellationToken cancellationToken = default(CancellationToken))
        {
            RestRequest req = _client.Create("trending/person/{time_window}");
            req.AddUrlSegment("time_window", timeWindow.ToString());

            RestResponse<SearchContainer<SearchPerson>> resp = await req.ExecuteGet<SearchContainer<SearchPerson>>(cancellationToken).ConfigureAwait(false);

            return resp;
        }
    }
}