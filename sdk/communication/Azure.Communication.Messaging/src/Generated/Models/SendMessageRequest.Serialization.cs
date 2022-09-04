// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Messaging
{
    internal partial class SendMessageRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("channelRegistrationId");
            writer.WriteStringValue(ChannelRegistrationId);
            writer.WritePropertyName("to");
            writer.WriteStartArray();
            foreach (var item in To)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            if (Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content");
                writer.WriteStringValue(Content);
            }
            if (Optional.IsDefined(MediaUri))
            {
                writer.WritePropertyName("mediaUri");
                writer.WriteStringValue(MediaUri);
            }
            if (Optional.IsDefined(Template))
            {
                writer.WritePropertyName("template");
                writer.WriteObjectValue(Template);
            }
            writer.WriteEndObject();
        }
    }
}
