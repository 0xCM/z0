//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Refs
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void store<T>(ReadOnlySpan<Ref> src, Span<T> dst)
            where T : struct
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = first(recover<T>(skip(src,i).Buffer));
        }
    }
}