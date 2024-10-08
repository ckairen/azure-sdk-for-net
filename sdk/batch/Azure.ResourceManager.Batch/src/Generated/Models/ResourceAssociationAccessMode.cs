// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Access mode of the resource association. </summary>
    public readonly partial struct ResourceAssociationAccessMode : IEquatable<ResourceAssociationAccessMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceAssociationAccessMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceAssociationAccessMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnforcedValue = "Enforced";
        private const string LearningValue = "Learning";
        private const string AuditValue = "Audit";

        /// <summary> Enforced access mode - traffic to the resource that failed access checks is blocked. </summary>
        public static ResourceAssociationAccessMode Enforced { get; } = new ResourceAssociationAccessMode(EnforcedValue);
        /// <summary> Learning access mode - traffic to the resource is enabled for analysis but not blocked. </summary>
        public static ResourceAssociationAccessMode Learning { get; } = new ResourceAssociationAccessMode(LearningValue);
        /// <summary> Audit access mode - traffic to the resource that fails access checks is logged but not blocked. </summary>
        public static ResourceAssociationAccessMode Audit { get; } = new ResourceAssociationAccessMode(AuditValue);
        /// <summary> Determines if two <see cref="ResourceAssociationAccessMode"/> values are the same. </summary>
        public static bool operator ==(ResourceAssociationAccessMode left, ResourceAssociationAccessMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceAssociationAccessMode"/> values are not the same. </summary>
        public static bool operator !=(ResourceAssociationAccessMode left, ResourceAssociationAccessMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResourceAssociationAccessMode"/>. </summary>
        public static implicit operator ResourceAssociationAccessMode(string value) => new ResourceAssociationAccessMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceAssociationAccessMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceAssociationAccessMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
