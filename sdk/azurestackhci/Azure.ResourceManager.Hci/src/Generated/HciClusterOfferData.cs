// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing the HciClusterOffer data model.
    /// Offer details.
    /// </summary>
    public partial class HciClusterOfferData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HciClusterOfferData"/>. </summary>
        public HciClusterOfferData()
        {
            SkuMappings = new ChangeTrackingList<HciSkuMappings>();
        }

        /// <summary> Initializes a new instance of <see cref="HciClusterOfferData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning State. </param>
        /// <param name="publisherId"> Identifier of the Publisher for the offer. </param>
        /// <param name="content"> JSON serialized catalog content of the offer. </param>
        /// <param name="contentVersion"> The API version of the catalog service used to serve the catalog content. </param>
        /// <param name="skuMappings"> Array of SKU mappings. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HciClusterOfferData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string provisioningState, string publisherId, string content, string contentVersion, IList<HciSkuMappings> skuMappings, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            PublisherId = publisherId;
            Content = content;
            ContentVersion = contentVersion;
            SkuMappings = skuMappings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Provisioning State. </summary>
        [WirePath("properties.provisioningState")]
        public string ProvisioningState { get; }
        /// <summary> Identifier of the Publisher for the offer. </summary>
        [WirePath("properties.publisherId")]
        public string PublisherId { get; set; }
        /// <summary> JSON serialized catalog content of the offer. </summary>
        [WirePath("properties.content")]
        public string Content { get; set; }
        /// <summary> The API version of the catalog service used to serve the catalog content. </summary>
        [WirePath("properties.contentVersion")]
        public string ContentVersion { get; set; }
        /// <summary> Array of SKU mappings. </summary>
        [WirePath("properties.skuMappings")]
        public IList<HciSkuMappings> SkuMappings { get; }
    }
}
