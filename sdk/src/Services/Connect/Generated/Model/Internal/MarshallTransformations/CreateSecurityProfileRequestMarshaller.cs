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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSecurityProfile Request Marshaller
    /// </summary>       
    public class CreateSecurityProfileRequestMarshaller : IMarshaller<IRequest, CreateSecurityProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSecurityProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSecurityProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            request.ResourcePath = "/security-profiles/{InstanceId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAllowedAccessControlTags())
                {
                    context.Writer.WritePropertyName("AllowedAccessControlTags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAllowedAccessControlTagsKvp in publicRequest.AllowedAccessControlTags)
                    {
                        context.Writer.WritePropertyName(publicRequestAllowedAccessControlTagsKvp.Key);
                        var publicRequestAllowedAccessControlTagsValue = publicRequestAllowedAccessControlTagsKvp.Value;

                            context.Writer.Write(publicRequestAllowedAccessControlTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetPermissions())
                {
                    context.Writer.WritePropertyName("Permissions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPermissionsListValue in publicRequest.Permissions)
                    {
                            context.Writer.Write(publicRequestPermissionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSecurityProfileName())
                {
                    context.Writer.WritePropertyName("SecurityProfileName");
                    context.Writer.Write(publicRequest.SecurityProfileName);
                }

                if(publicRequest.IsSetTagRestrictedResources())
                {
                    context.Writer.WritePropertyName("TagRestrictedResources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagRestrictedResourcesListValue in publicRequest.TagRestrictedResources)
                    {
                            context.Writer.Write(publicRequestTagRestrictedResourcesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateSecurityProfileRequestMarshaller _instance = new CreateSecurityProfileRequestMarshaller();        

        internal static CreateSecurityProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSecurityProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}