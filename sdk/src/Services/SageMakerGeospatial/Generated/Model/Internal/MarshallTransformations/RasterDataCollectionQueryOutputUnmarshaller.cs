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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMakerGeospatial.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMakerGeospatial.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RasterDataCollectionQueryOutput Object
    /// </summary>  
    public class RasterDataCollectionQueryOutputUnmarshaller : IUnmarshaller<RasterDataCollectionQueryOutput, XmlUnmarshallerContext>, IUnmarshaller<RasterDataCollectionQueryOutput, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RasterDataCollectionQueryOutput IUnmarshaller<RasterDataCollectionQueryOutput, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RasterDataCollectionQueryOutput Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RasterDataCollectionQueryOutput unmarshalledObject = new RasterDataCollectionQueryOutput();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AreaOfInterest", targetDepth))
                {
                    var unmarshaller = AreaOfInterestUnmarshaller.Instance;
                    unmarshalledObject.AreaOfInterest = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PropertyFilters", targetDepth))
                {
                    var unmarshaller = PropertyFiltersUnmarshaller.Instance;
                    unmarshalledObject.PropertyFilters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RasterDataCollectionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RasterDataCollectionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RasterDataCollectionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RasterDataCollectionName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimeRangeFilter", targetDepth))
                {
                    var unmarshaller = TimeRangeFilterInputUnmarshaller.Instance;
                    unmarshalledObject.TimeRangeFilter = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RasterDataCollectionQueryOutputUnmarshaller _instance = new RasterDataCollectionQueryOutputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RasterDataCollectionQueryOutputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}