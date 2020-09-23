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

    partial struct Sized
    {
        [MethodImpl(Inline), Op]
        public static uint2 add(uint2 x, uint2 y)
        {
            var sum = x.data + y.data;
            return wrap(w2, (sum >= uint2.Count) ? sum - (byte)uint2.Count: sum);
        }

        [MethodImpl(Inline), Op]
        public static uint2 sub(uint2 x, uint2 y)
        {
            var diff = (int)x - (int)y;
            return wrap(w2, diff < 0 ? (byte)(diff + uint2.Count) : (byte)diff);
        }

        [MethodImpl(Inline), Op]
        public static uint2 mul(uint2 lhs, uint2 rhs)
            => reduce2((byte)(lhs.data * rhs.data));

        [MethodImpl(Inline), Op]
        public static uint2 div (uint2 lhs, uint2 rhs)
            => wrap(w2, (byte)(lhs.data / rhs.data));

        [MethodImpl(Inline), Op]
        public static uint2 mod (uint2 lhs, uint2 rhs)
            => wrap(w2, (byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static uint2 or(uint2 lhs, uint2 rhs)
            => wrap(w2, (byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static uint2 and(uint2 lhs, uint2 rhs)
            => wrap(w2, (byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static uint2 xor(uint2 lhs, uint2 rhs)
            => wrap(w2, (byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static uint2 srl(uint2 lhs, byte rhs)
            => create(w2, lhs.data >> rhs);

        [MethodImpl(Inline), Op]
        public static uint2 sll(uint2 lhs, byte rhs)
            => create(w2, lhs.data << rhs);

        [MethodImpl(Inline), Op]
        public static BitState test(uint2 src, byte pos)
            => z.test(src,pos);

        [MethodImpl(Inline), Op]
        public static uint2 set(uint2 src, byte pos, BitState state)
        {
            if(pos < uint2.Width)
                return wrap(w2, z.set(src.data, pos, state));
            else
                return src;
        }

        [MethodImpl(Inline), Op]
        public static bool eq(uint2 x, uint2 y)
            => x.data == y.data;

        [MethodImpl(Inline)]
        internal static byte crop2(byte x)
            => (byte)(uint2.MaxLiteral & x);

        [MethodImpl(Inline), Op]
        internal static byte reduce2(byte x)
            => (byte)(x % uint2.Count);

        [MethodImpl(Inline)]
        internal static uint2 wrap2(int src)
            => new uint2((byte)src, false);
    }
}