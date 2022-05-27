// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Endpoint service. </summary>
    public partial class EndpointServiceResult : NetworkSubResource
    {
        /// <summary> Initializes a new instance of EndpointServiceResult. </summary>
        public EndpointServiceResult()
        {
        }

        /// <summary> Initializes a new instance of EndpointServiceResult. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Name of the endpoint service. </param>
        /// <param name="resourceType"> Type of the endpoint service. </param>
        internal EndpointServiceResult(ResourceIdentifier id, string name, ResourceType? resourceType) : base(id)
        {
            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> Name of the endpoint service. </summary>
        public string Name { get; }
        /// <summary> Type of the endpoint service. </summary>
        public ResourceType? ResourceType { get; }
    }
}
