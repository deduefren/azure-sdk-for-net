// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.Messaging
{
    /// <summary> Details of the message to send. </summary>
    internal partial class SendMessageRequest
    {
        /// <summary> Initializes a new instance of SendMessageRequest. </summary>
        /// <param name="channelRegistrationId"> The Channel Registration ID for the Business Identifier. </param>
        /// <param name="to"> The native external platform user identifiers of the recipient. </param>
        /// <param name="type"> The type of message. Supports text, image, template. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="channelRegistrationId"/> or <paramref name="to"/> is null. </exception>
        public SendMessageRequest(string channelRegistrationId, IEnumerable<string> to, MessageType type)
        {
            if (channelRegistrationId == null)
            {
                throw new ArgumentNullException(nameof(channelRegistrationId));
            }
            if (to == null)
            {
                throw new ArgumentNullException(nameof(to));
            }

            ChannelRegistrationId = channelRegistrationId;
            To = to.ToList();
            Type = type;
        }

        /// <summary> The Channel Registration ID for the Business Identifier. </summary>
        public string ChannelRegistrationId { get; }
        /// <summary> The native external platform user identifiers of the recipient. </summary>
        public IList<string> To { get; }
        /// <summary> The type of message. Supports text, image, template. </summary>
        public MessageType Type { get; }
        /// <summary> Message content. </summary>
        public string Content { get; set; }
        /// <summary> A media url for the file. Required if the type is one of the supported media types, e.g. image. </summary>
        public string MediaUri { get; set; }
        /// <summary> The template object used to create templates. </summary>
        public MessageTemplate Template { get; set; }
    }
}
