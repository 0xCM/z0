//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using U = uint3;

    partial struct UI
    {
        /// <summary>
        /// Creates a 3-bit unsigned integer, equal to zero or one, if the source value is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint3(bool src)
            => new U(z.bitstate(src));

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint3(byte src)
            => new U(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint3(sbyte src)
            => new U(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint3(ushort src)
            => new U(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint3(short src)
            => new U(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint3(int src)
            => new U(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint3(uint src)
            => new U(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint3(long src)
            => new U(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint3(ulong src)
            => new U((byte)((byte)src & U.MaxLiteral));

        /// <summary>
        /// Creates a 3-bit unsigned integer from a 3-term bit sequence
        /// </summary>
        /// <param name="x0">The term at index 0</param>
        /// <param name="x1">The term at index 1</param>
        /// <param name="x2">The term at index 2</param>
        [MethodImpl(Inline), Op]
        public static U uint3(BitState x0, BitState x1 = default, BitState x2 = default)
             => wrap3((byte)(
                 ((uint)x0 << 0) |
                 ((uint)x1 << 1) |
                 ((uint)x2 << 2)
                 ));

        [MethodImpl(Inline), Op]
        public static U add(U x, U y)
        {
            var sum = x.data + y.data;
            return wrap3((sum >= U.Count) ? (byte)(sum - U.Count): (byte)sum);
        }

        [MethodImpl(Inline), Op]
        public static U sub(U x, U y)
        {
            var diff = (int)x - (int)y;
            return wrap3(diff < 0 ? (byte)(diff + U.Count) : (byte)diff);
        }

        [MethodImpl(Inline), Op]
        public static U mul(U lhs, U rhs)
            => reduce3((byte)(lhs.data * rhs.data));

        [MethodImpl(Inline), Op]
        public static U div (U lhs, U rhs)
            => wrap3((byte)(lhs.data / rhs.data));

        [MethodImpl(Inline), Op]
        public static U mod (U lhs, U rhs)
            => wrap3((byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static U or(U lhs, U rhs)
            => wrap3((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static U and(U lhs, U rhs)
            => wrap3((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static U xor(U lhs, U rhs)
            => wrap3((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static U srl(U lhs, byte rhs)
            => uint3(lhs.data >> rhs);

        [MethodImpl(Inline), Op]
        public static U sll(U lhs, byte rhs)
            => uint3(lhs.data << rhs);

        [MethodImpl(Inline), Op]
        public static BitState test(U src, byte pos)
            => z.test(src,pos);

        [MethodImpl(Inline), Op]
        public static U set(U src, byte pos, BitState state)
        {
            if(pos < U.Width)
                return wrap3(z.set(src.data, pos, state));
            else
                return src;
        }

        [MethodImpl(Inline), Op]
        public static bool eq(U x, U y)
            => x.data == y.data;

        [MethodImpl(Inline), Op]
        internal static byte reduce3(byte x)
            => (byte)(x % U.Count);

        [MethodImpl(Inline)]
        internal static U wrap3(byte src)
            => new U(src,false);

        [MethodImpl(Inline)]
        internal static U wrap3(int src)
            => new U((byte)src,false);

        [MethodImpl(Inline)]
        internal static byte crop3(byte x)
            => (byte)(U.MaxLiteral & x);

        static BitFormat FormatConfig3
            => BitFormatter.limited(U.Width,U.Width);

        [MethodImpl(Inline)]
        public static string format(U src)
            => BitFormatter.format(src.data, FormatConfig3);

        /// <summary>
        /// Promotes a triad to an quartet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint4 extend(U src, W4 w)
            => src;

        /// <summary>
        /// Promotes a triad to an quintet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint5 extend(U src, W5 w)
            => src;

        /// <summary>
        /// Promotes a triad to an quintet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint6 extend(U src, W6 w)
            => src;

        /// <summary>
        /// Promotes a triad to an octet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static octet extend(U src, W8 w)
            => src;
    }
}