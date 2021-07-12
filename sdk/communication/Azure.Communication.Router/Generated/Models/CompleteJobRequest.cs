// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.Router.Models
{
    /// <summary> Request payload for completing jobs. </summary>
    public partial class CompleteJobRequest
    {
        /// <summary> Initializes a new instance of CompleteJobRequest. </summary>
        /// <param name="assignmentId"> The assignment Id that assigns a worker to a job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentId"/> is null. </exception>
        public CompleteJobRequest(string assignmentId)
        {
            if (assignmentId == null)
            {
                throw new ArgumentNullException(nameof(assignmentId));
            }

            AssignmentId = assignmentId;
        }

        /// <summary> The assignment Id that assigns a worker to a job. </summary>
        public string AssignmentId { get; }
    }
}
