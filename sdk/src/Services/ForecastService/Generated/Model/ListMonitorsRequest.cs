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
    /// Container for the parameters to the ListMonitors operation.
    /// Returns a list of monitors created with the <a>CreateMonitor</a> operation and <a>CreateAutoPredictor</a>
    /// operation. For each monitor resource, this operation returns of a summary of its properties,
    /// including its Amazon Resource Name (ARN). You can retrieve a complete set of properties
    /// of a monitor resource by specify the monitor's ARN in the <a>DescribeMonitor</a> operation.
    /// </summary>
    public partial class ListMonitorsRequest : AmazonForecastServiceRequest
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of filters. For each filter, provide a condition and a match statement. The
        /// condition is either <code>IS</code> or <code>IS_NOT</code>, which specifies whether
        /// to include or exclude the resources that match the statement from the list. The match
        /// statement consists of a key and a value.
        /// </para>
        ///  
        /// <para>
        ///  <b>Filter properties</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Condition</code> - The condition to apply. Valid values are <code>IS</code>
        /// and <code>IS_NOT</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Key</code> - The name of the parameter to filter on. The only valid value is
        /// <code>Status</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Value</code> - The value to match.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, to list all monitors who's status is ACTIVE, you would specify:
        /// </para>
        ///  
        /// <para>
        ///  <code>"Filters": [ { "Condition": "IS", "Key": "Status", "Value": "ACTIVE" } ]</code>
        /// 
        /// </para>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of monitors to include in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the result of the previous request was truncated, the response includes a <code>NextToken</code>.
        /// To retrieve the next set of results, use the token in the next request. Tokens expire
        /// after 24 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}