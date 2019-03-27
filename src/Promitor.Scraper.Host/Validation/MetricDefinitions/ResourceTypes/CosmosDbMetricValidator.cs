using System.Collections.Generic;
using Promitor.Core.Scraping.Configuration.Model.Metrics.ResourceTypes;
using Promitor.Scraper.Host.Validation.MetricDefinitions.Interfaces;

namespace Promitor.Scraper.Host.Validation.MetricDefinitions.ResourceTypes
{
    public class CosmosDbMetricValidator : IMetricValidator<CosmosDbMetricDefinition>
    {
        public List<string> Validate(CosmosDbMetricDefinition cosmosDbMetricDefinition)
        {
            var errorMessages = new List<string>();

            if (string.IsNullOrWhiteSpace(cosmosDbMetricDefinition.DbName))
            {
                errorMessages.Add("DbName not configured");
            }

            return errorMessages;
        }
    }
}
