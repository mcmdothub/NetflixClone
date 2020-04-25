using System.Net;

namespace DotnetFlix.Objects.Exceptions
{
    public class GeneralHttpException : TMDbException
    {
        public HttpStatusCode HttpStatusCode { get; }

        public GeneralHttpException(HttpStatusCode httpStatusCode)
            : base("TMDb returned an unexpected HTTP error")
        {
            HttpStatusCode = httpStatusCode;
        }
    }
}