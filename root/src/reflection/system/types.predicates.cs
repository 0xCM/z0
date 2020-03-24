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
    using System.Runtime.CompilerServices;

    using static Root;

    using static ReflectionFlags;

    partial class RootReflections
    {      
        /// <summary>
        /// Determines whether a supplied type is predicated on a bit, including nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsBit(this Type t)
            => t.IsTypeOf<bit>();
    }
}