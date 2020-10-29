//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial struct ClrQuerySvc
    {
        /// <summary>
        /// Determines whether a type is static
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline), Op]
        public static bool IsStatic(Type t)
            => t.IsAbstract && t.IsSealed;
    }
}