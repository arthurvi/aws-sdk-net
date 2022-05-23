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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeMonitor operation.
    /// Describes a monitor resource. In addition to listing the properties provided in the
    /// <a>CreateMonitor</a> request, this operation lists the following properties:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <code>Baseline</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CreationTime</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>LastEvaluationTime</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>LastEvaluationState</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>LastModificationTime</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Message</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Status</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeMonitorRequest : AmazonForecastServiceRequest
    {
        private string _monitorArn;

        /// <summary>
        /// Gets and sets the property MonitorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the monitor resource to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string MonitorArn
        {
            get { return this._monitorArn; }
            set { this._monitorArn = value; }
        }

        // Check to see if MonitorArn property is set
        internal bool IsSetMonitorArn()
        {
            return this._monitorArn != null;
        }

    }
}