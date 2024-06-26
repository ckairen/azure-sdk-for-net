// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the alternative option specified by the Publisher for this
    /// image when this image is deprecated.
    /// </summary>
    public partial class AlternativeOption
    {
        /// <summary>
        /// Initializes a new instance of the AlternativeOption class.
        /// </summary>
        public AlternativeOption()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlternativeOption class.
        /// </summary>
        /// <param name="type">Describes the type of the alternative option.
        /// Possible values include: 'None', 'Offer', 'Plan'</param>
        /// <param name="value">Indicates the alternative option value
        /// specified by the Publisher. This is the Offer name when the type is
        /// Offer or the Plan name when the type is Plan.</param>
        public AlternativeOption(string type = default(string), string value = default(string))
        {
            Type = type;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes the type of the alternative option. Possible
        /// values include: 'None', 'Offer', 'Plan'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets indicates the alternative option value specified by
        /// the Publisher. This is the Offer name when the type is Offer or the
        /// Plan name when the type is Plan.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
