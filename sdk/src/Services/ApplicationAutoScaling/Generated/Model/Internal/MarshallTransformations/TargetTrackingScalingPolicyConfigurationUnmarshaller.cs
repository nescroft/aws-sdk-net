/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationAutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ApplicationAutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TargetTrackingScalingPolicyConfiguration Object
    /// </summary>  
    public class TargetTrackingScalingPolicyConfigurationUnmarshaller : IUnmarshaller<TargetTrackingScalingPolicyConfiguration, XmlUnmarshallerContext>, IUnmarshaller<TargetTrackingScalingPolicyConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TargetTrackingScalingPolicyConfiguration IUnmarshaller<TargetTrackingScalingPolicyConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TargetTrackingScalingPolicyConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TargetTrackingScalingPolicyConfiguration unmarshalledObject = new TargetTrackingScalingPolicyConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CustomizedMetricSpecification", targetDepth))
                {
                    var unmarshaller = CustomizedMetricSpecificationUnmarshaller.Instance;
                    unmarshalledObject.CustomizedMetricSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PredefinedMetricSpecification", targetDepth))
                {
                    var unmarshaller = PredefinedMetricSpecificationUnmarshaller.Instance;
                    unmarshalledObject.PredefinedMetricSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScaleInCooldown", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ScaleInCooldown = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScaleOutCooldown", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ScaleOutCooldown = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetValue", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.TargetValue = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TargetTrackingScalingPolicyConfigurationUnmarshaller _instance = new TargetTrackingScalingPolicyConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TargetTrackingScalingPolicyConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}