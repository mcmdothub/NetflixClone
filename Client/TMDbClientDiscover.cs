using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DotnetFlix.Objects.Discover;
using DotnetFlix.Objects.General;
using DotnetFlix.Rest;
using DotnetFlix.Utilities;

namespace DotnetFlix.Client
{
    public partial class TMDbClient
    {
        /// <summary>
        /// Can be used to discover movies matching certain criteria
        /// </summary>
        public DiscoverMovie DiscoverMoviesAsync()
        {
            return new DiscoverMovie(this);
        }

        internal async Task<SearchContainer<T>> DiscoverPerformAsync<T>(string endpoint, string language, int page, SimpleNamedValueCollection parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            RestRequest request = _client.Create(endpoint);

            if (page != 1 && page > 1)
                request.AddParameter("page", page.ToString());

            if (!string.IsNullOrWhiteSpace(language))
                request.AddParameter("language", language);

            foreach (KeyValuePair<string, string> pair in parameters)
                request.AddParameter(pair.Key, pair.Value);

            RestResponse<SearchContainer<T>> response = await request.ExecuteGet<SearchContainer<T>>(cancellationToken).ConfigureAwait(false);
            return response;
        }

        /// <summary>
        /// Can be used to discover new tv shows matching certain criteria
        /// </summary>
        public DiscoverTv DiscoverTvShowsAsync()
        {
            return new DiscoverTv(this);
        }
    }
}
