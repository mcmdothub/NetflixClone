﻿using System.Threading;
using System.Threading.Tasks;
using DotnetFlix.Objects.Credit;
using DotnetFlix.Rest;

namespace DotnetFlix.Client
{
    public partial class TMDbClient
    {
        public async Task<Credit> GetCreditsAsync(string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await GetCreditsAsync(id, DefaultLanguage, cancellationToken).ConfigureAwait(false);
        }

        public async Task<Credit> GetCreditsAsync(string id, string language, CancellationToken cancellationToken = default(CancellationToken))
        {
            RestRequest req = _client.Create("credit/{id}");

            if (!string.IsNullOrEmpty(language))
                req.AddParameter("language", language);

            req.AddUrlSegment("id", id);

            RestResponse<Credit> resp = await req.ExecuteGet<Credit>(cancellationToken).ConfigureAwait(false);

            return resp;
        }
    }
}
