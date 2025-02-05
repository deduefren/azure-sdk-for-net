// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class AnalyticalStorageConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SchemaType))
            {
                writer.WritePropertyName("schemaType"u8);
                writer.WriteStringValue(SchemaType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AnalyticalStorageConfiguration DeserializeAnalyticalStorageConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AnalyticalStorageSchemaType> schemaType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schemaType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schemaType = new AnalyticalStorageSchemaType(property.Value.GetString());
                    continue;
                }
            }
            return new AnalyticalStorageConfiguration(Optional.ToNullable(schemaType));
        }
    }
}
