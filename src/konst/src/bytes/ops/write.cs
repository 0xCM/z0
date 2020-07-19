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

    partial struct Bytes 
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<byte> write<T>(in T src)
            where T : struct
        {
            Span<byte> dst =  new byte[z.size<T>()];
            z.first(z.recover<byte,T>(dst)) = src;
            return dst;
        }
    }
}