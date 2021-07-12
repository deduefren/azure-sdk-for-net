// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Router.Models
{
    public partial class UpdateJobRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClassificationPolicyId))
            {
                if (ClassificationPolicyId != null)
                {
                    writer.WritePropertyName("classificationPolicyId");
                    writer.WriteStringValue(ClassificationPolicyId);
                }
                else
                {
                    writer.WriteNull("classificationPolicyId");
                }
            }
            if (Optional.IsDefined(QueueId))
            {
                if (QueueId != null)
                {
                    writer.WritePropertyName("queueId");
                    writer.WriteStringValue(QueueId);
                }
                else
                {
                    writer.WriteNull("queueId");
                }
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority");
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsCollectionDefined(RequiredAbilities))
            {
                if (RequiredAbilities != null)
                {
                    writer.WritePropertyName("requiredAbilities");
                    writer.WriteStartObject();
                    foreach (var item in RequiredAbilities)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteNumberValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("requiredAbilities");
                }
            }
            if (Optional.IsCollectionDefined(Labels))
            {
                if (Labels != null)
                {
                    writer.WritePropertyName("labels");
                    writer.WriteStartObject();
                    foreach (var item in Labels)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("labels");
                }
            }
            writer.WriteEndObject();
        }
    }
}
