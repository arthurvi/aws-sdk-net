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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Source details for an Amazon S3 data access asset.
    /// </summary>
    public partial class S3DataAccessAssetSourceEntry
    {
        private string _bucket;
        private List<string> _keyPrefixes = new List<string>();
        private List<string> _keys = new List<string>();

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The Amazon S3 bucket used for hosting shared data in the Amazon S3 data access.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property KeyPrefixes. 
        /// <para>
        /// Organizes Amazon S3 asset key prefixes stored in an Amazon S3 bucket.
        /// </para>
        /// </summary>
        public List<string> KeyPrefixes
        {
            get { return this._keyPrefixes; }
            set { this._keyPrefixes = value; }
        }

        // Check to see if KeyPrefixes property is set
        internal bool IsSetKeyPrefixes()
        {
            return this._keyPrefixes != null && this._keyPrefixes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Keys. 
        /// <para>
        /// The keys used to create the Amazon S3 data access.
        /// </para>
        /// </summary>
        public List<string> Keys
        {
            get { return this._keys; }
            set { this._keys = value; }
        }

        // Check to see if Keys property is set
        internal bool IsSetKeys()
        {
            return this._keys != null && this._keys.Count > 0; 
        }

    }
}