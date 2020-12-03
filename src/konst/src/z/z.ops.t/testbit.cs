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
        [MethodImpl(Inline), TestBit]
        public static BitState testbit(sbyte src, int pos)
            => (BitState)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static BitState testbit(byte src, int pos)
            => (BitState)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static BitState testbit(short src, int pos)
            => (BitState)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static BitState testbit(ushort src, int pos)
            => (BitState)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static BitState testbit(int src, int pos)
            => (BitState)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static BitState testbit(uint src, int pos)
            => (BitState)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static BitState testbit(long src, int pos)
            => (BitState)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static BitState testbit(ulong src, int pos)
            => (BitState)((src >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static BitState testbit(float src, int pos)
            => (BitState)((ScalarCast.uint32(src) >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static BitState testbit(double src, int pos)
            => (BitState)((ScalarCast.uint64(src) >> pos) & 1);

        [MethodImpl(Inline), TestBit]
        public static BitState testbit(char src, int pos)
            => (BitState)((src >> pos) & 1);
    }
}