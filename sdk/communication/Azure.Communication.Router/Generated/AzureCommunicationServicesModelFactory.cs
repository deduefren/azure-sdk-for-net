// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.Router.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class AzureCommunicationServicesModelFactory
    {
        /// <summary> Initializes a new instance of UpsertChannelResponse. </summary>
        /// <param name="id"> Id of the channel created. </param>
        /// <param name="name"> Friendly name of the channel created. </param>
        /// <param name="acsManaged"> Indicates that the Channel was created and is maintained by ACS. </param>
        /// <returns> A new <see cref="Models.UpsertChannelResponse"/> instance for mocking. </returns>
        public static UpsertChannelResponse UpsertChannelResponse(string id = null, string name = null, bool? acsManaged = null)
        {
            return new UpsertChannelResponse(id, name, acsManaged);
        }

        /// <summary> Initializes a new instance of ChannelCollection. </summary>
        /// <param name="value"> Page of items. </param>
        /// <param name="nextLink"> If there are more items that can be retrieved, the next link will be populated. </param>
        /// <returns> A new <see cref="Models.ChannelCollection"/> instance for mocking. </returns>
        public static ChannelCollection ChannelCollection(IEnumerable<Channel> value = null, string nextLink = null)
        {
            value ??= new List<Channel>();

            return new ChannelCollection(value?.ToList(), nextLink);
        }

        /// <summary> Initializes a new instance of Channel. </summary>
        /// <param name="id"> The Id of the channel. </param>
        /// <param name="name"> The friendly name of the channel. </param>
        /// <param name="acsManaged"> Indicates that the Channel was created and is maintained by ACS. </param>
        /// <returns> A new <see cref="Models.Channel"/> instance for mocking. </returns>
        public static Channel Channel(string id = null, string name = null, bool? acsManaged = null)
        {
            return new Channel(id, name, acsManaged);
        }

        /// <summary> Initializes a new instance of CreateClassificationPolicyResponse. </summary>
        /// <param name="id"> Id of the newly created Classification Policy. </param>
        /// <returns> A new <see cref="Models.CreateClassificationPolicyResponse"/> instance for mocking. </returns>
        public static CreateClassificationPolicyResponse CreateClassificationPolicyResponse(string id = null)
        {
            return new CreateClassificationPolicyResponse(id);
        }

        /// <summary> Initializes a new instance of ClassificationPolicyCollection. </summary>
        /// <param name="value"> Page of items. </param>
        /// <param name="nextLink"> If there are more items that can be retrieved, the next link will be populated. </param>
        /// <returns> A new <see cref="Models.ClassificationPolicyCollection"/> instance for mocking. </returns>
        public static ClassificationPolicyCollection ClassificationPolicyCollection(IEnumerable<ClassificationPolicy> value = null, string nextLink = null)
        {
            value ??= new List<ClassificationPolicy>();

            return new ClassificationPolicyCollection(value?.ToList(), nextLink);
        }

        /// <summary> Initializes a new instance of ClassificationPolicy. </summary>
        /// <param name="id"> Unique identifier of this policy. </param>
        /// <param name="name"> Friendly name of this policy. </param>
        /// <param name="defaultQueueId"> The default queue to select if the rules don&apos;t find a match. </param>
        /// <param name="queueSelectionRules"> The rules to select a queue for a given job. </param>
        /// <param name="workerAbilityRules"> The rules to determine the minimum worker abilities required to service a given job. </param>
        /// <param name="prioritizationRules"> The rules to determine a priority score for a given job. </param>
        /// <returns> A new <see cref="Models.ClassificationPolicy"/> instance for mocking. </returns>
        public static ClassificationPolicy ClassificationPolicy(string id = null, string name = null, string defaultQueueId = null, ClassificationPolicyQueueSelectionRules queueSelectionRules = null, ClassificationPolicyWorkerAbilityRules workerAbilityRules = null, ClassificationPolicyPrioritizationRules prioritizationRules = null)
        {
            return new ClassificationPolicy(id, name, defaultQueueId, queueSelectionRules, workerAbilityRules, prioritizationRules);
        }

        /// <summary> Initializes a new instance of TimeSpan. </summary>
        /// <param name="ticks"> . </param>
        /// <param name="days"> . </param>
        /// <param name="hours"> . </param>
        /// <param name="milliseconds"> . </param>
        /// <param name="minutes"> . </param>
        /// <param name="seconds"> . </param>
        /// <param name="totalDays"> . </param>
        /// <param name="totalHours"> . </param>
        /// <param name="totalMilliseconds"> . </param>
        /// <param name="totalMinutes"> . </param>
        /// <param name="totalSeconds"> . </param>
        /// <returns> A new <see cref="Models.TimeSpan"/> instance for mocking. </returns>
        public static TimeSpan TimeSpan(long? ticks = null, int? days = null, int? hours = null, int? milliseconds = null, int? minutes = null, int? seconds = null, double? totalDays = null, double? totalHours = null, double? totalMilliseconds = null, double? totalMinutes = null, double? totalSeconds = null)
        {
            return new TimeSpan(ticks, days, hours, milliseconds, minutes, seconds, totalDays, totalHours, totalMilliseconds, totalMinutes, totalSeconds);
        }

        /// <summary> Initializes a new instance of CreateDistributionPolicyResponse. </summary>
        /// <param name="id"> Id of the newly created distribution policy. </param>
        /// <returns> A new <see cref="Models.CreateDistributionPolicyResponse"/> instance for mocking. </returns>
        public static CreateDistributionPolicyResponse CreateDistributionPolicyResponse(string id = null)
        {
            return new CreateDistributionPolicyResponse(id);
        }

        /// <summary> Initializes a new instance of DistributionPolicyCollection. </summary>
        /// <param name="value"> Page of items. </param>
        /// <param name="nextLink"> If there are more items that can be retrieved, the next link will be populated. </param>
        /// <returns> A new <see cref="Models.DistributionPolicyCollection"/> instance for mocking. </returns>
        public static DistributionPolicyCollection DistributionPolicyCollection(IEnumerable<DistributionPolicy> value = null, string nextLink = null)
        {
            value ??= new List<DistributionPolicy>();

            return new DistributionPolicyCollection(value?.ToList(), nextLink);
        }

        /// <summary> Initializes a new instance of DistributionPolicy. </summary>
        /// <param name="id"> The unique identifier of the policy. </param>
        /// <param name="name"> The human readable name of the policy. </param>
        /// <param name="offerTTL"> . </param>
        /// <param name="mode"> The policy governing the specific distribution method. </param>
        /// <param name="filter"> The filter policy to be used when distributing jobs. </param>
        /// <returns> A new <see cref="Models.DistributionPolicy"/> instance for mocking. </returns>
        public static DistributionPolicy DistributionPolicy(string id = null, string name = null, TimeSpan offerTTL = null, DistributionPolicyMode mode = null, DistributionPolicyFilter filter = null)
        {
            return new DistributionPolicy(id, name, offerTTL, mode, filter);
        }

        /// <summary> Initializes a new instance of CreateExceptionPolicyResponse. </summary>
        /// <param name="id"> Id of the exception policy created. </param>
        /// <param name="name"> The name of the exception policy created. </param>
        /// <param name="exceptionRules"> A collection of exception rules on the exception policy. </param>
        /// <returns> A new <see cref="Models.CreateExceptionPolicyResponse"/> instance for mocking. </returns>
        public static CreateExceptionPolicyResponse CreateExceptionPolicyResponse(string id = null, string name = null, IEnumerable<ExceptionRule> exceptionRules = null)
        {
            exceptionRules ??= new List<ExceptionRule>();

            return new CreateExceptionPolicyResponse(id, name, exceptionRules?.ToList());
        }

        /// <summary> Initializes a new instance of ExceptionPolicyCollection. </summary>
        /// <param name="value"> Page of items. </param>
        /// <param name="nextLink"> If there are more items that can be retrieved, the next link will be populated. </param>
        /// <returns> A new <see cref="Models.ExceptionPolicyCollection"/> instance for mocking. </returns>
        public static ExceptionPolicyCollection ExceptionPolicyCollection(IEnumerable<ExceptionPolicy> value = null, string nextLink = null)
        {
            value ??= new List<ExceptionPolicy>();

            return new ExceptionPolicyCollection(value?.ToList(), nextLink);
        }

        /// <summary> Initializes a new instance of ExceptionPolicy. </summary>
        /// <param name="id"> The Id of the exception policy. </param>
        /// <param name="name"> (Optional) The name of the exception policy. </param>
        /// <param name="exceptionRules"> (Optional) A collection of exception rules on the exception policy. </param>
        /// <returns> A new <see cref="Models.ExceptionPolicy"/> instance for mocking. </returns>
        public static ExceptionPolicy ExceptionPolicy(string id = null, string name = null, IEnumerable<ExceptionRule> exceptionRules = null)
        {
            exceptionRules ??= new List<ExceptionRule>();

            return new ExceptionPolicy(id, name, exceptionRules?.ToList());
        }

        /// <summary> Initializes a new instance of UpdateExceptionPolicyResponse. </summary>
        /// <param name="id"> The Id of the exception policy updated. </param>
        /// <param name="name"> The name of the exception policy updated. </param>
        /// <param name="exceptionRules"> A collection of exception rules on the exception policy. </param>
        /// <returns> A new <see cref="Models.UpdateExceptionPolicyResponse"/> instance for mocking. </returns>
        public static UpdateExceptionPolicyResponse UpdateExceptionPolicyResponse(string id = null, string name = null, IEnumerable<ExceptionRule> exceptionRules = null)
        {
            exceptionRules ??= new List<ExceptionRule>();

            return new UpdateExceptionPolicyResponse(id, name, exceptionRules?.ToList());
        }

        /// <summary> Initializes a new instance of CreateJobResponse. </summary>
        /// <param name="id"> Id of the newly created job. </param>
        /// <returns> A new <see cref="Models.CreateJobResponse"/> instance for mocking. </returns>
        public static CreateJobResponse CreateJobResponse(string id = null)
        {
            return new CreateJobResponse(id);
        }

        /// <summary> Initializes a new instance of Job. </summary>
        /// <param name="id"> The id of the Job. </param>
        /// <param name="channelReference"> Reference to an external parent context, eg. call ID. </param>
        /// <param name="jobType"> . </param>
        /// <param name="jobStatus"> . </param>
        /// <param name="enqueueTimeUtc"> The time a job was queued. </param>
        /// <param name="channelId"> The channel or modality upon which this job will be executed. </param>
        /// <param name="classificationPolicyId"> The Id of the Classification policy used for classifying a job. </param>
        /// <param name="queueId"> The Id of the Queue that a job is queued to. </param>
        /// <param name="priority"> The priority of this job. </param>
        /// <param name="dispositionCode"> Reason code for cancelled or closed jobs. </param>
        /// <param name="requiredAbilities"> Minimum required worker abilities needed to service this job. </param>
        /// <param name="labels"> A set of key/value pairs used by the classification policy to determine queue, priority and required abilities. </param>
        /// <returns> A new <see cref="Models.Job"/> instance for mocking. </returns>
        public static Job Job(string id = null, string channelReference = null, JobType? jobType = null, JobStatus? jobStatus = null, DateTimeOffset? enqueueTimeUtc = null, string channelId = null, string classificationPolicyId = null, string queueId = null, int? priority = null, string dispositionCode = null, IReadOnlyDictionary<string, int> requiredAbilities = null, IReadOnlyDictionary<string, string> labels = null)
        {
            requiredAbilities ??= new Dictionary<string, int>();
            labels ??= new Dictionary<string, string>();

            return new Job(id, channelReference, jobType, jobStatus, enqueueTimeUtc, channelId, classificationPolicyId, queueId, priority, dispositionCode, requiredAbilities, labels);
        }

        /// <summary> Initializes a new instance of JobCollection. </summary>
        /// <param name="value"> Page of items. </param>
        /// <param name="nextLink"> If there are more items that can be retrieved, the next link will be populated. </param>
        /// <returns> A new <see cref="Models.JobCollection"/> instance for mocking. </returns>
        public static JobCollection JobCollection(IEnumerable<Job> value = null, string nextLink = null)
        {
            value ??= new List<Job>();

            return new JobCollection(value?.ToList(), nextLink);
        }

        /// <summary> Initializes a new instance of AcceptJobOfferResponse. </summary>
        /// <param name="assignmentId"> The assignment Id that assigns a worker that has accepted an offer to a job. </param>
        /// <param name="jobId"> The Id of the job assigned. </param>
        /// <param name="workerId"> The Id of the worker that has been assigned this job. </param>
        /// <returns> A new <see cref="Models.AcceptJobOfferResponse"/> instance for mocking. </returns>
        public static AcceptJobOfferResponse AcceptJobOfferResponse(string assignmentId = null, string jobId = null, string workerId = null)
        {
            return new AcceptJobOfferResponse(assignmentId, jobId, workerId);
        }

        /// <summary> Initializes a new instance of CreateQueueResponse. </summary>
        /// <param name="id"> Id of the newly created queue. </param>
        /// <returns> A new <see cref="Models.CreateQueueResponse"/> instance for mocking. </returns>
        public static CreateQueueResponse CreateQueueResponse(string id = null)
        {
            return new CreateQueueResponse(id);
        }

        /// <summary> Initializes a new instance of QueueCollection. </summary>
        /// <param name="value"> Page of items. </param>
        /// <param name="nextLink"> If there are more items that can be retrieved, the next link will be populated. </param>
        /// <returns> A new <see cref="Models.QueueCollection"/> instance for mocking. </returns>
        public static QueueCollection QueueCollection(IEnumerable<Queue> value = null, string nextLink = null)
        {
            value ??= new List<Queue>();

            return new QueueCollection(value?.ToList(), nextLink);
        }

        /// <summary> Initializes a new instance of Queue. </summary>
        /// <param name="id"> The Id of this queue. </param>
        /// <param name="name"> The name of this queue. </param>
        /// <param name="distributionPolicyId"> The ID of the distribution policy that will determine how a job is distributed to workers. </param>
        /// <param name="labels"> (Optional) A set of key/value pairs used by the classification policy to determine queue to assign a job. </param>
        /// <param name="exceptionPolicyId"> (Optional) The ID of the exception policy that determines various job escalation rules. </param>
        /// <returns> A new <see cref="Models.Queue"/> instance for mocking. </returns>
        public static Queue Queue(string id = null, string name = null, string distributionPolicyId = null, IReadOnlyDictionary<string, string> labels = null, string exceptionPolicyId = null)
        {
            labels ??= new Dictionary<string, string>();

            return new Queue(id, name, distributionPolicyId, labels, exceptionPolicyId);
        }

        /// <summary> Initializes a new instance of UpdateQueueResponse. </summary>
        /// <param name="id"> The id of the queue to be deleted. </param>
        /// <param name="name"> The name of this queue. </param>
        /// <param name="distributionPolicyId"> The ID of the distribution policy that will determine how a job is distributed to workers. </param>
        /// <param name="labels"> A set of key/value pairs used by the classification policy to determine queue to assign a job. </param>
        /// <param name="exceptionPolicyId"> The ID of the exception policy that determines various job escalation rules. </param>
        /// <returns> A new <see cref="Models.UpdateQueueResponse"/> instance for mocking. </returns>
        public static UpdateQueueResponse UpdateQueueResponse(string id = null, string name = null, string distributionPolicyId = null, IReadOnlyDictionary<string, string> labels = null, string exceptionPolicyId = null)
        {
            labels ??= new Dictionary<string, string>();

            return new UpdateQueueResponse(id, name, distributionPolicyId, labels, exceptionPolicyId);
        }

        /// <summary> Initializes a new instance of Worker. </summary>
        /// <param name="id"> . </param>
        /// <param name="state"> . </param>
        /// <param name="queueAssignments"> . </param>
        /// <param name="totalCapacityScore"> . </param>
        /// <param name="abilities"> Dictionary of &lt;integer&gt;. </param>
        /// <param name="labels"> Dictionary of &lt;string&gt;. </param>
        /// <param name="socketConfigurations"> . </param>
        /// <param name="offers"> . </param>
        /// <param name="assignedJobs"> . </param>
        /// <returns> A new <see cref="Models.Worker"/> instance for mocking. </returns>
        public static Worker Worker(string id = null, WorkerState? state = null, IEnumerable<WorkerQueueAssignmentsItem> queueAssignments = null, int? totalCapacityScore = null, IReadOnlyDictionary<string, int> abilities = null, IReadOnlyDictionary<string, string> labels = null, IEnumerable<SocketConfiguration> socketConfigurations = null, IEnumerable<Offer> offers = null, IEnumerable<JobAssignment> assignedJobs = null)
        {
            queueAssignments ??= new List<WorkerQueueAssignmentsItem>();
            abilities ??= new Dictionary<string, int>();
            labels ??= new Dictionary<string, string>();
            socketConfigurations ??= new List<SocketConfiguration>();
            offers ??= new List<Offer>();
            assignedJobs ??= new List<JobAssignment>();

            return new Worker(id, state, queueAssignments?.ToList(), totalCapacityScore, abilities, labels, socketConfigurations?.ToList(), offers?.ToList(), assignedJobs?.ToList());
        }

        /// <summary> Initializes a new instance of Offer. </summary>
        /// <param name="id"> The Id of the offer. </param>
        /// <param name="jobId"> The Id of the job assigned. </param>
        /// <param name="consumedScore"> . </param>
        /// <param name="offerTimeUtc"> The time the offer was created. </param>
        /// <param name="expiryTimeUtc"> The time that indicates when the offer will expire. </param>
        /// <returns> A new <see cref="Models.Offer"/> instance for mocking. </returns>
        public static Offer Offer(string id = null, string jobId = null, int? consumedScore = null, DateTimeOffset? offerTimeUtc = null, DateTimeOffset? expiryTimeUtc = null)
        {
            return new Offer(id, jobId, consumedScore, offerTimeUtc, expiryTimeUtc);
        }

        /// <summary> Initializes a new instance of JobAssignment. </summary>
        /// <param name="id"> The Id of the job assignment. </param>
        /// <param name="jobId"> The Id of the Job assigned. </param>
        /// <param name="consumedScore"> The amount of capacity this assignment has consumed for a worker. </param>
        /// <param name="assignTimeUtc"> The Assignment time of the job. </param>
        /// <param name="completeTimeUtc"> The time the job was marked as completed after being assigned. </param>
        /// <returns> A new <see cref="Models.JobAssignment"/> instance for mocking. </returns>
        public static JobAssignment JobAssignment(string id = null, string jobId = null, int? consumedScore = null, DateTimeOffset? assignTimeUtc = null, DateTimeOffset? completeTimeUtc = null)
        {
            return new JobAssignment(id, jobId, consumedScore, assignTimeUtc, completeTimeUtc);
        }

        /// <summary> Initializes a new instance of WorkerCollection. </summary>
        /// <param name="value"> Page of items. </param>
        /// <param name="nextLink"> If there are more items that can be retrieved, the next link will be populated. </param>
        /// <returns> A new <see cref="Models.WorkerCollection"/> instance for mocking. </returns>
        public static WorkerCollection WorkerCollection(IEnumerable<Worker> value = null, string nextLink = null)
        {
            value ??= new List<Worker>();

            return new WorkerCollection(value?.ToList(), nextLink);
        }
    }
}
