//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static unsafe void copy<A>(ReadOnlySpan<A> src, Span<byte> dst)
            where A : unmanaged, IByteSeq
        {
            for(var i=0u; i<src.Length; i++)
                copy(z.skip(src,i), ref z.seek(dst,i*64));
        }

        [MethodImpl(Inline)]
        public static void copy<A>(in A src, ref byte dst)
            where A : unmanaged, IByteSeq
                => copy(n2, src, ref dst);

        [MethodImpl(Inline)]
        static void copy<A>(N2 n, in A src, ref byte dst)
            where A : unmanaged, IByteSeq
        {
            if(typeof(A) == typeof(asci2))
                copy(cast(n2, src), ref dst);
            else if(typeof(A) == typeof(asci4))
                copy(cast(n4, src), ref dst);
            else if(typeof(A) == typeof(asci8))
                copy(cast(n8, src), ref dst);
            else if(typeof(A) == typeof(asci16))
                copy(cast(n16, src), ref dst);
            else
                copy(n32, src, ref dst);
        }

        [MethodImpl(Inline)]
        static void copy<A>(N32 n, in A src, ref byte dst)
            where A : unmanaged, IByteSeq
        {
            if(typeof(A) == typeof(asci32))
                copy(cast(n32, src), ref dst);
            else if(typeof(A) == typeof(asci64))
                copy(cast(n64, src), ref dst);
            else
                throw no<A>();
        }
    }
}