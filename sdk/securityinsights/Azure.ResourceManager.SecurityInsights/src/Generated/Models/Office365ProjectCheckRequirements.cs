// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents Office365 Project requirements check request. </summary>
    public partial class Office365ProjectCheckRequirements : DataConnectorsCheckRequirements
    {
        /// <summary> Initializes a new instance of <see cref="Office365ProjectCheckRequirements"/>. </summary>
        public Office365ProjectCheckRequirements()
        {
            Kind = DataConnectorKind.Office365Project;
        }

        /// <summary> Initializes a new instance of <see cref="Office365ProjectCheckRequirements"/>. </summary>
        /// <param name="kind"> Describes the kind of connector to be checked. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="tenantId"> The tenant id to connect to, and get the data from. </param>
        internal Office365ProjectCheckRequirements(DataConnectorKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, Guid? tenantId) : base(kind, serializedAdditionalRawData)
        {
            TenantId = tenantId;
            Kind = kind;
        }

        /// <summary> The tenant id to connect to, and get the data from. </summary>
        [WirePath("properties.tenantId")]
        public Guid? TenantId { get; set; }
    }
}
