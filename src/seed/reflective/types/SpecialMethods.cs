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
        /// Returns the methods from the source type per the binding flags; however, only those with special names are included
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <param name="flags">The reflection query flags</param>
        public static IEnumerable<MethodInfo> SpecialMethods(this Type src, BindingFlags flags)
            => src.FlaggedMethods(flags).Where(m =>  m.IsNonSpecial());

        /// <summary>
        /// Returns the methods from the source type per the binding flags, exluding those with special names
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <param name="flags">The reflection query flags</param>
        public static IEnumerable<MethodInfo> NonSpecialMethods(this Type src, BindingFlags flags)
            => src.FlaggedMethods(flags).Where(IsNonSpecial);
    }
}