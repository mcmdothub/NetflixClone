using System.Threading;
using System.Threading.Tasks;
using DotnetFlix.Objects.Certifications;
using DotnetFlix.Rest;

namespace DotnetFlix.Client
{
    public partial class TMDbClient
    {
        public async Task<CertificationsContainer> GetMovieCertificationsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            RestRequest req = _client.Create("certification/movie/list");

            RestResponse<CertificationsContainer> resp = await req.ExecuteGet<CertificationsContainer>(cancellationToken).ConfigureAwait(false);

            return resp;
        }

        public async Task<CertificationsContainer> GetTvCertificationsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            RestRequest req = _client.Create("certification/tv/list");

            RestResponse<CertificationsContainer> resp = await req.ExecuteGet<CertificationsContainer>(cancellationToken).ConfigureAwait(false);

            return resp;
        }
    }
}
