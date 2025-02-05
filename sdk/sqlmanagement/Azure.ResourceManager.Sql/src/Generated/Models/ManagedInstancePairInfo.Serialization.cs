// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstancePairInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryManagedInstanceId))
            {
                writer.WritePropertyName("primaryManagedInstanceId"u8);
                writer.WriteStringValue(PrimaryManagedInstanceId);
            }
            if (Optional.IsDefined(PartnerManagedInstanceId))
            {
                writer.WritePropertyName("partnerManagedInstanceId"u8);
                writer.WriteStringValue(PartnerManagedInstanceId);
            }
            writer.WriteEndObject();
        }

        internal static ManagedInstancePairInfo DeserializeManagedInstancePairInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> primaryManagedInstanceId = default;
            Optional<ResourceIdentifier> partnerManagedInstanceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryManagedInstanceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    primaryManagedInstanceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("partnerManagedInstanceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partnerManagedInstanceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new ManagedInstancePairInfo(primaryManagedInstanceId.Value, partnerManagedInstanceId.Value);
        }
    }
}
