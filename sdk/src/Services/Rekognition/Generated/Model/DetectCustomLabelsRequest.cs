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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the DetectCustomLabels operation.
    /// Detects custom labels in a supplied image by using an Amazon Rekognition Custom Labels
    /// model. 
    /// 
    ///  
    /// <para>
    /// You specify which version of a model version to use by using the <code>ProjectVersionArn</code>
    /// input parameter. 
    /// </para>
    ///  
    /// <para>
    /// You pass the input image as base64-encoded image bytes or as a reference to an image
    /// in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition operations,
    /// passing image bytes is not supported. The image must be either a PNG or JPEG formatted
    /// file. 
    /// </para>
    ///  
    /// <para>
    ///  For each object that the model version detects on an image, the API returns a (<code>CustomLabel</code>)
    /// object in an array (<code>CustomLabels</code>). Each <code>CustomLabel</code> object
    /// provides the label name (<code>Name</code>), the level of confidence that the image
    /// contains the object (<code>Confidence</code>), and object location information, if
    /// it exists, for the label on the image (<code>Geometry</code>). 
    /// </para>
    ///  
    /// <para>
    /// To filter labels that are returned, specify a value for <code>MinConfidence</code>.
    /// <code>DetectCustomLabelsLabels</code> only returns labels with a confidence that's
    /// higher than the specified value. The value of <code>MinConfidence</code> maps to the
    /// assumed threshold values created during training. For more information, see <i>Assumed
    /// threshold</i> in the Amazon Rekognition Custom Labels Developer Guide. Amazon Rekognition
    /// Custom Labels metrics expresses an assumed threshold as a floating point value between
    /// 0-1. The range of <code>MinConfidence</code> normalizes the threshold value to a percentage
    /// value (0-100). Confidence responses from <code>DetectCustomLabels</code> are also
    /// returned as a percentage. You can use <code>MinConfidence</code> to change the precision
    /// and recall or your model. For more information, see <i>Analyzing an image</i> in the
    /// Amazon Rekognition Custom Labels Developer Guide. 
    /// </para>
    ///  
    /// <para>
    /// If you don't specify a value for <code>MinConfidence</code>, <code>DetectCustomLabels</code>
    /// returns labels based on the assumed threshold of each label.
    /// </para>
    ///  
    /// <para>
    /// This is a stateless API operation. That is, the operation does not persist any data.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>rekognition:DetectCustomLabels</code>
    /// action. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <i>Analyzing an image</i> in the Amazon Rekognition Custom
    /// Labels Developer Guide. 
    /// </para>
    /// </summary>
    public partial class DetectCustomLabelsRequest : AmazonRekognitionRequest
    {
        private Image _image;
        private int? _maxResults;
        private float? _minConfidence;
        private string _projectVersionArn;

        /// <summary>
        /// Gets and sets the property Image.
        /// </summary>
        [AWSProperty(Required=true)]
        public Image Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results you want the service to return in the response. The service
        /// returns the specified number of highest confidence labels ranked from highest confidence
        /// to lowest.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// Gets and sets the property MinConfidence. 
        /// <para>
        /// Specifies the minimum confidence level for the labels to return. <code>DetectCustomLabels</code>
        /// doesn't return any labels with a confidence value that's lower than this specified
        /// value. If you specify a value of 0, <code>DetectCustomLabels</code> returns all labels,
        /// regardless of the assumed threshold applied to each label. If you don't specify a
        /// value for <code>MinConfidence</code>, <code>DetectCustomLabels</code> returns labels
        /// based on the assumed threshold of each label.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float MinConfidence
        {
            get { return this._minConfidence.GetValueOrDefault(); }
            set { this._minConfidence = value; }
        }

        // Check to see if MinConfidence property is set
        internal bool IsSetMinConfidence()
        {
            return this._minConfidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProjectVersionArn. 
        /// <para>
        /// The ARN of the model version that you want to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ProjectVersionArn
        {
            get { return this._projectVersionArn; }
            set { this._projectVersionArn = value; }
        }

        // Check to see if ProjectVersionArn property is set
        internal bool IsSetProjectVersionArn()
        {
            return this._projectVersionArn != null;
        }

    }
}