// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.Messaging
{
    /// <summary> Status of a message. </summary>
    public readonly partial struct MessageStatus : IEquatable<MessageStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MessageStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MessageStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnqueuedValue = "enqueued";
        private const string SentValue = "sent";
        private const string DeliveredValue = "delivered";
        private const string ReadValue = "read";
        private const string FailedValue = "failed";
        private const string UnknownValue = "unknown";

        /// <summary> enqueued. </summary>
        public static MessageStatus Enqueued { get; } = new MessageStatus(EnqueuedValue);
        /// <summary> sent. </summary>
        public static MessageStatus Sent { get; } = new MessageStatus(SentValue);
        /// <summary> delivered. </summary>
        public static MessageStatus Delivered { get; } = new MessageStatus(DeliveredValue);
        /// <summary> read. </summary>
        public static MessageStatus Read { get; } = new MessageStatus(ReadValue);
        /// <summary> failed. </summary>
        public static MessageStatus Failed { get; } = new MessageStatus(FailedValue);
        /// <summary> unknown. </summary>
        public static MessageStatus Unknown { get; } = new MessageStatus(UnknownValue);
        /// <summary> Determines if two <see cref="MessageStatus"/> values are the same. </summary>
        public static bool operator ==(MessageStatus left, MessageStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MessageStatus"/> values are not the same. </summary>
        public static bool operator !=(MessageStatus left, MessageStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MessageStatus"/>. </summary>
        public static implicit operator MessageStatus(string value) => new MessageStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MessageStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MessageStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
