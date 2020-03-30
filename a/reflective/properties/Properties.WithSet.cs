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
        /// Selects the properties with set methods from the stream
        /// </summary>
        /// <param name="src">The properties to examine</param>
        public static IEnumerable<PropertyInfo> WithSet(this IEnumerable<PropertyInfo> src)
            => src.Where(p => p.GetSetMethod() != null);

        /// <summary>
        /// Selects the properties from a stream that have public manipulators
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<PropertyInfo> WithPublicSet(this IEnumerable<PropertyInfo> src)
            => src.Where(p => p.CanWrite && p.GetSetMethod().IsPublic);
    }
}