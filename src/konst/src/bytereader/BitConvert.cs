//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public static class BitConvert
    {
        [MethodImpl(Inline), Op]
        public static ushort ToUInt16(ReadOnlySpan<byte> src, int offset = 0)
            => z.cell<ushort>(src, offset);

        [MethodImpl(Inline), Op]
        public static uint ToUInt32(ReadOnlySpan<byte> src, int offset = 0)
            => z.cell<uint>(src,offset);
        
        [MethodImpl(Inline), Op]
        public static ulong ToUInt64(ReadOnlySpan<byte> src, int offset = 0)
            => z.cell<ulong>(src, offset);

        [MethodImpl(Inline), Op]
        public static uint ToUInt32(float src)
            => (uint)BitConverter.SingleToInt32Bits(src);

        [MethodImpl(Inline), Op]
        public static ulong ToUInt64(double src)
            => (ulong)BitConverter.DoubleToInt64Bits(src);
    }
}