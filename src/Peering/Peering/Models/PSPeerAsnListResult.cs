// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The paginated list of peer ASNs.
    /// </summary>
    public partial class PSPeerAsnListResult
    {
        /// <summary>
        /// Initializes a new instance of the PSPeerAsnListResult class.
        /// </summary>
        public PSPeerAsnListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PSPeerAsnListResult class.
        /// </summary>
        /// <param name="value">The list of peer ASNs.</param>
        /// <param name="nextLink">The link to fetch the next page of peer
        /// ASNs.</param>
        public PSPeerAsnListResult(IList<PSPeerAsn> value = default(IList<PSPeerAsn>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of peer ASNs.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<PSPeerAsn> Value { get; set; }

        /// <summary>
        /// Gets or sets the link to fetch the next page of peer ASNs.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
