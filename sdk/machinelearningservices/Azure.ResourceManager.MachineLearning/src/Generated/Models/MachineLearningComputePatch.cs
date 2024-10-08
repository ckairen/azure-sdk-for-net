// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> AmlCompute update parameters. </summary>
    public partial class MachineLearningComputePatch
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningComputePatch"/>. </summary>
        public MachineLearningComputePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningComputePatch"/>. </summary>
        /// <param name="properties"> Properties of ClusterUpdate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningComputePatch(ScaleSettingsInformation properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Properties of ClusterUpdate. </summary>
        internal ScaleSettingsInformation Properties { get; set; }
        /// <summary> scale settings for AML Compute. </summary>
        [WirePath("properties.properties.scaleSettings")]
        public AmlComputeScaleSettings ScaleSettings
        {
            get => Properties is null ? default : Properties.ScaleSettings;
            set
            {
                if (Properties is null)
                    Properties = new ScaleSettingsInformation();
                Properties.ScaleSettings = value;
            }
        }
    }
}
