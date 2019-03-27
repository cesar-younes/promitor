using System;
using System.Collections.Generic;
using System.Text;

namespace Promitor.Core.Scraping.Configuration.Model.Metrics.ResourceTypes
{
    public class CosmosDbMetricDefinition : MetricDefinition
    {
        public string TotalRequests { get; set; }
        public string DbName { get; set; }
        public string Kind { get; set; }

        public override ResourceType ResourceType { get; set; } = ResourceType.CosmosDb;
    }
}
