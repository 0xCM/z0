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

    partial struct Resources
    {
        [MethodImpl(Inline)]
        public static ResourceSet<A> encode<A>(in asci32 name, ReadOnlySpan<string> src, Span<byte> dst, byte n)
            where A : unmanaged, IBytes
        {
            var width = size<A>();
            var count = src.Length;
            for(int i=0, j=0; i<count; i++, j+=width)
                encode(src, dst,n,i,j);
            return new ResourceSet<A>(name, dst);
        }

        [MethodImpl(Inline), Op]
        public static void encode(ReadOnlySpan<string> src, Span<byte> dst, byte n, int i, int j)
        {
            var chars = span(skip(src,(uint)i));
            asci.encode(first(chars), min(chars.Length, n), ref seek(dst, (uint)j));
        }
    }
}