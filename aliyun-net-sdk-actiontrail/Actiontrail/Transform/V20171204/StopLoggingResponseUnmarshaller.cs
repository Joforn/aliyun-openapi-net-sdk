/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Actiontrail.Model.V20171204;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Actiontrail.Transform.V20171204
{
    public class StopLoggingResponseUnmarshaller
    {
        public static StopLoggingResponse Unmarshall(UnmarshallerContext context)
        {
			StopLoggingResponse stopLoggingResponse = new StopLoggingResponse();

			stopLoggingResponse.HttpResponse = context.HttpResponse;
			stopLoggingResponse.RequestId = context.StringValue("StopLogging.RequestId");
			stopLoggingResponse.Param = context.StringValue("StopLogging.Param");
			stopLoggingResponse.Result = context.StringValue("StopLogging.Result");
        
			return stopLoggingResponse;
        }
    }
}