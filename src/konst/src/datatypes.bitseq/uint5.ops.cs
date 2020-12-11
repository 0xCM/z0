//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using U = uint5;
    using W = W5;

    partial struct BitSeq
    {
        [MethodImpl(Inline), Op]
        public static uint5 maxval(W w)
            => U.Max;

        [MethodImpl(Inline), Op]
        public static U dec(U x)
            => !x.IsMin ? new U(Bytes.sub(x.data, 1), false) : Z0.uint5.Max;

        /// <summary>
        /// Converts a source integral value to an enum value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="K">The target enum  type</typeparam>
        [MethodImpl(Inline)]
        public static ref K refine<K>(in U src)
            where K : unmanaged, Enum
                => ref z.@as<U,K>(src);

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
        /// Creates a 5-bit unsigned integer, equal to zero or one, if the source value is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint5(bool src)
            => new U(BitStates.bitstate(src));

        /// <summary>
        /// Creates a 5-bit unsigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint5(byte src)
            => new U(src);

        /// <summary>
        /// Creates a 5-bit unsigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint5(sbyte src)
            => new U(src);

        /// <summary>
        /// Creates a 5-bit unsigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint5(ushort src)
            => new U(src);

        /// <summary>
        /// Creates a 5-bit unsigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint5(short src)
            => new U(src);

        /// <summary>
        /// Creates a 5-bit unsigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint5(int src)
            => new U(src);

        /// <summary>
        /// Creates a 5-bit unsigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint5(uint src)
            => new U(src);

        /// <summary>
        /// Creates a 5-bit unsigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint5(long src)
            => new U(src);

        /// <summary>
        /// Creates a 5-bit unsigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint5(ulong src)
            => new U((byte)((byte)src & U.MaxLiteral));

        /// <summary>
        /// Creates a 5-bit unsigned integer from a 5-term bit sequence
        /// </summary>
        /// <param name="x0">The term at index 0</param>
        /// <param name="x1">The term at index 1</param>
        /// <param name="x2">The term at index 2</param>
        /// <param name="x3">The term at index 3</param>
        /// <param name="x4">The term at index 4</param>
        [MethodImpl(Inline), Op]
        public static U uint5(BitState x0, BitState x1 = default, BitState x2 = default, BitState x3 = default, BitState x4 = default)
             => wrap5(Bytes.or(
                 Bytes.sll((byte)x0, 0),
                 Bytes.sll((byte)x1, 1),
                 Bytes.sll((byte)x2, 2),
                 Bytes.sll((byte)x3, 3),
                 Bytes.sll((byte)x4, 4)
                 ));

        [MethodImpl(Inline), Op]
        public static U inc(U x)
            => !x.IsMax ? new U(memory.add(x.data, 1), false) : U.Min;

        [MethodImpl(Inline), Op]
        public static U add(U x, U y)
        {
            var d = (byte)(x.data + y.data);
            var result = Bytes.gteq(d, U.Count) ? Bytes.sub(d, U.Count) : d;
            return new U(result, true);
        }

        [MethodImpl(Inline), Op]
        public static U sub(U x, U y)
        {
            var delta = x.data - y.data;
            if(delta < 0)
                return wrap5((byte)(delta + U.Count));
            else
                return wrap5((byte)delta);
        }

        [MethodImpl(Inline), Op]
        public static U div (U lhs, U rhs)
            => wrap5((byte)(lhs.data / rhs.data));

        [MethodImpl(Inline), Op]
        public static U mod (U lhs, U rhs)
            => wrap5((byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static U mul(U lhs, U rhs)
            => reduce5((byte)(lhs.data * rhs.data));

        [MethodImpl(Inline), Op]
        public static U or(U lhs, U rhs)
            => wrap5((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static U and(U lhs, U rhs)
            => wrap5((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static U xor(U lhs, U rhs)
            => wrap5((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static U srl(U lhs, byte rhs)
            => uint5(lhs.data >> rhs);

        [MethodImpl(Inline), Op]
        public static U sll(U lhs, byte rhs)
            => uint5(lhs.data << rhs);

        [MethodImpl(Inline), Op]
        public static BitState test(U src, byte pos)
            => z.test(src,pos);

        [MethodImpl(Inline), Op]
        public static U set(U src, byte pos, BitState state)
            => Bytes.lt(pos, U.Width) ? new U(z.set(src.data, pos, state), false) : src;

        [MethodImpl(Inline)]
        public static bool eq(U x, U y)
            => Bytes.eq(x.data, y.data);

        [MethodImpl(Inline)]
        internal static byte crop5(byte x)
            => (byte)(U.MaxLiteral & x);

        [MethodImpl(Inline), Op]
        internal static byte reduce5(byte x)
            => (byte)(x % U.Count);

        [MethodImpl(Inline)]
        internal static U wrap5(uint src)
            => new U(src,false);

        [MethodImpl(Inline)]
        internal static U wrap5(int src)
            => new U((byte)src,false);

        static BitFormat FormatConfig5
            => BitFormatter.limited(U.Width,U.Width);

        [MethodImpl(Inline)]
        public static string format(U src)
            => BitFormatter.format(src.data, FormatConfig5);
    }
}