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

    partial struct MemRefs
    {
        [MethodImpl(Inline), Op]
        public StringRefs<N4> refs(string s0, string s1, string s2, string s3)
            => refs(default(N4), @string(s0), @string(s1), @string(s2), @string(s3));

        [MethodImpl(Inline)]
        public static StringRefs<N> refs<N>(N n, params StringRef[] src)
            where N : unmanaged, ITypeNat
                => new StringRefs<N>(src);

        [MethodImpl(Inline), Op]
        public static void refs(ReadOnlySpan<string> src, Span<StringRef> dst)
        {
            for(var i=0u; i<src.Length; i++)
                seek(dst,i) = @string(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static StringRef[] refs(ReadOnlySpan<string> src)
        {
            var dst = sys.alloc<StringRef>(src.Length);
            refs(src,dst);
            return dst;
        }
    }
}