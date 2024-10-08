// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The data boundary definition. </summary>
    public readonly partial struct DataBoundaryRegion : IEquatable<DataBoundaryRegion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataBoundaryRegion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataBoundaryRegion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotDefinedValue = "NotDefined";
        private const string GlobalValue = "Global";
        private const string EUValue = "EU";

        /// <summary> NotDefined. </summary>
        public static DataBoundaryRegion NotDefined { get; } = new DataBoundaryRegion(NotDefinedValue);
        /// <summary> Global. </summary>
        public static DataBoundaryRegion Global { get; } = new DataBoundaryRegion(GlobalValue);
        /// <summary> EU. </summary>
        public static DataBoundaryRegion EU { get; } = new DataBoundaryRegion(EUValue);
        /// <summary> Determines if two <see cref="DataBoundaryRegion"/> values are the same. </summary>
        public static bool operator ==(DataBoundaryRegion left, DataBoundaryRegion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataBoundaryRegion"/> values are not the same. </summary>
        public static bool operator !=(DataBoundaryRegion left, DataBoundaryRegion right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataBoundaryRegion"/>. </summary>
        public static implicit operator DataBoundaryRegion(string value) => new DataBoundaryRegion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataBoundaryRegion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataBoundaryRegion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
