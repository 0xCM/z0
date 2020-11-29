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

    using U = uint2;
    using W = W2;

    partial struct UI
    {
        /// <summary>
        /// Promotes a <see cref='U'/> to a <see cref='Z0.uint3'/>, as indicated by the <see cref='W3'/> selector
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint3 extend(U src, W w)
            => wrap3(src.Content);

        /// <summary>
        /// Reduces the source value to a width-identified integer via modular arithmetic
        /// </summary>
        /// <param name="src">The input value</param>
        /// <param name="w">The target bit-width</param>
        [MethodImpl(Inline), Op]
        public static U reduce(byte src, W w)
            => new U(src);

        /// <summary>
        /// (a,b) -> [bbaa]
        /// </summary>
        /// <param name="a">Source bits 0-1</param>
        /// <param name="b">Source bits 2-3</param>
        [MethodImpl(Inline), Op]
        public static uint4 join(U a, U b)
            => (uint4)a | ((uint4)b << 2);

        /// <summary>
        /// (a,b) -> [bbaa]
        /// </summary>
        /// <param name="a">Source bits 0-1</param>
        /// <param name="b">Source bits 2-3</param>
        /// <param name="c">Source bits 4-5</param>
        /// <param name="d">Source bits 6-7</param>
        [MethodImpl(Inline), Op]
        public static uint6 join(U a, U b, U c)
            => (uint6)a | ((uint6)b << 2) | ((uint6)c << 4);

        /// <summary>
        /// (a,b,c,d) -> [dd cc bb aa]
        /// </summary>
        /// <param name="a">Source bits 0-1</param>
        /// <param name="b">Source bits 2-3</param>
        /// <param name="c">Source bits 4-5</param>
        /// <param name="d">Source bits 6-7</param>
        [MethodImpl(Inline), Op]
        public static uint8T join(U a, U b, U c, U d)
            => (uint8T)a | ((uint8T)b << 2) | ((uint8T)c << 4) | ((uint8T)d << 6);


        /// <summary>
        /// Reinterprets an input reference as a mutable <see cref='U'/> reference cell
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="dst">The target width selector</param>
        /// <typeparam name="S">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref U edit<S>(in S src, W dst)
            where S : unmanaged
                => ref @as<S,U>(src);

        [MethodImpl(Inline), Op]
        public static U maxval(W w)
            => maxval<U>();

        [MethodImpl(Inline), Op]
        public static U dec(U x)
            => !x.IsMin ? new U(Bytes.sub(x.data, 1), false) : U.Max;

        [MethodImpl(Inline), Op]
        public static U inc(U x)
            => !x.IsMax ? new U(z.add(x.data, 1), false) : U.Min;

        /// <summary>
        /// Converts a source integral value to an enum value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="K">The target enum  type</typeparam>
        [MethodImpl(Inline)]
        public static ref K refine<K>(in U src)
            where K : unmanaged, Enum
                => ref @as<U,K>(src);

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

        [MethodImpl(Inline)]
        internal static U wrap(W w, int src)
            => new U((byte)src,false);

        /// <summary>
        /// Creates a 2-bit unsigned integer, equal to zero or one, if the source value is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, bool src)
            => new U(z.bitstate(src));

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, byte src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, sbyte src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, ushort src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, short src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, int src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, uint src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, long src)
            => new U(src);

        /// <summary>
        /// Creates a 2-bit unsigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, ulong src)
            => new U((byte)((byte)src & U.MaxLiteral));

        /// <summary>
        /// Creates a 2-bit unsigned integer from a 2-term bit sequence
        /// </summary>
        /// <param name="x0">The term at index 0</param>
        /// <param name="x1">The term at index 1</param>
        [MethodImpl(Inline), Op]
        public static U create(W w, bit x0, bit x1 = default)
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
        /// Injects the source value directly into the width-identified target, bypassing bounds-checks
        /// </summary>
        /// <param name="src">The value to inject</param>
        /// <param name="w">The target bit-width</param>
        [MethodImpl(Inline)]
        public static U inject(byte src, W w)
            => new U(src, false);

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
        public static U add(U x, U y)
        {
            var sum = x.data + y.data;
            return wrap(w2, (sum >= U.Count) ? sum - (byte)U.Count: sum);
        }

        [MethodImpl(Inline), Op]
        public static U sub(U x, U y)
        {
            var diff = (int)x - (int)y;
            return wrap(w2, diff < 0 ? (byte)(diff + U.Count) : (byte)diff);
        }

        [MethodImpl(Inline), Op]
        public static U mul(U lhs, U rhs)
            => reduce2((byte)(lhs.data * rhs.data));

        [MethodImpl(Inline), Op]
        public static U div (U lhs, U rhs)
            => wrap(w2, (byte)(lhs.data / rhs.data));

        [MethodImpl(Inline), Op]
        public static U mod (U lhs, U rhs)
            => wrap(w2, (byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static U or(U lhs, U rhs)
            => wrap(w2, (byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static U and(U lhs, U rhs)
            => wrap(w2, (byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static U xor(U lhs, U rhs)
            => wrap(w2, (byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static U srl(U lhs, byte rhs)
            => create(w2, lhs.data >> rhs);

        [MethodImpl(Inline), Op]
        public static U sll(U lhs, byte rhs)
            => create(w2, lhs.data << rhs);

        [MethodImpl(Inline), Op]
        public static BitState test(U src, byte pos)
            => z.test(src,pos);

        [MethodImpl(Inline), Op]
        public static U set(U src, byte pos, BitState state)
        {
            if(pos < U.Width)
                return wrap(w2, z.set(src.data, pos, state));
            else
                return src;
        }

        [MethodImpl(Inline), Op]
        public static bool eq(U x, U y)
            => x.data == y.data;

        [MethodImpl(Inline)]
        internal static byte crop2(byte x)
            => (byte)(U.MaxLiteral & x);

        [MethodImpl(Inline), Op]
        internal static byte reduce2(byte x)
            => (byte)(x % U.Count);

        [MethodImpl(Inline)]
        internal static U wrap2(int src)
            => new U((byte)src, false);
    }
}