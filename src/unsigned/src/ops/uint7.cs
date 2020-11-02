//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using U = uint7;

    partial struct Sized
    {
        /// <summary>
        /// Creates a 7-bit unsigned integer, equal to zero or one, according to whether the source is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint7(bool src)
            => new U(z.bitstate(src));

        /// <summary>
        /// Creates a 7-bit unsigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint7(byte src)
            => new U(src);

        /// <summary>
        /// Creates a 7-bit unsigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint7(sbyte src)
            => new U(src);

        /// <summary>
        /// Creates a 7-bit unsigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint7(ushort src)
            => new U(src);

        /// <summary>
        /// Creates a 7-bit unsigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint7(short src)
            => new U(src);

        /// <summary>
        /// Creates a 7-bit unsigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint7(int src)
            => new U(src);

        /// <summary>
        /// Creates a 7-bit unsigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint7(uint src)
            => new U(src);

        /// <summary>
        /// Creates a 7-bit unsigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint7(long src)
            => new U(src);

        /// <summary>
        /// Creates a 7-bit unsigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint7(ulong src)
            => new U((byte)((byte)src & U.MaxLiteral));

        /// <summary>
        /// Constructs a uint7 value from a sequence of bits ranging from low to high
        /// </summary>
        /// <param name="x0">The first/least bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x1">The second bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x2">The third bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x3">The fourth/highest bit value, if specified; otherwise, defaults to 0</param>
        [MethodImpl(Inline), Op]
        public static U uint7(BitState x0, BitState x1 = default, BitState x2 = default, BitState x3 = default, BitState x4 = default, BitState x5 = default, BitState x6 = default)
             => wrap7(((uint)x0 << 0) | ((uint)x1 << 1) | ((uint)x2 << 2) | ((uint)x3 << 3) | ((uint)x4 << 4) | ((uint)x5 << 5) | ((uint)x6 << 6));

        [MethodImpl(Inline), Op]
        public static U add(U x, U y)
        {
            var sum = (byte)(x.data + y.data);
            return wrap7((sum >= U.Count) ? (byte)(sum - U.Count): sum);
        }

        [MethodImpl(Inline), Op]
        public static U sub(U x, U y)
        {
            var diff = (int)x - (int)y;
            return wrap7(diff < 0 ? (uint)(diff + U.Count) : (uint)diff);
        }

        [MethodImpl(Inline), Op]
        public static U div (U x, U y)
            => wrap7((byte)(x.data / y.data));

        [MethodImpl(Inline), Op]
        public static U mod (U lhs, U rhs)
            => wrap7((byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static U mul(U lhs, U rhs)
            => reduce7((byte)(lhs.data * rhs.data));

        [MethodImpl(Inline), Op]
        public static U or(U lhs, U rhs)
            => wrap7((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static U and(U lhs, U rhs)
            => wrap7((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static U xor(U lhs, U rhs)
            => wrap7((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static U srl(U lhs, byte rhs)
            => uint7(lhs.data >> rhs);

        [MethodImpl(Inline), Op]
        public static U sll(U lhs, byte rhs)
            => uint7(lhs.data << rhs);


        [MethodImpl(Inline), Op]
        public static BitState test(U src, byte pos)
            => z.test(src,pos);

        [MethodImpl(Inline), Op]
        public static U set(U src, byte pos, BitState state)
        {
            if(pos < U.Width)
                return wrap7(z.set(src.data, pos, state));
            else
                return src;
        }

        [MethodImpl(Inline)]
        public static bool eq(U x, U y)
            => x.data == y.data;

        [MethodImpl(Inline)]
        internal static byte crop7(byte x)
            => (byte)(U.MaxLiteral & x);

        [MethodImpl(Inline), Op]
        internal static byte reduce7(byte x)
            => (byte)(x % U.Count);

        [MethodImpl(Inline)]
        internal static U wrap7(byte src)
            => new U(src,false);

        [MethodImpl(Inline)]
        internal static U wrap7(uint src)
            => new U(src,false);

        static BitFormat FormatConfig7
            => BitFormatter.limited(U.Width,U.Width);

        [MethodImpl(Inline)]
        public static string format(U src)
            => BitFormatter.format(src.data, FormatConfig7);
    }
}