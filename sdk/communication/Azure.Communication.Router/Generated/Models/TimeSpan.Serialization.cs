// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Router.Models
{
    public partial class TimeSpan : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static TimeSpan DeserializeTimeSpan(JsonElement element)
        {
            Optional<long> ticks = default;
            Optional<int> days = default;
            Optional<int> hours = default;
            Optional<int> milliseconds = default;
            Optional<int> minutes = default;
            Optional<int> seconds = default;
            Optional<double> totalDays = default;
            Optional<double> totalHours = default;
            Optional<double> totalMilliseconds = default;
            Optional<double> totalMinutes = default;
            Optional<double> totalSeconds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ticks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ticks = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("days"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    days = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hours"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("milliseconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    milliseconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minutes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("seconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    seconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalDays"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalDays = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("totalHours"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalHours = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("totalMilliseconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalMilliseconds = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("totalMinutes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalMinutes = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("totalSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalSeconds = property.Value.GetDouble();
                    continue;
                }
            }
            return new TimeSpan(Optional.ToNullable(ticks), Optional.ToNullable(days), Optional.ToNullable(hours), Optional.ToNullable(milliseconds), Optional.ToNullable(minutes), Optional.ToNullable(seconds), Optional.ToNullable(totalDays), Optional.ToNullable(totalHours), Optional.ToNullable(totalMilliseconds), Optional.ToNullable(totalMinutes), Optional.ToNullable(totalSeconds));
        }
    }
}
