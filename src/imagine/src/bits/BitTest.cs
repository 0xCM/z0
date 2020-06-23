//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct BitTest
    {
        [MethodImpl(Inline), TestBit]
        public static Bit test(sbyte src, int pos)
            => (Bit)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit test(byte src, int pos)
            => (Bit)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit test(short src, int pos)
            => (Bit)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit test(ushort src, int pos)
            => (Bit)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit test(int src, int pos)
            => (Bit)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit test(uint src, int pos)
            => (Bit)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit test(long src, int pos)
            => (Bit)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit test(ulong src, int pos)
            => (Bit)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit test(float src, int pos)
            => (Bit)((As.uint32(src) >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit test(double src, int pos)
            => (Bit)((As.uint64(src) >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit test(char src, int pos)
            => (Bit)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static unsafe Bit test(bool src, int pos)
            => (Bit) (*((byte*)(&src)));
    }
}