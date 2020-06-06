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

    using static Seed;

    partial class XTend
    {
        /// <summary>
        /// Selects the first method found on the type, if any, that has a specified name
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <param name="name">The name to match</param>
        [MethodImpl(Inline), Op]
        public static Option<MethodInfo> Method(this Type src, string name)
            => src.DeclaredMethods().WithName(name).FirstOrDefault();
    }
}