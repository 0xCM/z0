//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Unsigned
    {
        [MethodImpl(Inline), Op]
        public static ushort u16(ReadOnlySpan<byte> src, int offset = 0)
            => z.cell<ushort>(src, offset);        
    }
}