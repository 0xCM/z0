//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    partial struct Bytes 
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<byte> write<T>(in T src)
            where T : struct
        {
            Span<byte> dst =  new byte[size<T>()];
            As.generic<T>(ref head(dst)) = src;
            return dst;
        }
    }
}