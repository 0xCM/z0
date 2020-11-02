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

    using U = uint1;

    partial struct UBits
    {
        [MethodImpl(Inline), Op]
        public static uint2 maxval(W2 w)
            => maxval<uint2>();

       [MethodImpl(Inline)]
        internal static U wrap(W2 w, int src)
            => new U((byte)src,false);

        /// <summary>
        /// Creates a 2-bit unsigned integer, equal to zero or one, if the source value is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W2 w, bool src)
            => new U(z.bitstate(src));

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W2 w, byte src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W2 w, sbyte src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W2 w, ushort src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W2 w, short src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W2 w, int src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W2 w, uint src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W2 w, long src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W2 w, ulong src)
            => new U((byte)((byte)src & U.MaxLiteral));

        /// <summary>
        /// Creates a 2-bit unsigned integer from a 2-term bit sequence
        /// </summary>
        /// <param name="x0">The term at index 0</param>
        /// <param name="x1">The term at index 1</param>
        [MethodImpl(Inline), Op]
        public static U create(W2 w, bit x0, bit x1 = default)
             => new U(((uint)x0 << 0) | ((uint)x1 << 1), true);

        [MethodImpl(Inline), Op]
        public static U uint2(bool src)
            => new U(z.bitstate(src));

        /// <summary>
        /// Creates a 2-bit unsigned integer from the first two source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint2(byte src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the first least two source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint2(sbyte src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the first least two source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint2(ushort src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least two bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint2(short src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least two bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint2(int src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least two bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint2(uint src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least two bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint2(long src)
            => new U((byte)src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least two bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint2(ulong src)
            => new U((byte)((byte)src & U.MaxLiteral));

        [MethodImpl(Inline), Op]
        public static uint2 add(uint2 x, uint2 y)
        {
            var sum = x.data + y.data;
            return wrap(w2, (sum >= U.Count) ? sum - (byte)U.Count: sum);
        }

        [MethodImpl(Inline), Op]
        public static uint2 sub(uint2 x, uint2 y)
        {
            var diff = (int)x - (int)y;
            return wrap(w2, diff < 0 ? (byte)(diff + U.Count) : (byte)diff);
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
            if(pos < U.Width)
                return wrap(w2, z.set(src.data, pos, state));
            else
                return src;
        }

        [MethodImpl(Inline), Op]
        public static bool eq(uint2 x, uint2 y)
            => x.data == y.data;

        [MethodImpl(Inline)]
        internal static byte crop2(byte x)
            => (byte)(U.MaxLiteral & x);

        [MethodImpl(Inline), Op]
        internal static byte reduce2(byte x)
            => (byte)(x % U.Count);

        [MethodImpl(Inline)]
        internal static uint2 wrap2(int src)
            => new uint2((byte)src, false);
    }
}