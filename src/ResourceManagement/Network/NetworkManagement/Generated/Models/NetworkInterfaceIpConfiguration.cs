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
    public partial class NetworkInterfaceIpConfiguration : SubResource
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
        /// Gets or sets the privateIPAddress of the Network Interface IP
        /// Configuration
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAddress")]
        public string PrivateIPAddress { get; set; }

        /// <summary>
        /// Gets or sets PrivateIP allocation method (Static/Dynamic).
        /// Possible values for this property include: 'Static', 'Dynamic'
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAllocationMethod")]
        public IpAllocationMethod? PrivateIPAllocationMethod { get; set; }

        /// <summary>
        /// Gets or sets the reference of the subnet resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public SubResource Subnet { get; set; }

        /// <summary>
        /// Gets or sets the reference of the PublicIP resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddress")]
        public SubResource PublicIPAddress { get; set; }

        /// <summary>
        /// Gets or sets the reference of LoadBalancerBackendAddressPool
        /// resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancerBackendAddressPools")]
        public IList<SubResource> LoadBalancerBackendAddressPools { get; set; }

        /// <summary>
        /// Gets or sets list of references of LoadBalancerInboundNatRules
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancerInboundNatRules")]
        public IList<SubResource> LoadBalancerInboundNatRules { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.Subnet != null)
            {
                this.Subnet.Validate();
            }
            if (this.PublicIPAddress != null)
            {
                this.PublicIPAddress.Validate();
            }
            if (this.LoadBalancerBackendAddressPools != null)
            {
                foreach ( var element in this.LoadBalancerBackendAddressPools)
            {
                if (element != null)
            {
                element.Validate();
            }
            }
            }
            if (this.LoadBalancerInboundNatRules != null)
            {
                foreach ( var element1 in this.LoadBalancerInboundNatRules)
            {
                if (element1 != null)
            {
                element1.Validate();
            }
            }
            }
        }
    }
}