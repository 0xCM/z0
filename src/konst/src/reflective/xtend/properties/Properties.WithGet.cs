//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    
    partial class XTend
    {
        /// <summary>
        /// Selects the properties with get methods from the stream
        /// </summary>
        /// <param name="src">The properties to examine</param>
        public static PropertyInfo[] WithGet(this PropertyInfo[] src)
            => src.Where(p => p.GetGetMethod() != null);
 
        /// <summary>
        /// Selects the properties from a stream that have public accessesors
        /// </summary>
        /// <param name="src">The source stream</param>
        public static PropertyInfo[] WithPublicGet(this PropertyInfo[] src)
            => src.Where(p => p.CanRead && p.GetGetMethod().IsPublic);
    }
}