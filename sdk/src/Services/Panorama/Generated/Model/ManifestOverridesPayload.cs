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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Panorama.Model
{
    /// <summary>
    /// Parameter overrides for an application instance. This is a JSON document that has
    /// a single key (<code>PayloadData</code>) where the value is an escaped string representation
    /// of the overrides document.
    /// </summary>
    public partial class ManifestOverridesPayload
    {
        private string _payloadData;

        /// <summary>
        /// Gets and sets the property PayloadData. 
        /// <para>
        /// The overrides document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=51200)]
        public string PayloadData
        {
            get { return this._payloadData; }
            set { this._payloadData = value; }
        }

        // Check to see if PayloadData property is set
        internal bool IsSetPayloadData()
        {
            return this._payloadData != null;
        }

    }
}