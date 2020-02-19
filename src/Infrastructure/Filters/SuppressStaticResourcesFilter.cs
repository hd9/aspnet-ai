using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace aspnet_ai.Infrastructure.Filters
{
    public class SuppressStaticResourcesFilter : ITelemetryProcessor
    {
        private ITelemetryProcessor Next { get; set; }
        static readonly List<string> names = new List<string> { "favicon.ico", "bootstrap", "jquery", "site.css", "site.js" };

        // next will point to the next TelemetryProcessor in the chain.
        public SuppressStaticResourcesFilter(ITelemetryProcessor next)
        {
            Next = next;
        }

        public void Process(ITelemetry item)
        {
            var req = item as RequestTelemetry;
            if (req != null && names.Any(n => req.Name.Contains(n)))
            {
                return;
            }

            // Send everything else
            this.Next.Process(item);
        }
    }
}
