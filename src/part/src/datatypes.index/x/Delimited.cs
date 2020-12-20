//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XIndex
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<T> Delimited<T>(this T[] src, char delimiter = FieldDelimiter)
            where T : unmanaged
                => Index.delimit(src, delimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedIndex<T> Delimited<T>(this IIndex<T> src, char delimiter = Chars.Comma)
            => Index.delimit(src.Storage, delimiter);
    }
}