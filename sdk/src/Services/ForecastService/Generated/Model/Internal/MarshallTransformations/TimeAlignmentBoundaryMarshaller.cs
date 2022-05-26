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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ForecastService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ForecastService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TimeAlignmentBoundary Marshaller
    /// </summary>
    public class TimeAlignmentBoundaryMarshaller : IRequestMarshaller<TimeAlignmentBoundary, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TimeAlignmentBoundary requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDayOfMonth())
            {
                context.Writer.WritePropertyName("DayOfMonth");
                context.Writer.Write(requestObject.DayOfMonth);
            }

            if(requestObject.IsSetDayOfWeek())
            {
                context.Writer.WritePropertyName("DayOfWeek");
                context.Writer.Write(requestObject.DayOfWeek);
            }

            if(requestObject.IsSetHour())
            {
                context.Writer.WritePropertyName("Hour");
                context.Writer.Write(requestObject.Hour);
            }

            if(requestObject.IsSetMonth())
            {
                context.Writer.WritePropertyName("Month");
                context.Writer.Write(requestObject.Month);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TimeAlignmentBoundaryMarshaller Instance = new TimeAlignmentBoundaryMarshaller();

    }
}