﻿﻿/*
     Copyright 2012 Terso Solutions

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 */
using System;

namespace TersoSolutions.Jetstream.Application.Model
{
    /// <summary>
    /// Abstract request class for application request
    /// </summary>
    /// <remarks>Author Mike Lohmeier</remarks>
    public abstract class JetstreamRequest
    {
        /// <summary>
        /// Strategy pattern for building the Uri for the request
        /// </summary>
        /// <param name="baseUri">The base Jetstream Domain url 
        /// https://jetstream.tersosolutions.com/ or https://jetstreambeta.tersosolutions.com
        /// </param>
        /// <param name="accesskey">The user access key</param>
        /// <returns>
        /// String uri for the request
        /// </returns>
        internal abstract String BuildUri(String baseUri, String accesskey);
    }
}
