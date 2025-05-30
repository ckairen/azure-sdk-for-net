// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Vision.Face
{
    /// <summary> The liveness operation mode to drive the client's end-user experience. </summary>
    public readonly partial struct LivenessOperationMode : IEquatable<LivenessOperationMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LivenessOperationMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LivenessOperationMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PassiveValue = "Passive";
        private const string PassiveActiveValue = "PassiveActive";

        /// <summary> Utilizes a passive liveness technique that requires no additional actions from the user. Requires normal indoor lighting and high screen brightness for optimal performance. And thus, this mode has a narrow operational envelope and will not be suitable for scenarios that requires the end-user's to be in bright lighting conditions. Note: this is the only supported mode for the Mobile (iOS and Android) solution. </summary>
        public static LivenessOperationMode Passive { get; } = new LivenessOperationMode(PassiveValue);
        /// <summary> This mode utilizes a hybrid passive or active liveness technique that necessitates user cooperation. It is optimized to require active motion only under suboptimal lighting conditions. Unlike the passive mode, this mode has no lighting restrictions, and thus offering a broader operational envelope. This mode is preferable on Web based solutions due to the lack of automatic screen brightness control available on browsers which hinders the Passive mode's operational envelope on Web based solutions. </summary>
        public static LivenessOperationMode PassiveActive { get; } = new LivenessOperationMode(PassiveActiveValue);
        /// <summary> Determines if two <see cref="LivenessOperationMode"/> values are the same. </summary>
        public static bool operator ==(LivenessOperationMode left, LivenessOperationMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LivenessOperationMode"/> values are not the same. </summary>
        public static bool operator !=(LivenessOperationMode left, LivenessOperationMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="LivenessOperationMode"/>. </summary>
        public static implicit operator LivenessOperationMode(string value) => new LivenessOperationMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LivenessOperationMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LivenessOperationMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
