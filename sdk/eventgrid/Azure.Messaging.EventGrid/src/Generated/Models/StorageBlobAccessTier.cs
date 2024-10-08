// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> The access tier of the blob. </summary>
    public readonly partial struct StorageBlobAccessTier : IEquatable<StorageBlobAccessTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageBlobAccessTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageBlobAccessTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HotValue = "Hot";
        private const string CoolValue = "Cool";
        private const string ColdValue = "Cold";
        private const string ArchiveValue = "Archive";
        private const string DefaultValue = "Default";

        /// <summary> The blob is in access tier Hot. </summary>
        public static StorageBlobAccessTier Hot { get; } = new StorageBlobAccessTier(HotValue);
        /// <summary> The blob is in access tier Cool. </summary>
        public static StorageBlobAccessTier Cool { get; } = new StorageBlobAccessTier(CoolValue);
        /// <summary> The blob is in access tier Cold. </summary>
        public static StorageBlobAccessTier Cold { get; } = new StorageBlobAccessTier(ColdValue);
        /// <summary> The blob is in access tier Archive. </summary>
        public static StorageBlobAccessTier Archive { get; } = new StorageBlobAccessTier(ArchiveValue);
        /// <summary> The blob is in access tier Default(Inferred). </summary>
        public static StorageBlobAccessTier Default { get; } = new StorageBlobAccessTier(DefaultValue);
        /// <summary> Determines if two <see cref="StorageBlobAccessTier"/> values are the same. </summary>
        public static bool operator ==(StorageBlobAccessTier left, StorageBlobAccessTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageBlobAccessTier"/> values are not the same. </summary>
        public static bool operator !=(StorageBlobAccessTier left, StorageBlobAccessTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StorageBlobAccessTier"/>. </summary>
        public static implicit operator StorageBlobAccessTier(string value) => new StorageBlobAccessTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageBlobAccessTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageBlobAccessTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
