//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XClrQuery
    {
        /// <summary>
        /// Searches a type for any method that matches the supplied signature
        /// </summary>
        /// <param name="declarer">The type to search</param>
        /// <param name="name">The name of the method</param>
        /// <param name="paramTypes">The method parameter types in ordinal position</param>
        [MethodImpl(Inline), Op]
        public static Option<MethodInfo> MatchMethod(this Type declarer, string name, params Type[] paramTypes)
            => ClrQuery.method(declarer, name, paramTypes);
    }
}