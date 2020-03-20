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

        /// <summary>
        /// Determines whether a type is a non-numeric primitive
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool IsNonNumericSystemType(this Type src)
            => TypeIdentities.IsNonNumericSystemType(src);

        /// <summary>
        /// Determines whether a type is system-defined
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool IsSystemType(this Type src)
            => TypeIdentities.IsSystemType(src);        

        [MethodImpl(Inline)]
        public static bool Ignore(this Type src)
            => src.IsAttributed<IgnoreAttribute>();
    }
}