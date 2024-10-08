// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> State of recommendation. </summary>
    public readonly partial struct RecommendationState : IEquatable<RecommendationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RecommendationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RecommendationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "Active";
        private const string InProgressValue = "InProgress";
        private const string DismissedValue = "Dismissed";
        private const string CompletedByUserValue = "CompletedByUser";
        private const string CompletedBySystemValue = "CompletedBySystem";

        /// <summary> Recommendation is active. </summary>
        public static RecommendationState Active { get; } = new RecommendationState(ActiveValue);
        /// <summary> Recommendation is in progress. </summary>
        public static RecommendationState InProgress { get; } = new RecommendationState(InProgressValue);
        /// <summary> Recommendation has been dismissed. </summary>
        public static RecommendationState Dismissed { get; } = new RecommendationState(DismissedValue);
        /// <summary> Recommendation has been completed by user. </summary>
        public static RecommendationState CompletedByUser { get; } = new RecommendationState(CompletedByUserValue);
        /// <summary> Recommendation has been completed by the system. </summary>
        public static RecommendationState CompletedBySystem { get; } = new RecommendationState(CompletedBySystemValue);
        /// <summary> Determines if two <see cref="RecommendationState"/> values are the same. </summary>
        public static bool operator ==(RecommendationState left, RecommendationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RecommendationState"/> values are not the same. </summary>
        public static bool operator !=(RecommendationState left, RecommendationState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RecommendationState"/>. </summary>
        public static implicit operator RecommendationState(string value) => new RecommendationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RecommendationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RecommendationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
