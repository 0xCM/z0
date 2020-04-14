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
    
    partial class Reflective
    {
        /// <summary>
        /// For the generic methods in a stream, selects their respective definitions
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> MemberOf(this IEnumerable<MethodInfo> src, GenericPartition g)
            => g == GenericPartition.Generic ? src.OpenGeneric().Union(src.ClosedGeneric()) : src.NonGeneric();
    }
}