/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the DNS_REQUEST action described in this finding.
    /// </summary>
    public partial class DnsRequestAction
    {
        private bool? _blocked;
        private string _domain;
        private string _protocol;

        /// <summary>
        /// Gets and sets the property Blocked. 
        /// <para>
        /// Indicates whether the targeted port is blocked.
        /// </para>
        /// </summary>
        public bool Blocked
        {
            get { return this._blocked.GetValueOrDefault(); }
            set { this._blocked = value; }
        }

        // Check to see if Blocked property is set
        internal bool IsSetBlocked()
        {
            return this._blocked.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain information for the API request.
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The network connection protocol observed in the activity that prompted GuardDuty to
        /// generate the finding.
        /// </para>
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

    }
}