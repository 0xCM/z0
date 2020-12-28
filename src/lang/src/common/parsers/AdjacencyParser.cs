//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static memory;

    public readonly struct AdjacencyParser
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Adjacent<T> create<T>(T left, T right)
            => new Adjacent<T>(left, right);

        [Op, Closures(UnsignedInts)]
        public static uint run<T>(in Adjacent<T> parser, ReadOnlySpan<T> src, Span<uint> dst)
            where T : unmanaged, IEquatable<T>
        {
            var terms = math.min(src.Length - 1, dst.Length);
            var matched = 0u;
            for(var i=0u; i<terms; i++)
            {
                ref readonly var s0 = ref skip(src, i);
                ref readonly var s1 = ref skip(src, i + 1);
                if(gmath.eq(s0, parser.A) & gmath.eq(s1, parser.B))
                    seek(dst, matched++) = i;
            }
            return matched;
        }
    }
}