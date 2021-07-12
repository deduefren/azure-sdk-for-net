// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.Router.Models
{
    /// <summary> The JobType. </summary>
    public readonly partial struct JobType : IEquatable<JobType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="JobType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InboundValue = "Inbound";
        private const string OutboundValue = "Outbound";

        /// <summary> Inbound. </summary>
        public static JobType Inbound { get; } = new JobType(InboundValue);
        /// <summary> Outbound. </summary>
        public static JobType Outbound { get; } = new JobType(OutboundValue);
        /// <summary> Determines if two <see cref="JobType"/> values are the same. </summary>
        public static bool operator ==(JobType left, JobType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobType"/> values are not the same. </summary>
        public static bool operator !=(JobType left, JobType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobType"/>. </summary>
        public static implicit operator JobType(string value) => new JobType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
