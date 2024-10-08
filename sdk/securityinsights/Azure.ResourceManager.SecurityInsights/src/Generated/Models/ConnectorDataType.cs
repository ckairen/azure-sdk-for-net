// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// The data type which is created by the connector,
    /// including a query indicated when was the last time that data type was received in the workspace.
    /// </summary>
    public partial class ConnectorDataType
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

        /// <summary> Initializes a new instance of <see cref="ConnectorDataType"/>. </summary>
        /// <param name="name"> Gets or sets the name of the data type to show in the graph. </param>
        /// <param name="lastDataReceivedQuery"> Gets or sets the query to indicate when relevant data was last received in the workspace. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="lastDataReceivedQuery"/> is null. </exception>
        public ConnectorDataType(string name, string lastDataReceivedQuery)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(lastDataReceivedQuery, nameof(lastDataReceivedQuery));

            Name = name;
            LastDataReceivedQuery = lastDataReceivedQuery;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectorDataType"/>. </summary>
        /// <param name="name"> Gets or sets the name of the data type to show in the graph. </param>
        /// <param name="lastDataReceivedQuery"> Gets or sets the query to indicate when relevant data was last received in the workspace. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectorDataType(string name, string lastDataReceivedQuery, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            LastDataReceivedQuery = lastDataReceivedQuery;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectorDataType"/> for deserialization. </summary>
        internal ConnectorDataType()
        {
        }

        /// <summary> Gets or sets the name of the data type to show in the graph. </summary>
        [WirePath("name")]
        public string Name { get; set; }
        /// <summary> Gets or sets the query to indicate when relevant data was last received in the workspace. </summary>
        [WirePath("lastDataReceivedQuery")]
        public string LastDataReceivedQuery { get; set; }
    }
}
