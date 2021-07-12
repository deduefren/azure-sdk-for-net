// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.Router.Models
{
    /// <summary> The CreateClassificationPolicyRequest. </summary>
    public partial class CreateClassificationPolicyRequest
    {
        /// <summary> Initializes a new instance of CreateClassificationPolicyRequest. </summary>
        public CreateClassificationPolicyRequest()
        {
        }

        /// <summary>
        /// Unique identifier of this policy.
        /// 
        /// You can provide this value, or if it is omitted, one will be generated.
        /// </summary>
        public string Id { get; set; }
        /// <summary> Friendly name of this policy. </summary>
        public string Name { get; set; }
        /// <summary> The default queue to select if the rules don&apos;t find a match. </summary>
        public string DefaultQueueId { get; set; }
        /// <summary> The rules to select a queue for a given job. </summary>
        public CreateClassificationPolicyRequestQueueSelectionRules QueueSelectionRules { get; set; }
        /// <summary> The rules to determine the minimum worker abilities required to service a given job. </summary>
        public CreateClassificationPolicyRequestWorkerAbilityRules WorkerAbilityRules { get; set; }
        /// <summary> The rules to determine a priority score for a given job. </summary>
        public CreateClassificationPolicyRequestPrioritizationRules PrioritizationRules { get; set; }
    }
}
