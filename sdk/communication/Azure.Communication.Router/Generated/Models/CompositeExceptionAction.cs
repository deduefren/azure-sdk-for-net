// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Router.Models
{
    /// <summary> The CompositeExceptionAction. </summary>
    internal partial class CompositeExceptionAction : ExceptionAction
    {
        /// <summary> Initializes a new instance of CompositeExceptionAction. </summary>
        internal CompositeExceptionAction()
        {
            ExceptionActions = new ChangeTrackingList<CompositeExceptionActionExceptionActionsItem>();
            ObjectType = "composite";
        }

        /// <summary> Collections of actions in this composite exception action. </summary>
        public IReadOnlyList<CompositeExceptionActionExceptionActionsItem> ExceptionActions { get; }
    }
}
