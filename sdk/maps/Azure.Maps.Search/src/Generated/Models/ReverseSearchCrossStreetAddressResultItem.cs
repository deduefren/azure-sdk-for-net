// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Search.Models
{
    /// <summary> Result object for a Search Address Reverse Cross Street response. </summary>
    public partial class ReverseSearchCrossStreetAddressResultItem
    {
        /// <summary> Initializes a new instance of ReverseSearchCrossStreetAddressResultItem. </summary>
        internal ReverseSearchCrossStreetAddressResultItem()
        {
        }

        /// <summary> Initializes a new instance of ReverseSearchCrossStreetAddressResultItem. </summary>
        /// <param name="address"> The address of the result. </param>
        /// <param name="position"> Position property in the form of &quot;{latitude},{longitude}&quot;. </param>
        internal ReverseSearchCrossStreetAddressResultItem(MapsAddress address, string position)
        {
            Address = address;
            Position = position;
        }

        /// <summary> The address of the result. </summary>
        public MapsAddress Address { get; }
        /// <summary> Position property in the form of &quot;{latitude},{longitude}&quot;. </summary>
        public string Position { get; }
    }
}
