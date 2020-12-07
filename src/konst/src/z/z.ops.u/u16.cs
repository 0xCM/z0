//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static ushort u16(bool on)
            => memory.u16(on);

        [MethodImpl(Inline)]
        public static ref ushort u16<T>(in T src)
            => ref memory.u16(src);

        [MethodImpl(Inline), Op]
        public static ushort u16(ReadOnlySpan<byte> src, int offset = 0)
            => z.cell<ushort>(src, offset);
    }
}