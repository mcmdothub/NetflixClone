using System.Collections.Generic;

namespace DotnetFlix.Objects.Certifications
{
    public class CertificationsContainer
    {
        public Dictionary<string, List<CertificationItem>> Certifications { get; set; }
    }
}