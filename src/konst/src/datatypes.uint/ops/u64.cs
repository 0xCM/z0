//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct UI
    {
        [MethodImpl(Inline), Op]
        public static ulong u64(ReadOnlySpan<byte> src, int offset = 0)
            => z.cell<ulong>(src, offset);

        [MethodImpl(Inline), Op]
        public static ulong u64(double src)
            => (ulong)BitConverter.DoubleToInt64Bits(src);
    }
}