using System.Collections.Generic;

namespace Glimpse.Package
{
    public class ReleaseQueryInfo
    {
        public bool HasNewer { get; set; }

        public string ViewLink { get; set; }

        public IDictionary<string, ReleaseQueryDetails> Details { get; set; }
    }
}