// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is

namespace MyNamespace.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// List of resource groups.
    /// </summary>
    public partial class ResourceGroupListResult
    {
        /// <summary>
        /// Gets or sets the list of resource groups.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ResourceGroup> Value { get; set; }

        /// <summary>
        /// Gets or sets the URL to get the next set of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}