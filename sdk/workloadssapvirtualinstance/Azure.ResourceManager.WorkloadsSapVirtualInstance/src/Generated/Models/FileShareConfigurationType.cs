// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.WorkloadsSapVirtualInstance.Models
{
    /// <summary> The type of file share config. </summary>
    internal readonly partial struct FileShareConfigurationType : IEquatable<FileShareConfigurationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FileShareConfigurationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FileShareConfigurationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SkipValue = "Skip";
        private const string CreateAndMountValue = "CreateAndMount";
        private const string MountValue = "Mount";

        /// <summary> Skip creating the file share. </summary>
        public static FileShareConfigurationType Skip { get; } = new FileShareConfigurationType(SkipValue);
        /// <summary> Fileshare will be created and mounted by service. </summary>
        public static FileShareConfigurationType CreateAndMount { get; } = new FileShareConfigurationType(CreateAndMountValue);
        /// <summary> Existing fileshare provided will be mounted by service. </summary>
        public static FileShareConfigurationType Mount { get; } = new FileShareConfigurationType(MountValue);
        /// <summary> Determines if two <see cref="FileShareConfigurationType"/> values are the same. </summary>
        public static bool operator ==(FileShareConfigurationType left, FileShareConfigurationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FileShareConfigurationType"/> values are not the same. </summary>
        public static bool operator !=(FileShareConfigurationType left, FileShareConfigurationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FileShareConfigurationType"/>. </summary>
        public static implicit operator FileShareConfigurationType(string value) => new FileShareConfigurationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FileShareConfigurationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FileShareConfigurationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
