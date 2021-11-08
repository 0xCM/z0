//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct minicore
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<char> chars<E>(ReadOnlySpan<E> src)
            where E : unmanaged
                => recover<E,char>(src);

        // [MethodImpl(Inline), Op]
        // public static unsafe ReadOnlySpan<char> chars(string src)
        //     => cover(pchar(src), (uint)src.Length);
    }
}