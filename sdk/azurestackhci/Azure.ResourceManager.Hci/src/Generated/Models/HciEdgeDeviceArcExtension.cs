// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Arc extension installed on edge device. </summary>
    public partial class HciEdgeDeviceArcExtension
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

        /// <summary> Initializes a new instance of <see cref="HciEdgeDeviceArcExtension"/>. </summary>
        internal HciEdgeDeviceArcExtension()
        {
            ErrorDetails = new ChangeTrackingList<HciValidationFailureDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="HciEdgeDeviceArcExtension"/>. </summary>
        /// <param name="extensionName"> Arc extension name installed on edge device. </param>
        /// <param name="state"> Arc extension state from arc machine extension. </param>
        /// <param name="errorDetails"> Error details while installing Arc extension. </param>
        /// <param name="extensionResourceId"> Arc Extension Azure resource id. </param>
        /// <param name="typeHandlerVersion"> Extension version installed. </param>
        /// <param name="managedBy"> Extension managed by user or Azure. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HciEdgeDeviceArcExtension(string extensionName, ArcExtensionState? state, IReadOnlyList<HciValidationFailureDetail> errorDetails, ResourceIdentifier extensionResourceId, string typeHandlerVersion, ArcExtensionManagedBy? managedBy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ExtensionName = extensionName;
            State = state;
            ErrorDetails = errorDetails;
            ExtensionResourceId = extensionResourceId;
            TypeHandlerVersion = typeHandlerVersion;
            ManagedBy = managedBy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Arc extension name installed on edge device. </summary>
        [WirePath("extensionName")]
        public string ExtensionName { get; }
        /// <summary> Arc extension state from arc machine extension. </summary>
        [WirePath("state")]
        public ArcExtensionState? State { get; }
        /// <summary> Error details while installing Arc extension. </summary>
        [WirePath("errorDetails")]
        public IReadOnlyList<HciValidationFailureDetail> ErrorDetails { get; }
        /// <summary> Arc Extension Azure resource id. </summary>
        [WirePath("extensionResourceId")]
        public ResourceIdentifier ExtensionResourceId { get; }
        /// <summary> Extension version installed. </summary>
        [WirePath("typeHandlerVersion")]
        public string TypeHandlerVersion { get; }
        /// <summary> Extension managed by user or Azure. </summary>
        [WirePath("managedBy")]
        public ArcExtensionManagedBy? ManagedBy { get; }
    }
}
