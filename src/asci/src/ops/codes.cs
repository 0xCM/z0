//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Asci
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCode> codes(sbyte offset, sbyte count)
            => AsciSymbols.codes(offset, (sbyte)(count));

        [MethodImpl(Inline), Op]
        public static void codes(in char src, int count, ref AsciCode dst)
        {
            for(var i=0u; i<count; i++)
                seek(dst,i) = (AsciCode)skip(src,i);
        }

        [MethodImpl(Inline), Op]
        public static void codes(ReadOnlySpan<char> src, Span<AsciCode> dst)
        {
            var count = root.min(src.Length, dst.Length);
            codes(first(src), count, ref first(dst));
        }
    }
}