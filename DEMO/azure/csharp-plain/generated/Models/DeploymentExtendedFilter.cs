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
    /// Deployment filter.
    /// </summary>
    public partial class DeploymentExtendedFilter
    {
        /// <summary>
        /// Gets or sets the provisioning state.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

    }
}