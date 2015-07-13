namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Azure;

    /// <summary>
    /// </summary>
    public partial class Probe : SubResource
    {
        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// A unique read-only string that changes whenever the resource is
        /// updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets Load balancer rules that use this probe
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancingRules")]
        public IList<SubResource> LoadBalancingRules { get; set; }

        /// <summary>
        /// Gets or sets the protocol of the end point. Possible values are
        /// http pr Tcp. If Tcp is specified, a received ACK is required for
        /// the probe to be successful. If http is specified,a 200 OK
        /// response from the specifies URI is required for the probe to be
        /// successful. Possible values for this property include: 'Http',
        /// 'Tcp'
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocol")]
        public ProbeProtocol? Protocol { get; set; }

        /// <summary>
        /// Gets or sets Port for communicating the probe. Possible values
        /// range from 1 to 65535, inclusive.
        /// </summary>
        [JsonProperty(PropertyName = "properties.port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or sets the interval, in seconds, for how frequently to probe
        /// the endpoint for health status. Typically, the interval is
        /// slightly less than half the allocated timeout period (in seconds)
        /// which allows two full probes before taking the instance out of
        /// rotation. The default value is 15, the minimum value is 5
        /// </summary>
        [JsonProperty(PropertyName = "properties.intervalInSeconds")]
        public int? IntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the number of probes where if no response, will
        /// result in stopping further traffic from being delivered to the
        /// endpoint. This values allows endponints to be taken out of
        /// rotation faster or slower than the typical times used in Azure.
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfProbes")]
        public int? NumberOfProbes { get; set; }

        /// <summary>
        /// Gets or sets the URI used for requesting health status from the
        /// VM. Path is required if a protocol is set to http. Otherwise, it
        /// is not allowed. There is no default value
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestPath")]
        public string RequestPath { get; set; }

    }
}