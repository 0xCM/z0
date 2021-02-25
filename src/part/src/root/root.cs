//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    [ApiHost]
    public readonly partial struct root
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] succeed<T>(ParseResult<T[]> src)
            => src.Failed ? Array.Empty<T>() : src.Value;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T succeed<T>(ParseResult<T> src)
            where T : struct
                => src.Failed ? default : src.Value;
    }

    partial class XTend
    {
        public static HashSet<T> ToHashSet<T>(this IEnumerable<T> src)
            => root.hashset(src);

        public static HashSet<T> ToHashSet<T>(this T[] src)
            => root.hashset(src);
    }
}