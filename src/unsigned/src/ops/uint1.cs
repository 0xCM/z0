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
        public static U maxval(W1 w)
            => maxval<U>();

        /// <summary>
        /// Converts an to sized integral value
        /// </summary>
        /// <param name="src">The source enum value</param>
        /// <param name="n">The target integer width</param>
        /// <typeparam name="K">The source enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref U scalar<K>(in K src, N1 n)
            where K : unmanaged, Enum
                => ref @as<K,U>(src);

        [MethodImpl(Inline), Op]
        public static U uint1(bool src)
            => new U(z.bitstate(src));

        /// <summary>
        /// Creates a 1-bit unsigned integer from the first bit of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint1(byte src)
            => new U(src);

        /// <summary>
        /// Creates a 1-bit unsigned integer from the first bit of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint1(sbyte src)
            => new U(src);

        /// <summary>
        /// Creates a 1-bit unsigned integer from the first bit of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint1(ushort src)
            => new U(src);

        /// <summary>
        /// Creates a 1-bit unsigned integer from the first bit of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint1(short src)
            => new U(src);

        /// <summary>
        /// Creates a 1-bit unsigned integer from the first bit of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint1(int src)
            => new U(src);

        /// <summary>
        /// Creates a 1-bit unsigned integer from the first bit of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint1(uint src)
            => new U(src);

        /// <summary>
        /// Creates a 1-bit unsigned integer from the first bit of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint1(long src)
            => new U((byte)src);

        /// <summary>
        /// Creates a 1-bit unsigned integer from the first bit of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U uint1(ulong src)
            => new U((byte)((byte)src & U.MaxLiteral));

        [MethodImpl(Inline), Op]
        public static U add(U x, U y)
        {
            var sum = x.data + y.data;
            return wrap1((sum >= U.Count) ? (byte)sum - (byte)U.Count: sum);
        }

        [MethodImpl(Inline), Op]
        public static U sub(U x, U y)
        {
            var diff = (int)x - (int)y;
            return wrap1(diff < 0 ? (byte)(diff + U.Count) : (byte)diff);
        }

        [MethodImpl(Inline), Op]
        public static U mul(U lhs, U rhs)
            => reduce1((byte)(lhs.data * rhs.data));

        [MethodImpl(Inline), Op]
        public static U div (U lhs, U rhs)
            => wrap1((byte)(lhs.data / rhs.data));

        [MethodImpl(Inline), Op]
        public static U mod (U lhs, U rhs)
            => wrap1((byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static U or(U lhs, U rhs)
            => wrap1((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static U and(U lhs, U rhs)
            => wrap1((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static U xor(U lhs, U rhs)
            => wrap1((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static U srl(U lhs, byte rhs)
            => uint1((byte)(lhs.data >> rhs));

        [MethodImpl(Inline), Op]
        public static U sll(U lhs, byte rhs)
            => uint1((byte)(lhs.data << rhs));

        [MethodImpl(Inline), Op]
        public static U inc(U x)
            => !x.IsMax ? new U(Bytes.add(x.data, 1), false) : U.Min;

        [MethodImpl(Inline), Op]
        public static U dec(U x)
            => !x.IsMin ? new U(Bytes.sub(x.data, 1), false) : U.Max;

        [MethodImpl(Inline), Op]
        public static BitState test(U x)
            => z.test(x.data, 0);

        [MethodImpl(Inline), Op]
        public static U set(U src, byte pos, BitState state)
        {
            if(pos < U.Width)
                return wrap1(z.set(src.data, pos, state));
            else
                return src;
        }

        [MethodImpl(Inline), Op]
        public static bool eq(U x, U y)
            => x.data == y.data;

        [MethodImpl(Inline)]
        internal static byte crop1(byte x)
            => (byte)(U.MaxLiteral & x);

        [MethodImpl(Inline), Op]
        internal static byte reduce1(byte x)
            => (byte)(x % U.Count);

        [MethodImpl(Inline)]
        internal static U wrap1(int src)
            => new U((byte)src, false);
    }
}