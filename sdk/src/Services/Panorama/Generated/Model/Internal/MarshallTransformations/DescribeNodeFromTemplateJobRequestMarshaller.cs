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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Panorama.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Panorama.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeNodeFromTemplateJob Request Marshaller
    /// </summary>       
    public class DescribeNodeFromTemplateJobRequestMarshaller : IMarshaller<IRequest, DescribeNodeFromTemplateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeNodeFromTemplateJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeNodeFromTemplateJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Panorama");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-24";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetJobId())
                throw new AmazonPanoramaException("Request object does not have required field JobId set");
            request.AddPathResource("{JobId}", StringUtils.FromString(publicRequest.JobId));
            request.ResourcePath = "/packages/template-job/{JobId}";

            return request;
        }
        private static DescribeNodeFromTemplateJobRequestMarshaller _instance = new DescribeNodeFromTemplateJobRequestMarshaller();        

        internal static DescribeNodeFromTemplateJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeNodeFromTemplateJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}