/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeZoneInstanceConfigInfosRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件。
        /// 
        /// <li> zone - String - 是否必填：否 -（过滤条件）按照可用区过滤。</li>
        /// 
        /// <li> instance-family String - 是否必填：否 -（过滤条件）按照机型系列过滤。按照实例机型系列过滤。实例机型系列形如：S1、I1、M1等。</li>
        /// 
        /// <li> instance-type - String - 是否必填：否 - （过滤条件）按照机型过滤。按照实例机型过滤。不同实例机型指定了不同的资源规格，具体取值可通过调用接口 DescribeInstanceTypeConfigs 来获得最新的规格表或参见实例类型描述。若不指定该参数，则默认机型为S1.SMALL1。</li>
        /// 
        /// <li> instance-charge-type - String - 是否必填：否 -（过滤条件）按照实例计费模式过滤。 (PREPAID：表示预付费，即包年包月 | POSTPAID_BY_HOUR：表示后付费，即按量计费 | CDHPAID：表示CDH付费，即只对CDH计费，不对CDH上的实例计费。 )  </li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

