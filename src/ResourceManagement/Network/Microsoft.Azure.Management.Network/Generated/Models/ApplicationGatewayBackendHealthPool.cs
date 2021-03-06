// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Application gateway backendhealth pool.
    /// </summary>
    public partial class ApplicationGatewayBackendHealthPool
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHealthPool class.
        /// </summary>
        public ApplicationGatewayBackendHealthPool() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHealthPool class.
        /// </summary>
        public ApplicationGatewayBackendHealthPool(ApplicationGatewayBackendAddressPool backendAddressPool = default(ApplicationGatewayBackendAddressPool), IList<ApplicationGatewayBackendHealthHttpSettings> backendHttpSettingsCollection = default(IList<ApplicationGatewayBackendHealthHttpSettings>))
        {
            BackendAddressPool = backendAddressPool;
            BackendHttpSettingsCollection = backendHttpSettingsCollection;
        }

        /// <summary>
        /// Reference of application gateway backend address pool resource.
        /// </summary>
        [JsonProperty(PropertyName = "backendAddressPool")]
        public ApplicationGatewayBackendAddressPool BackendAddressPool { get; set; }

        /// <summary>
        /// List of application gateway backendhealth http settings.
        /// </summary>
        [JsonProperty(PropertyName = "backendHttpSettingsCollection")]
        public IList<ApplicationGatewayBackendHealthHttpSettings> BackendHttpSettingsCollection { get; set; }

    }
}
