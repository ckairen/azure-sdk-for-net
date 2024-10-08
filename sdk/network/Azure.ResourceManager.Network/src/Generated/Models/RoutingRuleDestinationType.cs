// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Routing rule destination type. </summary>
    public readonly partial struct RoutingRuleDestinationType : IEquatable<RoutingRuleDestinationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RoutingRuleDestinationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RoutingRuleDestinationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AddressPrefixValue = "AddressPrefix";
        private const string ServiceTagValue = "ServiceTag";

        /// <summary> AddressPrefix. </summary>
        public static RoutingRuleDestinationType AddressPrefix { get; } = new RoutingRuleDestinationType(AddressPrefixValue);
        /// <summary> ServiceTag. </summary>
        public static RoutingRuleDestinationType ServiceTag { get; } = new RoutingRuleDestinationType(ServiceTagValue);
        /// <summary> Determines if two <see cref="RoutingRuleDestinationType"/> values are the same. </summary>
        public static bool operator ==(RoutingRuleDestinationType left, RoutingRuleDestinationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RoutingRuleDestinationType"/> values are not the same. </summary>
        public static bool operator !=(RoutingRuleDestinationType left, RoutingRuleDestinationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RoutingRuleDestinationType"/>. </summary>
        public static implicit operator RoutingRuleDestinationType(string value) => new RoutingRuleDestinationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RoutingRuleDestinationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RoutingRuleDestinationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
