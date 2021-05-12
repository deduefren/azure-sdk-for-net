// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class TasksStateTasksSentimentAnalysisTasksItem
    {
        internal static TasksStateTasksSentimentAnalysisTasksItem DeserializeTasksStateTasksSentimentAnalysisTasksItem(JsonElement element)
        {
            Optional<SentimentResponse> results = default;
            DateTimeOffset lastUpdateDateTime = default;
            Optional<string> name = default;
            TextAnalyticsOperationStatus status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    results = SentimentResponse.DeserializeSentimentResponse(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new TextAnalyticsOperationStatus(property.Value.GetString());
                    continue;
                }
            }
            return new TasksStateTasksSentimentAnalysisTasksItem(lastUpdateDateTime, name.Value, status, results.Value);
        }
    }
}
