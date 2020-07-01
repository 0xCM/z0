//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct As
    {
        [MethodImpl(Inline), TestBit]
        public static Bit testbit(sbyte src, int pos)
            => (Bit)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit testbit(byte src, int pos)
            => (Bit)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit testbit(short src, int pos)
            => (Bit)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit testbit(ushort src, int pos)
            => (Bit)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit testbit(int src, int pos)
            => (Bit)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit testbit(uint src, int pos)
            => (Bit)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit testbit(long src, int pos)
            => (Bit)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit testbit(ulong src, int pos)
            => (Bit)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit testbit(float src, int pos)
            => (Bit)((As.uint32(src) >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit testbit(double src, int pos)
            => (Bit)((As.uint64(src) >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static Bit testbit(char src, int pos)
            => (Bit)((src >> pos) & 1);
    }
}