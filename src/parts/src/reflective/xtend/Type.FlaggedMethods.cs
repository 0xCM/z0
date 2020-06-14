//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    
    partial class XTend
    {
        /// <summary>
        /// Returns the methods from the source type per the binding flags
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <param name="flags">The reflection query flags</param>
        public static MethodInfo[] FlaggedMethods(this Type src, BindingFlags flags)
            => src.GetMethods(flags);
    }
}