// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Router.Models
{
    public partial class WorkerCollection
    {
        internal static WorkerCollection DeserializeWorkerCollection(JsonElement element)
        {
            IReadOnlyList<Worker> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<Worker> array = new List<Worker>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Worker.DeserializeWorker(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nextLink = null;
                        continue;
                    }
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new WorkerCollection(value, nextLink.Value);
        }
    }
}
