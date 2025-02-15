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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings related to WebVTT captions. WebVTT is a sidecar format that holds captions
    /// in a file that is separate from the video container. Set up sidecar captions in the
    /// same output group, but different output from your video. For more information, see
    /// https://docs.aws.amazon.com/mediaconvert/latest/ug/ttml-and-webvtt-output-captions.html.
    /// When you work directly in your JSON job specification, include this object and any
    /// required children when you set destinationType to WebVTT.
    /// </summary>
    public partial class WebvttDestinationSettings
    {
        private WebvttAccessibilitySubs _accessibility;
        private WebvttStylePassthrough _stylePassthrough;

        /// <summary>
        /// Gets and sets the property Accessibility. Set Accessibility subtitles to Enabled if
        /// the ISMC or WebVTT captions track is intended to provide accessibility for people
        /// who are deaf or hard of hearing. When you enable this feature, MediaConvert adds the
        /// following attributes under EXT-X-MEDIA in the HLS or CMAF manifest for this track:
        /// CHARACTERISTICS="public.accessibility.describes-spoken-dialog,public.accessibility.describes-music-and-sound"
        /// and AUTOSELECT="YES". Keep the default value, Disabled, if the captions track is not
        /// intended to provide such accessibility. MediaConvert will not add the above attributes.
        /// </summary>
        public WebvttAccessibilitySubs Accessibility
        {
            get { return this._accessibility; }
            set { this._accessibility = value; }
        }

        // Check to see if Accessibility property is set
        internal bool IsSetAccessibility()
        {
            return this._accessibility != null;
        }

        /// <summary>
        /// Gets and sets the property StylePassthrough. To use the available style, color, and
        /// position information from your input captions: Set Style passthrough (stylePassthrough)
        /// to Enabled (ENABLED). MediaConvert uses default settings when style and position information
        /// is missing from your input captions. To recreate the input captions exactly: Set Style
        /// passthrough to Strict (STRICT). MediaConvert automatically applies timing adjustments,
        /// including adjustments for frame rate conversion, ad avails, and input clipping. Your
        /// input captions format must be WebVTT. To ignore the style and position information
        /// from your input captions and use simplified output captions: Set Style passthrough
        /// to Disabled (DISABLED), or leave blank.
        /// </summary>
        public WebvttStylePassthrough StylePassthrough
        {
            get { return this._stylePassthrough; }
            set { this._stylePassthrough = value; }
        }

        // Check to see if StylePassthrough property is set
        internal bool IsSetStylePassthrough()
        {
            return this._stylePassthrough != null;
        }

    }
}