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
        /// For the generic methods in a stream, selects their respective definitions
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static MethodInfo[] MemberOf(this MethodInfo[] src, GenericPartition g)
            => (g.IsGeneric() ? src.OpenGeneric().Union(src.ClosedGeneric()) : src.NonGeneric()).Array();
    }
}