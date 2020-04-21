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
        public static GenericPartition GenericPartition(this MethodInfo src)
            => src.IsNonGeneric() ? Z0.GenericPartition.NonGeneric : Z0.GenericPartition.Generic;

        public static bool IsMemberOf(this MethodInfo src, GenericPartition g)
            => src.GenericPartition().State == g.State;

        /// <summary>
        /// For the generic methods in a stream, selects their respective definitions
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> MemberOf(this IEnumerable<MethodInfo> src, GenericPartition g)
            => g.IsGeneric() ? src.OpenGeneric().Union(src.ClosedGeneric()) : src.NonGeneric();
    }
}