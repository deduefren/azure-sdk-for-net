// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Router.Models
{
    public partial class UpsertChannelRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                if (Id != null)
                {
                    writer.WritePropertyName("id");
                    writer.WriteStringValue(Id);
                }
                else
                {
                    writer.WriteNull("id");
                }
            }
            if (Optional.IsDefined(Name))
            {
                if (Name != null)
                {
                    writer.WritePropertyName("name");
                    writer.WriteStringValue(Name);
                }
                else
                {
                    writer.WriteNull("name");
                }
            }
            writer.WriteEndObject();
        }
    }
}
