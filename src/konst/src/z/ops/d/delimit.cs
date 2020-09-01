//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static DelimitedList<object> delimit(params object[] src)
            => new DelimitedList<object>(src, FieldDelimiter);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static DelimitedList<T> delimit<T>(params T[] src)
            where T : unmanaged
                => new DelimitedList<T>(src, text.delimit, Chars.Pipe);
    }
}