/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧藍
   | Copyright ｩ Pablo Orozco (pablo@orozco.me).                              |
   | All rights reserved.                                                     |
   |                                                                          |
   | Licensed under the Apache License, Version 2.0 (the "License");          |
   | you may not use this file except in compliance with the License.         |
   | You may obtain a copy of the License at                                  |
   |                                                                          |
   | http://www.apache.org/licenses/LICENSE-2.0                               |
   |                                                                          |
   | Unless required by applicable law or agreed to in writing, software      |
   | distributed under the License is distributed on an "AS IS" BASIS,        |
   | WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. |
   | See the License for the specific language governing permissions and      |
   | limitations under the License.                                           |
   風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧藍 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringProxy = global::AopAlliance.Intercept;

namespace Proxi
{
	internal class SpringInterceptorAdapter : SpringProxy.IMethodInterceptor
	{
		private IInterceptor interceptor;

		public SpringInterceptorAdapter(IInterceptor interceptor)
		{
			this.interceptor = interceptor;
		}

		#region IMethodInterceptor Members

        public object Invoke(SpringProxy.IMethodInvocation invocation)
        {
            return interceptor.Run(new SpringInvocationAdapter(invocation));
        }

		#endregion
	}
}
