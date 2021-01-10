//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using U = uint6;
    using W = W6;

    partial struct UI
    {
        [MethodImpl(Inline), Op]
        public static U maxval(W w)
            => maxval<U>();

        [MethodImpl(Inline), Op]
        public static U inc(U x)
            => !x.IsMax ? new U(memory.add(x.data, 1), false) : U.Min;

        [MethodImpl(Inline), Op]
        public static U dec(U x)
            => !x.IsMin ? new U(Bytes.sub(x.data, 1), false) : U.Max;

        /// <summary>
        /// Converts a source integral value to an enum value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="K">The target enum  type</typeparam>
        [MethodImpl(Inline)]
        public static ref K refine<K>(in uint6 src)
            where K : unmanaged, Enum
                => ref @as<uint6,K>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref S edit<S>(in U src)
            where S : unmanaged
                => ref @as<U,S>(src);

        /// <summary>
        /// Converts an enum to a width-identified integer
        /// </summary>
        /// <param name="src">The source enum value</param>
        /// <param name="n">The target integer width</param>
        /// <typeparam name="K">The source enum type</typeparam>
        [MethodImpl(Inline)]
        public static U scalar<K>(in K src, W w)
            where K : unmanaged, Enum
                => new U(z.@as<K,byte>(src));

        /// <summary>
        /// Injects the source value directly into the width-identified target, bypassing bounds-checks
        /// </summary>
        /// <param name="src">The value to inject</param>
        /// <param name="w">The target bit-width</param>
        [MethodImpl(Inline)]
        public static U inject(byte src, W w)
            => new U(src, false);

        /// <summary>
        /// Reduces the source value to a width-identified integer via modular arithmetic
        /// </summary>
        /// <param name="src">The input value</param>
        /// <param name="w">The target bit-width</param>
        [MethodImpl(Inline), Op]
        public static U reduce(byte src, W w)
            => new U(src);

        /// <summary>
        /// Creates a 6-bit unsigned integer, equal to zero or one, if the source value is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint6(bool src)
            => new U(BitStates.bitstate(src));

        /// <summary>
        /// Creates a 6-bit unsigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint6(byte src)
            => new U(src);

        /// <summary>
        /// Creates a 6-bit unsigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint6(sbyte src)
            => new U(src);

        /// <summary>
        /// Creates a 6-bit unsigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint6(ushort src)
            => new U(src);

        /// <summary>
        /// Creates a 6-bit unsigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint6(short src)
            => new U(src);

        /// <summary>
        /// Creates a 6-bit unsigned integer from the least 6 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint6(int src)
            => new U(src);

        /// <summary>
        /// Creates a 6-bit unsigned integer from the least 6 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint6(uint src)
            => new U(src);

        /// <summary>
        /// Creates a 6-bit unsigned integer from the least 6 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint6(long src)
            => new U(src);

        /// <summary>
        /// Creates a 6-bit unsigned integer from the least 6 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint6(uint24 src)
            => new U((uint)src);

        /// <summary>
        /// Creates a 6-bit unsigned integer from the least 6 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint6(ulong src)
            => new U((byte)((byte)src & U.MaxLiteral));

        /// <summary>
        /// Constructs a uint6 value from a sequence of bits ranging from low to high
        /// </summary>
        /// <param name="x0">The first/least bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x1">The second bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x2">The third bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x3">The fourth/highest bit value, if specified; otherwise, defaults to 0</param>
        [MethodImpl(Inline), Op]
        public static U uint6(BitState x0, BitState x1 = default, BitState x2 = default, BitState x3 = default, BitState x4 = default, BitState x5 = default)
             => wrap6((byte)(
                 ((uint)x0 << 0) |
                 ((uint)x1 << 1) |
                 ((uint)x2 << 2) |
                 ((uint)x3 << 3) |
                 ((uint)x4 << 4) |
                 ((uint)x5 << 5)
                ));

        [MethodImpl(Inline), Op]
        public static U add(U x, U y)
        {
            var sum = (byte)(x.data + y.data);
            return wrap6((sum >= U.Count) ? (byte)(sum - U.Count): sum);
        }

        [MethodImpl(Inline), Op]
        public static U sub(U x, U y)
        {
            var diff = (int)x - (int)y;
            return wrap6(diff < 0 ? (byte)(diff + U.Count) : (byte)diff);
        }

        [MethodImpl(Inline), Op]
        public static U div (U lhs, U rhs)
            => wrap6((byte)(lhs.data / rhs.data));

        [MethodImpl(Inline), Op]
        public static U mod (U lhs, U rhs)
            => wrap6((byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static U mul(U lhs, U rhs)
            => reduce6((byte)(lhs.data * rhs.data));

        [MethodImpl(Inline), Op]
        public static U or(U lhs, U rhs)
            => wrap6((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static U and(U lhs, U rhs)
            => wrap6((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static U xor(U lhs, U rhs)
            => wrap6((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static U srl(U lhs, byte rhs)
            => uint6(lhs.data >> rhs);

        [MethodImpl(Inline), Op]
        public static U sll(U lhs, byte rhs)
            => uint6(lhs.data << rhs);

        [MethodImpl(Inline), Op]
        public static BitState test(U src, byte pos)
            => z.test(src,pos);

        [MethodImpl(Inline), Op]
        public static U set(U src, byte pos, BitState state)
        {
            if(pos < U.Width)
                return wrap6(z.set(src.data, pos, state));
            else
                return src;
        }

        [MethodImpl(Inline)]
        public static bool eq(U x, U y)
            => x.data == y.data;

        [MethodImpl(Inline)]
        internal static byte crop6(byte x)
            => (byte)(U.MaxLiteral & x);

        [MethodImpl(Inline), Op]
        internal static byte reduce6(byte x)
            => (byte)(x % U.Count);

        [MethodImpl(Inline)]
        internal static U wrap6(byte src)
            => new U(src,false);

        static BitFormat FormatConfig6
            => BitFormatter.limited(U.Width,U.Width);

        [MethodImpl(Inline)]
        public static string format(U src)
            => BitFormatter.format(src.data, FormatConfig6);
    }
}