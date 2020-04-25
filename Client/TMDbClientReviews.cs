using System.Threading;
using System.Threading.Tasks;
using DotnetFlix.Objects.Reviews;
using DotnetFlix.Rest;

namespace DotnetFlix.Client
{
    public partial class TMDbClient
    {
        public async Task<Review> GetReviewAsync(string reviewId, CancellationToken cancellationToken = default(CancellationToken))
        {
            RestRequest request  = _client.Create("review/{reviewId}");
            request.AddUrlSegment("reviewId", reviewId);

            // TODO: Dateformat?
            //request.DateFormat = "yyyy-MM-dd";

            RestResponse<Review> resp = await request.ExecuteGet<Review>(cancellationToken).ConfigureAwait(false);

            return resp;
        }
    }
}
