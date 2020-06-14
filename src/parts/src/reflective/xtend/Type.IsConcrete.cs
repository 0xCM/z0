//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Returns true if the source type is either non-generic or a generic type that has been closed over all parameters
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool IsConcrete(this Type src)
            => !src.ContainsGenericParameters && !src.IsGenericParameter && !src.IsAbstract;
    }
}