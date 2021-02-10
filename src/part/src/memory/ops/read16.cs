//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort read16<T>(in T src)
        {
            if(size<T>() >= 16)
                return u16(src);
            else
                return u8(src);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort read16(ReadOnlySpan<byte> src, int offset)
            => first(recover<ushort>(slice(src,offset,2)));
    }
}