// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Router.Models
{
    public partial class UpdateClassificationPolicyRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            if (Optional.IsDefined(DefaultQueueId))
            {
                if (DefaultQueueId != null)
                {
                    writer.WritePropertyName("defaultQueueId");
                    writer.WriteStringValue(DefaultQueueId);
                }
                else
                {
                    writer.WriteNull("defaultQueueId");
                }
            }
            if (Optional.IsDefined(QueueSelectionRules))
            {
                if (QueueSelectionRules != null)
                {
                    writer.WritePropertyName("queueSelectionRules");
                    writer.WriteObjectValue(QueueSelectionRules);
                }
                else
                {
                    writer.WriteNull("queueSelectionRules");
                }
            }
            if (Optional.IsDefined(WorkerAbilityRules))
            {
                if (WorkerAbilityRules != null)
                {
                    writer.WritePropertyName("workerAbilityRules");
                    writer.WriteObjectValue(WorkerAbilityRules);
                }
                else
                {
                    writer.WriteNull("workerAbilityRules");
                }
            }
            if (Optional.IsDefined(PrioritizationRules))
            {
                if (PrioritizationRules != null)
                {
                    writer.WritePropertyName("prioritizationRules");
                    writer.WriteObjectValue(PrioritizationRules);
                }
                else
                {
                    writer.WriteNull("prioritizationRules");
                }
            }
            writer.WriteEndObject();
        }
    }
}
